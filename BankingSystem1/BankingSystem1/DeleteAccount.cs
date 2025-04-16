using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BankingSystem1
{
    public partial class DeleteAccount : Form
    {
        public DeleteAccount()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userid = textBox1.Text;
            

            string ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BankingSystemDB;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                string Query = "delete from Tbl_User where UserId = @User";
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(Query, connection))
                    {
                        command.Parameters.AddWithValue("@User", userid);
                       

                        int row = command.ExecuteNonQuery();

                        if (row > 0)
                        {
                            MessageBox.Show("Account deleted successfully");
                            //FetchDetails();
                        }
                        else
                        {
                            MessageBox.Show("There is no account");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error :" + ex.Message);
                }
            }
        }
    }
}
