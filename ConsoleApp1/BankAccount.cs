using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class BankAccount
    {
        private double balance = 0;

        public double Deposit(double amount)
        {
            balance += amount;
            return balance;
        }

        public double GetBalance(double amount)
        {
            balance = amount;
            return balance;
        }
        
    }
}
