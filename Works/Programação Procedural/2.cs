using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Source {
    internal class Program {
        static void Main(string[] args) {

            int n = int.Parse(Console.ReadLine());
            if (n == 0) {
                Console.WriteLine("Número não negativo");
            } else if (n < 0){
                Console.WriteLine("Número negativo");
            } else {
                Console.WriteLine("Número positivo");
            }
            Console.WriteLine();


            int num = int.Parse(Console.ReadLine());
            if (num % 2 == 0) {
                Console.WriteLine("Número par!");
            }
            else {
                Console.WriteLine("Número ímpar!");
            }
            Console.WriteLine();
            

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            if (a % b == 0 || b % a == 0) {
                Console.WriteLine("São múltiplos");
            }
            else {
                Console.WriteLine("Não são múltiplos");
            }
            Console.WriteLine();


            int inicio = int.Parse(Console.ReadLine());
            int fim = int.Parse(Console.ReadLine());
            if(inicio == fim) {
                Console.WriteLine("O jogo durou 24h");
            } else if(inicio < fim) {
                Console.WriteLine($"O jogo durou {fim - inicio}h");
            } else {
                Console.WriteLine($"O jogo durou {(fim + 24) - inicio}h");
            }
            Console.WriteLine();

        }
    }
}
