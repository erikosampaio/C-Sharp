using System;
using System.Collections.Generic;

namespace Matriz {
    class Program {
        static void Main(string[] args) {

            List<string> list = new List<string>(); // Criando lista.
            string[] vect = new string[] { }; // Criando vetor.
            double[,] mat2 = new double[2, 3]; // Criando matriz.


            Console.Write("Square matrix size? ");
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, n];
            int negative = 0;

            Console.WriteLine();
            Console.WriteLine("Headquaters:");
            for (int i = 0; i < n; i++) {
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++) {
                    mat[i, j] = int.Parse(values[j]);
                    if (int.Parse(values[j]) < 0)
                        negative++;
                }
            }

            Console.WriteLine("\nMain diagonal: ");
            for (int i = 0; i < n; i++) {
                for (int j = 0; j < n; j++) {
                    if (i == j)
                        Console.Write(" " + mat[i, j] + " ");
                }
            }
            Console.WriteLine();
            Console.WriteLine("\nNegative numbers = " + negative + "\n");
        }
    }
}
