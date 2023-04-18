
namespace FormTask1
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
            this.label1 = new System.Windows.Forms.Label();
            this.dtagridroles = new System.Windows.Forms.DataGridView();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtagridroles)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(299, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "All Roles";
            // 
            // dtagridroles
            // 
            this.dtagridroles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtagridroles.Location = new System.Drawing.Point(58, 114);
            this.dtagridroles.Name = "dtagridroles";
            this.dtagridroles.RowHeadersWidth = 62;
            this.dtagridroles.RowTemplate.Height = 28;
            this.dtagridroles.Size = new System.Drawing.Size(639, 150);
            this.dtagridroles.TabIndex = 1;
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnInsert.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnInsert.Location = new System.Drawing.Point(58, 324);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(108, 40);
            this.btnInsert.TabIndex = 2;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnUpdate.ForeColor = System.Drawing.Color.Crimson;
            this.btnUpdate.Location = new System.Drawing.Point(227, 324);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(105, 40);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btndelete.ForeColor = System.Drawing.Color.Crimson;
            this.btndelete.Location = new System.Drawing.Point(406, 324);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(100, 40);
            this.btndelete.TabIndex = 4;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnclose.Location = new System.Drawing.Point(579, 324);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(100, 40);
            this.btnclose.TabIndex = 5;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.dtagridroles);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtagridroles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtagridroles;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnclose;
    }
}

