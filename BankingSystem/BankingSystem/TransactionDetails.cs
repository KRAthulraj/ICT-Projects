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
    public partial class TransactionDetails : Form
    {
        public TransactionDetails()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {




        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int userid = Convert.ToInt32(textBox1.Text);


            string ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BankingSystemDB;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    connection.Open();

                    var query = "select * from Tbl_Trasaction where UserId = @userid";

                    using (SqlCommand command1 = new SqlCommand(query, connection))
                    {

                        command1.Parameters.AddWithValue("@userid", userid);
                        using (SqlDataReader reader = command1.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(reader);

                            dataGridView1.DataSource = dt;
                        }

                        int row = command1.ExecuteNonQuery();
                        if (row > 0)
                        {
                            MessageBox.Show("Success");

                        }
                        else
                        {
                            MessageBox.Show("Not Found");

                        }

                    }



                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error :" + ex.Message);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
