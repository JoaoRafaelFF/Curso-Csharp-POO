using System;
using System.Globalization;
using ExemploEncapsulamento;

namespace ExemploEncapsulamentoe
{
    class Program
    {
        static void Main(string[] args)
        {
            //testes

            Produto p = new Produto("TV", 500.00 ,10);

            p.SetNome("TV 4k");

            Console.WriteLine(p.GetNome());
            


        }
    }
}