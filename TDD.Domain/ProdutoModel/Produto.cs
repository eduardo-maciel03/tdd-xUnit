using TDD.Domain.ProdutoModel.Enums;

namespace TDD.Domain.ProdutoModel
{
    public class Produto
    {
        public ProdutoTipo Tipo { get; private set; }
        public string Cor { get; private set; }
        public decimal Preco { get; private set; }
        public int Estoque { get; private set; }

        public Produto(ProdutoTipo tipo, string cor, decimal preco, int estoque)
        {
            this.Tipo = tipo;
            this.Cor = cor;
            this.Preco = preco;
            this.Estoque = estoque;
        }
    }
}
