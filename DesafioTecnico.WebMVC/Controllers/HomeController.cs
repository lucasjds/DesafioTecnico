using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DesafioTecnico.WebMVC.Models;
using System.Net.Http;

namespace DesafioTecnico.WebMVC.Controllers
{
  public class HomeController : Controller
  {
    private readonly ILogger<HomeController> _logger;
   
    public HomeController(ILogger<HomeController> logger)
    {
      _logger = logger;
    }

    public IActionResult Index()
    {
      return View();
    }

    [HttpPost]
    public async Task<JsonResult> ObtemResultadoCalculadoraAsync(string numero)
    {
      using(HttpClient httpClient = new HttpClient())
      {
        string relativeUri = "api/calculadora/" + numero + "/obtemresultado";
        Uri baseUri = new Uri("http://localhost:5000");
        Uri uri = new Uri(baseUri, relativeUri);
        HttpResponseMessage httpResponseMessage = await httpClient.GetAsync(uri);
        if (!httpResponseMessage.IsSuccessStatusCode)
        {
          throw new ApplicationException(httpResponseMessage.ReasonPhrase);
        }

        return Json(await httpResponseMessage.Content.ReadAsStringAsync());
      }
      
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
  }
}
