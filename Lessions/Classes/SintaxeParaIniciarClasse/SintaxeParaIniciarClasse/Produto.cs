using System.Globalization;

namespace SituacaoProduto {
    internal class Produto {

        // Atributos
        public string Nome;
        public double Preco;
        public int Quantidade;

        public Produto() {
            Quantidade = 10;
        }

        public Produto(string nome, double preco) : this() {
            Nome = nome;
            Preco = preco;
        }

        public Produto(string nome, double preco, int quantidade) : this(nome, preco) {
            Quantidade = quantidade;
        }

        // Métodos
        public double ValorTotalEmEstoque() {
            return Preco * Quantidade;
        }

        public override string ToString() {
            return Nome
                + ", R$ "
                + Preco.ToString("f2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " Unidades, Total: R$ "
                + ValorTotalEmEstoque().ToString("f2", CultureInfo.InvariantCulture);
        }

        public void AdicionarProdutos(int quantidade) {
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade) {
            Quantidade -= quantidade;
        }
    }
}
