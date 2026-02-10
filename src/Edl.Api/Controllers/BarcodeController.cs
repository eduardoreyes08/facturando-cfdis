using Edl.Api.Models;
using Edl.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace Edl.Api.Controllers;

[ApiController]
[Route("api/v1/barcode")]
public class BarcodeController(IEdlService service) : ControllerBase
{
  [HttpPost("cfdi")]
  public async Task<ActionResult<BarcodeResponse>> Cfdi([FromBody] BarcodeCfdiRequest request, CancellationToken ct)
  {
    if (string.IsNullOrWhiteSpace(request.RfcEmisor) || string.IsNullOrWhiteSpace(request.RfcReceptor) || string.IsNullOrWhiteSpace(request.Uuid))
      return BadRequest(new ErrorResponse { Message = "rfcEmisor, rfcReceptor y uuid son requeridos." });

    return Ok(await service.GenerateCfdiBarcodeAsync(request, ct));
  }

  [HttpPost("retentions")]
  public async Task<ActionResult<BarcodeResponse>> Retentions([FromBody] BarcodeRetentionsRequest request, CancellationToken ct)
  {
    if (string.IsNullOrWhiteSpace(request.RfcEmisor) || string.IsNullOrWhiteSpace(request.RfcReceptor) || string.IsNullOrWhiteSpace(request.Uuid))
      return BadRequest(new ErrorResponse { Message = "rfcEmisor, rfcReceptor y uuid son requeridos." });

    return Ok(await service.GenerateRetentionsBarcodeAsync(request, ct));
  }

  [HttpPost("carta-porte")]
  public async Task<ActionResult<BarcodeResponse>> CartaPorte([FromBody] BarcodeCartaPorteRequest request, CancellationToken ct)
  {
    if (string.IsNullOrWhiteSpace(request.Uuid))
      return BadRequest(new ErrorResponse { Message = "uuid es requerido." });

    return Ok(await service.GenerateCartaPorteBarcodeAsync(request, ct));
  }
}
