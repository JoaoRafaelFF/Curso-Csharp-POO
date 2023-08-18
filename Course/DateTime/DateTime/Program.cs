using System;
using System.Globalization;

namespace MyDateTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = DateTime.Now;
            Console.WriteLine(d1);
            Console.WriteLine(d1.Ticks);

            DateTime d2 = new DateTime(2018, 11, 25);
            DateTime d3 = new DateTime(2018, 11, 25, 20, 43, 15);
            DateTime d4 = new DateTime(2018, 11, 25, 20, 43, 15, 500);
            DateTime d5 = DateTime.Now;
            DateTime d6 = DateTime.Today;
            DateTime d7 = DateTime.UtcNow;

            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);
            Console.WriteLine(d5);
            Console.WriteLine(d6);
            Console.WriteLine(d7);


            DateTime d8 = DateTime.Parse("2000-08-15");
            Console.WriteLine(d8);

            DateTime d9 = DateTime.Parse("2000-08-15 13:15:58");
            Console.WriteLine(d9);

            DateTime d10 = DateTime.Parse("15/08/2000");
            Console.WriteLine(d10);

            DateTime d11 = DateTime.Parse("15/08/2000 13:15:58");
            Console.WriteLine(d11);

            DateTime d12 = DateTime.ParseExact("2000-08-15","yyyy-MM-dd",CultureInfo.InvariantCulture);
            Console.WriteLine(d12);

            DateTime d13 = DateTime.ParseExact("15/08/2000 13:05:58","dd/MM/yyyy HH:mm:ss",CultureInfo.InvariantCulture);
            Console.WriteLine(d13);



        }
    }
}
