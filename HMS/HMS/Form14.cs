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
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }

        private void Form14_Load(object sender, EventArgs e)
        {
         

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-51VM929\\SQLEXPRESS;Initial Catalog=HOSPITAL;Integrated Security=True ");
            con.Open();
            string value = textBox1.Text.ToString();
            SqlCommand cm;
            SqlDataAdapter adapter;
            DataTable table;
            string query = "SELECT * FROM IN_BILL WHERE P_CNIC = '" + value + "' ";
            cm = new SqlCommand(query, con);
            adapter = new SqlDataAdapter(cm);
            table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form15 f15 = new Form15();
            f15.Show();
            this.Hide();
        }
    }
}
