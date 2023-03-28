namespace HMS
{
    partial class Form16
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
            this.button1 = new System.Windows.Forms.Button();
            this.hOSPITALDataSet1 = new HMS.HOSPITALDataSet1();
            this.oUTBILLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oUT_BILLTableAdapter = new HMS.HOSPITALDataSet1TableAdapters.OUT_BILLTableAdapter();
            this.dOCTORBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dOCTORTableAdapter = new HMS.HOSPITALDataSet1TableAdapters.DOCTORTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.hOSPITALDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oUTBILLBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOCTORBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(446, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(466, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "WELCOME TO REPORT SECTION";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.button1.Location = new System.Drawing.Point(23, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "REPORT 1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // hOSPITALDataSet1
            // 
            this.hOSPITALDataSet1.DataSetName = "HOSPITALDataSet1";
            this.hOSPITALDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // oUTBILLBindingSource
            // 
            this.oUTBILLBindingSource.DataMember = "OUT_BILL";
            this.oUTBILLBindingSource.DataSource = this.hOSPITALDataSet1;
            // 
            // oUT_BILLTableAdapter
            // 
            this.oUT_BILLTableAdapter.ClearBeforeFill = true;
            // 
            // dOCTORBindingSource
            // 
            this.dOCTORBindingSource.DataMember = "DOCTOR";
            this.dOCTORBindingSource.DataSource = this.hOSPITALDataSet1;
            // 
            // dOCTORTableAdapter
            // 
            this.dOCTORTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(24, 192);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "REPORT 2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1289, 405);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(148, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "BACK TO MENU";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(23, 269);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "REPORT 3";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(22, 347);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(95, 23);
            this.button5.TabIndex = 6;
            this.button5.Text = "REPORT 4";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(22, 431);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(95, 23);
            this.button6.TabIndex = 7;
            this.button6.Text = "REPORT 5";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(1328, 120);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(109, 23);
            this.button7.TabIndex = 8;
            this.button7.Text = "REPORT 6";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(1328, 228);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(109, 23);
            this.button8.TabIndex = 9;
            this.button8.Text = "REPORT 8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(1328, 174);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(109, 23);
            this.button9.TabIndex = 10;
            this.button9.Text = "REPORT 7";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(1328, 286);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(109, 23);
            this.button10.TabIndex = 11;
            this.button10.Text = "REPORT 9";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(1328, 347);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(109, 23);
            this.button11.TabIndex = 12;
            this.button11.Text = "REPORT 10";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(123, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1160, 486);
            this.dataGridView1.TabIndex = 13;
            // 
            // Form16
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1465, 571);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form16";
            this.Text = "Form16";
            this.Load += new System.EventHandler(this.Form16_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hOSPITALDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oUTBILLBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOCTORBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private HOSPITALDataSet1 hOSPITALDataSet1;
        private System.Windows.Forms.BindingSource oUTBILLBindingSource;
        private HOSPITALDataSet1TableAdapters.OUT_BILLTableAdapter oUT_BILLTableAdapter;
        private System.Windows.Forms.BindingSource dOCTORBindingSource;
        private HOSPITALDataSet1TableAdapters.DOCTORTableAdapter dOCTORTableAdapter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}