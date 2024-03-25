using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyfirstAPI.Controllers;
[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {

        return Ok("Guilherme");
    }
}
