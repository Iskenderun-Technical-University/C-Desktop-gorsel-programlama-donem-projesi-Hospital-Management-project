using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string pass = txtPassword.Text;

            if (username == "hms" && pass == "pass")
            {
               
                this.Hide();
                Dashboard ds = new Dashboard();
                ds.Show();

            }
            else
            {
                MessageBox.Show("şifree yada kulancı adı yalnış ");
            }
        }
    }
}
