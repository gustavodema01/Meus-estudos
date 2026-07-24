using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContribuintesPOO.Entities
{
    internal class PessoaJuridica : Contribuinte
    {
        public int NmrFuncionarios { get; private set; }

        public PessoaJuridica(string name, double rendaanual, int nmrfuncionarios) : base(name, rendaanual)
        {
            NmrFuncionarios = nmrfuncionarios;
        }
        public override double Imposto()
        {
            double imposto = 0.0;
            if(NmrFuncionarios> 10)
            {
                imposto = RendaAnual * 0.14;
            }
            else
            {
                imposto = RendaAnual * 0.16;
            }
            return imposto;
        }
    }
}
