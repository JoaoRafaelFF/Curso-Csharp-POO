using System;
using System.Globalization;
using ClasseComTresAtributos;

namespace ClasseComTresAtrubutos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Entre com as medidas do Triangulo X:");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Console.WriteLine("Entre com as medidas do Triangulo Y:");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            double AreaX = x.Area();

            double AreaY = y.Area();

            Console.WriteLine("Area de X igual a: " + AreaX.ToString("F4", CultureInfo.InvariantCulture));

            Console.WriteLine("Area de Y igual a: " + AreaY.ToString("F4", CultureInfo.InvariantCulture));

            if (AreaX > AreaY)
            {
                Console.WriteLine("X tem maior area");
            }
            else
            {
                Console.WriteLine("Y tem maior area");
            }
        }
    }
}