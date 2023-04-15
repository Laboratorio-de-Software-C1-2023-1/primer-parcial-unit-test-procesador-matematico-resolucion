using primer_parcial_unit_test_procesador_matematico;
using System;
using Xunit;

namespace ProcesadorMatemáticoTests
{
    public class ProcesadorMatematicoTests
    {
        [Fact]
        public void Sumar_ConNumerosPositivos_DevuelveResultadoSuma()
        {
            //Arrange
            ProcesadorMatematico procesadorMatematico = new ProcesadorMatematico();
            int resultadoEsperado = 10;

            //Act
            int resultadoObtenido = procesadorMatematico.Sumar(7, 3);

            //Assert
            Assert.Equal(resultadoEsperado, resultadoObtenido);
        }

        [Fact]
        public void Sumar_ConNumerosNegativos_DevuelveCero()
        {
            //Arrange
            ProcesadorMatematico procesadorMatematico = new ProcesadorMatematico();
            int resultadoEsperado = 0;

            //Act
            int resultadoObtenido = procesadorMatematico.Sumar(-7, 3);

            //Assert
            Assert.Equal(resultadoEsperado, resultadoObtenido);
        }

        [Fact]
        public void Dividir_ConNumerosPositivos_DevuelveResultadoDivision()
        {
            //Arrange
            ProcesadorMatematico procesadorMatematico = new ProcesadorMatematico();
            int resultadoEsperado = 5;

            //Act
            int resultadoObtenido = procesadorMatematico.Dividir(10, 2);

            //Assert
            Assert.Equal(resultadoEsperado, resultadoObtenido);
        }

        [Fact]
        public void Dividir_ConNumerosNegativos_DevuelveCero()
        {
            //Arrange
            ProcesadorMatematico procesadorMatematico = new ProcesadorMatematico();
            int resultadoEsperado = 0;

            //Act
            int resultadoObtenido = procesadorMatematico.Dividir(10, -2);

            //Assert
            Assert.Equal(resultadoEsperado, resultadoObtenido);
        }


        [Fact]
        public void Dividir_DivisorCero_ArrojaExcepcion()
        {
            //Arrange
            ProcesadorMatematico procesadorMatematico = new ProcesadorMatematico();

            //Act & Assert
            try
            {
                int resultadoObtenido = procesadorMatematico.Dividir(10, 0);
            }
            catch (Exception ex)
            {
                Assert.IsType<DivideByZeroException>(ex);
                Assert.Contains("No se acepta divisor igual a cero", ex.Message);
                return;
            }

            Assert.True(false, "DivideByZeroException Exception no ha sucedido");

        }

        [Theory]
        [InlineData(10, 9, 10)]
        [InlineData(9, 10, 10)]
        [InlineData(10, 10, 10)]
        public void CalcularMayor_ConPrimerValorMayor_DevelvePrimerValor(
            int primerValor,
            int segundoValor,
            int resultadoEsperado
        )
        {
            //Arrange
            ProcesadorMatematico procesadorMatematico = new ProcesadorMatematico();

            //Act
            int resultadoObtenido = procesadorMatematico.CalcularMayor(primerValor, segundoValor);

            //Assert
            Assert.Equal(resultadoEsperado, resultadoObtenido);

        }
    }
}
