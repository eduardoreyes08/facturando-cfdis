namespace Edl.Api.Models;

public sealed class CertificateValidateRequest
{
  public string CerBase64 { get; init; } = string.Empty;
  public string KeyBase64 { get; init; } = string.Empty;
  public string KeyPassword { get; init; } = string.Empty;
}

public sealed class CertificateInfoResponse
{
  public bool IsValid { get; init; }
  public string Rfc { get; init; } = string.Empty;
  public string SerialNumber { get; init; } = string.Empty;
  public DateTimeOffset? ValidFrom { get; init; }
  public DateTimeOffset? ValidTo { get; init; }
  public IReadOnlyList<string> Warnings { get; init; } = Array.Empty<string>();
}
