using DesafioTecnico.ConsoleApp;
using Moq;
using System;
using System.Collections.Generic;
using Xunit;

namespace DesafioTecnico.UnitTest
{
  public class UnitTest1
  {
    [Fact]
    public void EhDivisaoExatao_QuandoRestoIgualZero()
    {
      //arrange
      Calculadora calculadora = new Calculadora();
      //act
      bool resultado = calculadora.EhDivisaoExata(10, 5);
      //Assert
      Assert.True(resultado);
    }

    [Fact]
    public void NaoEhDivisaoExatao_QuandoRestoDiferenteDeZero()
    {
      //arrange
      Calculadora calculadora = new Calculadora();
      //act
      bool resultado = calculadora.EhDivisaoExata(10, 4);
      //Assert
      Assert.False(resultado);
    }

    [Fact]
    public void RetornaVerdadeiro_QuandoNumeroPrimo()
    {
      //arrange
      Calculadora calculadora = new Calculadora();
      //act
      bool resultado = calculadora.EhPrimo(7);
      //Assert
      Assert.True(resultado);
    }

    [Fact]
    public void RetornaFalso_QuandoNumeroNaoEhPrimo()
    {
      //arrange
      Calculadora calculadora = new Calculadora();
      //act
      bool resultado = calculadora.EhPrimo(4);
      //Assert
      Assert.False(resultado);
    }

    [Fact]
    public void VerificaObtemDivisoresEqual()
    {
      //arrange
      List<int> listaEsperada = new List<int>() { 1, 3, 5, 9, 15, 45 };

      Calculadora calculadora = new Calculadora();
      //act
      List<int> resultado = calculadora.ObtemDivisores(45);
      //Assert
      Assert.Equal(listaEsperada, resultado);
    }

    [Fact]
    public void VerificaObtemDivisoresNotEqual()
    {
      //arrange

      Calculadora calculadora = new Calculadora();
      //act
      List<int> resultado = calculadora.ObtemDivisores(45);
      //Assert
      Assert.NotEqual(new List<int>() { 1, 3, 5, 9, 45 }, resultado);
    }

    [Fact]
    public void VerificaObtemPrimos()
    {
      //arrange
      Calculadora calculadora = new Calculadora();
      var listaNumeros = new List<int>() { 1, 3, 5, 9, 15, 45 };
      var listaEsperadaDePrimos = new List<int>() { 1, 3, 5,};
      //act
      List<int> resultado = calculadora.ObtemNumerosPrimos(listaNumeros);
      //Assert
      Assert.Equal(listaEsperadaDePrimos, resultado);
    }
  }
}
