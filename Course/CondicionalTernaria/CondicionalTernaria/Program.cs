using System;
using System.Globalization;

namespace CondicionalTernaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um valor deciaml: ");

            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double desconto = (preco < 20) ? preco * 0.1 : preco * 0.05;

            /*double desconto;
            if (preco < 20)
            {
                desconto = preco * 0.1;
            }
            else 
            {
                desconto = preco * 0.05;
            }
            */

            Console.WriteLine(desconto.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}