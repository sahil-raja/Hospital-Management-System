namespace HMS
{
    partial class Form11
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
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.prescriptionIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.docIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pCNICDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appointmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.presDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRESCRIPTIONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hOSPITALDataSet1 = new HMS.HOSPITALDataSet1();
            this.pRESCRIPTIONTableAdapter = new HMS.HOSPITALDataSet1TableAdapters.PRESCRIPTIONTableAdapter();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRESCRIPTIONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOSPITALDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(162, 294);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(161, 20);
            this.textBox5.TabIndex = 79;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 294);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 78;
            this.label7.Text = "Appointment";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 77;
            this.label6.Text = "Medicine Id";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(162, 250);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(161, 20);
            this.textBox4.TabIndex = 76;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(383, 396);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 75;
            this.button3.Text = "DELETE";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(279, 396);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 74;
            this.button2.Text = "UPDATE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(167, 396);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 73;
            this.button1.Text = "INSERT ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(162, 204);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(161, 20);
            this.textBox3.TabIndex = 72;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(162, 164);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(161, 20);
            this.textBox2.TabIndex = 71;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(162, 126);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(161, 20);
            this.textBox1.TabIndex = 70;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 69;
            this.label5.Text = "Patient Cnic";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 68;
            this.label3.Text = "Doctor ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 67;
            this.label2.Text = "Presciption ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(86, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 22);
            this.label1.TabIndex = 66;
            this.label1.Text = "PRESCRIPTION";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 342);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 80;
            this.label4.Text = "Prescription Date";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(162, 342);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(161, 20);
            this.textBox7.TabIndex = 83;
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(483, 396);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 84;
            this.button4.Text = "SEARCH";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(24, 396);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(102, 23);
            this.button5.TabIndex = 85;
            this.button5.Text = "BACK TO MENU";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.prescriptionIDDataGridViewTextBoxColumn,
            this.docIDDataGridViewTextBoxColumn,
            this.pCNICDataGridViewTextBoxColumn,
            this.medIDDataGridViewTextBoxColumn,
            this.appointmentDataGridViewTextBoxColumn,
            this.presDATEDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pRESCRIPTIONBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(350, 126);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(438, 236);
            this.dataGridView1.TabIndex = 86;
            // 
            // prescriptionIDDataGridViewTextBoxColumn
            // 
            this.prescriptionIDDataGridViewTextBoxColumn.DataPropertyName = "Prescription_ID";
            this.prescriptionIDDataGridViewTextBoxColumn.HeaderText = "Prescription_ID";
            this.prescriptionIDDataGridViewTextBoxColumn.Name = "prescriptionIDDataGridViewTextBoxColumn";
            this.prescriptionIDDataGridViewTextBoxColumn.Width = 20;
            // 
            // docIDDataGridViewTextBoxColumn
            // 
            this.docIDDataGridViewTextBoxColumn.DataPropertyName = "Doc_ID";
            this.docIDDataGridViewTextBoxColumn.HeaderText = "Doc_ID";
            this.docIDDataGridViewTextBoxColumn.Name = "docIDDataGridViewTextBoxColumn";
            this.docIDDataGridViewTextBoxColumn.Width = 20;
            // 
            // pCNICDataGridViewTextBoxColumn
            // 
            this.pCNICDataGridViewTextBoxColumn.DataPropertyName = "P_CNIC";
            this.pCNICDataGridViewTextBoxColumn.HeaderText = "P_CNIC";
            this.pCNICDataGridViewTextBoxColumn.Name = "pCNICDataGridViewTextBoxColumn";
            // 
            // medIDDataGridViewTextBoxColumn
            // 
            this.medIDDataGridViewTextBoxColumn.DataPropertyName = "Med_ID";
            this.medIDDataGridViewTextBoxColumn.HeaderText = "Med_ID";
            this.medIDDataGridViewTextBoxColumn.Name = "medIDDataGridViewTextBoxColumn";
            this.medIDDataGridViewTextBoxColumn.Width = 20;
            // 
            // appointmentDataGridViewTextBoxColumn
            // 
            this.appointmentDataGridViewTextBoxColumn.DataPropertyName = "Appointment";
            this.appointmentDataGridViewTextBoxColumn.HeaderText = "Appointment";
            this.appointmentDataGridViewTextBoxColumn.Name = "appointmentDataGridViewTextBoxColumn";
            this.appointmentDataGridViewTextBoxColumn.Width = 20;
            // 
            // presDATEDataGridViewTextBoxColumn
            // 
            this.presDATEDataGridViewTextBoxColumn.DataPropertyName = "Pres_DATE";
            this.presDATEDataGridViewTextBoxColumn.HeaderText = "Pres_DATE";
            this.presDATEDataGridViewTextBoxColumn.Name = "presDATEDataGridViewTextBoxColumn";
            // 
            // pRESCRIPTIONBindingSource
            // 
            this.pRESCRIPTIONBindingSource.DataMember = "PRESCRIPTION";
            this.pRESCRIPTIONBindingSource.DataSource = this.hOSPITALDataSet1;
            // 
            // hOSPITALDataSet1
            // 
            this.hOSPITALDataSet1.DataSetName = "HOSPITALDataSet1";
            this.hOSPITALDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pRESCRIPTIONTableAdapter
            // 
            this.pRESCRIPTIONTableAdapter.ClearBeforeFill = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(621, 82);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(107, 23);
            this.button6.TabIndex = 87;
            this.button6.Text = "SEARCH BY CNIC";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(410, 85);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(148, 20);
            this.textBox6.TabIndex = 88;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(589, 396);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 89;
            this.button7.Text = "CLEAR";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form11";
            this.Text = "Prescription Form";
            this.Load += new System.EventHandler(this.Form11_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRESCRIPTIONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOSPITALDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private HOSPITALDataSet1 hOSPITALDataSet1;
        private System.Windows.Forms.BindingSource pRESCRIPTIONBindingSource;
        private HOSPITALDataSet1TableAdapters.PRESCRIPTIONTableAdapter pRESCRIPTIONTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn prescriptionIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn docIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pCNICDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn appointmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn presDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button button7;
    }
}