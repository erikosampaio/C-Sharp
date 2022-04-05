using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace DadosRetangulo {
    internal class Program {
        static void Main(string[] args) {

            Retangulo r1;
            r1 = new Retangulo();

            Console.WriteLine("Entre com a largura e altura do retângulo:");
            r1.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            r1.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("AREA = " + r1.Area().ToString("f2", CultureInfo.InvariantCulture));
            Console.WriteLine("PERÍMETRO = " + r1.Perimetro().ToString("f2", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL = " + r1.Diagonal().ToString("f2", CultureInfo.InvariantCulture));
        }
    }
}
