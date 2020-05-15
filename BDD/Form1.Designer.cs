namespace BDD
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
            this.lbllogin = new System.Windows.Forms.Label();
            this.lblreg = new System.Windows.Forms.Label();
            this.btnlog = new System.Windows.Forms.Button();
            this.lblus = new System.Windows.Forms.Label();
            this.lblpass = new System.Windows.Forms.Label();
            this.mtxt1 = new System.Windows.Forms.TextBox();
            this.mtxt2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbllogin
            // 
            this.lbllogin.AutoSize = true;
            this.lbllogin.BackColor = System.Drawing.Color.Black;
            this.lbllogin.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllogin.ForeColor = System.Drawing.Color.White;
            this.lbllogin.Location = new System.Drawing.Point(12, 9);
            this.lbllogin.Name = "lbllogin";
            this.lbllogin.Size = new System.Drawing.Size(59, 23);
            this.lbllogin.TabIndex = 0;
            this.lbllogin.Text = "Login";
            // 
            // lblreg
            // 
            this.lblreg.AutoSize = true;
            this.lblreg.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblreg.ForeColor = System.Drawing.Color.Gray;
            this.lblreg.Location = new System.Drawing.Point(253, 12);
            this.lblreg.Name = "lblreg";
            this.lblreg.Size = new System.Drawing.Size(58, 19);
            this.lblreg.TabIndex = 3;
            this.lblreg.Text = "Register";
            // 
            // btnlog
            // 
            this.btnlog.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnlog.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlog.ForeColor = System.Drawing.Color.White;
            this.btnlog.Location = new System.Drawing.Point(121, 134);
            this.btnlog.Name = "btnlog";
            this.btnlog.Size = new System.Drawing.Size(75, 23);
            this.btnlog.TabIndex = 4;
            this.btnlog.Text = "Login";
            this.btnlog.UseVisualStyleBackColor = false;
            this.btnlog.Click += new System.EventHandler(this.btnlog_Click);
            // 
            // lblus
            // 
            this.lblus.AutoSize = true;
            this.lblus.ForeColor = System.Drawing.Color.White;
            this.lblus.Location = new System.Drawing.Point(32, 79);
            this.lblus.Name = "lblus";
            this.lblus.Size = new System.Drawing.Size(55, 13);
            this.lblus.TabIndex = 5;
            this.lblus.Text = "Username";
            // 
            // lblpass
            // 
            this.lblpass.AutoSize = true;
            this.lblpass.ForeColor = System.Drawing.Color.White;
            this.lblpass.Location = new System.Drawing.Point(32, 102);
            this.lblpass.Name = "lblpass";
            this.lblpass.Size = new System.Drawing.Size(53, 13);
            this.lblpass.TabIndex = 6;
            this.lblpass.Text = "Password";
            // 
            // mtxt1
            // 
            this.mtxt1.Location = new System.Drawing.Point(121, 72);
            this.mtxt1.Name = "mtxt1";
            this.mtxt1.Size = new System.Drawing.Size(100, 20);
            this.mtxt1.TabIndex = 7;
            // 
            // mtxt2
            // 
            this.mtxt2.Location = new System.Drawing.Point(121, 99);
            this.mtxt2.Name = "mtxt2";
            this.mtxt2.Size = new System.Drawing.Size(100, 20);
            this.mtxt2.TabIndex = 8;
            this.mtxt2.UseSystemPasswordChar = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::BDD.Properties.Resources.background_api_png;
            this.ClientSize = new System.Drawing.Size(323, 255);
            this.Controls.Add(this.mtxt2);
            this.Controls.Add(this.mtxt1);
            this.Controls.Add(this.lblpass);
            this.Controls.Add(this.lblus);
            this.Controls.Add(this.btnlog);
            this.Controls.Add(this.lblreg);
            this.Controls.Add(this.lbllogin);
            this.Name = "Form2";
            this.Text = "Belajar Bermain Dota 2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbllogin;
        private System.Windows.Forms.Label lblreg;
        private System.Windows.Forms.Button btnlog;
        private System.Windows.Forms.Label lblus;
        private System.Windows.Forms.Label lblpass;
        private System.Windows.Forms.TextBox mtxt1;
        private System.Windows.Forms.TextBox mtxt2;
    }
}