using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioQuatro
{
    internal class Funcionario
    {

        public string NomeFuncionario;
        public double SalarioBruto;
        public double Imposto;
        public double Porcentagem;



        public double SalarioLiquido() 
        {
            return SalarioBruto - Imposto;
        }


        public double AumentoSalario()
        {
            return SalarioBruto = SalarioBruto + ((SalarioBruto * Porcentagem) / 100);
        }

        public override string ToString()
        {
            return NomeFuncionario + ", R$ " + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
