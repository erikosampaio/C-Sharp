using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Source {
    internal class Program {
        static void Main(string[] args) {

            Pessoa primeira, segunda;

            primeira = new Pessoa();
            segunda = new Pessoa();

            Console.WriteLine("Dados da primeira Pessoa:");
            Console.Write("Nome: ");
            primeira.nome = Console.ReadLine();
            Console.Write("Idade: ");
            primeira.idade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados da segunda Pessoa:");
            Console.Write("Nome: ");
            segunda.nome = Console.ReadLine();
            Console.Write("Idade: ");
            segunda.idade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Pessoa mais velha: ");
            if (primeira.idade == segunda.idade) {
                Console.WriteLine("Idades iguais!");
            }
            else if (primeira.idade > segunda.idade) {
                Console.WriteLine(primeira.nome);
            }
            else {
                Console.WriteLine(segunda.nome);
            }
        }
    }
}
