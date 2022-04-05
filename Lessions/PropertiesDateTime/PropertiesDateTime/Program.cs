using System;
using System.Globalization;

namespace PropertiesDateTime {
    class Program {
        static void Main(string[] args) {

            DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, 275);

            //Console.WriteLine(d);
            //Console.WriteLine("1) Date: " + d.Date);
            //Console.WriteLine("2) Day: " + d.Day);
            //Console.WriteLine("3) DayOfWeek: " + d.DayOfWeek);
            //Console.WriteLine("4) DayOfYear: " + d.DayOfYear);
            //Console.WriteLine("5) Hour: " + d.Hour);
            //Console.WriteLine("6) Kind: " + d.Kind);
            //Console.WriteLine("7) Millisecond: " + d.Millisecond);
            //Console.WriteLine("8) Minute: " + d.Minute);
            //Console.WriteLine("9) Month: " + d.Month);
            //Console.WriteLine("10) Second: " + d.Second);
            //Console.WriteLine("11) Ticks: " + d.Ticks);
            //Console.WriteLine("12) TimeOfDay: " + d.TimeOfDay);
            //Console.WriteLine("13) Year: " + d.Year);


            DateTime c = new DateTime(2001, 8, 15, 13, 45, 58);

            // Convertendo DateTime em string
            string s1 = c.ToLongDateString();
            string s2 = c.ToLongTimeString();
            string s3 = c.ToShortDateString();
            string s4 = c.ToShortTimeString();

            string s5 = c.ToString();

            string s6 = c.ToString("yyyy-MM-dd HH:mm:ss");

            string s7 = c.ToString("yyyy-MM-dd HH:mm:ss.fff");

            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.WriteLine(s4);
            Console.WriteLine(s5);
            Console.WriteLine(s6);
            Console.WriteLine(s7);

            // Usando subtract para saber uma duraçao entre datas, ou vencimento.

            DateTime c1 = new DateTime(2022, 10, 15);
            DateTime c2 = new DateTime(2022, 10, 30);

            TimeSpan c3 = c2.Subtract(c1); //Guardando a diferença entre a data inicial e final de um boleto.

            Console.WriteLine(c3);
        }
    }
}
