using System;
using System.Globalization;

namespace ResolvendoUmProblemaSemOO
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double Xa, Xb, Xc, Ya, Yb, Yc;

            Console.WriteLine("Entre com as medidas do Triangulo X:");
            Xa = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Xb = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Xc = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Console.WriteLine("Entre com as medidas do Triangulo Y:");
            Ya = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Yb = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Yc = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double P = (Xa + Xb + Xc) / 2;
            double AreaX = Math.Sqrt(P * (P - Xa) * (P - Xb) * (P - Xc));

            P = (Ya + Yb + Yc) / 2;
            double AreaY = Math.Sqrt(P * (P - Ya) * (P - Yb) * (P - Yc));

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
