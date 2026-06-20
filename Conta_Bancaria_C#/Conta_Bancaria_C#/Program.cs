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
            int _numeroConta = 0;
            string _titular;
            bool validacao = false;

            Console.Write("Entre o número da conta: ");
            while (!validacao) //validação no program.cs pois, é uma interação com o usuário(console.readline)
            {
                _numeroConta = int.Parse(Console.ReadLine());
                if (_numeroConta < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Número de conta inválido, tente novamente: ");
                    Console.ResetColor();
                    validacao = false;
                }
                else
                {
                    validacao = true;
                }
            }  //falta a validação de letras
            Console.Write("Entre o titular da conta: ");
            _titular = Console.ReadLine();

            Conta C = new Conta(_numeroConta, _titular, _valor);
            Console.Write("Haverá depósito inicial?(s/n): ");

            validacao = false;
            while (!validacao)
            {
                char opcao = char.ToUpper(Convert.ToChar(Console.ReadLine()));
                if (opcao != 's' && opcao != 'n')
                {
                    Console.Clear();
                    Console.WriteLine("Entre o número da conta: "+_numeroConta);
                    Console.WriteLine("Entre o titular da conta: "+_titular);
                    Console.WriteLine("Haverá depósito inicial?(s/n): ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Escolha uma opção válida(s/n): ");
                    Console.ResetColor();
                    validacao = false;
                }
                else
                {
                    if (opcao == 'S' || opcao == 's')
                    {
                        Console.Write("Entre o valor de depósito inicial: ");
                        _valor = double.Parse(Console.ReadLine()); //saldo inicial
                        C.Deposito(_valor);
                        C = new Conta(_numeroConta, _titular, _valor);
                        Console.WriteLine(C);
                    }
                    else
                    {
                        C = new Conta(_numeroConta, _titular);
                        Console.WriteLine(C);
                    }
                }
            }        //falta validação só de char

            Console.WriteLine("\nEntre o valor para depósito: ");
            validacao = false;
            while (!validacao)
            {
                _valor = double.Parse(Console.ReadLine());
                if (_valor < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Valor inválido, tente novamente: ");
                    Console.ResetColor();
                    validacao = false;
                }
                else
                {
                    validacao = true;
                }
            } //falta validação só de números

            C.Deposito(_valor);

            Console.Write("Dados atualizados: " + C);

            Console.Write("\nEntre o valor para saque: ");
            validacao = false;
            while (!validacao)
            {
                _valor = double.Parse(Console.ReadLine());
                if (_valor < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Valor inválido, tente novamente: ");
                    Console.ResetColor();
                    validacao = false;
                }
                else
                {
                    validacao = true;
                }
            } //falta validação só de double

            C.Saque(_valor);
            Console.WriteLine("Dados atualizados: " + C);
        }
    }
}


