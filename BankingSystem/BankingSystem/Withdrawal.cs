using Microsoft.Data.SqlClient;
using System;
using System.Collections;
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
    public partial class Withdrawal : Form
    {
        public Withdrawal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int userid = Convert.ToInt32(textBox1.Text);
            decimal amount = Convert.ToDecimal(textBox2.Text);

            string ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BankingSystemDB;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    connection.Open();
                    var Query1 = "select Balance from Tbl_User where UserId = @userid";
                   // using (SqlCommand command = new SqlCommand(Query1, connection))
                   // {
                       // command.Parameters.AddWithValue("@userid", userid);
                        //command.Parameters.AddWithValue("")
                        //if (Query1 < amount)
                        //{
                        //    MessageBox.Show("No available balance");

                        //}
                        //else
                        //{
                            var update = "update Tbl_User set Balance = Balance - @Amount where UserId = @Userid";

                            using (SqlCommand command1 = new SqlCommand(update, connection))
                            {
                                command1.Parameters.AddWithValue("@Amount",amount);
                                command1.Parameters.AddWithValue("@Userid",userid);

                                int row = command1.ExecuteNonQuery();
                                if(row > 0)
                                {
                                    MessageBox.Show("Success");
                                    var insert = "Insert into Tbl_Transaction(UserId,Amount,TransDate,Type) values(@userid,@amount,@date,@type)";
                                    using (SqlCommand command2 = new SqlCommand(insert, connection))
                                    {
                                        command2.Parameters.AddWithValue("@userid", userid);
                                        command2.Parameters.AddWithValue("@amount", amount);
                                        command2.Parameters.AddWithValue("@date", DateTime.Now);
                                        command2.Parameters.AddWithValue("@type", "C");

                                            int row2 = command2.ExecuteNonQuery();
                                            if (row2 > 0)
                                            {
                                                MessageBox.Show("Success");
                                            }
                                            else
                                            {
                                                MessageBox.Show("Some issues!!!!.Please try again.");
                                            }
                                     }
                                }
                                else
                                {
                                    MessageBox.Show("Not Found");
                            
                                }

                            }

                           
                       // }
                    //}
                     
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error :"+ex.Message);
                }

                
            }

        }
    }
}
