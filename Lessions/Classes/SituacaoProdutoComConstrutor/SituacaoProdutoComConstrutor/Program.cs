using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace SituacaoProduto {
    internal class Program {
        static void Main(string[] args) {
                        
            Console.WriteLine("Informe os dados do produto:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            int quantidade = int.Parse(Console.ReadLine());

            Produto p1 = new Produto(nome, preco, quantidade);
            Produto p2 = new Produto(nome, preco);
            Produto p3 = new Produto();

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p1);
            Console.WriteLine("Dados do produto: " + p2);
            Console.WriteLine("Dados do produto: " + p3);

            Console.WriteLine();
            Console.Write("Informe a quantidade de produtos que deseja dar entrada no estoque: ");
            int qtd = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            p1.AdicionarProdutos(qtd);

            Console.WriteLine();
            Console.WriteLine("Dados do produto após entrada no estoque: " + p1);
            Console.WriteLine("Dados do produto: " + p2);
            Console.WriteLine("Dados do produto: " + p3);

            Console.WriteLine();
            Console.Write("Informe a quantidade de produtos que deseja dar saída no estoque: ");
            qtd = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            p1.RemoverProdutos(qtd);

            Console.WriteLine();
            Console.WriteLine("Dados do produto após saída no estoque: " + p1);
            Console.WriteLine("Dados do produto: " + p2);
            Console.WriteLine("Dados do produto: " + p3);
        }
    }
}
