using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingSystem1
{
    public partial class UserHomepage : Form
    {
        public UserHomepage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CustomerProfile customer = new CustomerProfile();
            customer.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Withdrawal withdrawal = new Withdrawal();
            withdrawal.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Deposit deposit = new Deposit();
            deposit.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TransactionDetails details = new TransactionDetails();
            details.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            HomePage page = new HomePage();
            page.Show();
            this.Hide();
        }
    }
}
