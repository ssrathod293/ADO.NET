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
    public partial class ManageRoles : Form
    {
        public ManageRoles()
        {
            InitializeComponent();
            LoadRoles();
        }

        private void LoadRoles()
        {
            #region using sql dataReader
            //string cs = ConfigurationManager.ConnectionStrings["B20WinDB"].ConnectionString;
            //SqlConnection con = new SqlConnection(cs);
            //SqlCommand cmd = new SqlCommand("select RoleId,RoleName,IsActive from Roles", con);
            //con.Open();//open as late as possible..just after prep command
            //SqlDataReader reader = cmd.ExecuteReader();
            //List<Roles> roles = new List<Roles>();
            //if (reader.HasRows)
            //{

            //    while (reader.Read())
            //    {
            //        Roles role= new Roles()
            //        {
            //            RoleId = (int)reader["RoleId"],
            //            RoleName = reader["RoleName"].ToString(),
            //            IsActive =(bool) reader["IsActive"]
            //        };
            //        roles.Add(role);
            //    }

            //    gridRoles.DataSource = roles;
            //    con.Close();
            #endregion
            string cs = ConfigurationManager.ConnectionStrings["B20WinDB"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            string cmdtext = $"select RoleId,RoleName from Roles where IsActive = 1;" +
                             $"select RoleId, RoleName from Roles where IsActive = 0";
            SqlDataAdapter adapter = new SqlDataAdapter(cmdtext, con);
            DataSet roles = new DataSet();
            adapter.Fill(roles);
            //gridRoles.DataSource = roles;
            gridActiveRoles.DataSource = roles.Tables[0];//first table from dataset
            gridInactiveRoles.DataSource = roles.Tables[1];
        }
        private void btncreate_Click(object sender, EventArgs e)
        {
            string roleName = txtRoleName.Text;
            string cs = ConfigurationManager.ConnectionStrings["B20WinDB"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand(DbConstants.spInsertRole, con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@RoleName", roleName);
            SqlParameter status = new SqlParameter();
            status.ParameterName = "@Status";
            status.Direction = ParameterDirection.Output;
            status.SqlDbType = SqlDbType.Bit;
            cmd.Parameters.Add(status);

            con.Open();
            cmd.ExecuteNonQuery();
            //cmd.ExecuteScalar();

            bool issuccess = (bool)status.Value;
            if (issuccess)
            {
                lblmsg.Text = "Role Create Success";
                ClearFields();
            }
            else
            {
                lblmsg.Text = "Role create failed";
            }
        }

        private void btnloadrole_Click(object sender, EventArgs e)
        {
            int roleId = int.Parse(txtroleid.Text);
            string cs = ConfigurationManager.ConnectionStrings["B20WinDB"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("usp_LoadRole", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@RoleId", roleId);
            SqlParameter name = new SqlParameter();
            name.ParameterName = "@RoleName";
            name.Direction = ParameterDirection.Output;
            name.SqlDbType = SqlDbType.VarChar;
            name.Size = 40;

            cmd.Parameters.Add(name);

            con.Open();
            cmd.ExecuteNonQuery();
            txtRoleName.Text = name.Value?.ToString();
            lblmsg.Text = "Role Details Loaded successfully";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int roleId = int.Parse(txtroleid.Text);
            string roleName = txtRoleName.Text;
            string cs = ConfigurationManager.ConnectionStrings["B20WinDB"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("usp_UpdateRole", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@RoleName", roleName);
            cmd.Parameters.AddWithValue("@RoleId", roleId);
            SqlParameter status = new SqlParameter();
            status.ParameterName = "@Status";
            status.Direction = ParameterDirection.Output;
            status.SqlDbType = SqlDbType.Bit;
            cmd.Parameters.Add(status);

            con.Open();
            cmd.ExecuteNonQuery();
            //cmd.ExecuteScalar();

            bool issuccess = (bool)status.Value;
            if (issuccess)
            {
                lblmsg.Text = "Role Update Success";
                ClearFields();
            }
            else
            {
                lblmsg.Text = "Role Update failed";
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            int roleId = int.Parse(txtroleid.Text);
            string cs = ConfigurationManager.ConnectionStrings["B20WinDB"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("usp_DeleteRole", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@RoleId", roleId);
            SqlParameter status = new SqlParameter();
            status.ParameterName = "@Status";
            status.Direction = ParameterDirection.Output;
            status.SqlDbType = SqlDbType.Bit;
            cmd.Parameters.Add(status);

            con.Open();
            cmd.ExecuteNonQuery();
            //cmd.ExecuteScalar();

            bool issuccess = (bool)status.Value;
            if (issuccess)
            {
                lblmsg.Text = "Role Delete Success";
                ClearFields();
            }
            else
            {
                lblmsg.Text = "Role Delete failed";
            }
        }

        private void btndisable_Click(object sender, EventArgs e)
        {
            int roleId = int.Parse(txtroleid.Text);
            string cs = ConfigurationManager.ConnectionStrings["B20WinDB"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("usp_SoftDeleteRole", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@RoleId", roleId);
            SqlParameter status = new SqlParameter();
            status.ParameterName = "@Status";
            status.Direction = ParameterDirection.Output;
            status.SqlDbType = SqlDbType.Bit;
            cmd.Parameters.Add(status);

            con.Open();
            cmd.ExecuteNonQuery();
            //cmd.ExecuteScalar();

            bool issuccess = (bool)status.Value;
            if (issuccess)
            {
                lblmsg.Text = "Role disable Success";
                ClearFields();
            }
            else
            {
                lblmsg.Text = "Role disable failed";
            }
        }

        private void ClearFields()
        {
            txtroleid.Text = string.Empty;
            txtRoleName.Text = string.Empty;
            // lblmsg.Text = string.Empty;
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ManageRoles_Load(object sender, EventArgs e)
        {

        }

        private  void button1_Click(object sender, EventArgs e)
        { //move disabledrole from b20windb to archivedb roles
            string maincs = ConfigurationManager.ConnectionStrings["B20WinDB"].ConnectionString;
            string Archivecs = ConfigurationManager.ConnectionStrings["ArchiveB20WinDB"].ConnectionString;
            SqlConnection Maincon = new SqlConnection(maincs);
            SqlConnection Archcon = new SqlConnection(Archivecs);
            try
            {
                
                SqlCommand cmd = new SqlCommand("select RoleId,RoleName,IsActive from Roles where IsActive=0", Maincon);

                Maincon.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                //SqlConnection Archcon = new SqlConnection(Archivecs);
                Archcon.Open();
                SqlBulkCopy bulkCopy = new SqlBulkCopy(Archcon);
                bulkCopy.DestinationTableName = "Roles";
                bulkCopy.WriteToServer(reader);//data copied to archive db
                Maincon.Close();
                Archcon.Close();
                DeleteArchiveData();//to delete archived data ...non active
                MessageBox.Show("data moved to trash");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {    if(Maincon!=null)
                Maincon.Close();
            if(Archcon!=null)
                Archcon.Close();


            }
         

            
        }
        private void DeleteArchiveData()
        {
            string maincs = ConfigurationManager.ConnectionStrings["B20WinDB"].ConnectionString;
            SqlConnection Maincon = new SqlConnection(maincs);
            SqlCommand deleteCopied = new SqlCommand("delete from Roles where IsActive=0", Maincon);
            Maincon.Open();
            int rowsAffected = deleteCopied.ExecuteNonQuery();
          
        }
    }
}



