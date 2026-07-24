using ContribuintesPOO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ContribuintesPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Contribuinte> list = new List<Contribuinte>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Tax payer #{i + 1} data: ");
                Console.Write("Individual or company (i/c)? ");
                char opcao = char.Parse(Console.ReadLine());
                if (opcao == 'i')
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();

                    Console.Write("Anual income: ");
                    double rendaanual = double.Parse(Console.ReadLine());

                    Console.Write("Health expeditures: ");
                    double gastosaude = double.Parse(Console.ReadLine());
                    list.Add(new PessoaFisica(name, rendaanual, gastosaude));
                }
                else if (opcao == 'c') {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();

                    Console.Write("Anual income: ");
                    double rendaanual = double.Parse(Console.ReadLine());

                    Console.Write("Number of employees: ");
                    int nmrfuncionarios = int.Parse(Console.ReadLine());
                    list.Add(new PessoaJuridica(name, rendaanual, nmrfuncionarios));
                }

            }
            double soma = 0;
            Console.WriteLine("\nTAXES PAID: ");
            foreach(Contribuinte contribuinte in list)
            {
                double impost = contribuinte.Imposto();
                soma += contribuinte.Imposto();
                Console.WriteLine(contribuinte.Name + " : $" + impost.ToString("F2", CultureInfo.InvariantCulture));
            }
            Console.Write("\nTOTAL TAXES: ");
            Console.WriteLine(soma.ToString("F2", CultureInfo.InvariantCulture));
            
        }
    }
}
