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
        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            labelIndecator1.ForeColor = System.Drawing.Color.Red;
            labelIndecator2.ForeColor = System.Drawing.Color.Black;
            labelIndecator3.ForeColor = System.Drawing.Color.Black;
            labelIndecator4.ForeColor = System.Drawing.Color.Black;

            panel1.Visible = true;
        }

        private void btnAddDiagnosis_Click(object sender, EventArgs e)
        {
            labelIndecator2.ForeColor = System.Drawing.Color.Red;
            labelIndecator1.ForeColor = System.Drawing.Color.Black;
            labelIndecator3.ForeColor = System.Drawing.Color.Black;
            labelIndecator4.ForeColor = System.Drawing.Color.Black;
        }

        private void btnFullHistory_Click(object sender, EventArgs e)
        {
            labelIndecator3.ForeColor = System.Drawing.Color.Red;
            labelIndecator2.ForeColor = System.Drawing.Color.Black;
            labelIndecator1.ForeColor = System.Drawing.Color.Black;
            labelIndecator4.ForeColor = System.Drawing.Color.Black;
        }

        private void btnHospital_Click(object sender, EventArgs e)
        {
            labelIndecator4.ForeColor = System.Drawing.Color.Red;
            labelIndecator2.ForeColor = System.Drawing.Color.Black;
            labelIndecator3.ForeColor = System.Drawing.Color.Black;
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
    }
}
