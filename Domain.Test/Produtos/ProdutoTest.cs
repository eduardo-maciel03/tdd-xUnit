using TDD.Domain.ProdutoModel;
using TDD.Domain.ProdutoModel.Enums;

namespace TDD.Domain.Test.Produtos;

public class ProdutoTest
{
    [Fact]
    public void Produto_CriarProduto_RetornaProduto()
    {
        var ProdutoEsperado = new
        {
            Tipo = ProdutoTipo.Livro,
            Cor = "Azul",
            Preco = (decimal)24.90,
            Estoque = (int)10
        };

        var produto = new Produto(ProdutoEsperado.Tipo, ProdutoEsperado.Cor, ProdutoEsperado.Preco, ProdutoEsperado.Estoque);

        Assert.Equal(ProdutoEsperado.Tipo, produto.Tipo);
    }
}
