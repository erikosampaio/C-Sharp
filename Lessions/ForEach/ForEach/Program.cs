using System;

namespace ForEach {
    class Program {
        static void Main(string[] args) {

            string[] vect = new string[3] { "Eriko", "Nayara", "Tarciane"};
            int[] v = new int[3] { 1, 2, 3 };

            Console.WriteLine("---------");
            foreach (var nome in vect) {
                Console.WriteLine(nome);
            }
            Console.WriteLine("---------");

            Console.WriteLine();
            Console.WriteLine("------");
            foreach (int numero in v) {
                Console.WriteLine(numero);
            }
            Console.WriteLine("------");
        }
    }
}
