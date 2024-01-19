using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosParteSete.Entities
{
    internal class Company : TaxPayers
    {
        public int NumberOfEmployees { get; set; }

        public Company() 
        {
        }

        public Company(string name, double anualIncome, int numberOfEmployes) : base(name, anualIncome)
        { 
            NumberOfEmployees = numberOfEmployes;
        }

        public override double Tax()
        {
            if (NumberOfEmployees > 10) 
            {
                return AnualIncome * 0.14;
            }
            else
            {
                return AnualIncome * 0.16;
            }
        }
    }
}
