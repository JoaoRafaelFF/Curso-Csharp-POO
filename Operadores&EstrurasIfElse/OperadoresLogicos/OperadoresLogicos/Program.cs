using System;

namespace OperadoresLogicos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool c1 = 2 > 3 && 4 != 5; //false v e f = f
            bool c2 = 2 > 3 || 4 != 5; // true
            bool c3 = !(2 > 3) && 4 != 5; // (nao 2>3 = v e 4 != 5 = v) = true 

            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine(c3);

            Console.WriteLine("--------------------");

            bool c4 = 10 < 5; // false
            bool c5 = c2 || c3 && c4; // c2 e c3 = fase || cs true = true

            Console.WriteLine(c4);
            Console.WriteLine(c5); 
        }
    }
}
