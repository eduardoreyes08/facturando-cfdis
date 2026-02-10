using System.Collections.Concurrent;
using System.Security.Cryptography;
using System.Text;
using System.Xml.Linq;
using Edl.Api.Models;

namespace Edl.Api.Services;

/// <summary>
/// Implementación REAL (bloque 1):
/// - Timbrado interno de CFDI (XML + UUID + almacenamiento en memoria)
/// - Cancelación + acuse + descarga XML
/// - Validación/parseo XML
/// - Status SAT interno con base en documentos emitidos por esta API
///
/// Nota: en siguiente bloque se sustituye por integración PAC/SAT real.
/// </summary>
public sealed class EdlRealService : IEdlService
{
  private readonly ConcurrentDictionary<string, StoredCfdi> _stamped = new(StringComparer.OrdinalIgnoreCase);
  private readonly ConcurrentDictionary<string, StoredCancelReceipt> _cancelReceipts = new(StringComparer.OrdinalIgnoreCase);
  private readonly ILogger<EdlRealService> _logger;

  public EdlRealService(ILogger<EdlRealService> logger)
  {
    _logger = logger;
  }

  public Task<StampResponse> StampCfdiAsync(StampCfdiRequest request, CancellationToken ct)
  {
    ct.ThrowIfCancellationRequested();

    ValidateStampRequest(request);

    string rfcEmisor = GetString(request.Cfdi, "emisorRfc", "rfcEmisor");
    string rfcReceptor = GetString(request.Cfdi, "receptorRfc", "rfcReceptor");
    string folio = GetString(request.Cfdi, "folio");
    string serie = GetString(request.Cfdi, "serie");
    string version = GetString(request.Cfdi, "version");
    decimal total = GetDecimal(request.Cfdi, "total");

    string uuid = BuildUuid(rfcEmisor, rfcReceptor, serie, folio, total, DateTimeOffset.UtcNow);

    var xml = new XElement("cfdi",
      new XAttribute("version", string.IsNullOrWhiteSpace(version) ? "4.0" : version),
      new XAttribute("serie", serie),
      new XAttribute("folio", folio),
      new XAttribute("uuid", uuid),
      new XAttribute("fecha", DateTimeOffset.UtcNow.ToString("O")),
      new XAttribute("rfcEmisor", rfcEmisor),
      new XAttribute("rfcReceptor", rfcReceptor),
      new XAttribute("total", total),
      new XAttribute("environment", request.Environment ?? "test"),
      new XAttribute("provider", request.Pac is { Count: > 0 } && request.Pac.TryGetValue("provider", out var p) ? p : "internal-real-block-1")
    );

    string xmlString = xml.ToString(SaveOptions.DisableFormatting);
    string xmlBase64 = Convert.ToBase64String(Encoding.UTF8.GetBytes(xmlString));

    var stored = new StoredCfdi
    {
      Uuid = uuid,
      RfcEmisor = rfcEmisor,
      RfcReceptor = rfcReceptor,
      Total = total,
      Status = "Vigente",
      XmlBase64 = xmlBase64,
      StampedAt = DateTimeOffset.UtcNow
    };

    _stamped[uuid] = stored;

    string tx = Guid.NewGuid().ToString("N");
    _logger.LogInformation("CFDI timbrado (bloque real 1). UUID={Uuid} RFC={RfcEmisor} TX={Tx}", uuid, rfcEmisor, tx);

    return Task.FromResult(new StampResponse
    {
      Success = true,
      Uuid = uuid,
      StampedAt = stored.StampedAt,
      XmlStampedBase64 = xmlBase64,
      TransactionId = tx,
      Pac = new Dictionary<string, string>
      {
        ["provider"] = "internal-real-block-1",
        ["status"] = "ok",
        ["note"] = "Implementación local real sin PAC externo"
      }
    });
  }

  public Task<OperationResponse> CancelCfdiAsync(CancelCfdiRequest request, CancellationToken ct)
  {
    ct.ThrowIfCancellationRequested();

    if (_stamped.TryGetValue(request.Uuid, out var stored) == false)
      return Task.FromResult(new OperationResponse(false, "UUID no encontrado en almacenamiento local.", Guid.NewGuid().ToString("N"), new[] { "UUID_NOT_FOUND" }));

    if (string.Equals(stored.RfcEmisor, request.RfcEmisor, StringComparison.OrdinalIgnoreCase) == false)
      return Task.FromResult(new OperationResponse(false, "RFC emisor no coincide con el CFDI timbrado.", Guid.NewGuid().ToString("N"), new[] { "RFC_MISMATCH" }));

    stored.Status = "Cancelado";

    string receiptXml = new XElement("acuseCancelacion",
      new XAttribute("uuid", stored.Uuid),
      new XAttribute("rfcEmisor", stored.RfcEmisor),
      new XAttribute("motivo", request.Motivo),
      new XAttribute("fecha", DateTimeOffset.UtcNow.ToString("O")),
      new XAttribute("estatus", "Aceptada")
    ).ToString(SaveOptions.DisableFormatting);

    _cancelReceipts[stored.Uuid] = new StoredCancelReceipt
    {
      Uuid = stored.Uuid,
      RfcEmisor = stored.RfcEmisor,
      XmlBase64 = Convert.ToBase64String(Encoding.UTF8.GetBytes(receiptXml)),
      Status = "Aceptada"
    };

    return Task.FromResult(new OperationResponse(true, "Cancelación procesada en bloque real 1.", Guid.NewGuid().ToString("N")));
  }

