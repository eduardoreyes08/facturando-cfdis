using Edl.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace Edl.Api.Controllers;

[ApiController]
[Route("api/v1/health")]
public class HealthController : ControllerBase
{
  [HttpGet]
  public ActionResult<HealthResponse> Get()
    => Ok(new HealthResponse("healthy", DateTimeOffset.UtcNow, "1.0.0"));
}
