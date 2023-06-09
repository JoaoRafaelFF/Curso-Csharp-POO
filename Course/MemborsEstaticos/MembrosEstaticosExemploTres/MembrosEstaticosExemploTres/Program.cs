﻿using System;
using System.Globalization;

namespace MembrosEstaticosExemploTres
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre o valor do Raio: ");
            double raio =double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            double circ = Calculadora.Circunferencia(raio);
            double volume = Calculadora.Volume(raio);

            Console.WriteLine("Circunferencia: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Pi " + Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}