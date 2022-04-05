using System;
using System.Globalization;
namespace Course {
    class Program {
        static void Main(string[] args) {

            Produto p = new Produto("TV", 500.00, 10);

            p.Nome = "T"; // É posível devido o properties criado.

            // p._preco = 20 -> Não é possivel devido o encapsulamento.
            // p.SetPreco(20.0) -> Não é possivel devido o encapsulamento.

            Console.WriteLine(p.Nome); // p.Nome = "TV 4K"; // É posível devido o properties criado.
            Console.WriteLine(p.Preco); // É posível acessar devido o encapsulamento.
            Console.WriteLine(p.Quantidade); // É posível acessar devido o encapsulamento.
        }
    }
}