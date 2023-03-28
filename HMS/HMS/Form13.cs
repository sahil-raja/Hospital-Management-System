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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox3.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                textBox3.Text = textBox3.Text.Remove(textBox3.Text.Length - 1);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try { 
            //INSERT
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-51VM929\\SQLEXPRESS;Initial Catalog=HOSPITAL;Integrated Security=True ");
            con.Open();
            SqlCommand cm;
            int in_bill_id = int.Parse(textBox4.Text);
            string p_cnic = textBox6.Text;
            int doc_id = int.Parse(textBox7.Text);
            int room_id = int.Parse(textBox8.Text);
            int med_id = int.Parse(textBox3.Text);

            string query = "INSERT INTO IN_BILL_INFO VALUES('" + in_bill_id + "', '" + p_cnic + "', '" + doc_id + "', '" + room_id + "', '" + med_id + "')";
            cm = new SqlCommand(query, con);
            cm.ExecuteNonQuery();
            cm.Dispose();
            con.Close();
            textBox4.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox3.Clear();
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
            int in_bill_id = int.Parse(textBox4.Text);
            string p_cnic = textBox6.Text;
            int doc_id = int.Parse(textBox7.Text);
            int room_id = int.Parse(textBox8.Text);
            int med_id = int.Parse(textBox3.Text);

            string query = "UPDATE IN_BILL_INFO SET P_CNIC = '" + p_cnic + "',Doc_ID = '" + doc_id + "', Room_ID = '" + room_id + "', Medicine_ID = '" + med_id + "' WHERE In_Bill_ID = '" + in_bill_id + "' ";
            cm = new SqlCommand(query, con);
            cm.ExecuteNonQuery();
            cm.Dispose();
            con.Close();
            textBox4.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox3.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try { 
            //DELETE
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-51VM929\\SQLEXPRESS;Initial Catalog=HOSPITAL;Integrated Security=True ");
            con.Open();
            SqlCommand cm;
            int in_bill_id = int.Parse(textBox4.Text);

            string query = "DELETE FROM IN_BILL_INFO WHERE In_Bill_ID = '" + in_bill_id + "' ";
            cm = new SqlCommand(query, con);
            cm.ExecuteNonQuery();
            cm.Dispose();
            con.Close();
            textBox4.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox3.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try { 
            //SEARCH
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-51VM929\\SQLEXPRESS;Initial Catalog=HOSPITAL;Integrated Security=True ");
            con.Open();
            SqlCommand cm;
            int in_bill_id = int.Parse(textBox4.Text);

            string query = "SELECT * FROM IN_BILL_INFO WHERE In_Bill_ID = '" + in_bill_id + "' ";
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

                    textBox4.Text = reader.GetValue(0).ToString();
                    textBox6.Text = reader.GetValue(1).ToString();
                    textBox7.Text = reader.GetValue(2).ToString();
                    textBox8.Text = reader.GetValue(2).ToString();
                    textBox3.Text = reader.GetValue(2).ToString();

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

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox4.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                textBox4.Text = textBox4.Text.Remove(textBox4.Text.Length - 1);
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox6.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                textBox6.Text = textBox6.Text.Remove(textBox6.Text.Length - 1);
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox7.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                textBox7.Text = textBox7.Text.Remove(textBox7.Text.Length - 1);
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox8.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                textBox8.Text = textBox8.Text.Remove(textBox8.Text.Length - 1);
            }
        }

        private void Form13_Load(object sender, EventArgs e)
        {

        }
    }
}
