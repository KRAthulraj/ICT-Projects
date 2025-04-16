//using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
namespace BankingSystem1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            string ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BankingSystemDB;Integrated Security=True";

            
            //var name = "@username";
            //var pass = "@password";
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                string Query = "select * from Tbl_Admin where UserName = @UserName and Password = @Password";
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(Query, connection))

                    {
                        command.Parameters.AddWithValue("@UserName", username);
                        command.Parameters.AddWithValue("@Password", password);
                        int rowaffected = command.ExecuteNonQuery();
                        if (Query != null)
                        {
                            MessageBox.Show("Admin login successfully");
                            Form2 form2 = new Form2();
                            form2.Show();
                            this.Hide();
                        }
                        else
                        
                        {
                            MessageBox.Show("Incorrect login.Please try again");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred :" + ex.Message);

                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            string ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BankingSystemDB;Integrated Security=True";


            //var name = "@username";
            //var pass = "@password";
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                string Query = "select * from Tbl_User where UserName = @UserName and Password = @Password";
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(Query, connection))

                    {
                        command.Parameters.AddWithValue("@UserName", username);
                        command.Parameters.AddWithValue("@Password", password);
                        int rowaffected = command.ExecuteNonQuery();
                        if (Query != null)
                        {
                            MessageBox.Show("User login successfully");
                            UserHomepage userHomepage = new UserHomepage();
                            userHomepage.Show();
                            this.Hide();

                        }
                        else

                        {
                            MessageBox.Show("Incorrect login.Please try again");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred :" + ex.Message);

                }

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
