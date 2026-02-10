using Edl.Api.Models;
using Edl.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace Edl.Api.Controllers;

[ApiController]
[Route("api/v1/certificates")]
public class CertificatesController(IEdlService service) : ControllerBase
{
  [HttpPost("validate-csd")]
  public async Task<ActionResult<CertificateInfoResponse>> ValidateCsd([FromBody] CertificateValidateRequest request, CancellationToken ct)
  {
    if (string.IsNullOrWhiteSpace(request.CerBase64) || string.IsNullOrWhiteSpace(request.KeyBase64) || string.IsNullOrWhiteSpace(request.KeyPassword))
      return BadRequest(new ErrorResponse { Message = "cerBase64, keyBase64 y keyPassword son requeridos." });

    return Ok(await service.ValidateCertificateAsync(request, ct));
  }
}
