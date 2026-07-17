using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order_Itens_in_POO___C_.Order
{
    internal class OrderItem
    {
        public int Quantity { get; private set; }
        public double Price { get; private set; }

        public double SubTotal(int quantity, double price)
        {
            Quantity = quantity;
            Price = price;
            return Quantity * Price;
        }
    }
}
