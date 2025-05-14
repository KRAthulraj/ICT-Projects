using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace BankingSystem1
{
    public partial class EditAccount : Form
    {
        public EditAccount()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userid = textBox1.Text;
            string password = textBox2.Text;
            string email = textBox3.Text;

            string ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BankingSystemDB;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                string Query = "update Tbl_User set Password = @Password,Email = @Email where UserId = @User ";
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(Query, connection))
                    {
                        command.Parameters.AddWithValue("@User", userid);
                        command.Parameters.AddWithValue("@Password", password);
                        command.Parameters.AddWithValue("@Email", email);
                        
                        int row = command.ExecuteNonQuery();

                        if (row > 0)
                        {
                            MessageBox.Show("Updated successfully");
                            //FetchDetails();
                        }
                        else
                        {
                            MessageBox.Show("There is no such a account Please try again");
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
