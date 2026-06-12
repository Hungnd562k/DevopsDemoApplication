using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using WebApplication1.Model;

namespace WebApplication1.Controllers;

[ApiController]
[Route("api/v1/config-options")]
public class ConfigOptionsController : ControllerBase
{
    private ConfigOptions _configOptions = new();
    
    public ConfigOptionsController(IOptions<ConfigOptions> configOptions)
    {
        _configOptions = configOptions.Value;
    }
    
    [HttpGet("get")]
    public IActionResult GetConfigOptions()
    {
        return Ok(_configOptions);
    }
}