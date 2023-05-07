using System;
using System.Globalization;

namespace ExercicioCinco
{
    class Program
    {
        static void Main(string[] args)
        {
            int cod1, cod2, qnt1, qnt2;
            double preco1, preco2, total;

            Console.WriteLine("Digite o Codigo do produto, a quantidade e o preco");
            string[] valores = Console.ReadLine().Split(' ');
            cod1 = int.Parse(valores[0]);
            qnt1 = int.Parse(valores[1]);
            preco1 = double.Parse(valores[2], CultureInfo.InvariantCulture);

            Console.WriteLine("Digite o Codigo do produto, a quantidade e o preco");
            valores = Console.ReadLine().Split(' ');
            cod2 = int.Parse(valores[0]);
            qnt2 = int.Parse(valores[1]);
            preco2 = double.Parse(valores[2], CultureInfo.InvariantCulture);

            total = preco1 * qnt1 + preco2 * qnt2;

            Console.WriteLine("VALOR A PAGAR: " + total.ToString("F2", CultureInfo.InvariantCulture) + " R$");


        }
    }
}
