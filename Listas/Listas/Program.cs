using System;
using System.Collections.Generic;

namespace Listas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int id = 0;
            string name = "";
            double salario = 0.0;

            Console.Write("How many employees will be registered?");
            int n = int.Parse(Console.ReadLine());

            List<Funcionario> list = new List<Funcionario>(); //lista que só aceita instaciações de Funcionario
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Emplyoee #" + (i + 1));
                Console.Write("ID: ");
                id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                name = Console.ReadLine();
                Console.Write("Salary: ");
                salario = int.Parse(Console.ReadLine());
                Funcionario funcionario = new Funcionario(id, name, salario); //instanciação de um objeto do tipo Funcionario
                list.Add(funcionario); //adiciona o objeto funcionario na lista,
            }

            Console.WriteLine("\nUpdated list of employees: ");
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
                Console.WriteLine("");  
            }
            bool validacao = false;
            Funcionario funcionarioencontrado = null;
            while (!validacao)
            {
                Console.Write("Enter the employee id that will have salary increase :");
                int idapoio = int.Parse(Console.ReadLine());
                for(int i = 0; i < list.Count; i++) 
                {
                    if (idapoio == list[i].ID)
                    {
                        funcionarioencontrado = list[i]; // guarda a referência
                        validacao = true; 
                        break;
                    }
                    else
                    {
                        Console.Write("This id does not exist!");
                        validacao = false; //sai do while
                        break;
                    }
                }
            }
            
            Console.Write("Enter the percentage:");
            double porcentagem = double.Parse(Console.ReadLine());

            funcionarioencontrado.AumentarSalario(porcentagem);

            Console.WriteLine("\nUpdated list of employees: ");
            foreach(Funcionario obj in list) //foreach no lugar do for para percorrer a lista de funcionários
            {
                Console.WriteLine(obj);
            }
        }

    }
}


