using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heritage.Entities
{
    internal class Account
    {
        public int Number { get; private set; }
        public string Holder { get; private set; }
        public double Balance { get; protected set; } //pode ser obtido e alterado pela própria classe e subclasses

        public Account() //para ter a opção de criar o objeto sem passar os dados.
        {
        }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public virtual void WithDraw(double amount) //virtual quer dizer que esse método pode ser sobrescrito em outras subclasses
        {
            Balance -= amount + 5.0;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }
    }
}
