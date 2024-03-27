using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;

namespace MyfirstAPI.Controllers;
[Route("api/[controller]")]
[ApiController]
public class MyfirstAPIBaseController : ControllerBase
{
    public string Produto { get; set; } = "lápis";
}
