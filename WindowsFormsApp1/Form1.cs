using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnFullName_Click(object sender, EventArgs e)
        {
            string fname = txtFirstName.Text;
            string lname = txtLastName.Text;

            //string fullName = string.Format($"FullName:{fname} {lname}");
            //MessageBox.Show(fullName);
            //lblresult.Text = string.Format($"Welcome,{fname} {lname}");

            this.Hide();//hide current form
            //we want to open home form
           // Home home = new Home();
            Home home = new Home("Welcome");
            home.Show();
        }
    }
}
