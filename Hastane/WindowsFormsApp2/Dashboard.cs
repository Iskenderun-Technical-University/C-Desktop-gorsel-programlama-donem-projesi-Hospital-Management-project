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
        {  //Changing The Indecator Colors
            labelIndecator1.ForeColor = System.Drawing.Color.Red;
            labelIndecator2.ForeColor = labelIndecator4.ForeColor = System.Drawing.Color.Black;
           //To Show Add Patient page
            pictureBox1.Visible = pictureBox2.Visible = panel2.Visible = false;
            panel1.Visible = true;
        }

        private void btnAddDiagnosis_Click(object sender, EventArgs e)
        {  //Changing The Indecator Colors
            labelIndecator2.ForeColor = System.Drawing.Color.Red;
            labelIndecator1.ForeColor = labelIndecator4.ForeColor = System.Drawing.Color.Black;
           //To Show More Details About The Patient
            pictureBox1.Visible = pictureBox2.Visible = false;
            panel1.Visible = panel2.Visible = true;
           //To Show The Patient's Data in DGV
            string query = "select * from Patient";
            con.Open();
            sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            dataGridView1.DataSource = dt;
        }

        private void btnHospital_Click(object sender, EventArgs e)
        {  //Changing The Indecator Colors
            labelIndecator4.ForeColor = System.Drawing.Color.Red;
            labelIndecator2.ForeColor = labelIndecator1.ForeColor = System.Drawing.Color.Black;
           //To Show The Hospital Picture
            pictureBox2.Visible = panel1.Visible = panel2.Visible = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //To Close The Entire App when it Clicked
            Application.Exit();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
               //To Add A new Patient
                string query="insert into Patient (Name,Full_Address,Contact,Age,Gender,Blood_Group,Major_Disease) values ('"+txtName.Text+"','"+txtAddress.Text+"','"+txtContact.Text+"','"+txtAge.Text+"','"+comboGender.Text+"','"+txtBlood.Text+"','"+txtAny.Text+"')";
                con.Open();
                cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("The Patient Added Succesfully!");
                //Clear The Data in The TextBoxes
                txtAddress.Clear(); txtAge.Clear(); txtAny.Clear(); txtBlood.Clear(); txtContact.Clear(); txtName.Clear();

            }
            catch
            {
               //To Show if Something get wrong
                MessageBox.Show("There Is A Problem Please,Check Your Data And Try Again");
            }    
        }

        private void button1_Click(object sender, EventArgs e)
        {
           //updating the Database's Table -Patient- to add more information of the patient
            string query = "update Patient set Symptoms='"+textBox2.Text+"',Diagnosis='"+textBox3.Text+"',Medicines='"+textBox4.Text+"',Ward_Req='"+comboBox1.Text+"',WardType='"+comboBox2.Text+"' where ID='"+textBox1.Text+"'";
            con.Open();
            cmd=new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Updated Succesfully!");
            //Clear The Data in The TextBoxes
            textBox2.Clear(); textBox3.Clear(); textBox4.Clear();
        }


        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
           //To Close The Entire App when it Clicked
            Application.Exit();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
           //to send the patient ID from the DGV to the TextBox
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
