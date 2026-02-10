namespace Edl.Api.Infrastructure;

public sealed class InMemoryLicenseStore : ILicenseStore
{
  private string? _licenseBase64;

  public void Set(string base64) => _licenseBase64 = base64;
  public string? Get() => _licenseBase64;
  public bool IsLoaded() => string.IsNullOrWhiteSpace(_licenseBase64) == false;
}
