using System;
using System.Collections.Generic;

namespace Matriz {
    class Program {
        static void Main(string[] args) {


            Console.Write("array row size? ");
            int row = int.Parse(Console.ReadLine());

            Console.Write("array column size? ");
            int column = int.Parse(Console.ReadLine());

            int[,] mat = new int[row, column];

            Console.WriteLine();
            Console.WriteLine("Headquaters:");
            for (int i = 0; i < row; i++) {
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < column; j++) {
                    mat[i, j] = int.Parse(values[j]);                                        
                }
            }

            Console.Write("\npick a number from the array: ");
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < row; i++) {
                for (int j = 0; j < column; j++) {
                    if (mat[i, j] == number) {
                        Console.WriteLine($"\nPosition {i},{j}:");
                        if (j - 1 >= 0) {
                            Console.WriteLine($"Left: {mat[i, j - 1]}");
                        }
                        if (j + 1 < column) {
                            Console.WriteLine($"Right: {mat[i, j + 1]}");
                        }
                        if (i - 1 >= 0) {
                            Console.WriteLine($"Up: {mat[i - 1, j]}");
                        }
                        if (i + 1 < row) {
                            Console.WriteLine($"Down: {mat[i + 1, j]}");
                        }
                    }
                }
            }
        }
    }
}
