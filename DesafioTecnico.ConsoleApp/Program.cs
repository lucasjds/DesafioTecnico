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
        if (numero % i == 0)
        {
          divisores.Add(i);
          if ((numero / i) != i )
            divisores.Add(numero / i);
        }
      }
      divisores.Sort();
      return divisores;
    }

    static void Main(string[] args)
    {
      var result = ObtemDivisores(100);
      foreach (int number in result)
      {
        Console.WriteLine(number);
      }

    }
  }
}