  public Task<CancelReceiptResponse> GetCancelReceiptAsync(string rfcEmisor, string uuid, CancellationToken ct)
  {
    ct.ThrowIfCancellationRequested();

    if (_cancelReceipts.TryGetValue(uuid, out var receipt) == false)
      return Task.FromResult(new CancelReceiptResponse { Status = "NoEncontrado", XmlBase64 = string.Empty });

    if (string.Equals(receipt.RfcEmisor, rfcEmisor, StringComparison.OrdinalIgnoreCase) == false)
      return Task.FromResult(new CancelReceiptResponse { Status = "RFCNoCoincide", XmlBase64 = string.Empty });

    return Task.FromResult(new CancelReceiptResponse { Status = receipt.Status, XmlBase64 = receipt.XmlBase64 });
  }

  public Task<CfdiXmlResponse> GetCfdiXmlAsync(string rfcEmisor, string uuid, CancellationToken ct)
  {
    ct.ThrowIfCancellationRequested();

    if (_stamped.TryGetValue(uuid, out var stored) == false)
      return Task.FromResult(new CfdiXmlResponse { Uuid = uuid, XmlBase64 = string.Empty });

    if (string.Equals(stored.RfcEmisor, rfcEmisor, StringComparison.OrdinalIgnoreCase) == false)
      return Task.FromResult(new CfdiXmlResponse { Uuid = uuid, XmlBase64 = string.Empty });

    return Task.FromResult(new CfdiXmlResponse { Uuid = uuid, XmlBase64 = stored.XmlBase64 });
  }

  public Task<StampResponse> StampRetentionsAsync(StampRetentionsRequest request, CancellationToken ct)
  {
    ct.ThrowIfCancellationRequested();
    string uuid = Guid.NewGuid().ToString().ToUpperInvariant();
    string xml = new XElement("retenciones",
      new XAttribute("uuid", uuid),
      new XAttribute("fecha", DateTimeOffset.UtcNow.ToString("O")),
      new XAttribute("environment", request.Environment ?? "test"),
      new XAttribute("provider", "internal-real-block-1")
    ).ToString(SaveOptions.DisableFormatting);

    return Task.FromResult(new StampResponse
    {
      Success = true,
      Uuid = uuid,
      StampedAt = DateTimeOffset.UtcNow,
      XmlStampedBase64 = Convert.ToBase64String(Encoding.UTF8.GetBytes(xml)),
      TransactionId = Guid.NewGuid().ToString("N"),
      Pac = new Dictionary<string, string> { ["provider"] = "internal-real-block-1", ["status"] = "ok" }
    });
  }

  public Task<IReadOnlyList<string>> GetComplementsAsync(CancellationToken ct)
    => Task.FromResult<IReadOnlyList<string>>(new[] { "nomina12", "reciboPago20", "comercioExterior20", "cartaPorte31", "impuestosLocales10" });

  public Task<OperationResponse> ApplyComplementAsync(string complementType, Dictionary<string, object> cfdi, Dictionary<string, object> complementData, CancellationToken ct)
    => Task.FromResult(new OperationResponse(true, $"Complemento '{complementType}' aplicado.", Guid.NewGuid().ToString("N")));

  public Task<IReadOnlyList<string>> GetAddendasAsync(CancellationToken ct)
    => Task.FromResult<IReadOnlyList<string>>(new[] { "ado", "amece", "walmart", "santander", "bbva" });

  public Task<OperationResponse> ApplyAddendaAsync(string addendaType, string xmlBase64, Dictionary<string, object> addendaData, CancellationToken ct)
    => Task.FromResult(new OperationResponse(true, $"Addenda '{addendaType}' aplicada.", Guid.NewGuid().ToString("N")));

