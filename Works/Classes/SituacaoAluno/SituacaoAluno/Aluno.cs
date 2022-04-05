using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace SituacaoAluno {
    internal class Aluno {

        public string Nome;
        public double Nota1;
        public double Nota2;
        public double Nota3;

        public double TotalNota() {
            return Nota1 + Nota2 + Nota3;
        }

        public void Situacao() {
            if(TotalNota() >= 60) {                ;
                Console.WriteLine("Aprovado");
            }
            else {                
                Console.WriteLine("Reprovado");
                Console.WriteLine("Faltaram " + (60 - TotalNota()).ToString("f2", CultureInfo.InvariantCulture) + " Pontos");
            }             
        }
    }    
}
