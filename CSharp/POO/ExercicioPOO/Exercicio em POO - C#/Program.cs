using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercicio_em_POO___C_.Entities;
using Exercicio_em_POO___C_.Entities.Enums;

namespace Exercicio_em_POO___C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter department's name: ");
            string department_ = Console.ReadLine();
            Department depto = new Department(department_);

            Console.WriteLine("\nEnter worker data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Level(Junior/MidLevel/Senior: ");
            string level = Console.ReadLine();
            WorkerLevel worklevel_ = (WorkerLevel)Enum.Parse(typeof(WorkerLevel), level);

            Console.Write("Base salary:");
            double salary = int.Parse(Console.ReadLine());
            Worker worker = new Worker(name, worklevel_, salary, depto);

            Console.Write("How many contracts to this worker?: ");
            int qtd = int.Parse(Console.ReadLine());

            for(int i = 0; i< qtd; i++)
            {
                Console.WriteLine($"Enter #{i+1} contract data: ");
                Console.Write("Date: ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valueperhour = double.Parse(Console.ReadLine());
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                HourContract HourContract_ = new HourContract(date, valueperhour, hours);
                worker.addContract(HourContract_);
            }
            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string yearAndMonth = Console.ReadLine();
            int month = int.Parse(yearAndMonth.Substring(0, 2)); //month = 2 primeiros indices de yearAndMonth
            int year = int.Parse(yearAndMonth.Substring(3)); //year = indices 3 pra frente de yearandMonth
            Console.WriteLine("Name:" + worker.Name);
            Console.WriteLine("Deparment: " + depto.name);
            Console.WriteLine("Income for: "+ worker.income(year, month) );
        }
    }
}
