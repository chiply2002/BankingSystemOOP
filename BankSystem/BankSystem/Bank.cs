using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankSystem
{
    class Bank
    {
        public int idnum = 0;

        private string[] _myId;
        private string[] _myName;
        private string[] _myAccType;
        private int[] _myAge;
        private string[] _myPassword;
        private double[] _myBalance;

        Credit _cr = new Credit();
        Debit _db = new Debit();
        Saving _sv = new Saving();

        public bool val = true;
        public bool debval = true;

        /// <summary>
        /// Get and set value for _myId, _myName, _myAccType, _myAge, _myPassword, _myBalance
        /// </summary>
        public string[] MyId { get => _myId; set => _myId = value; }
        public string[] MyName { get => _myName; set => _myName = value; }
        public string[] MyAccType { get => _myAccType; set => _myAccType = value; }
        public int[] MyAge { get => _myAge; set => _myAge = value; }
        public string[] MyPassword { get => _myPassword; set => _myPassword = value; }
        public double[] MyBalance { get => _myBalance; set => _myBalance = value; }

        /// <summary>
        /// Constructor of class Bank
        /// </summary>
        public Bank()
        {
            MyId = new string[100];
            MyName = new string[100];
            MyAccType = new string[100];
            MyAge = new int[100];
            MyPassword = new string[100];
            MyBalance = new double[100];
        }

        /// <summary>
        /// Create Account for the ID in the idnum index
        /// </summary>
        /// <param name="name"></param>
        /// <param name="accType"></param>
        /// <param name="password"></param>
        public void CreateAccount(string name, string accType, string password)
        {
            string input;
            double balance;
            object ob1 = Console.ReadLine();
            input = Convert.ToString(ob1);

            if (input == "Debit")
            {
                accType = "Debit";
                MyAccType[idnum] = accType;

                name = Convert.ToString(Console.ReadLine());
                MyName[idnum] = name;

                password = Convert.ToString(Console.ReadLine());
                MyPassword[idnum] = password;
                while (debval == true)
                {
                    balance = Convert.ToDouble(Console.ReadLine());
                    if (balance > _db._maxBalance)
                    {
                        debval = true;
                    }
                    else
                    {
                        MyBalance[idnum] = balance;
                        debval = false;
                    }
                }
                debval = true;

            }
            else if (input == "Credit")
            {
                accType = "Credit";
                MyAccType[idnum] = accType;

                name = Convert.ToString(Console.ReadLine());
                MyName[idnum] = name;

                password = Convert.ToString(Console.ReadLine());
                MyPassword[idnum] = password;

                while (debval == true)
                {
                    balance = Convert.ToDouble(Console.ReadLine());
                    if (balance < _cr._minBalance)
                    {
                        debval = true;
                    }
                    else
                    {
                        MyBalance[idnum] = balance;
                        debval = false;
                    }
                }
                debval = true;

            }
            else if (input == "Saving")
            {
                accType = "Saving";
                MyAccType[idnum] = accType;

                name = Convert.ToString(Console.ReadLine());
                MyName[idnum] = name;

                val = true;
                password = Convert.ToString(Console.ReadLine());
                MyPassword[idnum] = password;

                balance = Convert.ToDouble(Console.ReadLine());
                MyBalance[idnum] = balance;

            }
        }
    }
}

