using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TugasWeek14
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void HenshinButton_Click(object sender, EventArgs e)
        {
            char[] teks = textBoxinput.Text.ToCharArray();
            string huruf1 = textBoxhuruf1.Text;
            string huruf2 = textBoxhuruf2.Text;
            int a = henshin(huruf1[0]);
            int b = henshin(huruf2[0]);
            int c = Math.Abs(b - a);
            int d;
            string hasil = "";
            for (int i = 0; i < teks.Length; i++)
            {
                if (Char.IsUpper(teks[i]) || Char.IsLower(teks[i]))
                {
                    d = henshin(teks[i]);
                    d += c;
                    if (d > 26) d -= 26;
                    if (d >= 1 || d <= 26)
                    teks[i] = driver(d);
                }
                hasil += teks[i];
            }
            labelhasil.Text = hasil;
        }
        //because haven't studied Encoding.ASCII.GetBytes(s);
        private int henshin(char c)
        {
            if (c == 'a' || c == 'A') return 1;
            if (c == 'b' || c == 'B') return 2;
            if (c == 'c' || c == 'C') return 3;
            if (c == 'd' || c == 'D') return 4;
            if (c == 'e' || c == 'E') return 5;
            if (c == 'f' || c == 'F') return 6;
            if (c == 'g' || c == 'G') return 7;
            if (c == 'h' || c == 'H') return 8;
            if (c == 'i' || c == 'I') return 9;
            if (c == 'j' || c == 'J') return 10;
            if (c == 'k' || c == 'K') return 11;
            if (c == 'l' || c == 'L') return 12;
            if (c == 'm' || c == 'M') return 13;
            if (c == 'n' || c == 'N') return 14;
            if (c == 'o' || c == 'O') return 15;
            if (c == 'p' || c == 'P') return 16;
            if (c == 'q' || c == 'Q') return 17;
            if (c == 'r' || c == 'R') return 18;
            if (c == 's' || c == 'S') return 19;
            if (c == 't' || c == 'T') return 20;
            if (c == 'u' || c == 'U') return 21;
            if (c == 'v' || c == 'V') return 22;
            if (c == 'w' || c == 'W') return 23;
            if (c == 'x' || c == 'X') return 24;
            if (c == 'y' || c == 'Y') return 25;
            if (c == 'z' || c == 'Z') return 26;
            else return -1;
        }
        private char driver(int c)
        {
            if (c == 1) return 'a';
            if (c == 2) return 'b';
            if (c == 3) return 'c';
            if (c == 4) return 'd';
            if (c == 5) return 'e';
            if (c == 6) return 'f';
            if (c == 7) return 'g';
            if (c == 8) return 'h';
            if (c == 9) return 'i';
            if (c == 10) return 'j';
            if (c == 11) return 'k';
            if (c == 12) return 'l';
            if (c == 13) return 'm';
            if (c == 14) return 'n';
            if (c == 15) return 'o';
            if (c == 16) return 'p';
            if (c == 17) return 'q';
            if (c == 18) return 'r';
            if (c == 19) return 's';
            if (c == 20) return 't';
            if (c == 21) return 'u';
            if (c == 22) return 'v';
            if (c == 23) return 'w';
            if (c == 24) return 'x';
            if (c == 25) return 'y';
            if (c == 26) return 'z';
            else return ' ';
        }
    }
}
