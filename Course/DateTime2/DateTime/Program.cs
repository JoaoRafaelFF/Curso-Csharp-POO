using System;
using System.Data;

namespace MyAppDateTime2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, 275);
            Console.WriteLine(d);
            Console.WriteLine("1) Date " + d.Date);
            Console.WriteLine("2) Day " + d.Day);
            Console.WriteLine("3) Day of week " + d.DayOfWeek);
            Console.WriteLine("4) Day of Year " + d.DayOfYear);
            Console.WriteLine("5) Hour " + d.Hour);
            Console.WriteLine("6) Kind " + d.Kind);
            Console.WriteLine("7) Millisecond " + d.Millisecond);
            Console.WriteLine("8) Munite " + d.Minute);
            Console.WriteLine("9) Month " + d.Month);
            Console.WriteLine("10) Second " + d.Second);
            Console.WriteLine("11) Tikis " + d.Ticks);
            Console.WriteLine("12) Time of day " + d.TimeOfDay);
            Console.WriteLine("13) Year " + d.Year);

            DateTime d2 = new DateTime(2001, 8, 15, 13, 45, 58);

            string s1 = d2.ToLongDateString();
            string s2 = d2.ToLongTimeString();
            string s3 = d2.ToShortDateString();
            string s4 = d2.ToShortTimeString();
            string s5 = d2.ToString();

            string s6 = d2.ToString("yyyy-MM-dd HH:mm:ss");
            string s7 = d2.ToString("yyyy-MM-dd HH:mm:ss.fff");


            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.WriteLine(s4);
            Console.WriteLine(s5);
            Console.WriteLine(s6);
            Console.WriteLine(s7);


            DateTime d3 = new DateTime(2001, 8, 15, 13, 45, 58);

            DateTime d4 = d3.AddHours(2);
            DateTime d5 = d3.AddMinutes(3);

            DateTime d6 = DateTime.Now;
            DateTime d7 = d6.AddDays(7);

            Console.WriteLine(d3);
            Console.WriteLine(d4);
            Console.WriteLine(d5);
            Console.WriteLine(d6);
            Console.WriteLine(d7);

            DateTime d8 = new DateTime(2000,10,15);
            DateTime d9 = new DateTime(2000,10,18);

            TimeSpan t = d9.Subtract(d8);

            Console.WriteLine(t);





        }
    }
}