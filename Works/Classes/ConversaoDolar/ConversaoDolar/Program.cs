using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ConversaoDolar {
    class Program {
        static void Main(string[] args) {

            Console.Write("Qual é a cotação do dólar? ");
            ConversorDeMoeda.CotacaoDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dólares você vai comprar? ");
            ConversorDeMoeda.DolarComprar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            ConversorDeMoeda.DolarParaReal();
            Console.WriteLine("Valor a ser pago em reais = R$ " + ConversorDeMoeda.DolarParaReal().ToString("f2", CultureInfo.InvariantCulture));
        }
    }
}
