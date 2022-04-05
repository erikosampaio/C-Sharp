﻿using System;
using System.Globalization;

namespace PropertiesTimeSpan {
    class Program {
        static void Main(string[] args) {
                        
            
            TimeSpan t = new TimeSpan(2, 3, 5, 7, 11);

            Console.WriteLine(t);

            Console.WriteLine("Days: " + t.Days);
            Console.WriteLine("Hours: " + t.Hours);
            Console.WriteLine("Minutes: " + t.Minutes);
            Console.WriteLine("Seconds: " + t.Seconds);
            Console.WriteLine("Milliseconds: " + t.Milliseconds);
            Console.WriteLine("Ticks: " + t.Ticks);

            Console.WriteLine("TotalDays: " + t.TotalDays);
            Console.WriteLine("TotalHours: " + t.TotalHours);
            Console.WriteLine("TotalMinutes: " + t.TotalMinutes);
            Console.WriteLine("TotalSeconds: " + t.TotalSeconds);
            Console.WriteLine("TotalMilliseconds: " + t.TotalMilliseconds);


            TimeSpan t1 = new TimeSpan(1, 30, 10);
            TimeSpan t2 = new TimeSpan(0, 10, 5);
            
            TimeSpan sum = t1.Add(t2);
            Console.WriteLine(sum);

            TimeSpan dif = t1.Subtract(t2);
            Console.WriteLine(dif);

            TimeSpan mult = t2.Multiply(2.0); // Versão compatível apenas com o .NET Core
            Console.WriteLine(mult);

            TimeSpan div = t2.Divide(2); // Versão compatível apenas com o .NET Core
            Console.WriteLine(div);
        }
    }
}
