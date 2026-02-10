namespace Edl.Api.Models;

public sealed class LoadLicenseRequest
{
  public string LicenseBase64 { get; init; } = string.Empty;
}

public sealed class LicenseStatusResponse
{
  public string Status { get; init; } = "Unloaded";
  public string Description { get; init; } = "License not loaded.";
}
