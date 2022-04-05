using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace FuncionarioImposto {
    internal class Program {
        static void Main(string[] args) {

            Funcionario f1;
            f1 = new Funcionario();

            Console.Write("Nome: ");
            f1.Nome = Console.ReadLine();
            Console.Write("Salário Bruto: ");
            f1.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            f1.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("Funcionário: " + f1.Nome + ", " + "R$ " + f1.SalarioLiquido().ToString("f2", CultureInfo.InvariantCulture));

            Console.WriteLine();
            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double taxa = double.Parse(Console.ReadLine());
            f1.AumentarSalario(taxa);
            
            Console.WriteLine();
            Console.WriteLine("Dados Atualizados: " + f1.Nome + ", R$ " + f1.SalarioLiquido().ToString("f2", CultureInfo.InvariantCulture));

        }
    }
}
