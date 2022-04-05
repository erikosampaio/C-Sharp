using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ContaBancaria {
    class Program {
        static void Main(string[] args) {

            Conta c1;
            Console.Write("Entre com o número da conta: ");
            int numero = int.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Entre com o Titular da conta: ");
            string titular = Console.ReadLine();            
            Console.Write("Haverá depósito inicial (s/n)? ");            
            char escolha = char.Parse(Console.ReadLine());
            double valor;
            if (escolha ==  's' || escolha == 'S') {
                Console.Write("Entre com o valor de depósito inicial: ");
                valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                c1 = new Conta(numero, titular, valor);
            }
            else {
                c1 = new Conta(numero, titular);
            }
            
            Console.WriteLine();
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(c1);            
            
            Console.WriteLine();
            Console.Write("Entre com um valor para depósito: ");
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c1.Deposito(valor);
            Console.WriteLine();
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(c1);

            Console.WriteLine();
            Console.Write("Entre com um valor para saque: ");
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c1.Saque(valor);
            Console.WriteLine();
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(c1);
        }
    }
}
