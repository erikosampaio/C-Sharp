using System.Globalization;

namespace SituacaoProduto {
    internal class Produto {

        // Atributos
        public string Nome;
        public double Preco;
        public int Quantidade;

        // Construtor Padrão
        public Produto() {
        }

        // Construtor Opcional 1
        public Produto(string nome, double preco, int quantidade) {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        // Construtor Opcional 2
        public Produto(string nome, double preco) {
            Nome = nome;
            Preco = preco;
            Quantidade = 5;
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
