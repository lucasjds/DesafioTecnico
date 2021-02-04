using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesafioTecnico.Commons;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DesafioTecnico.WebApi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class CalculadoraController : ControllerBase
  {
    // GET: api/<CalculadoraController>
    [HttpGet]
    public IEnumerable<string> Get()
    {
      return new string[] { };
    }

    [HttpGet("{numero}/obtemresultado")]
    public IActionResult ObtemResultadosCalculadora(int numero)
    {
      Calculadora calculadora = new Calculadora();
      calculadora.ObtemDivisores(numero);
      calculadora.ObtemNumerosPrimos();
      return Ok(calculadora);
    }

  }
}
