using System;
using System.Globalization;

namespace ExercicioTres
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Retangulo ret = new Retangulo();

            Console.WriteLine("Digite a altura de um retangulo: ");
            ret.Altura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("Digite a largura de um retangulo: ");
            ret.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Area do retangulo = " + ret.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Perimetro do retangulo = " + ret.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Diagonal do retangulo = " + ret.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}