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

        [Theory]
        [InlineData(55, 6, 49)]
        [InlineData(1000, 1, 999)]
        public void Subtrai_PrimeiroNumeroPeloSegundo_RetornaResultadoCorreto(int x, int y, int valorEsperado) 
        {
            Assert.Equal(valorEsperado, _calculadora.Subtracao(x, y));
        }

        [Theory]
        [InlineData(1000, 2, 500)]
        [InlineData(int.MaxValue, int.MaxValue, 1)]
        public void Divide_PrimeiroNumeroPeloSegundo_RetornaResultadoCorreto(int x, int y, int valorEsperado) 
        {             
            Assert.Equal(valorEsperado, _calculadora.Divisao(x, y));
        }

        [Theory]
        [InlineData(11, 11, 121)]
        [InlineData(13, 10000, 130000)]
        public void Multiplica_DoisNumeros_RetornaResultadoCorreto(int x, int y, int valorEsperado) 
        {                       
            Assert.Equal(valorEsperado, _calculadora.Multiplicacao(x, y));
        }
    }
}