using System;
using System.Globalization;
using System.Globalization;

namespace MembrosEstaticosExemploDois
{
    internal class Program
    {
       

        static void Main(string[] args)
        {

            Calculadora calc = new Calculadora();

            Console.Write("Entre o valor do Raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = calc.Circunferencia(raio);
            double volume = calc.Volume(raio);

            Console.WriteLine("Circunferencia: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de Pi: " + calc.Pi.ToString("F2", CultureInfo.InvariantCulture));
        }

       
    }
}