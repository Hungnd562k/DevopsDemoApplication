using Microsoft.AspNetCore.Mvc;

namespace WebApplication1;

[Route("api/env-vars")]
public class EnvVarController : Controller
{
    [HttpGet("env-vars")]
    public IActionResult Get()
    {
        return Ok();
    }
}