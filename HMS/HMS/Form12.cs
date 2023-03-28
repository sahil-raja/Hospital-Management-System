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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hOSPITALDataSet1.OUT_BILL' table. You can move, or remove it, as needed.
            this.oUT_BILLTableAdapter.Fill(this.hOSPITALDataSet1.OUT_BILL);
            // TODO: This line of code loads data into the 'hOSPITALDataSet.OUT_BILL_INFO' table. You can move, or remove it, as needed.
            this.oUT_BILL_INFOTableAdapter.Fill(this.hOSPITALDataSet.OUT_BILL_INFO);

        }

 

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-51VM929\\SQLEXPRESS;Initial Catalog=HOSPITAL;Integrated Security=True ");
            con.Open();
            string value = textBox1.Text.ToString();
            SqlCommand cm;
            SqlDataAdapter adapter;
            DataTable table;
            string query = "SELECT * FROM OUT_BILL WHERE P_CNIC = '" + value + "' ";
            cm = new SqlCommand(query, con);
            adapter = new SqlDataAdapter(cm);
            table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;   

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form15 f15 = new Form15();
            f15.Show();
            this.Hide();
        }
    }
}
