using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tumakov12Classwork
{
    class BankAccount
    {
        private int id;
        private decimal balance;
        public BankAccount(int id, decimal balance)
        {
            this.id = id;
            this.balance = balance;
        }

        public int GetId()
        {
            return id;
        }

        public decimal GetBalance()
        {
            return balance;
        }
        public static bool operator +(object a, object b)
        {
            if (a.GetType() is int && b.GetType() is int)
            {
                return a and b;
            }
        }


    }
}