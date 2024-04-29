using CalculadoraDIO;

namespace TesteCalculadoraDIO
{
    public class UnitTest1
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
    }
}