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

    public IActionResult Privacy()
    {
      return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
      return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    [HttpPost]
    public async Task<JsonResult> ObtemResultadoCalculadora(string numero)
    {
      return Json(await _calculadoraHelper.ObtemResultados(Convert.ToInt32(numero)));
    }
  }
}
