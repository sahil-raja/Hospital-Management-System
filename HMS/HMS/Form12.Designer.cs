namespace HMS
{
    partial class Form12
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.outBillIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pCNICDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.docIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorChargesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oUTBILLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hOSPITALDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hOSPITALDataSet1 = new HMS.HOSPITALDataSet1();
            this.hOSPITALDataSet = new HMS.HOSPITALDataSet1();
            this.oUTBILLINFOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oUT_BILL_INFOTableAdapter = new HMS.HOSPITALDataSet1TableAdapters.OUT_BILL_INFOTableAdapter();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.oUT_BILLTableAdapter = new HMS.HOSPITALDataSet1TableAdapters.OUT_BILLTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oUTBILLBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOSPITALDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOSPITALDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOSPITALDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oUTBILLINFOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(357, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 31);
            this.label1.TabIndex = 12;
            this.label1.Text = "OUT BILL INFORMATION";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.outBillIDDataGridViewTextBoxColumn,
            this.pCNICDataGridViewTextBoxColumn,
            this.docIDDataGridViewTextBoxColumn,
            this.doctorChargesDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.oUTBILLBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(132, 162);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(905, 310);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // outBillIDDataGridViewTextBoxColumn
            // 
            this.outBillIDDataGridViewTextBoxColumn.DataPropertyName = "Out_Bill_ID";
            this.outBillIDDataGridViewTextBoxColumn.HeaderText = "Out_Bill_ID";
            this.outBillIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.outBillIDDataGridViewTextBoxColumn.Name = "outBillIDDataGridViewTextBoxColumn";
            this.outBillIDDataGridViewTextBoxColumn.Width = 125;
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
            // doctorChargesDataGridViewTextBoxColumn
            // 
            this.doctorChargesDataGridViewTextBoxColumn.DataPropertyName = "Doctor Charges";
            this.doctorChargesDataGridViewTextBoxColumn.HeaderText = "Doctor Charges";
            this.doctorChargesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.doctorChargesDataGridViewTextBoxColumn.Name = "doctorChargesDataGridViewTextBoxColumn";
            this.doctorChargesDataGridViewTextBoxColumn.Width = 125;
            // 
            // oUTBILLBindingSource
            // 
            this.oUTBILLBindingSource.DataMember = "OUT_BILL";
            this.oUTBILLBindingSource.DataSource = this.hOSPITALDataSet1BindingSource;
            // 
            // hOSPITALDataSet1BindingSource
            // 
            this.hOSPITALDataSet1BindingSource.DataSource = this.hOSPITALDataSet1;
            this.hOSPITALDataSet1BindingSource.Position = 0;
            // 
            // hOSPITALDataSet1
            // 
            this.hOSPITALDataSet1.DataSetName = "HOSPITALDataSet1";
            this.hOSPITALDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hOSPITALDataSet
            // 
            this.hOSPITALDataSet.DataSetName = "HOSPITALDataSet";
            this.hOSPITALDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // oUTBILLINFOBindingSource
            // 
            this.oUTBILLINFOBindingSource.DataMember = "OUT_BILL_INFO";
            this.oUTBILLINFOBindingSource.DataSource = this.hOSPITALDataSet;
            // 
            // oUT_BILL_INFOTableAdapter
            // 
            this.oUT_BILL_INFOTableAdapter.ClearBeforeFill = true;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(1067, 25);
            this.fillByToolStrip.TabIndex = 14;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // oUT_BILLTableAdapter
            // 
            this.oUT_BILLTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(709, 107);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 33);
            this.button1.TabIndex = 15;
            this.button1.Text = "SEARCH CNIC";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(316, 112);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(344, 22);
            this.textBox1.TabIndex = 16;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(886, 107);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 33);
            this.button2.TabIndex = 17;
            this.button2.Text = "BACK TO MENU";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form12";
            this.Text = "Form12";
            this.Load += new System.EventHandler(this.Form12_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oUTBILLBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOSPITALDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOSPITALDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOSPITALDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oUTBILLINFOBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private HOSPITALDataSet1 hOSPITALDataSet;
        private System.Windows.Forms.BindingSource oUTBILLINFOBindingSource;
        private HOSPITALDataSet1TableAdapters.OUT_BILL_INFOTableAdapter oUT_BILL_INFOTableAdapter;
        private System.Windows.Forms.BindingSource hOSPITALDataSet1BindingSource;
        private HOSPITALDataSet1 hOSPITALDataSet1;
        private System.Windows.Forms.BindingSource oUTBILLBindingSource;
        private HOSPITALDataSet1TableAdapters.OUT_BILLTableAdapter oUT_BILLTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn outBillIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pCNICDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn docIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorChargesDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
    }
}