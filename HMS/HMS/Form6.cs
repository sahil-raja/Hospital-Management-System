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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox4.Text, "[0-9]"))
            {
                MessageBox.Show("Please enter only string.");
                textBox4.Text = textBox4.Text.Remove(textBox4.Text.Length - 1);
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //DELETE
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-51VM929\\SQLEXPRESS;Initial Catalog=HOSPITAL;Integrated Security=True ");
            con.Open();
            SqlCommand cm;
            int med_id = int.Parse(textBox1.Text);
            string med_name = textBox2.Text;
            string brand = textBox3.Text;
            string description = textBox4.Text;
            int cost = int.Parse(textBox5.Text);

            string query = "DELETE FROM MEDICINE WHERE MEDICINE_ID = '"+med_id+ "' " ;
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

        private void button2_Click(object sender, EventArgs e)
        {
            //UPDATE
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-51VM929\\SQLEXPRESS;Initial Catalog=HOSPITAL;Integrated Security=True ");
            con.Open();
            SqlCommand cm;
            int med_id = int.Parse(textBox1.Text);
            string med_name = textBox2.Text;
            string brand = textBox3.Text;
            string description = textBox4.Text;
            int cost = int.Parse(textBox5.Text);

            string query = "UPDATE MEDICINE SET Med_Name = '" + med_name + "', Brand = '" + brand + "', Description = '" + description + "', Cost =  '" + cost + "' WHERE Medicine_ID = '" + med_id + "' ";
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

        private void button1_Click(object sender, EventArgs e)
        {
            try { 
            //INSERT
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-51VM929\\SQLEXPRESS;Initial Catalog=HOSPITAL;Integrated Security=True ");
            con.Open();
            SqlCommand cm;
            int med_id = int.Parse(textBox1.Text);
            string med_name = textBox2.Text;
            string brand = textBox3.Text;
            string description = textBox4.Text;
            int cost = int.Parse(textBox5.Text);

            string query = "INSERT INTO MEDICINE VALUES('" + med_id + "', '" + med_name + "', '" + brand + "', '" + description + "', '" + cost + "')";
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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox3.Text, "[0-9]"))
            {
                MessageBox.Show("Please enter only string.");
                textBox3.Text = textBox3.Text.Remove(textBox3.Text.Length - 1);
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox5.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                textBox5.Text = textBox5.Text.Remove(textBox5.Text.Length - 1);
            }

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hOSPITALDataSet1.MEDICINE' table. You can move, or remove it, as needed.
            this.mEDICINETableAdapter.Fill(this.hOSPITALDataSet1.MEDICINE);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try { 
            //SEARCH
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-51VM929\\SQLEXPRESS;Initial Catalog=HOSPITAL;Integrated Security=True ");
            con.Open();
            SqlCommand cm;
            string mname = textBox2.Text;
            string brand = textBox3.Text;
            string desc = textBox4.Text;

            string query = "SELECT * FROM MEDICINE WHERE Med_Name = '" + mname + "' OR Brand = '" + brand + "' OR Description = '" + desc + "' ";
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
                    textBox5.Text = reader.GetValue(4).ToString();
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

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try { 
            //SEARCH BY ID
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-51VM929\\SQLEXPRESS;Initial Catalog=HOSPITAL;Integrated Security=True ");
            con.Open();
            SqlCommand cm;
            int med_id = int.Parse(textBox1.Text);

            string query = "SELECT * FROM MEDICINE WHERE MEDICINE_ID = '" + med_id + "' ";
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
                    textBox5.Text = reader.GetValue(4).ToString();
                }
                con.Close();
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try { 
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-51VM929\\SQLEXPRESS;Initial Catalog=HOSPITAL;Integrated Security=True ");
            con.Open();
            string value = textBox6.Text.ToString();
            SqlCommand cm;
            SqlDataAdapter adapter;
            DataTable table;
            string query = "SELECT * FROM MEDICINE WHERE Description = '" + value + "' ";
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

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}
