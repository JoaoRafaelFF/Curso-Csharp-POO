using System;

namespace OperacoesTimeSpan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TimeSpan t1 = TimeSpan.MaxValue;

            TimeSpan t2 = TimeSpan.MinValue;

            TimeSpan t3 = TimeSpan.Zero;

            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);

            TimeSpan t = new TimeSpan(2, 3, 5, 7, 11);

            Console.WriteLine("Days: " + t.Days);
            Console.WriteLine("Hours: " + t.Hours);
            Console.WriteLine("Minutes: " + t.Minutes);
            Console.WriteLine("milliseconds: " + t.Milliseconds);
            Console.WriteLine("seconds: " + t.Seconds);
            Console.WriteLine("tiks: " + t.Ticks);

            Console.WriteLine("Total Days: " + t.TotalDays);
            Console.WriteLine("Total Hours: " + t.TotalHours);
            Console.WriteLine("Total Minutes: " + t.TotalMinutes);
            Console.WriteLine("Total Milleseconds" + t.TotalMilliseconds);
            Console.WriteLine("Total Seconds: " + t.TotalSeconds);


            TimeSpan T1 = new TimeSpan(1, 30, 10);
            TimeSpan T2 = new TimeSpan(0, 10, 5);


            TimeSpan sum = T1.Add(T2);
            TimeSpan dif = T1.Subtract(T2);
            TimeSpan mult = T2.Multiply(2);
            TimeSpan div = T2.Divide(2);


            Console.WriteLine(T1);
            Console.WriteLine(T2);
            Console.WriteLine(sum);
            Console.WriteLine(dif);
            Console.WriteLine(mult);
            Console.WriteLine(div);




        }
    }
}
