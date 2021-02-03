﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesafioTecnico.ConsoleApp;
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
      return new string[] { "value1", "value2" };
    }

    [HttpGet("{numero}")]
    public Calculadora Get(int numero)
    {
      Calculadora calculadora = new Calculadora();
      calculadora.Divisores = calculadora.ObtemDivisores(numero);
      calculadora.Primos = calculadora.ObtemNumerosPrimos(calculadora.Divisores);

      return calculadora;
    }

  

    // POST api/<CalculadoraController>
    [HttpPost]
    public void Post([FromBody] string value)
    {
    }

    // PUT api/<CalculadoraController>/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
    }

    // DELETE api/<CalculadoraController>/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
  }
}
