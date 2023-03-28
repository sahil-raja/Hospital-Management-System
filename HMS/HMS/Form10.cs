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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

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
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox2.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                textBox2.Text = textBox2.Text.Remove(textBox2.Text.Length - 1);
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-51VM929\\SQLEXPRESS;Initial Catalog=HOSPITAL;Integrated Security=True ");
            con.Open();
            try
            { 
            //INSERT
            SqlCommand cm;
            int a_id = int.Parse(textBox1.Text);
            int d_id = int.Parse(textBox2.Text);
            DateTime startt = DateTime.Parse(textBox3.Text);
            DateTime endt = DateTime.Parse(textBox4.Text);
            string p_id = textBox5.Text.ToString();

            string query = "EXEC ADD_APPOINTMENT @App_ID = '" + a_id + "', @Doc_ID = '" + d_id + "', @Start_Time = '" + startt + "', @End_Time = '" + endt + "', @P_CNIC = '" + p_id + "' ";
            //string query = "INSERT INTO APPOINTMENT VALUES('" + a_id + "', '" + d_id + "', '" + startt + "', '" + endt + "', '" + p_id + "')";
            cm = new SqlCommand(query, con);
            cm.ExecuteNonQuery();
            cm.Dispose();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
                throw;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try { 
            //UPDATE
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-51VM929\\SQLEXPRESS;Initial Catalog=HOSPITAL;Integrated Security=True ");
            con.Open();
            SqlCommand cm;
            int a_id = int.Parse(textBox1.Text);
            int d_id = int.Parse(textBox2.Text);
            DateTime startt = DateTime.Parse(textBox3.Text);
            DateTime endt = DateTime.Parse(textBox4.Text);
            string p_id = textBox5.Text;

            string query = "UPDATE APPOINTMENT SET Doc_ID = '" + d_id + "', Start_Time =  '" + startt + "', End_Time = '" + endt + "', '" + p_id + "' WHERE ID = '" + a_id + "' ";
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
            try { 
            //DELETE
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-51VM929\\SQLEXPRESS;Initial Catalog=HOSPITAL;Integrated Security=True ");
            con.Open();
            SqlCommand cm;
            int a_id = int.Parse(textBox1.Text);
            int d_id = int.Parse(textBox2.Text);
            DateTime startt = DateTime.Parse(textBox3.Text);
            DateTime endt = DateTime.Parse(textBox4.Text);
            string p_id = textBox5.Text;

            string query = "DELETE FROM APPOINTMENT WHERE ID = '" + a_id + "' ";
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
            try{ 
            //SEARCH
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-51VM929\\SQLEXPRESS;Initial Catalog=HOSPITAL;Integrated Security=True ");
            con.Open();
            SqlCommand cm;
            int a_id = int.Parse(textBox1.Text);
          
            string query = "SELECT * FROM APPOINTMENT WHERE ID = '" + a_id + "' ";
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

        private void button6_Click(object sender, EventArgs e)
        {
            try { 
            //SEARCH
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-51VM929\\SQLEXPRESS;Initial Catalog=HOSPITAL;Integrated Security=True ");
            con.Open();
            SqlCommand cm;
            string cnic = textBox5.Text;

            string query = "SELECT * FROM APPOINTMENT WHERE P_CNIC = '" + cnic + "' ";
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form10_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hospitalDataSet11.APPOINTMENT' table. You can move, or remove it, as needed.
            this.aPPOINTMENTTableAdapter.Fill(this.hospitalDataSet11.APPOINTMENT);

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            try { 
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-51VM929\\SQLEXPRESS;Initial Catalog=HOSPITAL;Integrated Security=True ");
            con.Open();
            int value = int.Parse(textBox6.Text);
            SqlCommand cm;
            SqlDataAdapter adapter;
            DataTable table;
            string query = "SELECT * FROM APPOINTMENT WHERE Doc_ID = '" + value + "' ";
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

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }
    }
}
