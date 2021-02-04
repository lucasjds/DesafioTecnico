using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using Microsoft.Extensions.Configuration;

namespace DesafioTecnico.Commons
{
  public interface ICalculadoraHelper
  {
    Task<string> ObtemResultados(int numero);
  }

  public class CalculadoraHelper : ICalculadoraHelper
  {
    private readonly IConfiguration configuration;
    private readonly HttpClient httpClient;

    public CalculadoraHelper(IConfiguration configuration, HttpClient httpClient)
    {
      this.configuration = configuration;
      this.httpClient = httpClient;
    }

    public async Task<string> ObtemResultados(int numero)
    {
      string relativeUri = "api/calculadora/" + numero + "/obtemresultado";
      Uri baseUri = new Uri(configuration["WebAPIURL"]);
      Uri uri = new Uri(baseUri, relativeUri);
      HttpResponseMessage httpResponseMessage = await httpClient.GetAsync(uri);
      if (!httpResponseMessage.IsSuccessStatusCode)
      {
        throw new ApplicationException(httpResponseMessage.ReasonPhrase);
      }

      return await httpResponseMessage.Content.ReadAsStringAsync();
      
    }
  }
}
