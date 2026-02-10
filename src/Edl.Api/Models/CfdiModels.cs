namespace Edl.Api.Models;

public sealed class StampCfdiRequest
{
  public string Environment { get; init; } = "test";
  public bool UseHttps { get; init; } = true;
  public Dictionary<string, string>? Pac { get; init; }
  public CertificateDto Certificate { get; init; } = new();
  public Dictionary<string, object> Cfdi { get; init; } = new();
}

public sealed class StampRetentionsRequest
{
  public string Environment { get; init; } = "test";
  public bool UseHttps { get; init; } = true;
  public CertificateDto Certificate { get; init; } = new();
  public Dictionary<string, object> Retentions { get; init; } = new();
}

public sealed class CertificateDto
{
  public string CerBase64 { get; init; } = string.Empty;
  public string KeyBase64 { get; init; } = string.Empty;
  public string KeyPassword { get; init; } = string.Empty;
}

public sealed class StampResponse
{
  public bool Success { get; init; }
  public string Uuid { get; init; } = string.Empty;
  public DateTimeOffset StampedAt { get; init; }
  public string XmlStampedBase64 { get; init; } = string.Empty;
  public Dictionary<string, string> Pac { get; init; } = new();
  public string TransactionId { get; init; } = string.Empty;
  public IReadOnlyList<string>? Errors { get; init; }
}

public sealed class CancelCfdiRequest
{
  public string RfcEmisor { get; init; } = string.Empty;
  public string Uuid { get; init; } = string.Empty;
  public string Motivo { get; init; } = string.Empty;
  public string? UuidSustitucion { get; init; }
  public bool OtroPac { get; init; }
}

public sealed class CancelReceiptResponse
{
  public string XmlBase64 { get; init; } = string.Empty;
  public string Status { get; init; } = string.Empty;
}

public sealed class CfdiXmlResponse
{
  public string Uuid { get; init; } = string.Empty;
  public string XmlBase64 { get; init; } = string.Empty;
}
