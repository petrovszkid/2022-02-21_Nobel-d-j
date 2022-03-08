using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _2022_02_21_Nobel_díj
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMentes_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < 1 || textBox2.Text.Length < 1 || textBox3.Text.Length < 1 || textBox4.Text.Length < 1) {
                MessageBox.Show("Töltsön ki minden mezőt!", "Mentés", MessageBoxButtons.OK);
                return;
            }
            if (int.Parse(textBox1.Text) < 1989) {
                MessageBox.Show("Hiba! Az évszám nem megfelelő!", "Mentés", MessageBoxButtons.OK);
                return;
            }
            try {
                StreamWriter sw = new StreamWriter("uj_dijazott.txt");
                sw.WriteLine("Év;Név;SzületésHalálozás;Országkód");
                sw.WriteLine($"{textBox1.Text};{textBox2.Text};{textBox3.Text};{textBox4.Text}");
                sw.Close();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
            } catch (Exception ex) {
                MessageBox.Show("Hiba az állomány írásánál!", "Mentés", MessageBoxButtons.OK);
            }
        }
    }
}
