using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace ManageUsersDemo
{
    public partial class ManageUsers : Form
    {
        public ManageUsers()
        {
            InitializeComponent();
        }

        private void bttnload_Click(object sender, EventArgs e)
        {
            int userId = int.Parse(txtuserid.Text);
            string cs = ConfigurationManager.ConnectionStrings["B20WinDB"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("usp_loadUser", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@UserId",userId);
            SqlParameter name = new SqlParameter();
            name.ParameterName = "@Name";
            name.Direction = ParameterDirection.Output;
            name.SqlDbType = SqlDbType.VarChar;
            name.Size = 50;
            cmd.Parameters.Add(name);
            SqlParameter email = new SqlParameter();
            email.ParameterName = "@Email";
            email.Direction = ParameterDirection.Output;
            email.SqlDbType = SqlDbType.VarChar;
            email.Size = 50;
            cmd.Parameters.Add(email);

            SqlParameter password = new SqlParameter();
            password.ParameterName = "@Password";
            password.Direction = ParameterDirection.Output;
            password.SqlDbType = SqlDbType.VarChar;
            password.Size = 50;
            cmd.Parameters.Add(password);

            SqlParameter date = new SqlParameter();
            date.ParameterName = "@RegisteredDate";
            date.Direction = ParameterDirection.Output;
            date.SqlDbType = SqlDbType.VarChar;
            date.Size = 50;
            cmd.Parameters.Add(date);

            con.Open();
            cmd.ExecuteReader();
            txtname.Text = name.Value?.ToString();
            txtemail.Text = email.Value?.ToString();
            txtpassword.Text = password.Value?.ToString();
            txtdate.Text = date.Value?.ToString();
            lblmessage.Text = "User Loaded Sccess";
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btncreate_Click(object sender, EventArgs e)
        {
            int userId = int.Parse(txtuserid.Text);
            string name = txtname.Text.ToString();
            string email = txtemail.Text.ToString();
            string password = txtpassword.Text.ToString();
            string date = txtdate.Text.ToString();
            string cs = ConfigurationManager.ConnectionStrings["B20WinDB"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("usp_CreateUser", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@UserId",userId);
            cmd.Parameters.AddWithValue("@Name",name);
            cmd.Parameters.AddWithValue("@Email",email);
            cmd.Parameters.AddWithValue("@Password",password);
            cmd.Parameters.AddWithValue("@RegisteredDate",date);
            SqlParameter status = new SqlParameter();
            status.ParameterName = "@Status";
            status.Direction = ParameterDirection.Output;
            status.SqlDbType = SqlDbType.Bit;
            cmd.Parameters.Add(status);

            con.Open();
            cmd.ExecuteReader();
            bool issuccess = (bool)status.Value;
            if (issuccess)
            {
                lblmessage.Text = "Role Create Success";
                ClearFields();
            }
            else
            {
                lblmessage.Text = "Role create failed";
            }

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            int userId = int.Parse(txtuserid.Text);
            string name = txtname.Text.ToString();
            string email = txtemail.Text.ToString();
            string password = txtpassword.Text.ToString();
            string date = txtdate.Text.ToString();
            string cs = ConfigurationManager.ConnectionStrings["B20WinDB"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("usp_UpdateUser", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@UserId", userId);
            cmd.Parameters.AddWithValue("@Name", name);
            cmd.Parameters.AddWithValue("@Email", email);
            cmd.Parameters.AddWithValue("@Password", password);
            cmd.Parameters.AddWithValue("@RegisteredDate", date);
            SqlParameter status = new SqlParameter();
            status.ParameterName = "@Status";
            status.Direction = ParameterDirection.Output;
            status.SqlDbType = SqlDbType.Bit;
            cmd.Parameters.Add(status);

            con.Open();
            cmd.ExecuteReader();
            bool issuccess = (bool)status.Value;
            if (issuccess)
            {
                lblmessage.Text = "User update Success";
                ClearFields();
            }
            else
            {
                lblmessage.Text = "User update failed";
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            int userId = int.Parse(txtuserid.Text);
           
            string cs = ConfigurationManager.ConnectionStrings["B20WinDB"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("usp_DeleteUser", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@UserId", userId);
            SqlParameter status = new SqlParameter();
            status.ParameterName = "@Status";
            status.Direction = ParameterDirection.Output;
            status.SqlDbType = SqlDbType.Bit;
            cmd.Parameters.Add(status);

            con.Open();
            cmd.ExecuteReader();
            bool issuccess = (bool)status.Value;
            if (issuccess)
            {
                lblmessage.Text = "User Delete Success";
                ClearFields();
            }
            else
            {
                lblmessage.Text = "User Delete failed";
            }
        }

        private void ClearFields()
        {
           txtuserid.Text = string.Empty;
            txtname.Text = string.Empty;
            txtemail.Text = string.Empty;
            txtpassword.Text = string.Empty;
            txtdate.Text = string.Empty;
          
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
    }
}
