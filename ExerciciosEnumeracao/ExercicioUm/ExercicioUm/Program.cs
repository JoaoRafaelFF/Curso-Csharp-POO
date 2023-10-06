using ExercicioUm.Entities;
using ExercicioUm.Entities.Enums;
using System;
using System.Globalization;

namespace ExercicioUm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o nome do Departamento: ");
            string deptName = Console.ReadLine();

            Console.WriteLine("Entre com os dados do Trabalhador: ");
            Console.WriteLine("Nome: ");
            string name = Console.ReadLine();
            Console.WriteLine("Digite o nivel do Funcionario: (Junior/MidLevel/Senior)");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.WriteLine("Digite o Salario Base do Funbcionario: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Department dept = new Department(deptName);
            Worker worker = new Worker(name, level, baseSalary, dept);

            Console.WriteLine("Quntos contratos serão cadastrados ao Funcionario: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Entro com os dados do {i}# contrato: ");
                Console.Write("Data (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());

                Console.Write("Valor por hora do contrato: ");
                double valuePerHour = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                Console.Write("Duracão (Horas): ");
                int hour = int.Parse(Console.ReadLine());
                HourContract contract = new HourContract(date,valuePerHour,hour);
                worker.AddContract(contract);
            }

            Console.WriteLine();
            Console.WriteLine("Entre com o mês e ano para calcular o ganho do Funcionario: (MM/YYYY)");
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));
            Console.WriteLine();
            Console.WriteLine("Nome "+worker.Name);
            Console.WriteLine("Departamento: "+worker.Department.Name);
            Console.WriteLine("Salario do periodo " + monthAndYear + ": " +worker.Income(year,month).ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}