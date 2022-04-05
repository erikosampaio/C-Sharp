using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace SituacaoAluno {
    internal class Program {
        static void Main(string[] args) {

            Aluno aluno1;
            aluno1 = new Aluno();

            Console.Write("Nome do aluno: ");
            aluno1.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno:");
            aluno1.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno1.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno1.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Nota Final = " + aluno1.TotalNota().ToString("f2", CultureInfo.InvariantCulture));
            aluno1.Situacao();
        }
    }
}
