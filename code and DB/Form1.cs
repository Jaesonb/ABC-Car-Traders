using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ABC_Car_Traders
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
            {

                string selectQuery = "SELECT COUNT(*) FROM dbo.Users WHERE Username=@Username AND Password=@Password";
                using (SqlCommand sqlCommand = new SqlCommand(selectQuery, connection)) 
                {
                    sqlCommand.Parameters.AddWithValue("@Username", txtbox1.Text);
                    sqlCommand.Parameters.AddWithValue("@Password", txtbox2.Text);


                    try
                    {
                        connection.Open();

                        // Use ExecuteScalar() for SELECT COUNT(*) query
                        int userCount = (int)sqlCommand.ExecuteScalar();

                        if (userCount > 0)
                        {
                            MessageBox.Show("Login successful", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch (SqlException sqlEx)
                    {
                        MessageBox.Show($"SQL Error: {sqlEx.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }



                }

            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            // Ensure that input fields are not empty (basic validation)
            if (string.IsNullOrWhiteSpace(txtbox1.Text) || string.IsNullOrWhiteSpace(txtbox2.Text) || string.IsNullOrWhiteSpace(txtbox3.Text))
            {
                MessageBox.Show("All fields are required.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
            {
                string insertQuery = "INSERT INTO dbo.Users (Username, Password, Email) VALUES(@Username, @Password, @Email)";

                using (SqlCommand sqlCommand = new SqlCommand(insertQuery, connection))
                {
                    // Adding parameters with size specifications for NVarChar to match the database schema
                    sqlCommand.Parameters.Add(new SqlParameter("@Username", SqlDbType.NVarChar, 50)).Value = txtbox1.Text;

                    // Always hash and salt passwords before storing them in the database
                    //string hashedPassword = HashPassword(txtbox2.Text); // Assuming HashPassword is a method that hashes the password
                    sqlCommand.Parameters.Add(new SqlParameter("@Password", SqlDbType.NVarChar, 100)).Value = txtbox2.Text;

                    sqlCommand.Parameters.Add(new SqlParameter("@Email", SqlDbType.NVarChar, 100)).Value = txtbox3.Text;


                    try
                    {
                        connection.Open();
                        sqlCommand.ExecuteNonQuery();
                        MessageBox.Show("Registered successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (SqlException sqlEx)
                    {

                        MessageBox.Show($"SQL Error: {sqlEx.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        //// Example hashing function (for demonstration only)
        //private string HashPassword(string password)
        //{
        //    // Implement a strong hashing algorithm like SHA-256 or bcrypt.
        //    return BCrypt.Net.BCrypt.HashPassword(password);
        //}


        //private void button2_Click(object sender, EventArgs e)
        //{
        //    using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
        //    {
                
        //        string insertQuery = "INSERT INTO dbo.Users (Username, Password, Email) VALUES(@Username, @Password, @Email)";
        //        using (SqlCommand SqlCommand = new SqlCommand(insertQuery, connection))
        //        {
                    
        //            SqlCommand.Parameters.Add(new SqlParameter("@Username", SqlDbType.NVarChar));
        //            SqlCommand.Parameters["@Username"].Value = txtbox1.Text;

        //            SqlCommand.Parameters.Add(new SqlParameter("@Password", SqlDbType.NVarChar));
        //            SqlCommand.Parameters["@Password"].Value = txtbox2.Text;

        //            SqlCommand.Parameters.Add(new SqlParameter("@Email", SqlDbType.NVarChar));
        //            SqlCommand.Parameters["@Email"].Value = txtbox3.Text;

        //            try
        //            {
        //                connection.Open();


        //                SqlCommand.ExecuteNonQuery();
        //                //MessageBox.Show("register successfully", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);

        //            }
        //            catch
        //            {

        //                MessageBox.Show("Error");

        //            }
        //            //finally
        //            //{

        //            //    connection.Close();
        //            //}
        //        }


            
        //    }

        //}

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void txtbox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
