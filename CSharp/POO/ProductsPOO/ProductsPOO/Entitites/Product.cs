using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ProductsPOO.Entitites
{
    internal class Product
    {
        public string Name { get; private set; }
        public double Price { get;  set; }

        public Product(string name, double price) //construtor para obrigar a variável a ser iniciada
        {
            Name = name;
            Price = price;
        }
        public virtual string PriceTag()
        {
            return Name + " $ " + Price.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
