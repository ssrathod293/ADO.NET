
namespace ManageUsersDemo
{
    partial class ManageRoles
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
            this.lblroles = new System.Windows.Forms.Label();
            this.txtRoleName = new System.Windows.Forms.TextBox();
            this.btncreate = new System.Windows.Forms.Button();
            this.lblRoleName = new System.Windows.Forms.Label();
            this.lblmsg = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtroleid = new System.Windows.Forms.TextBox();
            this.btnloadrole = new System.Windows.Forms.Button();
            this.btndisable = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.gridActiveRoles = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gridInactiveRoles = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridActiveRoles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridInactiveRoles)).BeginInit();
            this.SuspendLayout();
            // 
            // lblroles
            // 
            this.lblroles.AutoSize = true;
            this.lblroles.Location = new System.Drawing.Point(261, 27);
            this.lblroles.Name = "lblroles";
            this.lblroles.Size = new System.Drawing.Size(112, 20);
            this.lblroles.TabIndex = 0;
            this.lblroles.Text = "Manage Roles";
            // 
            // txtRoleName
            // 
            this.txtRoleName.Location = new System.Drawing.Point(203, 145);
            this.txtRoleName.Name = "txtRoleName";
            this.txtRoleName.Size = new System.Drawing.Size(265, 26);
            this.txtRoleName.TabIndex = 1;
            // 
            // btncreate
            // 
            this.btncreate.Location = new System.Drawing.Point(184, 186);
            this.btncreate.Name = "btncreate";
            this.btncreate.Size = new System.Drawing.Size(138, 41);
            this.btncreate.TabIndex = 2;
            this.btncreate.Text = "Create";
            this.btncreate.UseVisualStyleBackColor = true;
            this.btncreate.Click += new System.EventHandler(this.btncreate_Click);
            // 
            // lblRoleName
            // 
            this.lblRoleName.AutoSize = true;
            this.lblRoleName.Location = new System.Drawing.Point(80, 151);
            this.lblRoleName.Name = "lblRoleName";
            this.lblRoleName.Size = new System.Drawing.Size(92, 20);
            this.lblRoleName.TabIndex = 3;
            this.lblRoleName.Text = "Role Name:";
            // 
            // lblmsg
            // 
            this.lblmsg.AutoSize = true;
            this.lblmsg.Location = new System.Drawing.Point(592, 130);
            this.lblmsg.Name = "lblmsg";
            this.lblmsg.Size = new System.Drawing.Size(0, 20);
            this.lblmsg.TabIndex = 4;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(352, 186);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(138, 41);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(521, 186);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(138, 41);
            this.btndelete.TabIndex = 6;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Role Id:";
            // 
            // txtroleid
            // 
            this.txtroleid.Location = new System.Drawing.Point(203, 84);
            this.txtroleid.Name = "txtroleid";
            this.txtroleid.Size = new System.Drawing.Size(265, 26);
            this.txtroleid.TabIndex = 8;
            // 
            // btnloadrole
            // 
            this.btnloadrole.Location = new System.Drawing.Point(508, 81);
            this.btnloadrole.Name = "btnloadrole";
            this.btnloadrole.Size = new System.Drawing.Size(113, 27);
            this.btnloadrole.TabIndex = 9;
            this.btnloadrole.Text = "Load Role";
            this.btnloadrole.UseVisualStyleBackColor = true;
            this.btnloadrole.Click += new System.EventHandler(this.btnloadrole_Click);
            // 
            // btndisable
            // 
            this.btndisable.Location = new System.Drawing.Point(759, 138);
            this.btndisable.Name = "btndisable";
            this.btndisable.Size = new System.Drawing.Size(138, 41);
            this.btndisable.TabIndex = 10;
            this.btndisable.Text = "Disable";
            this.btndisable.UseVisualStyleBackColor = true;
            this.btndisable.Click += new System.EventHandler(this.btndisable_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(759, 63);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(138, 41);
            this.btnclear.TabIndex = 11;
            this.btnclear.Text = "Clear Form";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // gridActiveRoles
            // 
            this.gridActiveRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridActiveRoles.Location = new System.Drawing.Point(47, 262);
            this.gridActiveRoles.Name = "gridActiveRoles";
            this.gridActiveRoles.RowHeadersWidth = 62;
            this.gridActiveRoles.RowTemplate.Height = 28;
            this.gridActiveRoles.Size = new System.Drawing.Size(406, 227);
            this.gridActiveRoles.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Active Roles";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(490, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "InActive Roles";
            // 
            // gridInactiveRoles
            // 
            this.gridInactiveRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridInactiveRoles.Location = new System.Drawing.Point(494, 262);
            this.gridInactiveRoles.Name = "gridInactiveRoles";
            this.gridInactiveRoles.RowHeadersWidth = 62;
            this.gridInactiveRoles.RowTemplate.Height = 28;
            this.gridInactiveRoles.Size = new System.Drawing.Size(406, 227);
            this.gridInactiveRoles.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(726, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 34);
            this.button1.TabIndex = 16;
            this.button1.Text = "Move To Trash";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ManageRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 536);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gridInactiveRoles);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gridActiveRoles);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btndisable);
            this.Controls.Add(this.btnloadrole);
            this.Controls.Add(this.txtroleid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblmsg);
            this.Controls.Add(this.lblRoleName);
            this.Controls.Add(this.btncreate);
            this.Controls.Add(this.txtRoleName);
            this.Controls.Add(this.lblroles);
            this.Name = "ManageRoles";
            this.Text = "ManageRoles";
            this.Load += new System.EventHandler(this.ManageRoles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridActiveRoles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridInactiveRoles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblroles;
        private System.Windows.Forms.TextBox txtRoleName;
        private System.Windows.Forms.Button btncreate;
        private System.Windows.Forms.Label lblRoleName;
        private System.Windows.Forms.Label lblmsg;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtroleid;
        private System.Windows.Forms.Button btnloadrole;
        private System.Windows.Forms.Button btndisable;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.DataGridView gridActiveRoles;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView gridInactiveRoles;
        private System.Windows.Forms.Button button1;
    }
}