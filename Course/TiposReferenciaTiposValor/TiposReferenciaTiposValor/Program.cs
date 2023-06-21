using System;

namespace TiposReferenciaTiposValor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PointStruct p; // tipo struct nao precia mas aceita o new
            p.X = 10;
            p.Y = 20;

            Console.WriteLine(p);

            p= new PointStruct();

            Console.WriteLine(p);
        }
    }
}