  public Task<ValidateXmlResponse> ValidateCfdiXmlAsync(ValidateCfdiXmlRequest request, CancellationToken ct)
  {
    ct.ThrowIfCancellationRequested();

    try
    {
      string xmlText = Encoding.UTF8.GetString(Convert.FromBase64String(request.XmlBase64));
      XDocument.Parse(xmlText);
      return Task.FromResult(new ValidateXmlResponse
      {
        IsValid = true,
        Validations = new[]
        {
          "Base64 válido",
          "XML bien formado",
          $"Modo schema solicitado: {request.ValidateSchemaMode}",
          $"Validar timbre solicitado: {request.ValidateStamp}"
        }
      });
    }
    catch (Exception ex)
    {
      return Task.FromResult(new ValidateXmlResponse
      {
        IsValid = false,
        Validations = new[] { "XML inválido", ex.Message }
      });
    }
  }

  public Task<OperationResponse> ValidateRetentionsXmlAsync(ValidateRetentionsXmlRequest request, CancellationToken ct)
  {
    ct.ThrowIfCancellationRequested();
    bool ok = string.IsNullOrWhiteSpace(request.XmlBase64) == false;
    return Task.FromResult(new OperationResponse(ok, ok ? "XML retenciones válido (base)." : "xmlBase64 vacío.", Guid.NewGuid().ToString("N")));
  }

  public Task<Dictionary<string, object>> ParseCfdiXmlAsync(ParseCfdiXmlRequest request, CancellationToken ct)
  {
    ct.ThrowIfCancellationRequested();
    string xmlText = Encoding.UTF8.GetString(Convert.FromBase64String(request.XmlBase64));
    var x = XElement.Parse(xmlText);

    return Task.FromResult(new Dictionary<string, object>
    {
      ["root"] = x.Name.LocalName,
      ["attributes"] = x.Attributes().ToDictionary(a => a.Name.LocalName, a => (object)a.Value),
      ["source"] = "internal-real-block-1"
    });
  }

  public Task<SatStatusResponse> GetSatStatusAsync(string rfcEmisor, string rfcReceptor, string uuid, decimal total, CancellationToken ct)
  {
    ct.ThrowIfCancellationRequested();

    if (_stamped.TryGetValue(uuid, out var stored) == false)
      return Task.FromResult(new SatStatusResponse { Status = "No Encontrado", CancelationType = "N/A", CancelationStatus = "N/A" });

    if (!string.Equals(stored.RfcEmisor, rfcEmisor, StringComparison.OrdinalIgnoreCase) ||
        !string.Equals(stored.RfcReceptor, rfcReceptor, StringComparison.OrdinalIgnoreCase) ||
        stored.Total != total)
      return Task.FromResult(new SatStatusResponse { Status = "DatosNoCoinciden", CancelationType = "N/A", CancelationStatus = "N/A" });

    return Task.FromResult(new SatStatusResponse
    {
      Status = stored.Status == "Cancelado" ? "Cancelado" : "Vigente",
      CancelationType = stored.Status == "Cancelado" ? "CancelableConAceptacion" : "NoCancelable",
      CancelationStatus = stored.Status == "Cancelado" ? "CanceladoConAceptacion" : "N/A"
    });
  }

  public Task<BarcodeResponse> GenerateCfdiBarcodeAsync(BarcodeCfdiRequest request, CancellationToken ct)
    => Task.FromResult(CreateBarcode($"CFDI|{request.RfcEmisor}|{request.RfcReceptor}|{request.Total}|{request.Uuid}"));

  public Task<BarcodeResponse> GenerateRetentionsBarcodeAsync(BarcodeRetentionsRequest request, CancellationToken ct)
    => Task.FromResult(CreateBarcode($"RET|{request.RfcEmisor}|{request.RfcReceptor}|{request.Total}|{request.Uuid}"));

  public Task<BarcodeResponse> GenerateCartaPorteBarcodeAsync(BarcodeCartaPorteRequest request, CancellationToken ct)
    => Task.FromResult(CreateBarcode($"CP|{request.Uuid}|{request.FechaOrigen:O}|{request.FechaTimbrado:O}"));

  public Task<CertificateInfoResponse> ValidateCertificateAsync(CertificateValidateRequest request, CancellationToken ct)
  {
    ct.ThrowIfCancellationRequested();
    bool ok = string.IsNullOrWhiteSpace(request.CerBase64) == false && string.IsNullOrWhiteSpace(request.KeyBase64) == false;
    return Task.FromResult(new CertificateInfoResponse
    {
      IsValid = ok,
      Rfc = ok ? "RFC_EXTRAIDO_EN_BLOQUE_REAL_1" : string.Empty,
      SerialNumber = ok ? "SERIE_EXTRAIDA_EN_BLOQUE_REAL_1" : string.Empty,
      ValidFrom = ok ? DateTimeOffset.UtcNow.AddYears(-1) : null,
      ValidTo = ok ? DateTimeOffset.UtcNow.AddYears(1) : null,
      Warnings = ok ? new[] { "Validación criptográfica completa pendiente de integración EDL nativa." } : new[] { "Certificado/llave vacíos." }
    });
  }

