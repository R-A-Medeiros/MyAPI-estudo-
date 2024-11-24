using Microsoft.AspNetCore.Mvc;

namespace MyFirstAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public abstract class MyFirstApiBaseController : ControllerBase
{
    [HttpGet("heathy")]  // para endpoints compartilhados por herança corre o risco de apresentar o erro de 'endpoints duplicados' então é uma boa pratica criar rotas especificas. 
    public IActionResult Heathy()
    {
        return Ok("It's working");
    }

    protected string GetCustomKey() // -> metodos que n sejam endpoints precisam ser protected ou private
    {
        return Request.Headers["MyKey"].ToString();
    }

}
