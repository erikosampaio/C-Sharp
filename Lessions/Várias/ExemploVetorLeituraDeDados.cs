using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Source {
    internal class Program {
        static void Main(string[] args) {

            string frase1 = Console.ReadLine();
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();            
            
            string[] vetor = Console.ReadLine().Split(' ');

            string a = vetor[0];
            string b = vetor[1];
            string c = vetor[2];

            Console.WriteLine("Você digitou:");
            Console.WriteLine(frase1);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);            
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
    }
}
