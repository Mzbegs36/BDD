using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BDD
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            hero.Text = comboBox1.Text;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (hero.Text.Contains("Abaddon"))
            {
                str.Text = ("23");
                agi.Text = ("23");
                intel.Text = ("15");
                atk.Text = ("31");
                tipe.Text=("Melee");
            }
            else if (hero.Text.Contains("Alchemist"))
            {
                str.Text = ("25");
                agi.Text = ("22");
                intel.Text = ("25");
                atk.Text = ("28");
                tipe.Text = ("Melee");
            }
            else if (hero.Text.Contains("Anti Mage"))
            {
                str.Text = ("23");
                agi.Text = ("24");
                intel.Text = ("12");
                atk.Text = ("31");
                tipe.Text = ("Melee");
            }
            else if (hero.Text.Contains("Bane"))
            {
                str.Text = ("23");
                agi.Text = ("23");
                intel.Text = ("23");
                atk.Text = ("38");
                tipe.Text = ("Ranged");
            }
            else if (hero.Text.Contains("Batrider"))
            {
                str.Text = ("28");
                agi.Text = ("15");
                intel.Text = ("22");
                atk.Text = ("18");
                tipe.Text = ("Ranged");
            }
            else if (hero.Text.Contains("Beastmaster"))
            {
                str.Text = ("23");
                agi.Text = ("18");
                intel.Text = ("16");
                atk.Text = ("39");
                tipe.Text = ("Melee");
            }
            else if (hero.Text.Contains("Chen"))
            {
                str.Text = ("25");
                agi.Text = ("15");
                intel.Text = ("19");
                atk.Text = ("30");
                tipe.Text = ("Ranged");
            }
            else if (hero.Text.Contains("Clinkz"))
            {
                str.Text = ("14");
                agi.Text = ("22");
                intel.Text = ("18");
                atk.Text = ("18");
                tipe.Text = ("Ranged");
            }
            else if (hero.Text.Contains("Clockwerk"))
            {
                str.Text = ("26");
                agi.Text = ("13");
                intel.Text = ("18");
                atk.Text = ("25");
                tipe.Text = ("Melee");
            }
            else if (hero.Text.Contains("Dazzle"))
            {
                str.Text = ("18");
                agi.Text = ("21");
                intel.Text = ("25");
                atk.Text = ("25");
                tipe.Text = ("Ranged");
            }
            else if (hero.Text.Contains("Disruptor"))
            {
                str.Text = ("21");
                agi.Text = ("15");
                intel.Text = ("21");
                atk.Text = ("31");
                tipe.Text = ("Ranged");
            }
            else if (hero.Text.Contains("Doom"))
            {
                str.Text = ("24");
                agi.Text = ("11");
                intel.Text = ("15");
                atk.Text = ("38");
                tipe.Text = ("Melee");
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
