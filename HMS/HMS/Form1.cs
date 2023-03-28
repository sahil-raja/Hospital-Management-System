using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HMS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            //LOG IN
            Form15 f15 = new Form15();
            int e_id = int.Parse(textBox1.Text);
            string passcode = textBox2.Text;
            if (e_id == 1990)
                if (passcode == "1755")
                {
                    f15.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong Password!");
                    textBox2.Clear();
                }
                    
            else
            {
                MessageBox.Show("Wrong Employee Id!");
                textBox1.Clear();
            }
                
            
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
