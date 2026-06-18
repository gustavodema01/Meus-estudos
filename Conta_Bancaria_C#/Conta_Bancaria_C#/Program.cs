using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conta_Bancaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double _valor = 0.0;
            int _numeroConta;
            string _titular;

            Console.Write("Entre o número da conta: ");
            _numeroConta = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            _titular = Console.ReadLine();

            Conta C = new Conta(_numeroConta, _titular, _valor);

            Console.Write("Haverá depósito inicial?(s/n): ");
            char opcao = Convert.ToChar(Console.ReadLine());
            if (opcao == 'S' || opcao == 's')
            {
                Console.Write("Entre o valor de depósito inicial: ");
                _valor = double.Parse(Console.ReadLine()); //saldo inicial
                C.Deposito(_valor);
                C = new Conta(_numeroConta, _titular, _valor);
            }
            else
            {
                C = new Conta(_numeroConta, _titular);
            }
            Console.WriteLine(C);

            Console.WriteLine("\nEntre o valor para depósito: ");
            _valor = double.Parse(Console.ReadLine());
            C.Deposito(_valor);

            Console.Write("Dados atualizados: " + C);

            Console.Write("\nEntre o valor para saque: ");
            _valor = double.Parse(Console.ReadLine());
            C.Saque(_valor);
            Console.WriteLine("Dados atualizados: " + C);
        }
    }
}


