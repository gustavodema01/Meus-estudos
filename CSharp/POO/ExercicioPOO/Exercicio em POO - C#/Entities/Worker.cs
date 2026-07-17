using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercicio_em_POO___C_.Entities.Enums;

namespace Exercicio_em_POO___C_.Entities
{
    internal class Worker
    {
        public string Name { get; private set; }
        public WorkerLevel Worklevel { get; set; }
        public double BaseSalary { get; private set; }
        public Department Department_ { get; set; } 
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();
        public Worker(string _name, WorkerLevel _workerlevel, double _baseSalary, Department dept) //construtor para obrigar a incialização das variáveis
        {
            Name = _name;
            Worklevel = _workerlevel;
            BaseSalary = _baseSalary;
            Department_ = dept;
        }

        public void addContract(HourContract contract)
        {
            Contracts.Add(contract);//adiciono na lista
        }

        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);//adiciono da lista
        }
        public double income(int year, int month)
        {
            double sum = 0;
            foreach(HourContract contract in Contracts)
            {
                if(contract.date.Year == year && contract.date.Month == month)
                {
                    sum += contract.totalValue();
;                }
            }
            return sum;
        }
    }
}
