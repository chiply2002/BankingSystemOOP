using System;
using System.Collections.Generic;
using System.Text;

namespace BankSystem
{
    class Debit : Account
    {
        public double _maxBalance = 1000000;
        private double _dailyWithdrawLimit = 20000;

        /// <summary>
        /// First constructor for the Debit account with the base from abstract class Account
        /// </summary>
        public Debit() : base()
        {
        }

        /// <summary>
        /// Second constructor for the Debit account with the base from abstract class Account
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        /// <param name="balance"></param>
        public Debit(string name, int age, double balance) : base(name, age, balance)
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
            if (amount > _maxBalance)
            {
                return false;
            }
            else
            {
                this.Balance += Amount;
                return true;
            }
        }

        /// <summary>
        /// Subtraction of balance and amount
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        public override bool withdraw(double amount)
        {
            this.Amount = amount;

            if (amount > _dailyWithdrawLimit)
            {
                return false;

            }
            else if (amount > _maxBalance)
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

