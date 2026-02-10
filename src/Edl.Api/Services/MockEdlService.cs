using System.Text;
using Edl.Api.Models;

namespace Edl.Api.Services;

public sealed class MockEdlService : IEdlService
{
  private static string Tx() => Guid.NewGuid().ToString("N");

  public Task<StampResponse> StampCfdiAsync(StampCfdiRequest request, CancellationToken ct)
  {
    string uuid = Guid.NewGuid().ToString().ToUpperInvariant();
    string xml = $"<cfdi uuid=\"{uuid}\" environment=\"{request.Environment}\" />";
    return Task.FromResult(new StampResponse
    {
      Success = true,
      Uuid = uuid,
      StampedAt = DateTimeOffset.UtcNow,
      XmlStampedBase64 = Convert.ToBase64String(Encoding.UTF8.GetBytes(xml)),
      TransactionId = Tx(),
      Pac = new Dictionary<string, string> { ["provider"] = "mock", ["status"] = "ok" }
    });
  }

  public Task<OperationResponse> CancelCfdiAsync(CancelCfdiRequest request, CancellationToken ct)
    => Task.FromResult(new OperationResponse(true, "Cancelación procesada (mock).", Tx()));

  public Task<CancelReceiptResponse> GetCancelReceiptAsync(string rfcEmisor, string uuid, CancellationToken ct)
  {
    string xml = $"<acuse rfc=\"{rfcEmisor}\" uuid=\"{uuid}\" status=\"Aceptada\" />";
    return Task.FromResult(new CancelReceiptResponse { Status = "Aceptada", XmlBase64 = Convert.ToBase64String(Encoding.UTF8.GetBytes(xml)) });
  }

  public Task<CfdiXmlResponse> GetCfdiXmlAsync(string rfcEmisor, string uuid, CancellationToken ct)
  {
    string xml = $"<cfdi rfcEmisor=\"{rfcEmisor}\" uuid=\"{uuid}\" />";
    return Task.FromResult(new CfdiXmlResponse { Uuid = uuid, XmlBase64 = Convert.ToBase64String(Encoding.UTF8.GetBytes(xml)) });
  }

  public Task<StampResponse> StampRetentionsAsync(StampRetentionsRequest request, CancellationToken ct)
  {
    string uuid = Guid.NewGuid().ToString().ToUpperInvariant();
    string xml = $"<retenciones uuid=\"{uuid}\" environment=\"{request.Environment}\" />";
    return Task.FromResult(new StampResponse
    {
      Success = true,
      Uuid = uuid,
      StampedAt = DateTimeOffset.UtcNow,
      XmlStampedBase64 = Convert.ToBase64String(Encoding.UTF8.GetBytes(xml)),
      TransactionId = Tx(),
      Pac = new Dictionary<string, string> { ["provider"] = "mock", ["status"] = "ok" }
    });
  }

  public Task<IReadOnlyList<string>> GetComplementsAsync(CancellationToken ct)
    => Task.FromResult<IReadOnlyList<string>>(new[] { "nomina12", "reciboPago20", "comercioExterior20", "cartaPorte31", "impuestosLocales10" });

  public Task<OperationResponse> ApplyComplementAsync(string complementType, Dictionary<string, object> cfdi, Dictionary<string, object> complementData, CancellationToken ct)
    => Task.FromResult(new OperationResponse(true, $"Complemento '{complementType}' aplicado (mock).", Tx()));

  public Task<IReadOnlyList<string>> GetAddendasAsync(CancellationToken ct)
    => Task.FromResult<IReadOnlyList<string>>(new[] { "ado", "amece", "walmart", "santander", "bbva" });

  public Task<OperationResponse> ApplyAddendaAsync(string addendaType, string xmlBase64, Dictionary<string, object> addendaData, CancellationToken ct)
    => Task.FromResult(new OperationResponse(true, $"Addenda '{addendaType}' aplicada (mock).", Tx()));

  public Task<ValidateXmlResponse> ValidateCfdiXmlAsync(ValidateCfdiXmlRequest request, CancellationToken ct)
  {
    bool ok = string.IsNullOrWhiteSpace(request.XmlBase64) == false;
    var validations = ok ? new[] { "XML decodificable", "Estructura básica OK (mock)" } : new[] { "xmlBase64 vacío" };
    return Task.FromResult(new ValidateXmlResponse { IsValid = ok, Validations = validations });
  }

  public Task<OperationResponse> ValidateRetentionsXmlAsync(ValidateRetentionsXmlRequest request, CancellationToken ct)
    => Task.FromResult(new OperationResponse(string.IsNullOrWhiteSpace(request.XmlBase64) == false, "Validación retenciones ejecutada (mock).", Tx()));

  public Task<Dictionary<string, object>> ParseCfdiXmlAsync(ParseCfdiXmlRequest request, CancellationToken ct)
    => Task.FromResult(new Dictionary<string, object>
    {
      ["version"] = "4.0",
      ["emisorRfc"] = "XAXX010101000",
      ["receptorRfc"] = "XEXX010101000",
      ["total"] = 123.45m,
      ["source"] = "mock"
    });

  public Task<SatStatusResponse> GetSatStatusAsync(string rfcEmisor, string rfcReceptor, string uuid, decimal total, CancellationToken ct)
    => Task.FromResult(new SatStatusResponse { Status = "Vigente", CancelationType = "No cancelable", CancelationStatus = "N/A" });

  public Task<BarcodeResponse> GenerateCfdiBarcodeAsync(BarcodeCfdiRequest request, CancellationToken ct)
    => Task.FromResult(CreateBarcode($"CFDI|{request.RfcEmisor}|{request.RfcReceptor}|{request.Total}|{request.Uuid}"));

  public Task<BarcodeResponse> GenerateRetentionsBarcodeAsync(BarcodeRetentionsRequest request, CancellationToken ct)
    => Task.FromResult(CreateBarcode($"RET|{request.RfcEmisor}|{request.RfcReceptor}|{request.Total}|{request.Uuid}"));

  public Task<BarcodeResponse> GenerateCartaPorteBarcodeAsync(BarcodeCartaPorteRequest request, CancellationToken ct)
    => Task.FromResult(CreateBarcode($"CP|{request.Uuid}|{request.FechaOrigen:O}|{request.FechaTimbrado:O}"));

  private static BarcodeResponse CreateBarcode(string text)
    => new() { QrText = text, ImageBase64 = Convert.ToBase64String(Encoding.UTF8.GetBytes($"MOCK_QR::{text}")) };


  public Task<CertificateInfoResponse> ValidateCertificateAsync(CertificateValidateRequest request, CancellationToken ct)
    => Task.FromResult(new CertificateInfoResponse
    {
      IsValid = true,
      Rfc = "EKU9003173C9",
      SerialNumber = "30001000000500003416",
      ValidFrom = DateTimeOffset.UtcNow.AddYears(-1),
      ValidTo = DateTimeOffset.UtcNow.AddYears(1),
      Warnings = new[] { "Resultado MOCK: validar contra SAT/PAC en implementación real." }
    });

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

  private static AccountingXmlResponse CreateAccounting(string fileName, string node)
  {
    string xml = $"<{node} version=\"1.3\" />";
    return new AccountingXmlResponse
    {
      FileName = fileName,
      XmlBase64 = Convert.ToBase64String(Encoding.UTF8.GetBytes(xml))
    };
  }

}
