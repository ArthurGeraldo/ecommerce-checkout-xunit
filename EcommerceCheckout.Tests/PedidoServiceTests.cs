using EcommerceCheckout.App;
using Xunit;

namespace EcommerceCheckout.Tests
{
    public class PedidoServiceTests
    {
        [Fact]
        public void GerarCodigoRastreio_DeveRetornarCodigoFormatadoCorretamente()
        {
            // Arrange
            var service = new PedidoService();
            
            // Act
            string resultado = service.GerarCodigoRastreio("sudeste", 42);
            
            // Assert
            Assert.Equal("SUDESTE-0042", resultado);
        }

        [Fact]
        public void CalcularPontosFidelidade_DeveCalcularPontosCorretamente()
        {
            // Arrange
            var service = new PedidoService();
            
            // Act
            int resultado = service.CalcularPontosFidelidade(150);
            
            // Assert
            Assert.Equal(30, resultado);
        }

        [Fact]
        public void TemDireitoAFreteGratis_ClienteVIPAbaixoDe200_DeveRetornarTrue()
        {
            // Arrange
            var service = new PedidoService();
            
            // Act
            bool resultado = service.TemDireitoAFreteGratis(150, true);
            
            // Assert
            Assert.True(resultado);
        }

        [Fact]
        public void TemDireitoAFreteGratis_ClienteNaoVIPAbaixoDe200_DeveRetornarFalse()
        {
            // Arrange
            var service = new PedidoService();
            
            // Act
            bool resultado = service.TemDireitoAFreteGratis(150, false);
            
            // Assert
            Assert.False(resultado);
        }
    }
}