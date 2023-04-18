
namespace FormTask1
{
    partial class Form2
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
            this.lblroleid = new System.Windows.Forms.Label();
            this.lblrolename = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btninsert = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblroleid
            // 
            this.lblroleid.AutoSize = true;
            this.lblroleid.Location = new System.Drawing.Point(127, 138);
            this.lblroleid.Name = "lblroleid";
            this.lblroleid.Size = new System.Drawing.Size(60, 20);
            this.lblroleid.TabIndex = 0;
            this.lblroleid.Text = "RoleId:";
            // 
            // lblrolename
            // 
            this.lblrolename.AutoSize = true;
            this.lblrolename.Location = new System.Drawing.Point(127, 221);
            this.lblrolename.Name = "lblrolename";
            this.lblrolename.Size = new System.Drawing.Size(96, 20);
            this.lblrolename.TabIndex = 1;
            this.lblrolename.Text = "Role Name :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(242, 138);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(247, 26);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(242, 221);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(247, 26);
            this.textBox2.TabIndex = 3;
            // 
            // btninsert
            // 
            this.btninsert.Location = new System.Drawing.Point(186, 304);
            this.btninsert.Name = "btninsert";
            this.btninsert.Size = new System.Drawing.Size(144, 42);
            this.btninsert.TabIndex = 4;
            this.btninsert.Text = "Insert";
            this.btninsert.UseVisualStyleBackColor = true;
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(469, 304);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(128, 49);
            this.btnclose.TabIndex = 5;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btninsert);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblrolename);
            this.Controls.Add(this.lblroleid);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblroleid;
        private System.Windows.Forms.Label lblrolename;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btninsert;
        private System.Windows.Forms.Button btnclose;
    }
}