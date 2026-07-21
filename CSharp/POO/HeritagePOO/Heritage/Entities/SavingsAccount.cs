using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heritage.Entities
{
    internal class SavingsAccount : Account
    {
        public double interestRate { get; set; }

        public SavingsAccount()
        {
        }
        public SavingsAccount(int number, string holder, double balance, double interestrate) : base(number, holder, balance)
        {
            interestRate = interestrate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * interestRate;
        }

        public override void WithDraw(double amount) //sobreposição do método da superclasse
        {
            Balance -= amount;
        }
    }
}
