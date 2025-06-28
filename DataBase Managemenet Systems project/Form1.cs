using System;
using System.Windows.Forms;

namespace WindowsFormsApp_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Staff' table. You can move, or remove it, as needed.
            this.staffTableAdapter.Fill(this.dataSet1.Staff);
            // TODO: This line of code loads data into the 'dataSet1.Venues' table. You can move, or remove it, as needed.
            this.venuesTableAdapter.Fill(this.dataSet1.Venues);
            // TODO: This line of code loads data into the 'dataSet1.Events' table. You can move, or remove it, as needed.
            this.eventsTableAdapter.Fill(this.dataSet1.Events);

        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.eventsTableAdapter.EventsInsertQuery(textBox1.Text, textBox2.Text, int.Parse(textBox3.Text), int.Parse(textBox4.Text));
            this.eventsTableAdapter.Fill(this.dataSet1.Events);

            MessageBox.Show("Event was added successfully!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // Ensure a row is selected
                if (dataGridView1.CurrentRow != null)
                {
                    int val;
                    string str_val = dataGridView1.CurrentRow.Cells[0].Value?.ToString();

                    // Validate the primary key value
                    if (int.TryParse(str_val, out val))
                    {
                        // Call delete query
                        int rowsAffected = this.eventsTableAdapter.EventsDeleteQuery(val);

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Refresh the DataGridView
                            this.eventsTableAdapter.Fill(this.dataSet1.Events);
                        }
                        else
                        {
                            MessageBox.Show("Deletion failed. The record may not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid ID. Please select a valid row.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("No row selected. Please select a row to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                // Catch any unexpected errors and show a message
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.venuesTableAdapter.VenuesInsertQuery(textBox5.Text, textBox6.Text);

            this.venuesTableAdapter.Fill(this.dataSet1.Venues);

            MessageBox.Show("Venue was added successfully!");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                // Ensure a row is selected
                if (dataGridView2.CurrentRow != null)
                {
                    int val;
                    string str_val = dataGridView2.CurrentRow.Cells[0].Value?.ToString();

                    // Validate the primary key value
                    if (int.TryParse(str_val, out val))
                    {
                        // Call delete query
                        int rowsAffected = this.venuesTableAdapter.VenuesDeleteQuery(val);

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Refresh the DataGridView
                            this.venuesTableAdapter.Fill(this.dataSet1.Venues);
                        }
                        else
                        {
                            MessageBox.Show("Deletion failed. The record may not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid ID. Please select a valid row.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("No row selected. Please select a row to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                // Catch any unexpected errors and show a message
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.staffTableAdapter.StaffInsertQuery(textBox7.Text, textBox8.Text);

            this.staffTableAdapter.Fill(this.dataSet1.Staff);

            MessageBox.Show("Staff was added successfully!");


        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                // Ensure a row is selected
                if (dataGridView3.CurrentRow != null)
                {
                    int val;
                    string str_val = dataGridView3.CurrentRow.Cells[0].Value?.ToString();

                    // Validate the primary key value
                    if (int.TryParse(str_val, out val))
                    {
                        // Call delete query
                        int rowsAffected = this.staffTableAdapter.StaffDeleteQuery(val);

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Refresh the DataGridView
                            this.staffTableAdapter.Fill(this.dataSet1.Staff);
                        }
                        else
                        {
                            MessageBox.Show("Deletion failed. The record may not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid ID. Please select a valid row.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("No row selected. Please select a row to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                // Catch any unexpected errors and show a message
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show(); // Show Form2
            this.Hide();  // Hide Form1
        }
    }
}
