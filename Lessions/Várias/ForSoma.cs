using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Source {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("Entre com as medidas do trinângulo X:");
            double a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do trinângulo Y:");
            double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double z = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double p = (a + b + c) / 2;
            double area_x = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            p = (x + y + z) / 2;
            double area_y = Math.Sqrt(p * (p - x) * (p - y) * (p - z));            

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
