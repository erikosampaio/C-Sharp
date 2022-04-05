using System;
using System.Globalization;

namespace LessionDateTime {
    class Program {
        static void Main(string[] args) {

            DateTime d1 = new DateTime(2022, 03, 29);
            DateTime d2 = new DateTime(2022, 03, 29, 13, 23, 30);
            DateTime d3 = new DateTime(2022, 03, 29, 13, 23, 30, 500);

            DateTime d4 = DateTime.Now;
            DateTime d5 = DateTime.Today;
            DateTime d6 = DateTime.UtcNow;

            // Recebendo datas com Parse
            DateTime d7 = DateTime.Parse("1995-10-03");
            DateTime d8 = DateTime.Parse("1995-10-03 13:05:58");
            DateTime d9 = DateTime.Parse("1993/02/23");
            DateTime d0 = DateTime.Parse("1993/02/23 13:05:58");

            // Recebendo datas com ParseExact
            DateTime c1 = DateTime.ParseExact("2013-05-23", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            DateTime c2 = DateTime.ParseExact("30/05/1967 13:05:58", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);


            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);
            Console.WriteLine(d5);
            Console.WriteLine(d6);
            Console.WriteLine(d7);
            Console.WriteLine(d8);
            Console.WriteLine(d9);
            Console.WriteLine(d0);
            Console.WriteLine(c1);
            Console.WriteLine(c2);
        }
    }
}

