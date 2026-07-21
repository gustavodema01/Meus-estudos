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
            Account account = new Account(01, "Calleri", 0); //superclasse
            SavingsAccount sva = new SavingsAccount(11, "Rafael", 0, 0); //subclasse

            //UPCASTING  
            Account ac1 = sva;
            Account ac2 = new BusinessAccount(10, "Luciano", 0, 1000.0);
            Account ac3 = new BusinessAccount(10, "Giovana", 0, 1000.0);

            //DOWN CASTING - superclasse com um objeto subclasse de volta pra subclasse
            //bsa = new Account(02, "Gabriely", 0); subclassee(BusinessAccount) não pode ser superclasse
            BusinessAccount bsa2 = (BusinessAccount)ac2; //converti
            BusinessAccount bsa3 = ac2 as BusinessAccount; //outra maneira de converter
        }
    }
}
