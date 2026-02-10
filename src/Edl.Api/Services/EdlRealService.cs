using Edl.Api.Models;

namespace Edl.Api.Services;

/// <summary>
/// Implementación REAL (base) del servicio EDL.
///
/// Nota:
/// - Esta clase existe para permitir cambiar de Mock a Real sin errores de compilación.
/// - Mientras se completa la integración EDL/PAC endpoint por endpoint, reutiliza el comportamiento del Mock.
/// </summary>
public sealed class EdlRealService : IEdlService
{
  private readonly MockEdlService _mock;
  private readonly ILogger<EdlRealService> _logger;

  public EdlRealService(MockEdlService mock, ILogger<EdlRealService> logger)
  {
    _mock = mock;
    _logger = logger;
  }

  public Task<StampResponse> StampCfdiAsync(StampCfdiRequest request, CancellationToken ct)
  {
    _logger.LogWarning("EdlRealService.StampCfdiAsync está en modo base; delegando temporalmente a MockEdlService.");
    return _mock.StampCfdiAsync(request, ct);
  }

  public Task<OperationResponse> CancelCfdiAsync(CancelCfdiRequest request, CancellationToken ct) => _mock.CancelCfdiAsync(request, ct);
  public Task<CancelReceiptResponse> GetCancelReceiptAsync(string rfcEmisor, string uuid, CancellationToken ct) => _mock.GetCancelReceiptAsync(rfcEmisor, uuid, ct);
  public Task<CfdiXmlResponse> GetCfdiXmlAsync(string rfcEmisor, string uuid, CancellationToken ct) => _mock.GetCfdiXmlAsync(rfcEmisor, uuid, ct);
  public Task<StampResponse> StampRetentionsAsync(StampRetentionsRequest request, CancellationToken ct) => _mock.StampRetentionsAsync(request, ct);
  public Task<IReadOnlyList<string>> GetComplementsAsync(CancellationToken ct) => _mock.GetComplementsAsync(ct);
  public Task<OperationResponse> ApplyComplementAsync(string complementType, Dictionary<string, object> cfdi, Dictionary<string, object> complementData, CancellationToken ct) => _mock.ApplyComplementAsync(complementType, cfdi, complementData, ct);
  public Task<IReadOnlyList<string>> GetAddendasAsync(CancellationToken ct) => _mock.GetAddendasAsync(ct);
  public Task<OperationResponse> ApplyAddendaAsync(string addendaType, string xmlBase64, Dictionary<string, object> addendaData, CancellationToken ct) => _mock.ApplyAddendaAsync(addendaType, xmlBase64, addendaData, ct);
  public Task<ValidateXmlResponse> ValidateCfdiXmlAsync(ValidateCfdiXmlRequest request, CancellationToken ct) => _mock.ValidateCfdiXmlAsync(request, ct);
  public Task<OperationResponse> ValidateRetentionsXmlAsync(ValidateRetentionsXmlRequest request, CancellationToken ct) => _mock.ValidateRetentionsXmlAsync(request, ct);
  public Task<Dictionary<string, object>> ParseCfdiXmlAsync(ParseCfdiXmlRequest request, CancellationToken ct) => _mock.ParseCfdiXmlAsync(request, ct);
  public Task<SatStatusResponse> GetSatStatusAsync(string rfcEmisor, string rfcReceptor, string uuid, decimal total, CancellationToken ct) => _mock.GetSatStatusAsync(rfcEmisor, rfcReceptor, uuid, total, ct);
  public Task<BarcodeResponse> GenerateCfdiBarcodeAsync(BarcodeCfdiRequest request, CancellationToken ct) => _mock.GenerateCfdiBarcodeAsync(request, ct);
  public Task<BarcodeResponse> GenerateRetentionsBarcodeAsync(BarcodeRetentionsRequest request, CancellationToken ct) => _mock.GenerateRetentionsBarcodeAsync(request, ct);
  public Task<BarcodeResponse> GenerateCartaPorteBarcodeAsync(BarcodeCartaPorteRequest request, CancellationToken ct) => _mock.GenerateCartaPorteBarcodeAsync(request, ct);
  public Task<CertificateInfoResponse> ValidateCertificateAsync(CertificateValidateRequest request, CancellationToken ct) => _mock.ValidateCertificateAsync(request, ct);
  public Task<PacTimeResponse> GetPacTimeAsync(string provider, CancellationToken ct) => _mock.GetPacTimeAsync(provider, ct);
  public Task<PacAccountStatusResponse> GetPacAccountStatusAsync(string provider, string rfc, CancellationToken ct) => _mock.GetPacAccountStatusAsync(provider, rfc, ct);
  public Task<AccountingXmlResponse> GenerateAccountingCatalogAsync(AccountingRequest request, CancellationToken ct) => _mock.GenerateAccountingCatalogAsync(request, ct);
  public Task<AccountingXmlResponse> GenerateAccountingTrialBalanceAsync(AccountingRequest request, CancellationToken ct) => _mock.GenerateAccountingTrialBalanceAsync(request, ct);
  public Task<AccountingXmlResponse> GenerateAccountingPolicyAsync(AccountingRequest request, CancellationToken ct) => _mock.GenerateAccountingPolicyAsync(request, ct);
  public Task<AccountingXmlResponse> GenerateAccountingAuxAccountsAsync(AccountingRequest request, CancellationToken ct) => _mock.GenerateAccountingAuxAccountsAsync(request, ct);
  public Task<AccountingXmlResponse> GenerateAccountingAuxFoliosAsync(AccountingRequest request, CancellationToken ct) => _mock.GenerateAccountingAuxFoliosAsync(request, ct);
}