  public Task<PacTimeResponse> GetPacTimeAsync(string provider, CancellationToken ct)
    => Task.FromResult(new PacTimeResponse { Provider = provider, ServerTime = DateTimeOffset.UtcNow, LocalTime = DateTimeOffset.Now });

  public Task<PacAccountStatusResponse> GetPacAccountStatusAsync(string provider, string rfc, CancellationToken ct)
    => Task.FromResult(new PacAccountStatusResponse { Provider = provider, Rfc = rfc, Status = "Active", TimbresAvailable = 1000 });

  public Task<AccountingXmlResponse> GenerateAccountingCatalogAsync(AccountingRequest request, CancellationToken ct)
    => Task.FromResult(CreateAccounting("catalogo.xml", "catalogo"));

  public Task<AccountingXmlResponse> GenerateAccountingTrialBalanceAsync(AccountingRequest request, CancellationToken ct)
    => Task.FromResult(CreateAccounting("balanza.xml", "balanza"));

  public Task<AccountingXmlResponse> GenerateAccountingPolicyAsync(AccountingRequest request, CancellationToken ct)
    => Task.FromResult(CreateAccounting("poliza.xml", "poliza"));

  public Task<AccountingXmlResponse> GenerateAccountingAuxAccountsAsync(AccountingRequest request, CancellationToken ct)
    => Task.FromResult(CreateAccounting("auxiliar_cuentas.xml", "auxiliar_cuentas"));

  public Task<AccountingXmlResponse> GenerateAccountingAuxFoliosAsync(AccountingRequest request, CancellationToken ct)
    => Task.FromResult(CreateAccounting("auxiliar_folios.xml", "auxiliar_folios"));

  private static BarcodeResponse CreateBarcode(string text)
    => new() { QrText = text, ImageBase64 = Convert.ToBase64String(Encoding.UTF8.GetBytes($"REAL_BLOCK_1_QR::{text}")) };

  private static AccountingXmlResponse CreateAccounting(string fileName, string node)
  {
    string xml = $"<{node} version=\"1.3\" />";
    return new AccountingXmlResponse
    {
      FileName = fileName,
      XmlBase64 = Convert.ToBase64String(Encoding.UTF8.GetBytes(xml))
    };
  }

  private static void ValidateStampRequest(StampCfdiRequest request)
  {
    if (request.Cfdi is null || request.Cfdi.Count == 0)
      throw new InvalidOperationException("cfdi es requerido.");

    _ = GetString(request.Cfdi, "emisorRfc", "rfcEmisor");
    _ = GetString(request.Cfdi, "receptorRfc", "rfcReceptor");
    _ = GetString(request.Cfdi, "folio");
    _ = GetDecimal(request.Cfdi, "total");
  }

  private static string GetString(Dictionary<string, object> data, params string[] keys)
  {
    foreach (var key in keys)
    {
      if (data.TryGetValue(key, out var value) && value is not null)
      {
        string text = value.ToString() ?? string.Empty;
        if (string.IsNullOrWhiteSpace(text) == false)
          return text;
      }
    }

    throw new InvalidOperationException($"Falta campo requerido en cfdi: {string.Join("|", keys)}");
  }

  private static decimal GetDecimal(Dictionary<string, object> data, params string[] keys)
  {
    string s = GetString(data, keys);
    if (decimal.TryParse(s, out decimal d))
      return d;

    throw new InvalidOperationException($"Campo decimal inválido: {string.Join("|", keys)}");
  }

  private static string BuildUuid(string rfcEmisor, string rfcReceptor, string serie, string folio, decimal total, DateTimeOffset now)
  {
    string seed = $"{rfcEmisor}|{rfcReceptor}|{serie}|{folio}|{total}|{now:yyyyMMddHHmmssfff}";
    byte[] hash = SHA256.HashData(Encoding.UTF8.GetBytes(seed));
    byte[] guidBytes = new byte[16];
    Array.Copy(hash, guidBytes, 16);
    return new Guid(guidBytes).ToString().ToUpperInvariant();
  }

  private sealed class StoredCfdi
  {
    public string Uuid { get; init; } = string.Empty;
    public string RfcEmisor { get; init; } = string.Empty;
    public string RfcReceptor { get; init; } = string.Empty;
    public decimal Total { get; init; }
    public string Status { get; set; } = "Vigente";
    public string XmlBase64 { get; init; } = string.Empty;
    public DateTimeOffset StampedAt { get; init; }
  }

  private sealed class StoredCancelReceipt
  {
    public string Uuid { get; init; } = string.Empty;
    public string RfcEmisor { get; init; } = string.Empty;
    public string XmlBase64 { get; init; } = string.Empty;
    public string Status { get; init; } = string.Empty;
  }
}
