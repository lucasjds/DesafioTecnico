using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DesafioTecnico.WebMVC.Models;
using System.Net.Http;
using DesafioTecnico.Commons;
using System.Text.Json;

namespace DesafioTecnico.WebMVC.Controllers
{
  public class HomeController : Controller
  {
    private readonly ILogger<HomeController> _logger;
    private readonly ICalculadoraHelper _calculadoraHelper;
    public HomeController(ILogger<HomeController> logger, ICalculadoraHelper calculadoraHelper)
    {
      _logger = logger;
      _calculadoraHelper = calculadoraHelper;
    }

    public IActionResult Index()
    {
      return View();
    }


    [HttpPost]
    public async Task<string> ObtemResultadoCalculadora(string numero)
    {
      var resultado = await _calculadoraHelper.ObtemResultados(Convert.ToInt32(numero));
      return resultado;
    }
  }
}
