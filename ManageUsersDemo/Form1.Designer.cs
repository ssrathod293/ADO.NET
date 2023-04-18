
namespace ManageUsersDemo
{
    partial class Form1
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
            this.lblManageUser = new System.Windows.Forms.Label();
            this.dataViewUsers = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtuserId = new System.Windows.Forms.TextBox();
            this.lblmessage = new System.Windows.Forms.Label();
            this.btnName = new System.Windows.Forms.Button();
            this.lblroles = new System.Windows.Forms.Label();
            this.RolesdataGridView = new System.Windows.Forms.DataGridView();
            this.lnklblManageroles = new System.Windows.Forms.LinkLabel();
            this.lnklableManUser = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataViewUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RolesdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblManageUser
            // 
            this.lblManageUser.AutoSize = true;
            this.lblManageUser.ForeColor = System.Drawing.Color.Crimson;
            this.lblManageUser.Location = new System.Drawing.Point(320, 50);
            this.lblManageUser.Name = "lblManageUser";
            this.lblManageUser.Size = new System.Drawing.Size(113, 20);
            this.lblManageUser.TabIndex = 0;
            this.lblManageUser.Text = "Manage Users";
            // 
            // dataViewUsers
            // 
            this.dataViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataViewUsers.Location = new System.Drawing.Point(27, 182);
            this.dataViewUsers.Name = "dataViewUsers";
            this.dataViewUsers.RowHeadersWidth = 62;
            this.dataViewUsers.RowTemplate.Height = 28;
            this.dataViewUsers.Size = new System.Drawing.Size(867, 263);
            this.dataViewUsers.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(95, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "All Users";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(511, 92);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(99, 37);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "UserId";
            // 
            // txtuserId
            // 
            this.txtuserId.Location = new System.Drawing.Point(167, 97);
            this.txtuserId.Name = "txtuserId";
            this.txtuserId.Size = new System.Drawing.Size(266, 26);
            this.txtuserId.TabIndex = 5;
            // 
            // lblmessage
            // 
            this.lblmessage.AutoSize = true;
            this.lblmessage.Location = new System.Drawing.Point(666, 142);
            this.lblmessage.Name = "lblmessage";
            this.lblmessage.Size = new System.Drawing.Size(0, 20);
            this.lblmessage.TabIndex = 6;
            // 
            // btnName
            // 
            this.btnName.Location = new System.Drawing.Point(646, 92);
            this.btnName.Name = "btnName";
            this.btnName.Size = new System.Drawing.Size(139, 37);
            this.btnName.TabIndex = 7;
            this.btnName.Text = "Get Name";
            this.btnName.UseVisualStyleBackColor = true;
            this.btnName.Click += new System.EventHandler(this.btnName_Click);
            // 
            // lblroles
            // 
            this.lblroles.AutoSize = true;
            this.lblroles.ForeColor = System.Drawing.Color.Crimson;
            this.lblroles.Location = new System.Drawing.Point(33, 448);
            this.lblroles.Name = "lblroles";
            this.lblroles.Size = new System.Drawing.Size(71, 20);
            this.lblroles.TabIndex = 8;
            this.lblroles.Text = "All Roles";
            // 
            // RolesdataGridView
            // 
            this.RolesdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RolesdataGridView.Location = new System.Drawing.Point(27, 482);
            this.RolesdataGridView.Name = "RolesdataGridView";
            this.RolesdataGridView.RowHeadersWidth = 62;
            this.RolesdataGridView.RowTemplate.Height = 28;
            this.RolesdataGridView.Size = new System.Drawing.Size(537, 195);
            this.RolesdataGridView.TabIndex = 9;
            // 
            // lnklblManageroles
            // 
            this.lnklblManageroles.AutoSize = true;
            this.lnklblManageroles.Location = new System.Drawing.Point(583, 482);
            this.lnklblManageroles.Name = "lnklblManageroles";
            this.lnklblManageroles.Size = new System.Drawing.Size(108, 20);
            this.lnklblManageroles.TabIndex = 10;
            this.lnklblManageroles.TabStop = true;
            this.lnklblManageroles.Text = "ManageRoles";
            this.lnklblManageroles.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblManageroles_LinkClicked);
            // 
            // lnklableManUser
            // 
            this.lnklableManUser.AutoSize = true;
            this.lnklableManUser.Location = new System.Drawing.Point(731, 142);
            this.lnklableManUser.Name = "lnklableManUser";
            this.lnklableManUser.Size = new System.Drawing.Size(109, 20);
            this.lnklableManUser.TabIndex = 11;
            this.lnklableManUser.TabStop = true;
            this.lnklableManUser.Text = "ManageUsers";
            this.lnklableManUser.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklableManUser_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 689);
            this.Controls.Add(this.lnklableManUser);
            this.Controls.Add(this.lnklblManageroles);
            this.Controls.Add(this.RolesdataGridView);
            this.Controls.Add(this.lblroles);
            this.Controls.Add(this.btnName);
            this.Controls.Add(this.lblmessage);
            this.Controls.Add(this.txtuserId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataViewUsers);
            this.Controls.Add(this.lblManageUser);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataViewUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RolesdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblManageUser;
        private System.Windows.Forms.DataGridView dataViewUsers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtuserId;
        private System.Windows.Forms.Label lblmessage;
        private System.Windows.Forms.Button btnName;
        private System.Windows.Forms.Label lblroles;
        private System.Windows.Forms.DataGridView RolesdataGridView;
        private System.Windows.Forms.LinkLabel lnklblManageroles;
        private System.Windows.Forms.LinkLabel lnklableManUser;
    }
}

