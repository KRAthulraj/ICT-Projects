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
    public partial class AddAccount : Form
    {
        public DataTable DataView { get; private set; }

        public AddAccount()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string email = textBox2.Text;
            string password = textBox3.Text;
            decimal balance = Convert.ToDecimal(textBox4.Text);

            string ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BankingSystemDB;Integrated Security=True";


            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                string Query = "insert into Tbl_User (UserName,Email,Password,Balance) values (@Name,@Email,@Password,@Balance)";
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(Query, connection))
                    {
                        command.Parameters.AddWithValue("@Name", name);
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@Password", password);
                        command.Parameters.AddWithValue("@Balance", balance);

                        int row = command.ExecuteNonQuery();

                        if (row > 0)
                        {
                            MessageBox.Show("Registed succesfully");
                            //FetchDetails();
                        }
                        else
                        {
                            MessageBox.Show("Some error. Please try again");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error :" + ex.Message);
                }
            }

        }

        //private void FetchDetails()
        //{
        //    string ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BankingSystemDB;Integrated Security=True";
        //    using (SqlConnection connection = new SqlConnection(ConnectionString))
        //    {
        //        string Query = "select * from Tbl_User";

        //        try
        //        {
        //            connection.Open();
        //            using (SqlCommand command = new SqlCommand(Query, connection))
        //            {
        //                using (SqlDataReader reader = command.ExecuteReader())
        //                {
        //                    DataTable dataTable = new DataTable();
        //                    dataTable.Load(reader);
        //                    DataView = dataTable;
        //                }
        //            }

        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show("Error : " + ex.Message);
        //        }
        //    }
        //}

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    string ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BankingSystemDB;Integrated Security=True";
        //    using (SqlConnection connection = new SqlConnection(ConnectionString))
        //    {
        //        string Query = "select * from Tbl_User";

        //        try
        //        {
        //            connection.Open();
        //            using (SqlCommand command = new SqlCommand(Query, connection))
        //            {
        //                using (SqlDataReader reader = command.ExecuteReader())
        //                {
        //                    DataTable dataTable = new DataTable();
        //                    dataTable.Load(reader);
        //                    DataView = dataTable;
        //                }
        //            }

        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show("Error : " + ex.Message);
        //        }
        //    }
        //}
    }
}
