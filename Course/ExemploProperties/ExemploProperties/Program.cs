﻿using System;
using ExemploProperties;

namespace ExmploProperties // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("TV",500.00,10);

            p.Nome = ("TV 4K");

            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Preco);


        }
    }
}