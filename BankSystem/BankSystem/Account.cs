using System;
using System.Collections.Generic;
using System.Text;

namespace BankSystem
{
    abstract class Account
    {
        private string _name;
        private int _age;
        private double _balance;
        private double _amount;

        /// <summary>
        /// First constructor of Account class, other classes will inherit from this
        /// </summary>
        public Account()
        {
        }

        /// <summary>
        /// Second constructor of Account class, other classes will inherit from this
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        /// <param name="balance"></param>
        protected Account(string name, int age, double balance)
        {
            _name = name;
            _age = age;
            _balance = balance;
        }

        /// <summary>
        /// Get the value of _name
        /// </summary>
        public string Name { get => _name; }
        /// <summary>
        /// Get the value of _age
        /// </summary>
        public int Age { get => _age; }
        /// <summary>
        /// get and set the value of _balance
        /// </summary>
        public double Balance { get => _balance; set => _balance = value; }
        /// <summary>
        /// get and set the value of _amount
        /// </summary>
        public double Amount { get => _amount; set => _amount = value; }

        /// <summary>
        /// Insert abstract class for deposit function, which will be overrided in other classes
        /// </summary>
        /// <param name="amount"></param>
        public abstract bool deposit(double amount);

        /// <summary>
        /// Insert abstract class for withdraw function, which will be overrided in other classes
        /// </summary>
        /// <param name="amount"></param>
        public abstract bool withdraw(double amount);

        /// <summary>
        /// Get the value of _balance
        /// </summary>
        /// <returns>the value of _balance</returns>
        public double getBalance()
        {
            return _balance;
        }
    }
}

