using System;

namespace ModificadorParametroRefOut {
    class Program {
        static void Main(string[] args) {


            int a = 5; // Necessário inicializar a variável.
            Calculator.TripleRef(ref a);
            Console.WriteLine(a);

            int number = 10;
            int triple;

            Calculator.TripleOut(number, out triple); // Não precisa inicializar a variável que vai receber o dado (out).
            Console.WriteLine(triple);

            // Essas duas ferramentas devem ser evitadas por serem code smells (código ruim).
        }
    }
}
