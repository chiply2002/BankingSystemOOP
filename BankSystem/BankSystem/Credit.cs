using System;
using System.Collections.Generic;
using System.Text;

namespace BankSystem
{
    class Credit : Account
    {
        public double _minBalance = -100000;
        private double _dailyWithdrawLimit = 20000;

        /// <summary>
        /// First constructor for the Credit account with the base from abstract class Account
        /// </summary>
        public Credit() : base()
        {
        }

        /// <summary>
        /// Second constructor for the Credit account with the base from abstract class Account
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        /// <param name="balance"></param>
        public Credit(string name, int age, double balance) : base(name, age, balance)
        {
        }

        /// <summary>
        /// Addition of balance and amount
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        public override bool deposit(double amount)
        {
            this.Amount = amount;
            this.Balance += Amount;
            return true;
        }

        /// <summary>
        /// Subtraction of balance and amount
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        public override bool withdraw(double amount)
        {
            this.Amount = amount;
            if (amount < _minBalance)
            {
                return false;
            }
            else if (amount > _dailyWithdrawLimit)
            {
                return false;
            }
            else
            {
                this.Balance -= Amount;
                return true;
            }
        }
    }
}

