using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 using System.Configuration;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ManageUsersDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadUsers();
        }

        void LoadUsers()
        {
            //1-retrieve users from database table
            //2-display/bind data to datagridview
            //1.connection string
            string connectionString = ConfigurationManager.ConnectionStrings["B20WinDB"].ConnectionString;
            //2.connecting to sql server
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            //preparing command
            string command = $"select UserId,Name,Email,'********'as Password,RegisteredDate from Users;select RoleId,RoleName,IsActive from Roles";
                
            SqlCommand cmd = new SqlCommand(command,con);
            //exectuing command
            SqlDataReader reader=cmd.ExecuteReader();
            List<Users> users = new List<Users>();
            List<Roles> roles1 = new List<Roles>();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Users user = new Users();
                    user.UserId =(int) reader["UserId"];
                    user.Name = reader["Name"].ToString();
                    user.Email = reader["Email"].ToString();
                    user.Password = reader["Password"].ToString();
                    user.RegisteredDate =(DateTime)reader["RegisteredDate"];
                    users.Add(user);
                }
                reader.NextResult();
                while (reader.Read())
                {
                    Roles roles = new Roles();
                    roles.RoleId = (int)reader["RoleId"];
                    roles.RoleName = reader["RoleName"].ToString();
                    roles.IsActive = (bool)reader["IsActive"];
                    roles1.Add(roles);
                }
                
            }
             con.Close();
            //  display result
            dataViewUsers.DataSource = users;
            RolesdataGridView.DataSource = roles1;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            #region Recommended code
            //read input user id value from text box
            //retrieve user details from database using ado.net
            //int userId;
            //if (int.TryParse(txtuserId.Text,out userId))
            //{
            //    string cs = ConfigurationManager.ConnectionStrings["B20WinDB"].ConnectionString;
            //    SqlConnection con = new SqlConnection(cs);
            //    con.Open();
            //    string command= $"select UserId,Name,Email,Password,RegisteredDate from Users where UserId={userId}";
            //    SqlCommand cmd = new SqlCommand(command,con);
            //   SqlDataReader reader =cmd.ExecuteReader();
            //    Users user = new Users();
            //    if (reader.HasRows)
            //    {
            //        while (reader.Read())
            //        {

            //            user.UserId = (int)reader["UserId"];
            //            user.Name = reader["Name"].ToString();
            //            user.Email = reader["Email"].ToString();
            //            user.Password = reader["Password"].ToString();
            //            user.RegisteredDate = (DateTime)reader["RegisteredDate"];
            //            dataViewUsers.DataSource = new List<Users>(){ user};
            //            break;

            //        }
            //        lblmessage.Text = "USER FOUND";
            //        con.Close();
            //    }
            //    else
            //    {
            //        lblmessage.Text = "USER NOT EXIST";
            //    }

            //}
            //else
            //{
            //    lblmessage.Text = "INVALID USER ID";
            //}
            #endregion
            try
            {
                string cs = ConfigurationManager.ConnectionStrings["B20WinDB"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);
                
                // string command = $"select UserId,Name,Email,Password,RegisteredDate from Users where UserId=" +txtuserId.Text;
                //string command = $"select UserId,Name,Email,Password,RegisteredDate from Users where UserId=@UserId";
                string command = "usp_GetUserDetails";
                SqlCommand cmd = new SqlCommand(command, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UserId", txtuserId.Text);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                Users user = new Users();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        user.UserId = (int)reader["UserId"];
                        user.Name = reader["Name"].ToString();
                        user.Email = reader["Email"].ToString();
                        user.Password = reader["Password"].ToString();
                        user.RegisteredDate = (DateTime)reader["RegisteredDate"];
                        dataViewUsers.DataSource = new List<Users>() { user };
                        break;

                    }
                    lblmessage.Text = "USER FOUND";
                    con.Close();
                }
                else
                {
                    lblmessage.Text = "USER NOT EXIST";
                }
            }
            catch (Exception ex)
            {
                lblmessage.Text = "SERVER PROBLEM";
                MessageBox.Show(ex.Message);
            }
        }

        private void btnName_Click(object sender, EventArgs e)
        {
            try
            {
                string cs = ConfigurationManager.ConnectionStrings["B20WinDB"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);

                string command = "usp_UserNameByUserId";
                SqlCommand cmd = new SqlCommand(command, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UserId", int.Parse(txtuserId.Text));
                SqlParameter name = new SqlParameter();
                name.ParameterName = "@Name";
                name.Direction = ParameterDirection.Output;
                name.SqlDbType = SqlDbType.VarChar;
                name.Size = 50;
                cmd.Parameters.Add(name);



                con.Open();
                cmd.ExecuteNonQuery();
                lblmessage.Text = $"Name:{name.Value}";
                
            }
            catch (Exception ex)
            {
                lblmessage.Text = "SERVER PROBLEM";
                MessageBox.Show(ex.Message);
            }

        }

        private void lnklblManageroles_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ManageRoles role = new ManageRoles();
            role.Show();
        }

        private void lnklableManUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ManageUsers user = new ManageUsers();
            user.Show();
        }
    }
}
