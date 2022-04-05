using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Source {
    internal class Program {
        static void Main(string[] args) {

            Console.Write("Quantos números inteiros você vai digitar? ");
            int num = int.Parse(Console.ReadLine());

            int soma = 0;
            for (int i = 0; i < num; i++) {
                Console.Write($"Valor #{i + 1}: ");
                soma += int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"Soma = {soma}");
        }
    }
}
