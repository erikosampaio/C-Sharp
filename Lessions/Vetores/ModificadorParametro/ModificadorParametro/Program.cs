using System;

namespace ModificadorParametro {
    class Program {
        static void Main(string[] args) {

                                   
            int[] vetor = new int[4];


            for (int i = 0; i < 4; i++) {
                Console.Write($"{vetor[i]} ");
            }
            Console.WriteLine();
            Console.WriteLine();
            for (int i = 0; i < 4; i++) {
                vetor[i] = 2;
            }
            
            int s1 = Calculator.Sum(1, 2, 3);
            int s2 = Calculator.Sum(2, 3);
            int s3 = Calculator.Sum(vetor);

            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
        }
    }
}
