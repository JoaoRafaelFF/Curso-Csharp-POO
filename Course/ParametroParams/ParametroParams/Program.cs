using System;
using ParametroParams;

namespace PrametroParams
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // int s1 = calculator.Sum(2, 3);
            // int s2 = calculator.Sum(3, 4, 2);


            int s1 = calculator.Sum(2, 3); // com params nao precisa instaciae o new int[] {x,y, z...}
            int s2 = calculator.Sum(3, 4, 2);

            Console.WriteLine(s1);
            Console.WriteLine(s2);


        }
    }
}