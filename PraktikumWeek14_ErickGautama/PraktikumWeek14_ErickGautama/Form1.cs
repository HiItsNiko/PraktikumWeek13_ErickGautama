using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PraktikumWeek14_ErickGautama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null || textBox1.Text == "")
            {
                MessageBox.Show("Tolong isi Textbox Terlebih dahulu","",MessageBoxButtons.OK);
            }
            else
            {
                char[] a = textBox1.Text.ToCharArray();
                string balik = "";
                Array.Reverse(a);
                for (int i = 0; i < a.Length; i++) balik += a[i];
                label2.Text = balik;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null || textBox1.Text == "")
            {
                MessageBox.Show("Tolong isi Textbox Terlebih dahulu", "", MessageBoxButtons.OK);
            }
            else
            {
               
                char[] a = textBox1.Text.ToCharArray();
                string isi = "";
                Array.Sort(a);
                for (int i = 0; i < a.Length; i++)
                    if (a[i] >= 'a' && a[i] <= 'z') isi += a[i];
                for (int i = 0; i < a.Length; i++)
                    if (a[i] >= 'A' && a[i] <= 'Z') isi += a[i];
                for (int i = 0; i < a.Length; i++)
                    if (a[i] >= '0' && a[i] <= '9') isi += a[i];
                for (int i = 0; i < a.Length; i++)
                {
                    if ((a[i] >= '!' && a[i] <= '/') || (a[i] >= ':' && a[i] <= '@')) isi += a[i];
                }
                    
                label2.Text = isi;
            }
        }
    }
}
