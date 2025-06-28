namespace WindowsFormsApp_project
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.venueIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new WindowsFormsApp_project.DataSet1();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.venueIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.venueNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capacityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.venuesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.eventsTableAdapter = new WindowsFormsApp_project.DataSet1TableAdapters.EventsTableAdapter();
            this.venuesTableAdapter = new WindowsFormsApp_project.DataSet1TableAdapters.VenuesTableAdapter();
            this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.staffTableAdapter = new WindowsFormsApp_project.DataSet1TableAdapters.StaffTableAdapter();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.staffIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button7 = new System.Windows.Forms.Button();
            this.staffIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.venuesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(213, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 31);
            this.button1.TabIndex = 0;
            this.button1.Text = "INSERT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(347, 147);
            this.button2.Name = "button2";
            this.button2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button2.Size = new System.Drawing.Size(93, 33);
            this.button2.TabIndex = 1;
            this.button2.Text = "DELETE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(213, 236);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 32);
            this.button3.TabIndex = 2;
            this.button3.Text = "INSERT";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(347, 330);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(93, 36);
            this.button4.TabIndex = 3;
            this.button4.Text = "DELETE";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(213, 412);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(101, 31);
            this.button5.TabIndex = 4;
            this.button5.Text = "INSERT";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(347, 527);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(93, 31);
            this.button6.TabIndex = 5;
            this.button6.Text = "DELETE";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.venueIDDataGridViewTextBoxColumn,
            this.eventIDDataGridViewTextBoxColumn,
            this.eventNameDataGridViewTextBoxColumn,
            this.eventDateDataGridViewTextBoxColumn,
            this.staffIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.eventsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(446, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(431, 180);
            this.dataGridView1.TabIndex = 6;
            // 
            // venueIDDataGridViewTextBoxColumn
            // 
            this.venueIDDataGridViewTextBoxColumn.DataPropertyName = "VenueID";
            this.venueIDDataGridViewTextBoxColumn.HeaderText = "VenueID";
            this.venueIDDataGridViewTextBoxColumn.Name = "venueIDDataGridViewTextBoxColumn";
            // 
            // eventsBindingSource
            // 
            this.eventsBindingSource.DataMember = "Events";
            this.eventsBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.venueIDDataGridViewTextBoxColumn1,
            this.venueNameDataGridViewTextBoxColumn,
            this.capacityDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.venuesBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(446, 206);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(406, 180);
            this.dataGridView2.TabIndex = 7;
            // 
            // venueIDDataGridViewTextBoxColumn1
            // 
            this.venueIDDataGridViewTextBoxColumn1.DataPropertyName = "VenueID";
            this.venueIDDataGridViewTextBoxColumn1.HeaderText = "VenueID";
            this.venueIDDataGridViewTextBoxColumn1.Name = "venueIDDataGridViewTextBoxColumn1";
            this.venueIDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // venueNameDataGridViewTextBoxColumn
            // 
            this.venueNameDataGridViewTextBoxColumn.DataPropertyName = "VenueName";
            this.venueNameDataGridViewTextBoxColumn.HeaderText = "VenueName";
            this.venueNameDataGridViewTextBoxColumn.Name = "venueNameDataGridViewTextBoxColumn";
            // 
            // capacityDataGridViewTextBoxColumn
            // 
            this.capacityDataGridViewTextBoxColumn.DataPropertyName = "Capacity";
            this.capacityDataGridViewTextBoxColumn.HeaderText = "Capacity";
            this.capacityDataGridViewTextBoxColumn.Name = "capacityDataGridViewTextBoxColumn";
            // 
            // venuesBindingSource
            // 
            this.venuesBindingSource.DataMember = "Venues";
            this.venuesBindingSource.DataSource = this.dataSet1;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.staffIDDataGridViewTextBoxColumn1,
            this.staffNameDataGridViewTextBoxColumn,
            this.roleDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.staffBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(446, 392);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(406, 180);
            this.dataGridView3.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(95, 62);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(95, 88);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 10;
            // 
            // eventsTableAdapter
            // 
            this.eventsTableAdapter.ClearBeforeFill = true;
            // 
            // venuesTableAdapter
            // 
            this.venuesTableAdapter.ClearBeforeFill = true;
            // 
            // staffBindingSource
            // 
            this.staffBindingSource.DataMember = "Staff";
            this.staffBindingSource.DataSource = this.dataSet1;
            // 
            // staffTableAdapter
            // 
            this.staffTableAdapter.ClearBeforeFill = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(95, 119);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 11;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(95, 145);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 12;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(95, 261);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 13;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(95, 296);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 14;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(95, 443);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 15;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(95, 488);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 20);
            this.textBox8.TabIndex = 16;
            // 
            // staffIDDataGridViewTextBoxColumn1
            // 
            this.staffIDDataGridViewTextBoxColumn1.DataPropertyName = "StaffID";
            this.staffIDDataGridViewTextBoxColumn1.HeaderText = "StaffID";
            this.staffIDDataGridViewTextBoxColumn1.Name = "staffIDDataGridViewTextBoxColumn1";
            this.staffIDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // staffNameDataGridViewTextBoxColumn
            // 
            this.staffNameDataGridViewTextBoxColumn.DataPropertyName = "StaffName";
            this.staffNameDataGridViewTextBoxColumn.HeaderText = "StaffName";
            this.staffNameDataGridViewTextBoxColumn.Name = "staffNameDataGridViewTextBoxColumn";
            // 
            // roleDataGridViewTextBoxColumn
            // 
            this.roleDataGridViewTextBoxColumn.DataPropertyName = "Role";
            this.roleDataGridViewTextBoxColumn.HeaderText = "Role";
            this.roleDataGridViewTextBoxColumn.Name = "roleDataGridViewTextBoxColumn";
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(869, 588);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(79, 27);
            this.button7.TabIndex = 17;
            this.button7.Text = "NEXT";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // staffIDDataGridViewTextBoxColumn
            // 
            this.staffIDDataGridViewTextBoxColumn.DataPropertyName = "StaffID";
            this.staffIDDataGridViewTextBoxColumn.HeaderText = "StaffID";
            this.staffIDDataGridViewTextBoxColumn.Name = "staffIDDataGridViewTextBoxColumn";
            // 
            // eventDateDataGridViewTextBoxColumn
            // 
            this.eventDateDataGridViewTextBoxColumn.DataPropertyName = "EventDate";
            this.eventDateDataGridViewTextBoxColumn.HeaderText = "EventDate";
            this.eventDateDataGridViewTextBoxColumn.Name = "eventDateDataGridViewTextBoxColumn";
            // 
            // eventNameDataGridViewTextBoxColumn
            // 
            this.eventNameDataGridViewTextBoxColumn.DataPropertyName = "EventName";
            this.eventNameDataGridViewTextBoxColumn.HeaderText = "EventName";
            this.eventNameDataGridViewTextBoxColumn.Name = "eventNameDataGridViewTextBoxColumn";
            // 
            // eventIDDataGridViewTextBoxColumn
            // 
            this.eventIDDataGridViewTextBoxColumn.DataPropertyName = "EventID";
            this.eventIDDataGridViewTextBoxColumn.HeaderText = "EventID";
            this.eventIDDataGridViewTextBoxColumn.Name = "eventIDDataGridViewTextBoxColumn";
            this.eventIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 627);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.venuesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource eventsBindingSource;
        private DataSet1TableAdapters.EventsTableAdapter eventsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn venueIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource venuesBindingSource;
        private DataSet1TableAdapters.VenuesTableAdapter venuesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn venueIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn venueNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn capacityDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource staffBindingSource;
        private DataSet1TableAdapters.StaffTableAdapter staffTableAdapter;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffIDDataGridViewTextBoxColumn;
    }
}

