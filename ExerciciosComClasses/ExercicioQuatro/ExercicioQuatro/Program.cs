using System;
using System.Globalization;

namespace ExercicioQuatro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario func = new Funcionario();


            Console.Write("Nome: ");
            func.NomeFuncionario = Console.ReadLine();
            
            Console.Write(" Salario Bruto: ");
            func.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write(" Imposto: ");
            func.Imposto =double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("Funcionario: "+ func);


            Console.WriteLine();
            Console.WriteLine("Deseja aumentar o salario em qual porcentagem? ");
            func.Porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            func.AumentoSalario();

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + func);


        }
    }
}
