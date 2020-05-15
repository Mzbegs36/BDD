using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BDD
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        string [] usernames = { "Mzbegs" , "Ykukuh" };
        string [] passwords = { "123" , "asd" };
        List<string> users = new List<string>();
        List<string> pass = new List<string>();
        private void btnlog_Click(object sender, EventArgs e)
        {
            if (usernames.Contains(mtxt1.Text) && passwords.Contains(mtxt2.Text) && Array.IndexOf(usernames, mtxt1.Text) == Array.IndexOf(passwords, mtxt2.Text))
            {
                Form3 f = new Form3();
                f.ShowDialog();
            }
            else if (users.Contains(mtxt1.Text) && pass.Contains(mtxt2.Text) && Array.IndexOf(users.ToArray(), mtxt1.Text) == Array.IndexOf(pass.ToArray(), mtxt2.Text))
            {
                Form3 f = new Form3();
                f.ShowDialog();
            }
            else
            {
                
                MessageBox.Show("The username or password is incorrect");
            }
           
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("BBD.txt");
            string line = "";
            while ((line = sr.ReadLine()) != null)
            {
                string[] components = line.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                users.Add(components[0]);
                pass.Add(components[1]);
            }
        }
    }
}
