using Microsoft.AspNetCore.Mvc;
using MyFirstAPI.Communication.request;
using MyFirstAPI.Communication.response;
using MyFirstAPI.Models;
using System.Net.Cache;

namespace MyFirstAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
    [HttpGet]
    [Route("{id}")]
    [ProducesResponseType(typeof(User), StatusCodes.Status200OK)]
    public IActionResult Get()
    {
        var response = new User
        {
            Age = 23,
            Name = "Rinaldo"
        };

        return Ok(response);
    }

    [HttpPost]
    [ProducesResponseType(typeof(ResponseRegisteredUser), StatusCodes.Status201Created)]
    public IActionResult Create([FromBody] RequestRegisterUser request)
    {
        var response = new ResponseRegisteredUser
        {
            Id = 1,
            Name = request.Name,
        };

        return Created(string.Empty, response);
    }

    [HttpPut]
    //[Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult Update(
        [FromRoute] int id,
        [FromBody] RequestUpdateUserProfile request)
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
        var response = new List<User>()
        {
            new User { Id = 1, Age = 24, Name = "Rinaldo" },
            new User { Id = 2, Age = 20, Name = "Reinaldo" }
        };

        return Ok(response);
    }

    [HttpPut("change-password")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult ChangePassword([FromBody] RequestChangePassword request)
    {
        return NoContent();
    }
}
