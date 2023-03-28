namespace HMS
{
    partial class Form14
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.inBillIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pCNICDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.docIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicineCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorChargesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stayDurationDaysDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iNBILLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hOSPITALDataSet1 = new HMS.HOSPITALDataSet1();
            this.label1 = new System.Windows.Forms.Label();
            this.iN_BILLTableAdapter = new HMS.HOSPITALDataSet1TableAdapters.IN_BILLTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNBILLBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOSPITALDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(312, 144);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(344, 22);
            this.textBox1.TabIndex = 20;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(705, 139);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 33);
            this.button1.TabIndex = 19;
            this.button1.Text = "SEARCH CNIC";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.inBillIDDataGridViewTextBoxColumn,
            this.pCNICDataGridViewTextBoxColumn,
            this.docIDDataGridViewTextBoxColumn,
            this.roomIDDataGridViewTextBoxColumn,
            this.roomCostDataGridViewTextBoxColumn,
            this.medicineCostDataGridViewTextBoxColumn,
            this.doctorChargesDataGridViewTextBoxColumn,
            this.stayDurationDaysDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.iNBILLBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(39, 194);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1271, 298);
            this.dataGridView1.TabIndex = 18;
            // 
            // inBillIDDataGridViewTextBoxColumn
            // 
            this.inBillIDDataGridViewTextBoxColumn.DataPropertyName = "In_Bill_ID";
            this.inBillIDDataGridViewTextBoxColumn.HeaderText = "In_Bill_ID";
            this.inBillIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.inBillIDDataGridViewTextBoxColumn.Name = "inBillIDDataGridViewTextBoxColumn";
            this.inBillIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // pCNICDataGridViewTextBoxColumn
            // 
            this.pCNICDataGridViewTextBoxColumn.DataPropertyName = "P_CNIC";
            this.pCNICDataGridViewTextBoxColumn.HeaderText = "P_CNIC";
            this.pCNICDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pCNICDataGridViewTextBoxColumn.Name = "pCNICDataGridViewTextBoxColumn";
            this.pCNICDataGridViewTextBoxColumn.Width = 125;
            // 
            // docIDDataGridViewTextBoxColumn
            // 
            this.docIDDataGridViewTextBoxColumn.DataPropertyName = "Doc_ID";
            this.docIDDataGridViewTextBoxColumn.HeaderText = "Doc_ID";
            this.docIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.docIDDataGridViewTextBoxColumn.Name = "docIDDataGridViewTextBoxColumn";
            this.docIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // roomIDDataGridViewTextBoxColumn
            // 
            this.roomIDDataGridViewTextBoxColumn.DataPropertyName = "Room_ID";
            this.roomIDDataGridViewTextBoxColumn.HeaderText = "Room_ID";
            this.roomIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.roomIDDataGridViewTextBoxColumn.Name = "roomIDDataGridViewTextBoxColumn";
            this.roomIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // roomCostDataGridViewTextBoxColumn
            // 
            this.roomCostDataGridViewTextBoxColumn.DataPropertyName = "Room_Cost";
            this.roomCostDataGridViewTextBoxColumn.HeaderText = "Room_Cost";
            this.roomCostDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.roomCostDataGridViewTextBoxColumn.Name = "roomCostDataGridViewTextBoxColumn";
            this.roomCostDataGridViewTextBoxColumn.Width = 125;
            // 
            // medicineCostDataGridViewTextBoxColumn
            // 
            this.medicineCostDataGridViewTextBoxColumn.DataPropertyName = "Medicine_Cost";
            this.medicineCostDataGridViewTextBoxColumn.HeaderText = "Medicine_Cost";
            this.medicineCostDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.medicineCostDataGridViewTextBoxColumn.Name = "medicineCostDataGridViewTextBoxColumn";
            this.medicineCostDataGridViewTextBoxColumn.Width = 125;
            // 
            // doctorChargesDataGridViewTextBoxColumn
            // 
            this.doctorChargesDataGridViewTextBoxColumn.DataPropertyName = "Doctor_Charges";
            this.doctorChargesDataGridViewTextBoxColumn.HeaderText = "Doctor_Charges";
            this.doctorChargesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.doctorChargesDataGridViewTextBoxColumn.Name = "doctorChargesDataGridViewTextBoxColumn";
            this.doctorChargesDataGridViewTextBoxColumn.Width = 125;
            // 
            // stayDurationDaysDataGridViewTextBoxColumn
            // 
            this.stayDurationDaysDataGridViewTextBoxColumn.DataPropertyName = "Stay_Duration_(Days)";
            this.stayDurationDaysDataGridViewTextBoxColumn.HeaderText = "Stay_Duration_(Days)";
            this.stayDurationDaysDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stayDurationDaysDataGridViewTextBoxColumn.Name = "stayDurationDaysDataGridViewTextBoxColumn";
            this.stayDurationDaysDataGridViewTextBoxColumn.ReadOnly = true;
            this.stayDurationDaysDataGridViewTextBoxColumn.Width = 125;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalDataGridViewTextBoxColumn.Width = 125;
            // 
            // iNBILLBindingSource
            // 
            this.iNBILLBindingSource.DataMember = "IN_BILL";
            this.iNBILLBindingSource.DataSource = this.hOSPITALDataSet1;
            // 
            // hOSPITALDataSet1
            // 
            this.hOSPITALDataSet1.DataSetName = "HOSPITALDataSet1";
            this.hOSPITALDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(353, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 31);
            this.label1.TabIndex = 17;
            this.label1.Text = "IN BILL INFORMATION";
            // 
            // iN_BILLTableAdapter
            // 
            this.iN_BILLTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(906, 139);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(155, 33);
            this.button2.TabIndex = 21;
            this.button2.Text = "BACK TO MENU";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form14
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1461, 554);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form14";
            this.Text = "Form14";
            this.Load += new System.EventHandler(this.Form14_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNBILLBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOSPITALDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private HOSPITALDataSet1 hOSPITALDataSet1;
        private System.Windows.Forms.BindingSource iNBILLBindingSource;
        private HOSPITALDataSet1TableAdapters.IN_BILLTableAdapter iN_BILLTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn inBillIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pCNICDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn docIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicineCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorChargesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stayDurationDaysDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button2;
    }
}