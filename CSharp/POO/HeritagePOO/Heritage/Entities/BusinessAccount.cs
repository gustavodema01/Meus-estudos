using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heritage.Entities
{
    internal class BusinessAccount : Account //BussinessAcount vai herdar Account
    {
        public double LoanLimit { get; set; }

        public BusinessAccount()
        {
        }

        public BusinessAccount(int number, string holder, int balance, double loanLimit) : base(number, holder, balance) //herdei a Super Classe
        {
            LoanLimit = loanLimit;
        }
        public void Limit(double amount)
        {
            if (amount < LoanLimit)
            {
                Balance += amount;
            }
        }
        public void Loan(double amount)
        {
            if(amount<= LoanLimit)
            {   
                Balance += amount;
            }
        }
    }
}
