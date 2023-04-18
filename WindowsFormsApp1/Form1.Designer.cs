
namespace WindowsFormsApp1
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
            this.lblheading = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.btnFullName = new System.Windows.Forms.Button();
            this.lblresult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblheading
            // 
            this.lblheading.AutoSize = true;
            this.lblheading.ForeColor = System.Drawing.Color.Crimson;
            this.lblheading.Location = new System.Drawing.Point(289, 34);
            this.lblheading.Name = "lblheading";
            this.lblheading.Size = new System.Drawing.Size(127, 20);
            this.lblheading.TabIndex = 0;
            this.lblheading.Text = "V# Technologies";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "FirstName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "LastName";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(315, 94);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(235, 26);
            this.txtFirstName.TabIndex = 3;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(315, 152);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(235, 26);
            this.txtLastName.TabIndex = 4;
            // 
            // btnFullName
            // 
            this.btnFullName.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btnFullName.Location = new System.Drawing.Point(350, 219);
            this.btnFullName.Name = "btnFullName";
            this.btnFullName.Size = new System.Drawing.Size(179, 38);
            this.btnFullName.TabIndex = 5;
            this.btnFullName.Text = "FullName";
            this.btnFullName.UseVisualStyleBackColor = true;
            this.btnFullName.Click += new System.EventHandler(this.btnFullName_Click);
            // 
            // lblresult
            // 
            this.lblresult.AutoSize = true;
            this.lblresult.Location = new System.Drawing.Point(176, 283);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(0, 20);
            this.lblresult.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.btnFullName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblheading);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblheading;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Button btnFullName;
        private System.Windows.Forms.Label lblresult;
    }
}

