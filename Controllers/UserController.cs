using Microsoft.AspNetCore.Mvc;
using MyFirstAPI.Models;
using System.Net.Cache;

namespace MyFirstAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
    [HttpGet]
    [ProducesResponseType(typeof(Response), StatusCodes.Status200OK)]
    public IActionResult Get()
    {
        var response = new Response
        {
            Age = 23,
            Name = "Rinaldo"
        };

        return Ok(response);
    }

}
