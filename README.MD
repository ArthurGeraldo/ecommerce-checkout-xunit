# Ecommerce Checkout - Qualidade de Software

Este projeto foi desenvolvido como parte da disciplina de **Garantia da Qualidade de Software**, ministrada pelo Professor Daniel Henrique Matos de Paiva.

O objetivo do projeto é gerenciar o cálculo de cupons, itens e frete de uma loja online, focando no desenvolvimento e na cobertura com Testes Unitários utilizando **xUnit**.

## Tecnologias Utilizadas
- .NET 10
- C#
- xUnit (Framework de Testes)

## Estrutura do Projeto
- `EcommerceCheckout.App`: Projeto console contendo a classe `PedidoService` com as regras de negócio.
- `EcommerceCheckout.Tests`: Projeto xUnit contendo os testes unitários.

## Métodos Implementados

A classe `PedidoService` possui as seguintes responsabilidades:
1. `GerarCodigoRastreio(string regiao, int numeroPedido)`: Retorna uma string formatada unindo a região em maiúsculas com o número do pedido com 4 dígitos.
2. `CalcularPontosFidelidade(int valorTotal)`: Calcula os pontos de fidelidade do cliente (2 pontos a cada R$ 10).
3. `TemDireitoAFreteGratis(int valorTotal, bool eClienteVIP)`: Retorna `true` se a compra for >= 200 ou o cliente for VIP.

## Como Executar os Testes

Para validar a suíte de testes unitários, certifique-se de ter o .NET 10 SDK instalado e rode o comando abaixo no terminal (na raiz do projeto):

```bash
dotnet test