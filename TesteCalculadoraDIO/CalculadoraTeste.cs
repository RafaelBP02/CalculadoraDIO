using CalculadoraDIO;

namespace TesteCalculadoraDIO
{
    public class CalculadoraTeste
    {
        private Calculadora _calculadora = new Calculadora();

        [Theory]
        [InlineData(1, 4, 5)]
        [InlineData(17, 14, 31)]
        [InlineData(10003, 11007, 21010)]
        [InlineData(int.MaxValue, int.MinValue, -1)]
        public void Soma_DoisNumeros_RetornaResultadoCorreto(int x, int y, int valorEsperado)
        {
            Assert.Equal(valorEsperado, _calculadora.Soma(x, y));  
        }

        [Fact]
        public void Subtrai_PrimeiroNumeroPeloSegundo_RetornaResultadoCorreto() 
        {
            int x = 5; int y = 2; int valorEsperado = 3;

            int resultado = _calculadora.Subtracao(x, y);   

            Assert.Equal(valorEsperado, resultado);
        }

        [Fact]
        public void Divide_PrimeiroNumeroPeloSegundo_RetornaResultadoCorreto() 
        { 
            int x = 4, y = 2, valorEsperado = 2;

            int resultado = _calculadora.Divisao(x, y);

            Assert.Equal(valorEsperado, resultado);
        }

        [Fact]
        public void Multiplica_DoisNumeros_RetornaResultadoCorreto() 
        {
            int x = 5, y= 2, valorEsperado = 10;

            int resultado = _calculadora.Multiplicacao(x, y);

            Assert.Equal(valorEsperado, resultado);
        }
    }
}