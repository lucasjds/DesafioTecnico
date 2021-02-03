using System;
using System.Collections.Generic;

namespace DesafioTecnico.ConsoleApp
{

  public class Calculadora 
  {
    public List<int> Divisores { get; set; }
    public List<int> Primos { get; set; }

    public List<int> ObtemDivisores(int numero)
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

    public bool EhDivisaoExata(int numero, int i)
    {
      return numero % i == 0;
    }

    public bool EhPrimo(int numero)
    {
      for (int i = 2; (i * i) <= numero; i++)
      {
        if (EhDivisaoExata(numero, i)) 
          return false;
      }
      return true;
    }

    public List<int> ObtemNumerosPrimos(List<int> numeros)
    {
      List<int> primos = new List<int>();
      foreach(int numero in numeros)
      {
        if (EhPrimo(numero))
          primos.Add(numero);
      }
      return primos;
    } 

  }
}
