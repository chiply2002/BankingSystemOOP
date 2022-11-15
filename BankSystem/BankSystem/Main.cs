using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystem
{
    public partial class Main : Form
    {
        Bank bn = new Bank();
        IDGenerator Id = new IDGenerator();
        Credit cr = new Credit();
        Debit db = new Debit();
        Saving sv = new Saving();
        Payment p = new Payment();
        string id;
        int index = 0;
        

        public Main()
        {
            InitializeComponent();
            
        }

        private void Main_Load(object sender, EventArgs e)
        {
            loginTable.Hide();
            loginTable.Hide();
            infoTable.Hide();
            deposit.Hide();
            withdraw.Hide();
            registerAgain.Hide();
            login2.Hide();
            logout.Hide();
            login.Hide();
            contact2.Hide();
            aboutUs2.Hide();
            list.Hide();
            showAccounts.Hide();
            logout.Hide();
        }

        private void register_Click(object sender, EventArgs e)
        {
            double _balance;
            int _age;
            bn.CreateAccount(name.Text, accType.Text, password.Text);
            double.TryParse(amount.Text, out _balance);
            Int32.TryParse(age.Text, out _age);
            bn.MyName[index] = name.Text;
            bn.MyAge[index] = _age;
            bn.MyAccType[index] = accType.Text;
            bn.MyPassword[index] = password.Text;
            bn.MyBalance[index] = _balance;

            if (accType.Text == "Debit")
            {
                accType.Text = "Debit";

                id = Id.generate();
                id = id + "Deb";
                MessageBox.Show("Your Account Id : " + id);
                GetAcc(id);
            }

            if (accType.Text == "Credit")
            {
                accType.Text = "Credit";
                id = Id.generate();
                id = id + "Cre";
                MessageBox.Show("Your Account Id : " + id);
                GetAcc(id);
            }

            if (accType.Text == "Saving")
            {
                accType.Text = "Saving";
                id = Id.generate();
                id = id + "Sav";
                MessageBox.Show("Your Account Id : " + id);
                GetAcc(id);
            }
            name.Clear();
            age.Clear();
            password.Clear();
            amount.Clear();

            login2.Hide();
            registerAgain.Show();
            loginTable.Show();
            register.Hide();
            login.Show();
            infoTable.Hide();
            deposit.Hide();
            withdraw.Hide();
            list.Hide();
            showAccounts.Hide();
            exit.Show();
            contact.Hide();
            aboutUs.Hide();
            contact2.Show();
            aboutUs2.Show();
            registerTable.Hide();
        }


        private void login_Click(object sender, EventArgs e)
        {
            int indexN;

            if (bn.MyId.Contains(logID.Text) && bn.MyPassword.Contains(myPass.Text))
            {
                indexN = Array.IndexOf(bn.MyId, logID.Text);

                myId.Text = bn.MyId[indexN];
                myName.Text = bn.MyName[indexN];
                myAge.Text = bn.MyAge[indexN].ToString();
                myAccType.Text = bn.MyAccType[indexN];
                myAmount.Text = bn.MyBalance[indexN].ToString();

                logout.Show();
                infoTable.Show();
                deposit.Show();
                withdraw.Show();
                registerAgain.Show();
                login.Hide();
                loginTable.Hide();
                showAccounts.Show();
                contact2.Hide();
                aboutUs2.Hide();
            }

            else
            {
                MessageBox.Show("Wrong ID or Password");
            }
        }

        private void deposit_Click(object sender, EventArgs e)
        {
            int indexN;
            p.ShowDialog();
            indexN = Array.IndexOf(bn.MyId, logID.Text);
            if (bn.MyAccType[indexN] == "Debit")
            {
                db.Balance = bn.MyBalance[indexN];
                db.deposit(p.Money);
                bn.MyBalance[indexN] = db.Balance;
            }
            else if (bn.MyAccType[indexN] == "Credit")
            {
                cr.Balance = bn.MyBalance[indexN];
                cr.deposit(p.Money);
                bn.MyBalance[indexN] = cr.Balance;
            }
            else if (bn.MyAccType[indexN] == "Saving")
            {
                sv.Balance = bn.MyBalance[indexN];
                sv.deposit(p.Money);
                bn.MyBalance[indexN] = sv.Balance;
            }
            myAmount.Text = bn.MyBalance[indexN].ToString();
            contact.Hide();
            aboutUs.Hide();
        }

        private void withdraw_Click(object sender, EventArgs e)
        {
            p.ShowDialog();
            int indexN;
            indexN = Array.IndexOf(bn.MyId, logID.Text);
            if (bn.MyAccType[indexN] == "Debit")
            {
                db.Balance = bn.MyBalance[indexN];
                db.withdraw(p.Money);
                bn.MyBalance[indexN] = db.Balance;
            }
            else if (bn.MyAccType[indexN] == "Credit")
            {
                cr.Balance = bn.MyBalance[indexN];
                cr.withdraw(p.Money);
                bn.MyBalance[indexN] = cr.Balance;
            }
            else if (bn.MyAccType[indexN] == "Saving")
            {
                sv.Balance = bn.MyBalance[indexN];
                sv.withdraw(p.Money);
                bn.MyBalance[indexN] = sv.Balance;
            }
            myAmount.Text = bn.MyBalance[indexN].ToString();
            contact.Hide();
            aboutUs.Hide();
        }

        private void showAccounts_Click(object sender, EventArgs e)
        {
            list.Show();
            list.Items.Clear();
            for (int i = 0; i < index; i++)
            {
                list.Items.Add(bn.MyId[i]);
            }
            contact.Hide();
            aboutUs.Hide();
        }

        private void registerAgain_Click(object sender, EventArgs e)
        {
            login2.Show();
            loginTable.Hide();
            infoTable.Hide();
            deposit.Hide();
            withdraw.Hide();
            list.Hide();
            showAccounts.Hide();
            registerAgain.Hide();
            registerTable.Show();
            register.Show();
            infoTable.Hide();
            contact2.Show();
            aboutUs2.Show();
            logout.Hide();
        }

        private void login2_Click(object sender, EventArgs e)
        {
            registerTable.Hide();
            loginTable.Show();
            login.Show();
            login2.Hide();
            register.Hide();
            registerAgain.Show();
            contact.Hide();
            aboutUs.Hide();
            contact2.Show();
            aboutUs2.Show();
        }

        private void contact_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new Contact()).ShowDialog();
            this.Show();
        }

        private void aboutUs_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new AboutUs()).ShowDialog();
            this.Show();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            registerTable.Hide();
            loginTable.Show();
            login.Show();
            contact.Hide();
            aboutUs.Hide();
            login2.Hide();
            logout.Hide();
            deposit.Hide();
            withdraw.Hide();
            list.Hide();
            showAccounts.Hide();
            infoTable.Hide();
            register.Hide();
            registerAgain.Show();
            contact2.Show();
            aboutUs2.Show();
        }

        private void contact2_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new Contact()).ShowDialog();
            this.Show();
        }

        private void aboutUs2_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new AboutUs()).ShowDialog();
            this.Show();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Get the account ID
        /// </summary>
        /// <param name="ID"></param>
        public void GetAcc(string ID)
        {
            ID = this.id;
            bn.MyId[index] = ID;
            index++;
        }
    }
}
