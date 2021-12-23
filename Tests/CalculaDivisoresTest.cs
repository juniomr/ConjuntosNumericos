using ConjuntosNumericos.Services;
using Xunit;

namespace ConjuntosNumericosTests
{
    public class CalculaDivisoresTest
    {
        private readonly IDivisoresService _divisoresService;

        public CalculaDivisoresTest()
        {
            _divisoresService = new DivisoresService();
        }

        [Fact]
        public void Calcula_os_divisores_de_um_numero()
        {
            // Arrange
            var numeroEntrada = 45;

            // Act
            var retorno = _divisoresService.ObterDivisores(numeroEntrada);

            // Assert
            Assert.Equal(45, numeroEntrada);

            Assert.Collection(retorno.Divisores,
                item => Assert.Equal(1, item),
                item => Assert.Equal(3, item),
                item => Assert.Equal(5, item),
                item => Assert.Equal(9, item),
                item => Assert.Equal(15, item),
                item => Assert.Equal(45, item));
        }
    }
}
