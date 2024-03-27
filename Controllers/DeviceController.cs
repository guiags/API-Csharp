using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyfirstAPI.Entities;

namespace MyfirstAPI.Controllers;

public class DeviceController : MyfirstAPIBaseController
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok(Produto); // Produto foi crido na classe pai MyfirstAPIBaseController
    }

    [HttpGet("heranca")]
    public IActionResult Gether()
    {
        var laptop = new Laptop();
        var model = laptop.GetModel();
        var ola = laptop.Hello();//Teve a função de device sobrescrita em laptop
        return Ok(model);
    }
}
