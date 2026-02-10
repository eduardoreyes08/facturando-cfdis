namespace Edl.Api.Options;

public sealed class EdlApiOptions
{
  public const string SectionName = "EdlApi";
  public bool UseMockMode { get; set; } = true;
  public string EnvironmentDefault { get; set; } = "test";

  // Bloque real 3
  public bool RequireLicenseLoaded { get; set; } = true;
  public string StoragePath { get; set; } = string.Empty;

  // Bloque real 4
  public bool PersistXmlArtifacts { get; set; } = true;
  public string XmlOutputPath { get; set; } = string.Empty;
}
