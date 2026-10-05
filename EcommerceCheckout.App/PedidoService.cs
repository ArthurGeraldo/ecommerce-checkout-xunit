namespace EcommerceCheckout.App
{
    public class PedidoService
    {
        // 1. Retorno string — GerarCodigoRastreio
        public string GerarCodigoRastreio(string regiao, int numeroPedido)
        {
            // Transforma a região em maiúsculas e formata o número do pedido com zeros à esquerda (4 dígitos)
            return $"{regiao.ToUpper()}-{numeroPedido:D4}";
        }

        // 2. Retorno int — CalcularPontosFidelidade
        public int CalcularPontosFidelidade(int valorTotal)
        {
            // Para cada 10 reais, ganha 2 pontos
            return (valorTotal / 10) * 2;
        }

        // 3. Retorno bool — TemDireitoAFreteGratis
        public bool TemDireitoAFreteGratis(int valorTotal, bool eClienteVIP)
        {
            // Frete grátis se o valor >= 200 OU se for cliente VIP
            return valorTotal >= 200 || eClienteVIP;
        }
    }
}