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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddAccount addaccount = new AddAccount();
            addaccount.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            EditAccount editAccount = new EditAccount();
            editAccount.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DeleteAccount deleteAccount = new DeleteAccount();
            deleteAccount.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           HomePage homepage = new HomePage();
            homepage.Show();
            this.Hide();
        }
    }
}
