using Edl.Api.Infrastructure;
using Edl.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace Edl.Api.Controllers;

[ApiController]
[Route("api/v1/license")]
public class LicenseController(ILicenseStore licenseStore) : ControllerBase
{
  [HttpPost("load")]
  public ActionResult<OperationResponse> Load([FromBody] LoadLicenseRequest request)
  {
    if (string.IsNullOrWhiteSpace(request.LicenseBase64))
      return BadRequest(new ErrorResponse { Message = "licenseBase64 es requerido." });

    licenseStore.Set(request.LicenseBase64);
    return Ok(new OperationResponse(true, "Licencia cargada.", Guid.NewGuid().ToString("N")));
  }

  [HttpGet("status")]
  public ActionResult<LicenseStatusResponse> Status()
  {
    bool loaded = licenseStore.IsLoaded();
    return Ok(new LicenseStatusResponse
    {
      Status = loaded ? "Licensed" : "Unloaded",
      Description = loaded ? "Licencia cargada en memoria." : "Licencia no cargada."
    });
  }

  [HttpGet("data")]
  public IActionResult Data()
  {
    if (licenseStore.IsLoaded() == false)
      return NotFound(new ErrorResponse { Message = "No hay licencia cargada." });

    return Ok(new
    {
      source = "in-memory",
      length = licenseStore.Get()!.Length,
      preview = licenseStore.Get()![..Math.Min(20, licenseStore.Get()!.Length)]
    });
  }
}
