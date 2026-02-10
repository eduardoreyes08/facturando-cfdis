namespace Edl.Api.Models;

public sealed class AccountingRequest
{
  public string Rfc { get; init; } = string.Empty;
  public int Year { get; init; }
  public int Month { get; init; }
  public Dictionary<string, object> Data { get; init; } = new();
}

public sealed class AccountingXmlResponse
{
  public string XmlBase64 { get; init; } = string.Empty;
  public string FileName { get; init; } = string.Empty;
}
