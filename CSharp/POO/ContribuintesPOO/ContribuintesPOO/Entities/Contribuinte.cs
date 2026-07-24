using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContribuintesPOO.Entities
{
    abstract class Contribuinte
    {
        public string Name { get; private set; }
        public double RendaAnual { get; private set; }

        public Contribuinte()
        {
        }
        public Contribuinte(string name, double rendaanual)
        {
            Name = name;
            RendaAnual = rendaanual;
        }

        public abstract double Imposto();

    }
}
