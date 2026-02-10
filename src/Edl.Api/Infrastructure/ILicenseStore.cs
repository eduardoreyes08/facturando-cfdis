namespace Edl.Api.Infrastructure;

public interface ILicenseStore
{
  void Set(string base64);
  string? Get();
  bool IsLoaded();
}
