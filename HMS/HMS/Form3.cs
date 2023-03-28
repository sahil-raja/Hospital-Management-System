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
    public partial class Form3 : Form
    {
        public Form3()
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
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox4.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                textBox4.Text = textBox4.Text.Remove(textBox4.Text.Length - 1);
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            /*if (System.Text.RegularExpressions.Regex.IsMatch(textBox5.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                textBox5.Text = textBox5.Text.Remove(textBox5.Text.Length - 1);
            }*/
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox6.Text, "[0-9]"))
            {
                MessageBox.Show("Please enter only string.");
                textBox6.Text = textBox6.Text.Remove(textBox6.Text.Length - 1);
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hOSPITALDataSet.EMPLOYEE' table. You can move, or remove it, as needed.
            this.eMPLOYEETableAdapter.Fill(this.hOSPITALDataSet.EMPLOYEE);

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

        private void button1_Click(object sender, EventArgs e)
        {
            try { 
            //INSERT
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-51VM929\\SQLEXPRESS;Initial Catalog=HOSPITAL;Integrated Security=True");
            con.Open();
            SqlCommand cm;
            int e_id = int.Parse(textBox1.Text);
            string fname = textBox2.Text;
            string lname = textBox3.Text;
            string pnum = textBox4.Text;
            DateTime dt = DateTime.Parse(textBox5.Text);
            string etype = textBox6.Text;
            int salary = int.Parse(textBox7.Text);
            int deptId = int.Parse(textBox8.Text);

            string query = "INSERT INTO EMPLOYEE VALUES('" + e_id + "', '" + fname + "', '" + lname + "', '" + pnum + "', '" + dt + "', '" + etype + "', '" + salary + "', '" + deptId + "')";
            cm = new SqlCommand(query, con);
            cm.ExecuteNonQuery();
            cm.Dispose();
            con.Close();
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
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-51VM929\\SQLEXPRESS;Initial Catalog=HOSPITAL;Integrated Security=True");
            con.Open();
            SqlCommand cm;
            int e_id = int.Parse(textBox1.Text);
            string fname = textBox2.Text;
            string lname = textBox3.Text;
            string pnum = textBox4.Text;
            DateTime dt = DateTime.Parse(textBox5.Text);
            string etype = textBox6.Text;
            int salary = int.Parse(textBox7.Text);
            int deptId = int.Parse(textBox8.Text);

            string query = "UPDATE EMPLOYEE SET First_Name = '" + fname + "', Last_Name = '" + lname + "', Phone_No =  '" + pnum + "', Joining_Date =  '" + dt + "', Emp_Type = '" + etype + "', Salary = '" + salary + "', Dept_ID = '" + deptId + "')";
            cm = new SqlCommand(query, con);
            cm.ExecuteNonQuery();
            cm.Dispose();
            con.Close();
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
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-51VM929\\SQLEXPRESS;Initial Catalog=HOSPITAL;Integrated Security=True");
            con.Open();
            SqlCommand cm;
            int e_id = int.Parse(textBox1.Text);
            string fname = textBox2.Text;
            string lname = textBox3.Text;
            string pnum = textBox4.Text;
            DateTime dt = DateTime.Parse(textBox5.Text);
            string etype = textBox6.Text;
            int salary = int.Parse(textBox7.Text);
            int deptId = int.Parse(textBox8.Text);

            string query = "DELETE FROM EMPLOYEE WHERE Emp_ID = '" + e_id + "'";
            cm = new SqlCommand(query, con);
            cm.ExecuteNonQuery();
            cm.Dispose();
            con.Close();
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
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-51VM929\\SQLEXPRESS;Initial Catalog=HOSPITAL;Integrated Security=True ");
                con.Open();
                string value = textBox9.Text.ToString();
                string lname = textBox9.Text.ToString();
                string pnum = textBox9.Text.ToString();
                SqlCommand cm;
                SqlDataAdapter adapter;
                DataTable table;
                string query = "SELECT * FROM EMPLOYEE WHERE First_Name = '" + value + "' OR Last_Name = '" + value + "' OR Phone_No = '" + value + "' ";
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
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-51VM929\\SQLEXPRESS;Initial Catalog=HOSPITAL;Integrated Security=True");
            con.Open();
            SqlCommand cm;
            int e_num = int.Parse(textBox1.Text);
            string query = "SELECT * FROM EMPLOYEE WHERE Emp_ID = '" + e_num + "' ";
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
                    textBox6.Text = reader.GetValue(5).ToString();
                    textBox7.Text = reader.GetValue(6).ToString();
                    textBox8.Text = reader.GetValue(7).ToString();
                }
                con.Close();
            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
