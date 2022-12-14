using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp2
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        static string SqlCon = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Aya Academy\Desktop\C-Desktop-gorsel-programlama-donem-projesi-Hospital-Management-project\Hastane\WindowsFormsApp2\Database.mdf;Integrated Security=True";
        SqlConnection con = new SqlConnection(SqlCon);
        SqlCommand cmd;
        SqlDataAdapter sda;
        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            labelIndecator1.ForeColor = System.Drawing.Color.Red;
            labelIndecator2.ForeColor = System.Drawing.Color.Black;
            labelIndecator4.ForeColor = System.Drawing.Color.Black;
            pictureBox1.Visible = false;
            panel2.Visible = false;
            panel1.Visible = true;
        }

        private void btnAddDiagnosis_Click(object sender, EventArgs e)
        {
            labelIndecator2.ForeColor = System.Drawing.Color.Red;
            labelIndecator1.ForeColor = System.Drawing.Color.Black;
            labelIndecator4.ForeColor = System.Drawing.Color.Black;
            pictureBox1.Visible = false;
            panel1.Visible = true;
            panel2.Visible= true;
            string query = "select * from Patient";
            con.Open();
            sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            dataGridView1.DataSource = dt;
        }

        private void btnFullHistory_Click(object sender, EventArgs e)
        {
            labelIndecator2.ForeColor = System.Drawing.Color.Black;
            labelIndecator1.ForeColor = System.Drawing.Color.Black;
            labelIndecator4.ForeColor = System.Drawing.Color.Black;
        }

        private void btnHospital_Click(object sender, EventArgs e)
        {
            labelIndecator4.ForeColor = System.Drawing.Color.Red;
            labelIndecator2.ForeColor = System.Drawing.Color.Black;
            labelIndecator1.ForeColor = System.Drawing.Color.Black;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string query="insert into Patient values ('"+txtName.Text+"','"+txtAddress.Text+"','"+txtContact.Text+"','"+txtAge.Text+"','"+comboGender.Text+"','"+txtBlood.Text+"','"+txtAny.Text+"')";
                con.Open();
                cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch(Exception)
            {
                MessageBox.Show("There Is A Problem Please,Check Your Data And Try Again");
            }



                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "update Patient set Symptoms='"+textBox2.Text+"',Diagnosis='"+textBox3.Text+"',Medicines='"+textBox4.Text+"',Ward_Req='"+comboBox1.Text+"',WardType='"+comboBox2.Text+"' where ID='"+textBox1.Text+"'";
            con.Open();
            cmd=new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Updated Succesfully!");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
