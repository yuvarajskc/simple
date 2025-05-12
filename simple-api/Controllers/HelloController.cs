using Microsoft.AspNetCore.Mvc;
using Serilog;

namespace SimpleApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HelloController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        Log.Information("HelloController.Get endpoint was called.");
        return Ok(new { message = "Hello from API" });
    }
}
