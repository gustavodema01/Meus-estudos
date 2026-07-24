using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContribuintesPOO.Entities
{
    internal class PessoaFisica : Contribuinte
    {
        public double GastoSaude { get; private set; }

        public PessoaFisica(string name, double rendaanual, double gastosaude) : base(name, rendaanual) //construtor que obriga as variáveis serem iniciadas
        {
            GastoSaude = gastosaude;
        }

        public override double Imposto()
        {
            double imposto = 0.0;
            if (RendaAnual < 20000.0)
            {
                imposto = RendaAnual * 0.15 - GastoSaude * 0.50;
            }
            else
            {
                imposto = RendaAnual * 0.25 - GastoSaude * 0.50;
            }
            return imposto;
        }


    }
}
