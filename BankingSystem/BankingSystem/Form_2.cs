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
    public partial class Form_2 : Form
    {
        public Form_2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add_Account addaccount = new Add_Account();
            addaccount.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Edit_Account editAccount = new Edit_Account();
            editAccount.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Delete_Account deleteAccount = new Delete_Account();
            deleteAccount.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Home_Page homepage = new Home_Page();
            homepage.Show();
            this.Hide();
        }
    }

}
