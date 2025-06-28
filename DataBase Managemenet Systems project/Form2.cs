using System;
using System.Windows.Forms;

namespace WindowsFormsApp_project
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Participants' table. You can move, or remove it, as needed.
            this.participantsTableAdapter.Fill(this.dataSet1.Participants);
            // TODO: This line of code loads data into the 'dataSet1.Tickets' table. You can move, or remove it, as needed.
            this.ticketsTableAdapter.Fill(this.dataSet1.Tickets);

        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.participantsTableAdapter.ParticipantsInsertQuery(textBox1.Text, textBox2.Text);
            this.participantsTableAdapter.Fill(this.dataSet1.Participants);

            MessageBox.Show("Participant was added successfully!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Ensure a row is selected
            if (dataGridView1.CurrentRow != null)
            {
                int val;
                string str_val = dataGridView1.CurrentRow.Cells[0].Value?.ToString();

                // Validate the primary key value
                if (int.TryParse(str_val, out val))
                {
                    // Call delete query and refresh the DataGridView
                    this.participantsTableAdapter.ParticipantsDeleteQuery(val);
                    this.participantsTableAdapter.Fill(this.dataSet1.Participants);
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

        private void button3_Click(object sender, EventArgs e)
        {
            this.ticketsTableAdapter.TicketsInsertQuery(int.Parse(textBox3.Text), int.Parse(textBox4.Text));

            this.ticketsTableAdapter.Fill(this.dataSet1.Tickets);

            MessageBox.Show("Ticket was added successfully!");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Ensure a row is selected
            if (dataGridView2.CurrentRow != null)
            {
                int val;
                string str_val = dataGridView2.CurrentRow.Cells[0].Value?.ToString();

                // Validate the primary key value
                if (int.TryParse(str_val, out val))
                {
                    // Call delete query and refresh the DataGridView
                    this.ticketsTableAdapter.TicketsDeleteQuery(val);
                    this.ticketsTableAdapter.Fill(this.dataSet1.Tickets);
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

        private void button7_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show(); // Show Form1
            this.Hide();  // Hide Form2
        }
    }
}
