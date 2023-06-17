using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ExercicioUm
{
    internal class ContaCliente
    {

        public int NumeroConta { get; private set; }

        public string NomeCliente { get; set; }

        public double SaldoCliente { get; private set; }

        public ContaCliente(int numero, string nome)
        {
            NumeroConta = numero;
            NomeCliente = nome;
        }

        public ContaCliente(int numero, string nome, double depositoInicial) : this(numero,nome)
        {
            Deposito(depositoInicial);
        }

        public void Deposito(double quantia) 
        {
            SaldoCliente += quantia;
        }

        public void Saque(double quantia)
        {
            SaldoCliente -= quantia + 5.0;
        }





        public override string ToString()
        {
            return "Conta: " + NumeroConta + ", Titular: " + NomeCliente + ", Saldo: $ " + SaldoCliente.ToString("F2", CultureInfo.InvariantCulture); 
        }

    }
}
