using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_em_POO___C_.Entities
{
    internal class HourContract
    {
        public DateTime date { get; private set; }
        public double valuePerHour { get; private set; }
        public int hours { get; private set; }

        public HourContract(DateTime _date, double _valuePerHour, int _hours)
        {
            date = _date;
            valuePerHour = _valuePerHour;
            hours = _hours;
        }

        public double totalValue()
        {
            return valuePerHour * hours;
        }
    }
}
