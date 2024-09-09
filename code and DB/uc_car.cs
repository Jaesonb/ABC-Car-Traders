using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABC_Car_Traders
{
    public partial class uc_car : UserControl
    {
        public uc_car()
        {
            InitializeComponent();
        }

        private void uc_car_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
            {
                try
                {
                    if (textBox1.Text == "")
                    {
                        MessageBox.Show("Please, Enter Car ID.","Try Again", MessageBoxButtons.OK,MessageBoxIcon.Information);
                        textBox1.Focus();

                    }
                    else if (textBox2.Text == "")
                    {
                        MessageBox.Show("Please, Enter Car Name", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBox2.Focus();

                    }
                    else if (textBox3.Text == "")
                    {
                        MessageBox.Show("Please, Enter Car Brand", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBox3.Focus();
                    }
                    else if (textBox4.Text == "")
                    {
                        MessageBox.Show("Please, Enter Car Model Year", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBox4.Focus();
                    }
                    else if (textBox5.Text == "")
                    {
                        MessageBox.Show("Please, Enter Car Price", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBox5.Focus();
                    }
                    else 
                    {
                        SqlConnection con = new SqlConnection(Properties.Settings.Default.connString);

                        con.Open();

                        string insertQuery = "INSERT INTO dbo.Cars (CarID, CarName, Brand, ModelYear, Price) VALUES('"+textBox1.Text+ "','" + textBox2.Text + "', '"+textBox3.Text+ "', '"+textBox4.Text+ "', '"+textBox5.Text+ "' )";

                        SqlCommand cmd = new SqlCommand(insertQuery, con);

                        string str1 = "Select max(CarID) from dbo.Cars ";

                        SqlCommand cmd2 = new SqlCommand(str1, con);

                        SqlDataReader da = cmd2.ExecuteReader();

                        if (da.Read())
                        { 
                            MessageBox.Show("Car Information Inserted Successfully ...! ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            clear();

                        }
                        else
                        {
                            MessageBox.Show("Car Information Inserted Unuccessfully. Please Try again! ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }



                    }

                }
                catch (Exception ex) {

                    MessageBox.Show(ex.Message);
                
                    }
            }

            public void clear()
            {

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();

            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
            {
                try
                {
                    if (textBox1.Text == "")
                    {
                        MessageBox.Show("Please, Enter Car ID.", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBox1.Focus();

                    }
                    else if (textBox2.Text == "")
                    {
                        MessageBox.Show("Please, Enter Car Name", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBox2.Focus();

                    }
                    else if (textBox3.Text == "")
                    {
                        MessageBox.Show("Please, Enter Car Brand", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBox3.Focus();
                    }
                    else if (textBox4.Text == "")
                    {
                        MessageBox.Show("Please, Enter Car Model Year", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBox4.Focus();
                    }
                    else if (textBox5.Text == "")
                    {
                        MessageBox.Show("Please, Enter Car Price", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBox5.Focus();
                    }
                    else
                    {
                        SqlConnection con = new SqlConnection(Properties.Settings.Default.connString);

                        con.Open();

                        string updateQuery = " Update dbo.Cars Set CarID =  '"+textBox1.Text+ "',  CarName = '"+textBox2.Text+ "' ,  Brand = '"+textBox3.Text+ "' , ModelYear = '"+textBox4.Text+ "', Price = '"+textBox5.Text+ "' Where CarID =  '"+textBox1.Text+ "' ";

                        SqlCommand cmd = new SqlCommand(updateQuery, con);

                        string str1 = "Select max(CarID) from dbo.Cars ";

                        SqlCommand cmd2 = new SqlCommand(str1, con);

                        SqlDataReader da = cmd2.ExecuteReader();

                        if (da.Read())
                        {
                            MessageBox.Show("Car Information Updated Successfully ...! ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            clear();

                        }
                        else
                        {
                            MessageBox.Show("Car Information Updated Unuccessfully. Please Try Again! ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }



                    }

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);

                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
            {
                try
                {
                    if (textBox1.Text == "")
                    {
                        MessageBox.Show("Please, Enter Car ID.", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBox1.Focus();

                    }
                    else if (textBox2.Text == "")
                    {
                        MessageBox.Show("Please, Enter Car Name", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBox2.Focus();

                    }
                    else if (textBox3.Text == "")
                    {
                        MessageBox.Show("Please, Enter Car Brand", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBox3.Focus();
                    }
                    else if (textBox4.Text == "")
                    {
                        MessageBox.Show("Please, Enter Car Model Year", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBox4.Focus();
                    }
                    else if (textBox5.Text == "")
                    {
                        MessageBox.Show("Please, Enter Car Price", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBox5.Focus();
                    }
                    else
                    {
                        SqlConnection con = new SqlConnection(Properties.Settings.Default.connString);

                        con.Open();

                        string updateQuery = " Delete FROM  dbo.Cars Set  Where CarID =  '" + textBox1.Text + "' ";

                        SqlCommand cmd = new SqlCommand(updateQuery, con);

                        string str1 = "Select max(CarID) from dbo.Cars ";

                        SqlCommand cmd2 = new SqlCommand(str1, con);

                        SqlDataReader da = cmd2.ExecuteReader();

                        if (da.Read())
                        {
                            MessageBox.Show("Car Information Deleted Successfully ...! ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            clear();

                        }
                        else
                        {
                            MessageBox.Show("Car Information Deleted Unuccessfully. Please Try Again! ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }



                    }

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);

                }
            }
        }
    }
}
