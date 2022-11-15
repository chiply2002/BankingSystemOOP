using System;
using System.Collections.Generic;
using System.Text;

namespace BankSystem
{
    class Saving:Account
    {
        /// <summary>
        /// First constructor for the Saving account with the base from abstract class Account
        /// </summary>
        public Saving() : base()
        {
        }

        /// <summary>
        /// Second constructor for the Saving account with the base from abstract class Account
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        /// <param name="balance"></param>
        public Saving(string name, int age, double balance) : base(name, age, balance)
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
            this.Balance -= Amount;
            return true;
        }
    }
}

