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
    public partial class uc_carparts : UserControl
    {
        public uc_carparts()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.uc_carparts_Load);  // Attach the Load event handler
        }

        private void uc_carparts_Load(object sender, EventArgs e)
        {
            showdata();  // Load data into the DataGridView when the form loads
        }

        private void label2_Click(object sender, EventArgs e)
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
                    if (string.IsNullOrWhiteSpace(textBox1.Text))
                    {
                        MessageBox.Show("Please, Enter Part Name", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBox1.Focus();
                        return;
                    }

                    else if (string.IsNullOrWhiteSpace(textBox4.Text))
                    {
                        MessageBox.Show("Please, Enter Price", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBox4.Focus();
                        return;
                    }
                    

                    // Open the connection inside the using block
                    connection.Open();

                    // Parameterized SQL query to insert data into the database
                    string insertQuery = "INSERT INTO dbo.CarParts (PartName, CarID, Price) " +
                                         "VALUES (@PartName, @CarID, @Price)";

                    using (SqlCommand cmd = new SqlCommand(insertQuery, connection))
                    {
                        // Add parameters to avoid SQL injection
                        cmd.Parameters.AddWithValue("@PartName", textBox1.Text);
                        cmd.Parameters.AddWithValue("@Price", textBox4.Text);

                        // Execute the query
                        cmd.ExecuteNonQuery();
                    }

                    // Check the inserted record by selecting the max CarID
                    string selectQuery = "SELECT MAX(CarID) FROM dbo.CarParts";

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
            textBox1.Clear();
            textBox4.Clear();

            // Set focus back to the first input field
            textBox1.Focus();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

                    string selectQuery = "SELECT * FROM dbo.CarParts";

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

                textBox1.Text = row.Cells[1].Value.ToString();
                textBox4.Text = row.Cells[3].Value.ToString();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Use the connection string in a using block to ensure proper disposal
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
            {
                try
                {
                    // Validate input fields
                    if (string.IsNullOrWhiteSpace(textBox1.Text))
                    {
                        MessageBox.Show("Please, Enter Car Part Name", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBox1.Focus();
                        return;
                    }
                    else if (string.IsNullOrWhiteSpace(textBox4.Text))
                    {
                        MessageBox.Show("Please, Enter Car Pricer", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBox4.Focus();
                        return;
                    }

                    // Open the connection inside the using block
                    connection.Open();

                    // Use parameterized query to prevent SQL injection
                    string updateQuery = "UPDATE dbo.Cars SET PartName = @PartName, CarID = @CarID, " +
                                         "Price = @Price WHERE PartName = @PartName";

                    using (SqlCommand cmd = new SqlCommand(updateQuery, connection))
                    {
                        // Add parameters to the query to avoid SQL injection
                        cmd.Parameters.AddWithValue("@PartName", textBox1.Text);
                        cmd.Parameters.AddWithValue("@Price", textBox4.Text);

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
                    if (string.IsNullOrWhiteSpace(textBox1.Text))
                    {
                        MessageBox.Show("Please, Enter Car PartName.", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBox1.Focus();
                        return;
                    }

                    // Open the connection
                    connection.Open();

                    // Use parameterized query to prevent SQL injection
                    string deleteQuery = "DELETE FROM dbo.Cars WHERE PartName = @PartName";

                    using (SqlCommand cmd = new SqlCommand(deleteQuery, connection))
                    {
                        // Add the CarName parameter to avoid SQL injection
                        cmd.Parameters.AddWithValue("@PartName", textBox1.Text);

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
    }
}
