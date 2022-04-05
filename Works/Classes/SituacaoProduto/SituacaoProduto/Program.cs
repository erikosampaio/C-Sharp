using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace SituacaoProduto {
    internal class Program {
        static void Main(string[] args) {

            Produto produto1;

            produto1 = new Produto();

            Console.WriteLine("Informe os dados do produto:");
            Console.Write("Nome: ");
            produto1.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            produto1.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            produto1.Quantidade = int.Parse(Console.ReadLine());
            
            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + produto1);

            Console.WriteLine();
            Console.Write("Informe a quantidade de produtos que deseja dar entrada no estoque: ");
            int qtd = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            produto1.AdicionarProdutos(qtd);

            Console.WriteLine();
            Console.WriteLine("Dados do produto após entrada no estoque: " + produto1);

            Console.WriteLine();
            Console.Write("Informe a quantidade de produtos que deseja dar saída no estoque: ");
            qtd = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            produto1.RemoverProdutos(qtd);

            Console.WriteLine();
            Console.WriteLine("Dados do produto após saída no estoque: " + produto1);                        
        }
    }
}
