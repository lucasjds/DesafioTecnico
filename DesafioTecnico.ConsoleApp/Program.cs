using System;
using System.Collections.Generic;

namespace DesafioTecnico.ConsoleApp
{
  public class Program
  {

    public static List<int> ObtemDivisores(int numero)
    {
      List<int> divisores = new List<int>();
      for (int i = 1; i <= Math.Sqrt(numero); i++)
      {
        if (EhDivisaoExata(numero, i))
        {
          divisores.Add(i);
          int numeroEspelho = numero / i;
          if (numeroEspelho != i)
            divisores.Add(numeroEspelho);
        }
      }
      divisores.Sort();
      return divisores;
    }

    private static bool EhDivisaoExata(int numero, int i)
    {
      return numero % i == 0;
    }

    static void Main(string[] args)
    {
      int valorDeEntrada = Convert.ToInt32(Console.ReadLine());
      var result = ObtemDivisores(valorDeEntrada);
      foreach (int divisor in result)
      {
        Console.WriteLine(divisor);
      }

    }
  }
}
