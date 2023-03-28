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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
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
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox4.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                textBox4.Text = textBox4.Text.Remove(textBox4.Text.Length - 1);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try { 
            //INSERT
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-51VM929\\SQLEXPRESS;Initial Catalog=HOSPITAL;Integrated Security=True ");
            con.Open();
            SqlCommand cm;
            int room_id = int.Parse(textBox1.Text);
            string type = textBox3.Text;
            int cost = int.Parse(textBox4.Text);

            string query = "INSERT INTO MEDICINE VALUES('" + room_id + "', '" + type + "', '" + cost + "')";
            cm = new SqlCommand(query, con);
            cm.ExecuteNonQuery();
            cm.Dispose();
            con.Close();
            textBox1.Clear();
            textBox3.Clear();
            textBox4.Clear();
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
            int room_id = int.Parse(textBox1.Text);
            string type = textBox3.Text;
            int cost = int.Parse(textBox4.Text);

            string query = "UPDATE MEDICINE SET Availability = Room_Type = '" + type + "', Room_Cost = '" + cost + "' WHERE Room_ID = '" + room_id + "'";
            cm = new SqlCommand(query, con);
            cm.ExecuteNonQuery();
            cm.Dispose();
            con.Close();
            textBox1.Clear();
            textBox3.Clear();
            textBox4.Clear();
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
            int room_id = int.Parse(textBox1.Text);

            string query = "DELETE FROM ROOM WHERE Room_ID = '" + room_id + "'";
            cm = new SqlCommand(query, con);
            cm.ExecuteNonQuery();
            cm.Dispose();
            con.Close();
            textBox1.Clear();
            textBox3.Clear();
            textBox4.Clear();
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
            int room_id = int.Parse(textBox1.Text);

            string query = "SELECT * FROM ROOM WHERE Room_ID = '" + room_id + "'";
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
                    textBox3.Text = reader.GetValue(1).ToString();
                    textBox4.Text = reader.GetValue(2).ToString();

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
            textBox1.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }
    }
}
