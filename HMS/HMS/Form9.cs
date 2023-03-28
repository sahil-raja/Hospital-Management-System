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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox2.Text, "[0-9]"))
            {
                MessageBox.Show("Please enter only string.");
                textBox2.Text = textBox2.Text.Remove(textBox2.Text.Length - 1);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox3.Text, "[0-9]"))
            {
                MessageBox.Show("Please enter only string.");
                textBox3.Text = textBox3.Text.Remove(textBox3.Text.Length - 1);
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try 
            {
                //INSERT
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-51VM929\\SQLEXPRESS;Initial Catalog=HOSPITAL;Integrated Security=True ");
                con.Open();
                SqlCommand cm;
                int e_id = int.Parse(textBox1.Text);
                string degree = textBox2.Text;
                string institute = textBox3.Text;
                DateTime startd = DateTime.Parse(textBox4.Text);
                DateTime endd = DateTime.Parse(textBox5.Text);

                string query = "INSERT INTO QUALIFICATION VALUES('" + e_id + "', '" + degree + "', '" + institute + "', '" + startd + "', '" + endd + "')";
                cm = new SqlCommand(query, con);
                cm.ExecuteNonQuery();
                cm.Dispose();
                con.Close();
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try { 
            //UPDATE
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-51VM929\\SQLEXPRESS;Initial Catalog=HOSPITAL;Integrated Security=True ");
            con.Open();
            SqlCommand cm;
            int e_id = int.Parse(textBox1.Text);
            string degree = textBox2.Text;
            string institute = textBox3.Text;
            DateTime startd = DateTime.Parse(textBox4.Text);
            DateTime endd = DateTime.Parse(textBox5.Text);

            string query = "UPDATE QUALIFICATION SET Degree = '" + degree + "', Institute = '" + institute + "', D_Start_Date = '" + startd + "', D_End_Date = '" + endd + "' WHERE Employee_ID = '" + e_id + "' ";
            cm = new SqlCommand(query, con);
            cm.ExecuteNonQuery();
            cm.Dispose();
            con.Close();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                //DELETE
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-51VM929\\SQLEXPRESS;Initial Catalog=HOSPITAL;Integrated Security=True ");
                con.Open();
                SqlCommand cm;
                int e_id = int.Parse(textBox1.Text);
                string degree = textBox2.Text;
                string institute = textBox3.Text;
                DateTime startd = DateTime.Parse(textBox4.Text);
                DateTime endd = DateTime.Parse(textBox5.Text);

                string query = "DELETE FROM QUALIFICATION WHERE Employee_ID = '" + e_id + "' ";
                cm = new SqlCommand(query, con);
                cm.ExecuteNonQuery();
                cm.Dispose();
                con.Close();
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                //SEARCH
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-51VM929\\SQLEXPRESS;Initial Catalog=HOSPITAL;Integrated Security=True ");
                con.Open();
                SqlCommand cm;
                int e_id = int.Parse(textBox1.Text);

                string query = "SELECT * FROM QUALIFICATION WHERE Employee_ID = '" + e_id + "' ";
                cm = new SqlCommand(query, con);
                cm.ExecuteNonQuery();
                cm.Dispose();
                SqlDataReader reader;
                reader = cm.ExecuteReader();
                if (!reader.HasRows)
                {
                    MessageBox.Show("Wrong ID!");
                }
                else
                {
                    while (reader.Read())
                    {

                        textBox1.Text = reader.GetValue(0).ToString();
                        textBox2.Text = reader.GetValue(1).ToString();
                        textBox3.Text = reader.GetValue(2).ToString();
                        textBox4.Text = reader.GetValue(3).ToString();
                        textBox5.Text = reader.GetValue(3).ToString();

                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form15 f15 = new Form15();
            f15.Show();
            this.Hide();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hOSPITALDataSet1.QUALIFICATION' table. You can move, or remove it, as needed.
            this.qUALIFICATIONTableAdapter.Fill(this.hOSPITALDataSet1.QUALIFICATION);

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            try { 
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-51VM929\\SQLEXPRESS;Initial Catalog=HOSPITAL;Integrated Security=True ");
            con.Open();
            string value = textBox6.Text.ToString();
            SqlCommand cm;
            SqlDataAdapter adapter;
            DataTable table;
            string query = "SELECT * FROM QUALIFICATION WHERE Institute = '" + value + "' ";
            cm = new SqlCommand(query, con);
            adapter = new SqlDataAdapter(cm);
            table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }
    }
}
