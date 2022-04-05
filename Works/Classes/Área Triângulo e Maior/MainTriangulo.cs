using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Source {
    internal class Program {
        static void Main(string[] args) {

            Triangulo x, y;

            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Entre com as medidas do trinângulo X:");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do trinângulo Y:");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areaX = x.Area();
            double areaY = y.Area();

            Console.WriteLine("Área de X = " + area_x.ToString("f4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de Y = " + area_y.ToString("f4", CultureInfo.InvariantCulture));
            if (area_x == area_y) {
                Console.WriteLine("Maior área: Áreas com valores iguais!");
            }
            else if (area_x > area_y){
                Console.WriteLine($"Maior área: X");
            }
            else {
                Console.WriteLine($"Maior área: Y");
            }
        }
    }
}
