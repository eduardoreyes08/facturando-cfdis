namespace Edl.Api.Models;

public sealed class BarcodeCfdiRequest
{
  public string RfcEmisor { get; init; } = string.Empty;
  public string RfcReceptor { get; init; } = string.Empty;
  public decimal Total { get; init; }
  public string Uuid { get; init; } = string.Empty;
  public string? Sello { get; init; }
  public string ImageFormat { get; init; } = "png";
}

public sealed class BarcodeRetentionsRequest
{
  public string RfcEmisor { get; init; } = string.Empty;
  public string RfcReceptor { get; init; } = string.Empty;
  public decimal Total { get; init; }
  public string Uuid { get; init; } = string.Empty;
  public string? Sello { get; init; }
}

public sealed class BarcodeCartaPorteRequest
{
  public string Uuid { get; init; } = string.Empty;
  public DateTimeOffset FechaOrigen { get; init; }
  public DateTimeOffset FechaTimbrado { get; init; }
}

public sealed class BarcodeResponse
{
  public string ImageBase64 { get; init; } = string.Empty;
  public string QrText { get; init; } = string.Empty;
}
