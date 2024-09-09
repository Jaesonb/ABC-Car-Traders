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
            this.Load += new System.EventHandler(this.uc_car_Load);  // Attach the Load event handler
        }

        private void uc_car_Load(object sender, EventArgs e)
        {
            showdata();  // Load data into the DataGridView when the form loads
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
            // Create a connection string and use it within a using block
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
            {
                try
                {
                    // Validate the input fields
                    if (string.IsNullOrWhiteSpace(textBox2.Text))
                    {
                        MessageBox.Show("Please, Enter Car Name", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBox2.Focus();
                        return;
                    }
                    else if (string.IsNullOrWhiteSpace(textBox3.Text))
                    {
                        MessageBox.Show("Please, Enter Car Brand", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBox3.Focus();
                        return;
                    }
                    else if (string.IsNullOrWhiteSpace(textBox4.Text))
                    {
                        MessageBox.Show("Please, Enter Car Model Year", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBox4.Focus();
                        return;
                    }
                    else if (string.IsNullOrWhiteSpace(textBox5.Text))
                    {
                        MessageBox.Show("Please, Enter Car Price", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBox5.Focus();
                        return;
                    }

                    // Open the connection inside the using block
                    connection.Open();

                    // Parameterized SQL query to insert data into the database
                    string insertQuery = "INSERT INTO dbo.Cars (CarName, Brand, ModelYear, Price) " +
                                         "VALUES (@CarName, @Brand, @ModelYear, @Price)";

                    using (SqlCommand cmd = new SqlCommand(insertQuery, connection))
                    {
                        // Add parameters to avoid SQL injection
                        cmd.Parameters.AddWithValue("@CarName", textBox2.Text);
                        cmd.Parameters.AddWithValue("@Brand", textBox3.Text);
                        cmd.Parameters.AddWithValue("@ModelYear", textBox4.Text);
                        cmd.Parameters.AddWithValue("@Price", textBox5.Text);

                        // Execute the query
                        cmd.ExecuteNonQuery();
                    }

                    // Check the inserted record by selecting the max CarID
                    string selectQuery = "SELECT MAX(CarID) FROM dbo.Cars";

                    using (SqlCommand cmd2 = new SqlCommand(selectQuery, connection))
                    using (SqlDataReader reader = cmd2.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            MessageBox.Show("Car Information Inserted Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            clear();  // Clear all input fields
                            showdata();  // Refresh the data displayed in the DataGridView
                        }
                        else
                        {
                            MessageBox.Show("Car Information Insertion Failed. Please Try Again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (SqlException sqlEx) // Catch SQL-specific exceptions
                {
                    MessageBox.Show($"Database error occurred: {sqlEx.Message}", "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex) // Catch all other exceptions
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void clear()
        {
            // Clear all text boxes
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();

            // Set focus back to the first input field
            textBox2.Focus();
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
            // Use the connection string in a using block to ensure proper disposal
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
            {
                try
                {
                    // Validate input fields
                    if (string.IsNullOrWhiteSpace(textBox2.Text))
                    {
                        MessageBox.Show("Please, Enter Car Name", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBox2.Focus();
                        return;
                    }
                    else if (string.IsNullOrWhiteSpace(textBox3.Text))
                    {
                        MessageBox.Show("Please, Enter Car Brand", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBox3.Focus();
                        return;
                    }
                    else if (string.IsNullOrWhiteSpace(textBox4.Text))
                    {
                        MessageBox.Show("Please, Enter Car Model Year", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBox4.Focus();
                        return;
                    }
                    else if (string.IsNullOrWhiteSpace(textBox5.Text))
                    {
                        MessageBox.Show("Please, Enter Car Price", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBox5.Focus();
                        return;
                    }

                    // Open the connection inside the using block
                    connection.Open();

                    // Use parameterized query to prevent SQL injection
                    string updateQuery = "UPDATE dbo.Cars SET CarName = @CarName, Brand = @Brand, " +
                                         "ModelYear = @ModelYear, Price = @Price WHERE CarName = @CarName";

                    using (SqlCommand cmd = new SqlCommand(updateQuery, connection))
                    {
                        // Add parameters to the query to avoid SQL injection
                        cmd.Parameters.AddWithValue("@CarName", textBox2.Text);
                        cmd.Parameters.AddWithValue("@Brand", textBox3.Text);
                        cmd.Parameters.AddWithValue("@ModelYear", textBox4.Text);
                        cmd.Parameters.AddWithValue("@Price", textBox5.Text);

                        // Execute the query
                        int rowsAffected = cmd.ExecuteNonQuery();

                        // If rows were affected, the update was successful
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Car Information Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            clear();  // Clear all input fields
                            showdata();  // Refresh the data displayed in the DataGridView
                        }
                        else
                        {
                            MessageBox.Show("Car Information Update Failed. Please Try Again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (SqlException sqlEx) // Catch SQL-specific exceptions
                {
                    MessageBox.Show($"Database error occurred: {sqlEx.Message}", "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex) // Catch other exceptions
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }




        private void button3_Click(object sender, EventArgs e)
        {
            // Use the connection string in a using block to ensure proper disposal
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
            {
                try
                {
                    // Validate input fields
                    if (string.IsNullOrWhiteSpace(textBox2.Text))
                    {
                        MessageBox.Show("Please, Enter Car ID.", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBox2.Focus();
                        return;
                    }

                    // Open the connection
                    connection.Open();

                    // Use parameterized query to prevent SQL injection
                    string deleteQuery = "DELETE FROM dbo.Cars WHERE CarName = @CarName";

                    using (SqlCommand cmd = new SqlCommand(deleteQuery, connection))
                    {
                        // Add the CarName parameter to avoid SQL injection
                        cmd.Parameters.AddWithValue("@CarName", textBox2.Text);

                        // Execute the query and check how many rows were affected
                        int rowsAffected = cmd.ExecuteNonQuery();

                        // If rows were affected, the deletion was successful
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Car Information Deleted Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            clear();  // Clear input fields
                            showdata();
                        }
                        else
                        {
                            MessageBox.Show("Car Information Not Found. Please Try Again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (SqlException sqlEx) // Handle SQL-specific exceptions
                {
                    MessageBox.Show($"Database error occurred: {sqlEx.Message}", "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex) // Handle general exceptions
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            showdata();
        }

        private void showdata()
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
            {
                try
                {
                    connection.Open();

                    string selectQuery = "SELECT * FROM dbo.Cars";

                    using (SqlCommand cmd = new SqlCommand(selectQuery, connection))
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
                catch (SqlException sqlEx)
                {
                    MessageBox.Show($"Database error occurred: {sqlEx.Message}", "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                int index;

                index = e.RowIndex;

                DataGridViewRow row = dataGridView1.Rows[index];

                textBox2.Text = row.Cells[1].Value.ToString();
                textBox3.Text = row.Cells[2].Value.ToString();
                textBox4.Text = row.Cells[3].Value.ToString();
                textBox5.Text = row.Cells[4].Value.ToString();


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            
            }

        }
    }

}
