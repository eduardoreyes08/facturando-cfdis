namespace Edl.Api.Models;

public sealed class ValidateCfdiXmlRequest
{
  public string XmlBase64 { get; init; } = string.Empty;
  public bool ValidateStamp { get; init; } = true;
  public string ValidateSchemaMode { get; init; } = "full";
}

public sealed class ValidateRetentionsXmlRequest
{
  public string XmlBase64 { get; init; } = string.Empty;
}

public sealed class ParseCfdiXmlRequest
{
  public string XmlBase64 { get; init; } = string.Empty;
}

public sealed class ValidateXmlResponse
{
  public bool IsValid { get; init; }
  public IReadOnlyList<string> Validations { get; init; } = Array.Empty<string>();
}
