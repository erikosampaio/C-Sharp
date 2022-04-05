using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteComProprerties {
    internal class Program {
        static void Main(string[] args) {

            Cachorro dog = new Cachorro();            

            Console.WriteLine(dog.Nome);
            Console.WriteLine(dog.Raca);
            Console.WriteLine(dog.Idade);
            Console.WriteLine(dog.Saude);
        }
    }
}