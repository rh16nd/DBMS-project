namespace WindowsFormsApp_project
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.ticketIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.participantIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticketsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new WindowsFormsApp_project.DataSet1();
            this.particpantIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.participantNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactInfoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.participantsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ticketsTableAdapter = new WindowsFormsApp_project.DataSet1TableAdapters.TicketsTableAdapter();
            this.participantsTableAdapter = new WindowsFormsApp_project.DataSet1TableAdapters.ParticipantsTableAdapter();
            this.button7 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.participantsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.particpantIDDataGridViewTextBoxColumn,
            this.participantNameDataGridViewTextBoxColumn,
            this.contactInfoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.participantsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(437, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(406, 180);
            this.dataGridView1.TabIndex = 7;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ticketIDDataGridViewTextBoxColumn,
            this.participantIDDataGridViewTextBoxColumn,
            this.eventIDDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.ticketsBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(437, 243);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(406, 180);
            this.dataGridView2.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(242, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 31);
            this.button1.TabIndex = 9;
            this.button1.Text = "INSERT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(338, 169);
            this.button2.Name = "button2";
            this.button2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button2.Size = new System.Drawing.Size(93, 33);
            this.button2.TabIndex = 10;
            this.button2.Text = "DELETE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(242, 263);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 31);
            this.button3.TabIndex = 11;
            this.button3.Text = "INSERT";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(338, 379);
            this.button4.Name = "button4";
            this.button4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button4.Size = new System.Drawing.Size(93, 33);
            this.button4.TabIndex = 12;
            this.button4.Text = "DELETE";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(112, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 13;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(112, 118);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 14;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(112, 302);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 15;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(112, 349);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 15;
            // 
            // ticketIDDataGridViewTextBoxColumn
            // 
            this.ticketIDDataGridViewTextBoxColumn.DataPropertyName = "TicketID";
            this.ticketIDDataGridViewTextBoxColumn.HeaderText = "TicketID";
            this.ticketIDDataGridViewTextBoxColumn.Name = "ticketIDDataGridViewTextBoxColumn";
            this.ticketIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // participantIDDataGridViewTextBoxColumn
            // 
            this.participantIDDataGridViewTextBoxColumn.DataPropertyName = "ParticipantID";
            this.participantIDDataGridViewTextBoxColumn.HeaderText = "ParticipantID";
            this.participantIDDataGridViewTextBoxColumn.Name = "participantIDDataGridViewTextBoxColumn";
            // 
            // eventIDDataGridViewTextBoxColumn
            // 
            this.eventIDDataGridViewTextBoxColumn.DataPropertyName = "EventID";
            this.eventIDDataGridViewTextBoxColumn.HeaderText = "EventID";
            this.eventIDDataGridViewTextBoxColumn.Name = "eventIDDataGridViewTextBoxColumn";
            // 
            // ticketsBindingSource
            // 
            this.ticketsBindingSource.DataMember = "Tickets";
            this.ticketsBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // particpantIDDataGridViewTextBoxColumn
            // 
            this.particpantIDDataGridViewTextBoxColumn.DataPropertyName = "ParticpantID";
            this.particpantIDDataGridViewTextBoxColumn.HeaderText = "ParticpantID";
            this.particpantIDDataGridViewTextBoxColumn.Name = "particpantIDDataGridViewTextBoxColumn";
            this.particpantIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // participantNameDataGridViewTextBoxColumn
            // 
            this.participantNameDataGridViewTextBoxColumn.DataPropertyName = "ParticipantName";
            this.participantNameDataGridViewTextBoxColumn.HeaderText = "ParticipantName";
            this.participantNameDataGridViewTextBoxColumn.Name = "participantNameDataGridViewTextBoxColumn";
            // 
            // contactInfoDataGridViewTextBoxColumn
            // 
            this.contactInfoDataGridViewTextBoxColumn.DataPropertyName = "ContactInfo";
            this.contactInfoDataGridViewTextBoxColumn.HeaderText = "ContactInfo";
            this.contactInfoDataGridViewTextBoxColumn.Name = "contactInfoDataGridViewTextBoxColumn";
            // 
            // participantsBindingSource
            // 
            this.participantsBindingSource.DataMember = "Participants";
            this.participantsBindingSource.DataSource = this.dataSet1;
            // 
            // ticketsTableAdapter
            // 
            this.ticketsTableAdapter.ClearBeforeFill = true;
            // 
            // participantsTableAdapter
            // 
            this.participantsTableAdapter.ClearBeforeFill = true;
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(778, 464);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(79, 27);
            this.button7.TabIndex = 18;
            this.button7.Text = "BACK";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 503);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.participantsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource ticketsBindingSource;
        private DataSet1TableAdapters.TicketsTableAdapter ticketsTableAdapter;
        private System.Windows.Forms.BindingSource participantsBindingSource;
        private DataSet1TableAdapters.ParticipantsTableAdapter participantsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn particpantIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn participantNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactInfoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticketIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn participantIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button7;
    }
}