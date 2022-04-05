using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Source {
    internal class Program {
        static void Main(string[] args) {

            int numero = 0;           

            do {
                Console.Write("Informe um número: ");
                numero = int.Parse(Console.ReadLine());
                if (numero < 0) {
                    Console.WriteLine("Número negativo!");
                }
                else {
                    Console.WriteLine(numero.ToString("f3", CultureInfo.InvariantCulture));
                }
            }while (numero >= 0);
        }
    }
}
