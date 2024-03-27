using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyfirstAPI.Communication.Requests;
using MyfirstAPI.Communication.Responses;

namespace MyfirstAPI.Controllers;


public class UserController : MyfirstAPIBaseController //Heranlça do controller para manter o route igual dentre outros aspectos
{
    [HttpGet]
    [Route("{id}")]
    // Id obrigatorio e passado diretamente no Endpoint[Route("{id}")] api/user/{id}
    [ProducesResponseType(typeof(User), StatusCodes.Status200OK)]//Melhora a documentação do swagger exemplificando o json que ocorre no sucesso 200OK e o formato do objeto response
    [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
    public IActionResult GetById([FromRoute]int id)//FromHeader, FromRoute, FromQuery, ?= Parametro opicional / [FromHeader]int id, [FromHeader]string? nickname
    {
        var response = new User {
            id = 1,
            age = 24,
            name = "Guilherme"       
        };

        return Ok(response);
    }


    [HttpPost]
    [ProducesResponseType(typeof(ResponseRegisterUserJson), StatusCodes.Status201Created)]
    public IActionResult Create([FromBody] RequestRegisterUserJson request)
    {
        var response = new ResponseRegisterUserJson
        {
            Id = 1,
            Name = request.Name,
        };

        return Created(string.Empty, response);//uri, object
    }


    [HttpPut]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult Update([FromBody] RequestUpdateUserProfileJson request)
    {
        return NoContent();
    }


    [HttpDelete]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult Delete()
    {
        return NoContent();
    }

    [HttpGet]
    [ProducesResponseType(typeof(List<User>), StatusCodes.Status200OK)]
    public IActionResult GetAll()
    {
        var response = new List<User>() { 
            new User {id = 1, age = 10, name = "Ana"},
            new User {id = 2, age = 7, name = "Gui"}
        };
        return Ok(response);
    }

    [HttpPut("change-password")] // Diferenciar a rota
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult ChangePassword([FromBody] RequestChangePasswordJson request)
    {
        return NoContent();
    } 
}
