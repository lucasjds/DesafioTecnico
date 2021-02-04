using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;

namespace DesafioTecnico.ConsoleApp
{
  class Program
  {

    static async System.Threading.Tasks.Task Main(string[] args)
    {
      using (HttpClient httpClient = new HttpClient())
      {
        int valorDeEntrada = Convert.ToInt32(Console.ReadLine());
        string relativeUri = string.Format("api/calculadora/", valorDeEntrada, "/obtemresultado");
        Uri baseUri = new Uri("http://localhost:5000");
        Uri uri = new Uri(baseUri, relativeUri);

        HttpResponseMessage httpResponseMessage = await httpClient.GetAsync(uri);
        Console.WriteLine(await httpResponseMessage.Content.ReadAsStringAsync());

        if (!httpResponseMessage.IsSuccessStatusCode)
        {
          throw new ApplicationException(httpResponseMessage.ReasonPhrase);
        }
      }
      

    }
  }
}
