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
using System.Configuration;

namespace FormTask1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadRoles();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
           
        }

        public void LoadRoles()
        {
            string cs = ConfigurationManager.ConnectionStrings["B20WinDB"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            string command = "select RoleId,RoleName from Roles";
            SqlCommand cmd = new SqlCommand(command,con);
            SqlDataReader reader=cmd.ExecuteReader();
            List<Roles> roles1 = new List<Roles>();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Roles roles = new Roles();
                    roles.RoleId = (int)reader["RoleId"];
                    roles.RoleName = reader["RoleName"].ToString();
                    roles1.Add(roles);

                }

                con.Close();
                dtagridroles.DataSource = roles1;
            }
            else
            {
                MessageBox.Show("No User Present");
            }

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            
            Form2 f2 = new Form2();
            f2.Show();
        }
    }
}
