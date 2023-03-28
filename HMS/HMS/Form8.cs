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
    public partial class Form8 : Form
    {
        public Form8()
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
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox2.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                textBox2.Text = textBox2.Text.Remove(textBox2.Text.Length - 1);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox3.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
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
                int stay_id = int.Parse(textBox1.Text);
                string p_cnic = textBox2.Text;
                int room_id = int.Parse(textBox3.Text);
                DateTime startd = DateTime.Parse(textBox4.Text);
                DateTime endd = DateTime.Parse(textBox5.Text);
                int d_id = int.Parse(textBox6.Text);
                int m_id = int.Parse(textBox7.Text);
                int n_id = int.Parse(textBox8.Text);

                string query = "EXEC ADD_STAY @Stay_ID = '" + stay_id + "', @CNIC= '" + p_cnic + "', @R_ID = '" + room_id + "', @S_Date = '" + startd + "', @E_Date = '" + endd + "', @D_ID = '" + d_id + "', @M_ID = '" + m_id + "', @Nurse_ID = '" + n_id + "'";
                //string query = "INSERT INTO STAY VALUES('" + stay_id + "', '" + p_cnic + "', '" + room_id + "', '" + startd + "', '" + endd + "')";
                cm = new SqlCommand(query, con);
                cm.ExecuteNonQuery();
                cm.Dispose();
                con.Close();
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
                textBox7.Clear();
                textBox8.Clear();
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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try { 
            //UPDATE
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-51VM929\\SQLEXPRESS;Initial Catalog=HOSPITAL;Integrated Security=True ");
            con.Open();
            SqlCommand cm;
            int stay_id = int.Parse(textBox1.Text);
            string p_cnic = textBox2.Text;
            int room_id = int.Parse(textBox3.Text);
            DateTime startd = DateTime.Parse(textBox4.Text);
            DateTime endd = DateTime.Parse(textBox5.Text);
            
            string query = "UPDATE STAY SET P_CNIC = '" + p_cnic + "', Room_ID = '" + room_id + "', Start_Date = '" + startd + "', End_Date = '" + endd + "' WHERE Stay_ID = '" + stay_id + "' ";
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
            int stay_id = int.Parse(textBox1.Text);
            string p_cnic = textBox2.Text;
            int room_id = int.Parse(textBox3.Text);
            DateTime startd = DateTime.Parse(textBox4.Text);
            DateTime endd = DateTime.Parse(textBox5.Text);

            string query = "DELETE FROM STAY WHERE Stay_ID = '" + stay_id + "' ";
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
            try { 
            //SEARCH
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-51VM929\\SQLEXPRESS;Initial Catalog=HOSPITAL;Integrated Security=True ");
            con.Open();
            SqlCommand cm;
            int stay_id = int.Parse(textBox1.Text);

            string query = "SELECT * FROM STAY WHERE Stay_ID = '" + stay_id + "' ";
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

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }
    }
}
