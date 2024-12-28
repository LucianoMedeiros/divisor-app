using Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class DivisorController : ControllerBase
  {
    private readonly IDivisorService _divisorService;

    public DivisorController(IDivisorService divisorService)
    {
      _divisorService = divisorService;
    }

    [HttpGet("{number}")]
    public IActionResult GetDivisors(int number)
    {

      if (number > 0)
      {
        var divisors = _divisorService.GetDivisors(number);
        var primeDivisors = _divisorService.GetPrimeDivisors(divisors);

        return Ok(new
        {
          Number = number,
          Divisors = divisors,
          PrimeDivisors = primeDivisors
        });
      }

      return BadRequest(new { Error = "Por favor, forneça um número inteiro positivo." });
    }
  }
}
