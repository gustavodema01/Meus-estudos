using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Conta_Bancaria
{
    internal class Conta
    {
        private int NumeroConta;
        public string Titular { get; private set; } //autoproperty para o titular da conta, permitindo apenas leitura fora da classe
        public double Saldo { get; private set; } //autoproperty para o saldo da conta, permitindo apenas leitura fora da classe

        public Conta(int numeroConta, string titular, double saldo) // Construtor para inicializar os atributos da conta com saldo inicial 
        {
            NumeroConta = numeroConta;
            Titular = titular;
            Saldo = saldo;
        }
        public Conta(int numeroConta, string titular) : this(numeroConta, titular, 0.0) // Sobrecarga do construtor para permitir a criação de uma conta sem depósito inicial caso não tenha depósito inicial
        {
            Saldo = 0.0;
        }
        public void Deposito(double Valor)
        {
            if(Valor < 0.0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Digite um valor inválido!"); //proteção da própria classe
                Console.ResetColor();
                return; //sai do método 
            }
            Saldo += Valor;
        }

        public void Saque(double Valor)
        {
            if(Valor < 0.0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Digite um valor válido!");
                Console.ResetColor();
                return; //sai do método
            }
            Saldo -= Valor + 5.00; // Método para realizar um saque, descontando uma taxa fixa de 5.00
        }

        public override string ToString()
        {
            return "Conta:" + NumeroConta +
                   " Titular:" + Titular +
                   " Saldo:" + Saldo.ToString("F2", CultureInfo.InvariantCulture); // Método para retornar uma string formatada com os detalhes da conta
        }
    }
}
