using Microsoft.AspNetCore.Mvc;

namespace MCD.Controllers;

[ApiController]
[Route("api/[controller]")]
public class McdController : ControllerBase
{
    [HttpGet("mcd/{Dividendo:int}/{Divisor:int}")]
    public IActionResult MCD(int Dividendo, int Divisor)
    {
        int a = Math.Abs(Dividendo);
        int b = Math.Abs(Divisor);

        if (a == 0 && b == 0)
        {
            return BadRequest("No se puede calcular el MCD de 0 y 0.");
        }

        while (b != 0)
        {
            int residuo = a % b;
            a = b;
            b = residuo;
        }

       return Ok(new 
        { 
            dividendo = Dividendo,
            divisor = Divisor,
            resultado = a 
        });
    }
}