using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingSystem
{
    public partial class User_Home_page : Form
    {
        public User_Home_page()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Customer_Profile customer = new Customer_Profile();
            customer.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Withdrawal_Page withdrawal = new Withdrawal_Page();
            withdrawal.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Deposit_page deposit = new Deposit_page();
            deposit.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Transaction_Details details = new Transaction_Details();
            details.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Home_Page page = new Home_Page();
            page.Show();
            this.Hide();
        }
    }
}

}
