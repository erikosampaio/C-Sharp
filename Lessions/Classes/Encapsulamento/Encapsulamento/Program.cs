using System;
using System.Globalization;
namespace Course {
    class Program {
        static void Main(string[] args) {
            
            Produto p = new Produto("TV", 500.00, 10);

            p.SetNome("T"); // É posível modificar devido o encapsulamento.

            // p._preco = 20 -> Não é possivel devido o encapsulamento.
            // p.SetPreco(20.0) -> Não é possivel devido o encapsulamento.

            Console.WriteLine(p.GetNome()); // É posível acessar devido o encapsulamento.
            Console.WriteLine(p.GetPreco()); // É posível acessar devido o encapsulamento.
            Console.WriteLine(p.GetQuantidade()); // É posível acessar devido o encapsulamento.
        }
    }
}