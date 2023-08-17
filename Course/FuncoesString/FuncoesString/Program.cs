using System;
using System.Security.Cryptography.X509Certificates;

namespace FuncoesString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string original = "abcde FGHIJ ABC abc DEFG    ";

            string S1 = original.ToUpper();
            string S2 = original.ToLower();
            string S3 = original.Trim();

            int n1 = original.IndexOf("bc");
            int n2 = original.LastIndexOf("bc");

            string S4 = original.Substring(3);
            string S5 = original.Substring(3, 5);

            string S6 = original.Replace("a", "x");
            string S7 = original.Replace("abc", "xy");

            bool b1 = string.IsNullOrEmpty(original);
            bool b2 = string.IsNullOrWhiteSpace(original);

            Console.WriteLine("Original: -" + original + "-");
            Console.WriteLine("ToUpper: -" + S1 + "-");
            Console.WriteLine("ToLower: -" + S2 + "-");
            Console.WriteLine("Trim: -" + S3 + "-");
            Console.WriteLine("InfexOf:(bc) -" + n1 + "-");
            Console.WriteLine("LastInfexOf:(bc) -" + n2 + "-");
            Console.WriteLine("Substring (3) -" + S4 + "-");
            Console.WriteLine("Substring (3, 5) -" + S5 + "-");
            Console.WriteLine("Replace(a, x):  -" + S6 + "-");
            Console.WriteLine("Replace(abc, xy):  -" + S7 + "-");
            Console.WriteLine("IsNullOrEmpty: - " + b1 + "-");
            Console.WriteLine("IsNullOrWhiteSpace: - " + b2 + "-");
        }
    }
}