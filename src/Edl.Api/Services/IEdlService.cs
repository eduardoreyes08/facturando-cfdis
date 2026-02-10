using Edl.Api.Models;

namespace Edl.Api.Services;

public interface IEdlService
{
  Task<StampResponse> StampCfdiAsync(StampCfdiRequest request, CancellationToken ct);
  Task<OperationResponse> CancelCfdiAsync(CancelCfdiRequest request, CancellationToken ct);
  Task<CancelReceiptResponse> GetCancelReceiptAsync(string rfcEmisor, string uuid, CancellationToken ct);
  Task<CfdiXmlResponse> GetCfdiXmlAsync(string rfcEmisor, string uuid, CancellationToken ct);
  Task<StampResponse> StampRetentionsAsync(StampRetentionsRequest request, CancellationToken ct);
  Task<IReadOnlyList<string>> GetComplementsAsync(CancellationToken ct);
  Task<OperationResponse> ApplyComplementAsync(string complementType, Dictionary<string, object> cfdi, Dictionary<string, object> complementData, CancellationToken ct);
  Task<IReadOnlyList<string>> GetAddendasAsync(CancellationToken ct);
  Task<OperationResponse> ApplyAddendaAsync(string addendaType, string xmlBase64, Dictionary<string, object> addendaData, CancellationToken ct);
  Task<ValidateXmlResponse> ValidateCfdiXmlAsync(ValidateCfdiXmlRequest request, CancellationToken ct);
  Task<OperationResponse> ValidateRetentionsXmlAsync(ValidateRetentionsXmlRequest request, CancellationToken ct);
  Task<Dictionary<string, object>> ParseCfdiXmlAsync(ParseCfdiXmlRequest request, CancellationToken ct);
  Task<SatStatusResponse> GetSatStatusAsync(string rfcEmisor, string rfcReceptor, string uuid, decimal total, CancellationToken ct);
  Task<BarcodeResponse> GenerateCfdiBarcodeAsync(BarcodeCfdiRequest request, CancellationToken ct);
  Task<BarcodeResponse> GenerateRetentionsBarcodeAsync(BarcodeRetentionsRequest request, CancellationToken ct);
  Task<BarcodeResponse> GenerateCartaPorteBarcodeAsync(BarcodeCartaPorteRequest request, CancellationToken ct);
}
