using System;

namespace ParametrosRefeOut
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ref
            //int a = 10;
            //Calculator.Triple(ref a); // exige variavel iniciada
            //Console.WriteLine(a);

            int a = 10;
            int triple;
            Calculator.Triple(a, out triple);
            Console.WriteLine(triple);

            // ambos são codigos ruims -evitar-
        }
    }
}
