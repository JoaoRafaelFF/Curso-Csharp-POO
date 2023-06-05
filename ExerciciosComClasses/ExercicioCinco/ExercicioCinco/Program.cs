using System;
using System.Globalization;

namespace ExercicioCinco
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();

            Console.WriteLine("Entre com os dados do aluno");
            Console.Write("Nome: ");
            aluno.NomeAluno = Console.ReadLine();
            
            Console.WriteLine("Digite a primeira nota:");
            aluno.Nota1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a segunda nota: ");
            aluno.Nota2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a terceira nota: ");
            aluno.Nota3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Nota Final= "+ aluno.NotaFinal().ToString("F2",CultureInfo.InvariantCulture));

            if (aluno.Aprovado())
            {
                Console.WriteLine("Aluno Aprovado");
            }
            else 
            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM " + aluno.NotaRestante().ToString("F2", CultureInfo.InvariantCulture) + " PONTOS");
            }

        }
    }
}
