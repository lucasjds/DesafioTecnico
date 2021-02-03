using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioTecnico.ConsoleApp
{
  class Program
  {
    static void Main(string[] args)
    {
      Calculadora calculadora = new Calculadora();

      int valorDeEntrada = Convert.ToInt32(Console.ReadLine());
      var listaDivisores = calculadora.ObtemDivisores(valorDeEntrada);
      var listaPrimos = calculadora.ObtemNumerosPrimos(listaDivisores);
      Console.WriteLine("Divisores");
      foreach (int divisor in listaDivisores)
      {
        Console.WriteLine(divisor);
      }
      Console.WriteLine("Primos");
      foreach (int primo in listaPrimos)
      {
        Console.WriteLine(primo);
      }

    }
  }
}
