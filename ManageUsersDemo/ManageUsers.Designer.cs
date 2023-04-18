
namespace ManageUsersDemo
{
    partial class ManageUsers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblid = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.lblmessage = new System.Windows.Forms.Label();
            this.lbldate = new System.Windows.Forms.Label();
            this.lblpassword = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.txtuserid = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtdate = new System.Windows.Forms.TextBox();
            this.bttnload = new System.Windows.Forms.Button();
            this.btncreate = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.lblusers = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(107, 44);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(57, 20);
            this.lblid.TabIndex = 0;
            this.lblid.Text = "UserId";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(107, 101);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(51, 20);
            this.lblname.TabIndex = 5;
            this.lblname.Text = "Name";
            // 
            // lblmessage
            // 
            this.lblmessage.AutoSize = true;
            this.lblmessage.Location = new System.Drawing.Point(635, 78);
            this.lblmessage.Name = "lblmessage";
            this.lblmessage.Size = new System.Drawing.Size(0, 20);
            this.lblmessage.TabIndex = 6;
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Location = new System.Drawing.Point(107, 269);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(44, 20);
            this.lbldate.TabIndex = 7;
            this.lbldate.Text = "Date";
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Location = new System.Drawing.Point(107, 198);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(78, 20);
            this.lblpassword.TabIndex = 8;
            this.lblpassword.Text = "Password";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Location = new System.Drawing.Point(107, 148);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(48, 20);
            this.lblemail.TabIndex = 9;
            this.lblemail.Text = "Email";
            // 
            // txtuserid
            // 
            this.txtuserid.Location = new System.Drawing.Point(274, 44);
            this.txtuserid.Name = "txtuserid";
            this.txtuserid.Size = new System.Drawing.Size(239, 26);
            this.txtuserid.TabIndex = 10;
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(274, 198);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(239, 26);
            this.txtpassword.TabIndex = 11;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(274, 148);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(239, 26);
            this.txtemail.TabIndex = 12;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(274, 95);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(239, 26);
            this.txtname.TabIndex = 13;
            // 
            // txtdate
            // 
            this.txtdate.Location = new System.Drawing.Point(274, 269);
            this.txtdate.Name = "txtdate";
            this.txtdate.Size = new System.Drawing.Size(239, 26);
            this.txtdate.TabIndex = 14;
            // 
            // bttnload
            // 
            this.bttnload.Location = new System.Drawing.Point(624, 124);
            this.bttnload.Name = "bttnload";
            this.bttnload.Size = new System.Drawing.Size(115, 34);
            this.bttnload.TabIndex = 15;
            this.bttnload.Text = "Load";
            this.bttnload.UseVisualStyleBackColor = true;
            this.bttnload.Click += new System.EventHandler(this.bttnload_Click);
            // 
            // btncreate
            // 
            this.btncreate.Location = new System.Drawing.Point(139, 336);
            this.btncreate.Name = "btncreate";
            this.btncreate.Size = new System.Drawing.Size(102, 34);
            this.btncreate.TabIndex = 16;
            this.btncreate.Text = "Create";
            this.btncreate.UseVisualStyleBackColor = true;
            this.btncreate.Click += new System.EventHandler(this.btncreate_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(283, 336);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(95, 34);
            this.btnupdate.TabIndex = 17;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(438, 336);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(104, 34);
            this.btndelete.TabIndex = 18;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(624, 183);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(115, 35);
            this.btnClear.TabIndex = 19;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(624, 246);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(115, 43);
            this.btnclose.TabIndex = 20;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // lblusers
            // 
            this.lblusers.AutoSize = true;
            this.lblusers.BackColor = System.Drawing.Color.Coral;
            this.lblusers.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblusers.Location = new System.Drawing.Point(345, 9);
            this.lblusers.Name = "lblusers";
            this.lblusers.Size = new System.Drawing.Size(113, 20);
            this.lblusers.TabIndex = 21;
            this.lblusers.Text = "Manage Users";
            // 
            // ManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblusers);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btncreate);
            this.Controls.Add(this.bttnload);
            this.Controls.Add(this.txtdate);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtuserid);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.lblpassword);
            this.Controls.Add(this.lbldate);
            this.Controls.Add(this.lblmessage);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.lblid);
            this.Name = "ManageUsers";
            this.Text = "ManageUsers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblmessage;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.TextBox txtuserid;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtdate;
        private System.Windows.Forms.Button bttnload;
        private System.Windows.Forms.Button btncreate;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Label lblusers;
    }
}