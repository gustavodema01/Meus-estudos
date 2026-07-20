using Heritage.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heritage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account(01, "Calleri", 0);
            BusinessAccount bsa = new BusinessAccount(10, "Luciano", 0, 1000.0);
            BusinessAccount bsa1 = new BusinessAccount(10, "Giovana", 0, 1000.0);
            SavingsAccount sva = new SavingsAccount(11, "Rafael", 0, 0);

            //UPCASTING
            Account ac1 = bsa; //superclasse pode ser sub classe(BusinessAccount)
            Account ac2 = sva; //superclasse pode ser sub classe(SavingsAccount)
            Account ac3 = bsa1;

            //DOWN CASTING 
            //bsa = new Account(02, "Gabriely", 0); (subclasse não pode ser superclasse)
            BusinessAccount bsa2 = (BusinessAccount)bsa; //converti
            BusinessAccount bsa3 = bsa1 as BusinessAccount; //outra maneira de converter
        }
    }
}
