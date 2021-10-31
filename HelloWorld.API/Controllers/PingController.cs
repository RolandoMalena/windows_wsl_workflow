using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace HelloWorld.API.Controllers
{
  [ApiController]
  [Route("")]
  public class PingController : ControllerBase
  {
    private readonly ILogger<PingController> _logger;

    public PingController(ILogger<PingController> logger)
    {
      _logger = logger;
    }

    [HttpGet]
    public string Get()
    {
      _logger.LogInformation("Pong");
      return "Pong";
    }
  }
}
