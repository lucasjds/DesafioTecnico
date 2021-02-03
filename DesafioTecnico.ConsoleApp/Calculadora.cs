using System;
using System.Collections.Generic;

namespace DesafioTecnico.ConsoleApp
{
  public class Calculadora
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

    public static bool EhDivisaoExata(int numero, int i)
    {
      return numero % i == 0;
    }

    public static bool EhPrimo(int numero)
    {
      for (int i = 2; (i * i) <= numero; i++)
      {
        if (EhDivisaoExata(numero, i)) 
          return false;
      }
      return true;
    }

    public static List<int> ObtemNumerosPrimos(List<int> numeros)
    {
      List<int> primos = new List<int>();
      foreach(int numero in numeros)
      {
        if (EhPrimo(numero))
          primos.Add(numero);
      }
      return primos;
    } 

    static void Main(string[] args)
    {
      int valorDeEntrada = Convert.ToInt32(Console.ReadLine());
      var listaDivisores = ObtemDivisores(valorDeEntrada);
      var listaPrimos = ObtemNumerosPrimos(listaDivisores);
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
