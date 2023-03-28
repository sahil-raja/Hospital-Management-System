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
using Microsoft.Reporting.WinForms;

namespace HMS
{
    public partial class Form16 : Form
    {
        public Form16()
        {
            InitializeComponent();
        }

        private void Form16_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hOSPITALDataSet1.DOCTOR' table. You can move, or remove it, as needed.
            this.dOCTORTableAdapter.Fill(this.hOSPITALDataSet1.DOCTOR);
            // TODO: This line of code loads data into the 'hOSPITALDataSet1.OUT_BILL' table. You can move, or remove it, as needed.
            this.oUT_BILLTableAdapter.Fill(this.hOSPITALDataSet1.OUT_BILL);

          
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-51VM929\\SQLEXPRESS;Initial Catalog=HOSPITAL;Integrated Security=True ");
            con.Open();
            SqlCommand cm;
            string query = "SELECT EMPLOYEE.*, DEPARTMENT.D_Name FROM EMPLOYEE INNER JOIN DEPARTMENT ON EMPLOYEE.Dept_ID = DEPARTMENT.ID";
            cm = new SqlCommand(query, con);
            SqlDataAdapter d = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            d.Fill(dt);
            cm.ExecuteNonQuery();
            cm.Dispose();
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-51VM929\\SQLEXPRESS;Initial Catalog=HOSPITAL;Integrated Security=True ");
            con.Open();
            SqlCommand cm;

            string query = "SELECT EMPLOYEE.First_Name, EMPLOYEE.Last_Name, DEPARTMENT.D_Name, DEPARTMENT_HEAD.* FROM DEPARTMENT_HEAD INNER JOIN EMPLOYEE ON EMPLOYEE.Emp_ID = DEPARTMENT_HEAD.Head_ID INNER JOIN DEPARTMENT ON DEPARTMENT.ID = DEPARTMENT_HEAD.Dept_ID";
            cm = new SqlCommand(query, con);
            SqlDataAdapter d = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            d.Fill(dt);
            cm.ExecuteNonQuery();
            cm.Dispose();
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form15 f15 = new Form15();
            f15.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-51VM929\\SQLEXPRESS;Initial Catalog=HOSPITAL;Integrated Security=True ");
            con.Open();
            SqlCommand cm;

            string query = "SELECT * FROM ROOM";
            cm = new SqlCommand(query, con);
            SqlDataAdapter d = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            d.Fill(dt);
            cm.ExecuteNonQuery();
            cm.Dispose();
            dataGridView1.DataSource = dt;
            con.Close();
        }


        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-51VM929\\SQLEXPRESS;Initial Catalog=HOSPITAL;Integrated Security=True ");
            con.Open();
            SqlCommand cm;

            string query = "SELECT QUALIFICATION.Institute, COUNT(*) AS 'No of Degrees from Uni' FROM QUALIFICATION INNER JOIN EMPLOYEE ON EMPLOYEE.Emp_ID = QUALIFICATION.Employee_ID GROUP BY QUALIFICATION.Institute";
            cm = new SqlCommand(query, con);
            SqlDataAdapter d = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            d.Fill(dt);
            cm.ExecuteNonQuery();
            cm.Dispose();
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-51VM929\\SQLEXPRESS;Initial Catalog=HOSPITAL;Integrated Security=True ");
            con.Open();
            SqlCommand cm;

            string query = "SELECT CONVERT(DATE, QUALIFICATION.D_End_Date) AS 'Graduating Month of Doctors', QUALIFICATION.Degree, COUNT(*) AS 'Num of Doctors' FROM QUALIFICATION   INNER JOIN DOCTOR ON QUALIFICATION.Employee_ID = DOCTOR.Doctor_ID GROUP BY QUALIFICATION.D_End_Date, QUALIFICATION.Degree";
            cm = new SqlCommand(query, con);
            SqlDataAdapter d = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            d.Fill(dt);
            cm.ExecuteNonQuery();
            cm.Dispose();
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-51VM929\\SQLEXPRESS;Initial Catalog=HOSPITAL;Integrated Security=True ");
            con.Open();
            SqlCommand cm;

            string query = "SELECT EMPLOYEE.First_Name, DOCTOR.Doctor_ID, SUM(OUT_BILL.[Doctor Charges]) AS 'Total_Earnings_From_Doctor_On_Appointments' FROM DOCTOR INNER JOIN OUT_BILL ON DOCTOR.Doctor_ID = OUT_BILL.Doc_ID INNER JOIN EMPLOYEE ON EMPLOYEE.Emp_ID = DOCTOR.Doctor_ID GROUP BY DOCTOR.Doctor_ID, EMPLOYEE.First_Name";
            cm = new SqlCommand(query, con);
            SqlDataAdapter d = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            d.Fill(dt);
            cm.ExecuteNonQuery();
            cm.Dispose();
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-51VM929\\SQLEXPRESS;Initial Catalog=HOSPITAL;Integrated Security=True ");
            con.Open();
            SqlCommand cm;

            string query = "SELECT EMPLOYEE.First_Name, DOCTOR.Doctor_ID, SUM(IN_BILL.[Total Doctor Charges]) AS 'Total_Earnings_From_Doctor_On_Surgeries' FROM DOCTOR INNER JOIN IN_BILL ON DOCTOR.Doctor_ID = IN_BILL.Doc_ID INNER JOIN EMPLOYEE ON EMPLOYEE.Emp_ID = DOCTOR.Doctor_ID GROUP BY DOCTOR.Doctor_ID, EMPLOYEE.First_Name";
            cm = new SqlCommand(query, con);
            SqlDataAdapter d = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            d.Fill(dt);
            cm.ExecuteNonQuery();
            cm.Dispose();
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-51VM929\\SQLEXPRESS;Initial Catalog=HOSPITAL;Integrated Security=True ");
            con.Open();
            SqlCommand cm;

            string query = "EXEC APPOINTMENTS_FOR_DATE @Start_Date = '2022-05-06'";
            cm = new SqlCommand(query, con);
            SqlDataAdapter d = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            d.Fill(dt);
            cm.ExecuteNonQuery();
            cm.Dispose();
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-51VM929\\SQLEXPRESS;Initial Catalog=HOSPITAL;Integrated Security=True ");
            con.Open();
            SqlCommand cm;

            string query = "SELECT EMPLOYEE.Dept_ID, DEPARTMENT.D_Name, COUNT(*) AS 'No of Employees' FROM EMPLOYEE INNER JOIN DEPARTMENT ON DEPARTMENT.ID = EMPLOYEE.Dept_ID GROUP BY EMPLOYEE.Dept_ID, DEPARTMENT.D_Name";
            cm = new SqlCommand(query, con);
            SqlDataAdapter d = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            d.Fill(dt);
            cm.ExecuteNonQuery();
            cm.Dispose();
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-51VM929\\SQLEXPRESS;Initial Catalog=HOSPITAL;Integrated Security=True ");
            con.Open();
            SqlCommand cm;

            string query = "SELECT QUALIFICATION.*, EMPLOYEE.First_Name + ' ' + EMPLOYEE.Last_Name AS 'Full Name' FROM DOCTOR INNER JOIN QUALIFICATION ON DOCTOR.Doctor_ID = QUALIFICATION.Employee_ID INNER JOIN EMPLOYEE ON DOCTOR.Doctor_ID = EMPLOYEE.Emp_ID";           
            cm = new SqlCommand(query, con);
            SqlDataAdapter d = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            d.Fill(dt);
            cm.ExecuteNonQuery();
            cm.Dispose();
            dataGridView1.DataSource = dt;
            con.Close();
        }
    }
}
