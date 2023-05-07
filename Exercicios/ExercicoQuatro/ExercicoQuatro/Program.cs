using System;
using System.Globalization;

namespace ExercicioQuatro
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, horas;
            double valorHora, salario;

            Console.WriteLine("Digite o numero do cadastro do funcionario");
            numero = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o numero de horas trabalhadas");
            horas = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor da hora");
            valorHora = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            salario = valorHora * horas;

            Console.WriteLine("funcionario numero " + numero);
            Console.WriteLine("Salario " + salario.ToString("F2", CultureInfo.InvariantCulture)+" RS");

        }
    }
}