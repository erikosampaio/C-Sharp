using System;
using System.Collections.Generic;

namespace List {
    class Program {
        public static void Main(string[] args) {

            List<string> list = new List<string>(); // Declarando uma lista de string

            Console.WriteLine("---------------------------------------------------");
            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Anna");
            Console.WriteLine("----------------Imprimindo a lista-----------------");
            foreach (string item in list)
                Console.WriteLine(item);
            Console.WriteLine("----------------Adicionando item-------------------");
            list.Insert(2, "Marco");            
            foreach (string item in list)
                Console.WriteLine(item);
            
            
            Console.WriteLine("------------------Contando a lista-----------------");
            Console.WriteLine("List count: " + list.Count);


            Console.WriteLine("----------------Encontrando inicial----------------");
            string s1 = list.Find(x => x[0] == 'A');// Dentro dos parenteses temos uma função lambda
            Console.WriteLine("First 'A': " + s1);
            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("last 'A': " + s2);
            
            
            Console.WriteLine("----------------Encontrando posição----------------");
            int p1 = list.FindIndex(x => x[0] == 'A');            
            Console.WriteLine("First position 'A': " + p1);
            int p2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Last position 'A': " + p2);


            Console.WriteLine("-------------Encontrando tamanho itens-------------");
            List<string> list2 = list.FindAll(x => x.Length == 5);
            foreach (string item in list2)
                Console.WriteLine(item);


            Console.WriteLine("------------------Removendo item-------------------");
            list.Remove("Alex");
            foreach (string item in list)
                Console.WriteLine(item);


            Console.WriteLine("------------------Removendo itens------------------");
            list.RemoveAll(x => x[0] == 'M');
            foreach (string item in list)
                Console.WriteLine(item);


            Console.WriteLine("--------------Removendo pela posição--------------");
            list.RemoveAt(1);
            foreach (string item in list)
                Console.WriteLine(item);


            Console.WriteLine("---------------Removendo pela faixa---------------");            
            list.RemoveRange(2, 2); // Primeiro número é o index e o segundo é quantos serão removidos.
            foreach (string item in list)
                Console.WriteLine(item);

            Console.WriteLine("---------------------------------------------------");
        }
    }
}
