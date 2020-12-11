using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (result.Text == "[EMPTY]")
            {
                result.Text = textBox1.Text;
            }
            else if (result.Text != "[EMPTY]")
            {
                if (textBox1.Text == "DELETE")
                {
                    result.Text = "[EMPTY]";
                }
                else if (textBox1.Text == "SHOWN") result.Show();
                else if (textBox1.Text == "HIDE") result.Hide();
                else if (textBox1.Text == "BLUE") result.ForeColor = Color.Blue;
                else if (textBox1.Text == "RED") result.ForeColor = Color.Red;
                else if (textBox1.Text == "GREEN") result.ForeColor = Color.Green;
                else if (textBox1.Text == "BLACK") result.ForeColor = Color.Black;
                else result.Text = textBox1.Text;
            }
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
           
        }
    }
}
