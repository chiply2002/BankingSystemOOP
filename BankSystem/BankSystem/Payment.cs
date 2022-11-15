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
    public partial class Payment : Form
    {
        private double _money;
        public Payment()
        {
            InitializeComponent();
        }

        public double Money { get => _money; set => _money = value; }

        private void confirm_Click(object sender, EventArgs e)
        {
            if (double.TryParse(money.Text, out _money))
            {
                this.Hide();
                money.Clear();
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            _money = 0;
            this.Close();
        }
    }
}
