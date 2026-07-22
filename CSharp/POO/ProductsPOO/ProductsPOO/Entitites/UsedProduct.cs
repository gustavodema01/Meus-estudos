using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsPOO.Entitites
{
    internal class UsedProduct : Product
    {
        public DateTime manufactureDate { get; private set; }

        public UsedProduct(string name, double price, DateTime manufacturedate) : base(name, price)  //construtor com herança da superclasse
        {
            manufactureDate = manufacturedate;
        }

        public override string PriceTag() //sobreposição da superclasse
        {
            return base.PriceTag() + " (Manufacture date: " + manufactureDate.ToString("dd/MM/yyyy") + ")";
        }
    }
}
