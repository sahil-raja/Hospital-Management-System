using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS
{
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form11 f11 = new Form11();
            f11.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form9 f9 = new Form9();
            f9.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();
            f7.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form18 f18 = new Form18();
            f18.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form10 f10 = new Form10();
            f10.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            /*Form12 f12 = new Form12();
            f12.Show();
            this.Hide();*/
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form14 f14 = new Form14();
            f14.Show();
            this.Hide();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Form12 f12 = new Form12();
            f12.Show();
            this.Hide();
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Form16 f16 = new Form16();
            f16.Show();
            this.Hide();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Form17 f17 = new Form17();
            f17.Show();
            this.Hide();
        }
    }
}
