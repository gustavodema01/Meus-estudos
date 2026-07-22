using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductsPOO.Entitites;
using System.Globalization;

namespace ProductsPOO.Entitites
{
    internal class ImportedProduct : Product
    {
        public double customsFee { get; private set; }

        public ImportedProduct(string name, double price, double customsfeee) : base(name, price) //construtor com herança da superclasse
        {
            customsFee = customsfeee;
        }

        public override string PriceTag()
        {
            return base.PriceTag() + " (Customs fee: $ " + customsFee.ToString("F2") + ")"; //sobreposição da superclasse
        }

        public double totalPrice()
        {
            return Price + customsFee;
        }
    }
}
