namespace BDD
{
    partial class Form3
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
            this.components = new System.ComponentModel.Container();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.hero = new System.Windows.Forms.Label();
            this.database2DataSet1 = new BDD.Database2DataSet1();
            this.database2DataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.str = new System.Windows.Forms.Label();
            this.agi = new System.Windows.Forms.Label();
            this.intel = new System.Windows.Forms.Label();
            this.atk = new System.Windows.Forms.Label();
            this.tipe = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Abaddon",
            "Alchemist",
            "Anti Mage",
            "Bane",
            "Batrider",
            "Beastmaster",
            "Chen",
            "Clinkz",
            "Clockwerk",
            "Dazzle",
            "Disruptor",
            "Doom"});
            this.comboBox1.Location = new System.Drawing.Point(157, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(27, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Hero :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(11, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Base STR    :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(11, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Base AGI     :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(11, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "Base INT      :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(11, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 22);
            this.label5.TabIndex = 5;
            this.label5.Text = "Base Attack :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(10, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 22);
            this.label6.TabIndex = 6;
            this.label6.Text = "Attack Type :";
            // 
            // hero
            // 
            this.hero.AutoSize = true;
            this.hero.BackColor = System.Drawing.Color.Black;
            this.hero.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hero.ForeColor = System.Drawing.Color.DarkRed;
            this.hero.Location = new System.Drawing.Point(12, 76);
            this.hero.Name = "hero";
            this.hero.Size = new System.Drawing.Size(66, 22);
            this.hero.TabIndex = 7;
            this.hero.Text = "HERO";
            // 
            // database2DataSet1
            // 
            this.database2DataSet1.DataSetName = "Database2DataSet1";
            this.database2DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // database2DataSet1BindingSource
            // 
            this.database2DataSet1BindingSource.DataSource = this.database2DataSet1;
            this.database2DataSet1BindingSource.Position = 0;
            // 
            // str
            // 
            this.str.AutoSize = true;
            this.str.BackColor = System.Drawing.Color.Black;
            this.str.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.str.ForeColor = System.Drawing.Color.White;
            this.str.Location = new System.Drawing.Point(135, 120);
            this.str.Name = "str";
            this.str.Size = new System.Drawing.Size(20, 22);
            this.str.TabIndex = 8;
            this.str.Text = "0";
            // 
            // agi
            // 
            this.agi.AutoSize = true;
            this.agi.BackColor = System.Drawing.Color.Black;
            this.agi.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agi.ForeColor = System.Drawing.Color.White;
            this.agi.Location = new System.Drawing.Point(135, 152);
            this.agi.Name = "agi";
            this.agi.Size = new System.Drawing.Size(20, 22);
            this.agi.TabIndex = 9;
            this.agi.Text = "0";
            // 
            // intel
            // 
            this.intel.AutoSize = true;
            this.intel.BackColor = System.Drawing.Color.Black;
            this.intel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intel.ForeColor = System.Drawing.Color.White;
            this.intel.Location = new System.Drawing.Point(135, 185);
            this.intel.Name = "intel";
            this.intel.Size = new System.Drawing.Size(20, 22);
            this.intel.TabIndex = 10;
            this.intel.Text = "0";
            // 
            // atk
            // 
            this.atk.AutoSize = true;
            this.atk.BackColor = System.Drawing.Color.Black;
            this.atk.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.atk.ForeColor = System.Drawing.Color.White;
            this.atk.Location = new System.Drawing.Point(135, 217);
            this.atk.Name = "atk";
            this.atk.Size = new System.Drawing.Size(20, 22);
            this.atk.TabIndex = 11;
            this.atk.Text = "0";
            // 
            // tipe
            // 
            this.tipe.AutoSize = true;
            this.tipe.BackColor = System.Drawing.Color.Black;
            this.tipe.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipe.ForeColor = System.Drawing.Color.White;
            this.tipe.Location = new System.Drawing.Point(135, 249);
            this.tipe.Name = "tipe";
            this.tipe.Size = new System.Drawing.Size(20, 22);
            this.tipe.TabIndex = 12;
            this.tipe.Text = "0";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(299, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "check";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BDD.Properties.Resources.dota_2_logo_0;
            this.ClientSize = new System.Drawing.Size(644, 322);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tipe);
            this.Controls.Add(this.atk);
            this.Controls.Add(this.intel);
            this.Controls.Add(this.agi);
            this.Controls.Add(this.str);
            this.Controls.Add(this.hero);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Name = "Form3";
            this.Text = "Belajar Bermain Dota 2";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label hero;
        private Database2DataSet1 database2DataSet1;
        private System.Windows.Forms.BindingSource database2DataSet1BindingSource;
        private System.Windows.Forms.Label str;
        private System.Windows.Forms.Label agi;
        private System.Windows.Forms.Label intel;
        private System.Windows.Forms.Label atk;
        private System.Windows.Forms.Label tipe;
        private System.Windows.Forms.Button button1;
    }
}