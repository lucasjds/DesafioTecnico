﻿using System;
using System.Collections.Generic;

namespace DesafioTecnico.Commons
{

  public class Calculadora
  {
    public List<int> Divisores { get; set; }
    public List<int> Primos { get; set; }

    public void ObtemDivisores(int numero)
    {
      if(numero <= 0)
        throw new Exception("Entre com um numero maior que zero");
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
      Divisores = divisores;
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

    public void ObtemNumerosPrimos()
    {
      if (Divisores == null)
        throw new Exception("Os Divisores devem ser calculadores primeiramente");
      List<int> primos = new List<int>();
      foreach (int numero in Divisores)
      {
        if (EhPrimo(numero))
          primos.Add(numero);
      }
      Primos = primos;
    }

  }
}
