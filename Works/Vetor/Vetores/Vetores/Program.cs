using System;
using System.Globalization;


namespace Vetores {
    class Program {
        static void Main(string[] args) {


            Rooms[] rooms = new Rooms[10];
            Console.Write("How many rooms will be rentend? ");
            int qtd = int.Parse(Console.ReadLine());            

            Console.WriteLine();
            Console.WriteLine();
            for (int i = 0; i < qtd; i++) {
                Console.WriteLine("Rent #" + (i+1) + ":");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Room: ");
                int room = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                rooms[room] = new Rooms { Name = name, Email = email, Room = room };
                Console.WriteLine();
                Console.WriteLine();
            }

            Console.WriteLine("Busy rooms:");
            for (int i = 0; i < 10; i++) {
                if (rooms[i] != null)
                    Console.WriteLine($"{rooms[i].Room}: {rooms[i].Name}, {rooms[i].Email}");                
            }
        }
    }
}
