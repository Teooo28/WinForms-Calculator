using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void b0_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void b1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void b2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void b3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void b4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void b5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void b6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void b7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void b8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void b9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void bPunct_Click(object sender, EventArgs e)
        {
            textBox1.Text += ",";
        }

        private void bSageata_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Length > 0)
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
        }

        private void bDiv_Click(object sender, EventArgs e)
        {
            textBox1.Text += "/";
        }

        private void bOri_Click(object sender, EventArgs e)
        {
            textBox1.Text += "*";
        }

        private void bMinus_Click(object sender, EventArgs e)
        {
            textBox1.Text += "-";
        }

        private void bPlus_Click(object sender, EventArgs e)
        {
            textBox1.Text += "+";
        }

        private void bMod_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;

            double nr1 = 1, nr2 = 1;
            if (s.IndexOf('-') == 0)
            {
                nr1 = -1;
                s = s.Remove(0, 1);
            }
            int poz = s.IndexOf('-');
            if (poz != -1 && (!(s[poz - 1] >= '0' && s[poz - 1] <= '9') || s[poz + 1] == '-'))
            {
                nr2 = -1;
                s = s.Remove(poz, 1);
            }

            string[] op = s.Split('+', '-', '*', '/', '%');
            nr1 = nr1 * Convert.ToDouble(op[0]);
            nr2 = nr2 * Convert.ToDouble(op[1]);

            int p = 0;
            int p1 = s.IndexOf('-'); if (p1 != -1) p = p1 + 1;
            int p2 = s.IndexOf('+'); if (p2 != -1) p = p2 + 1;
            int p3 = s.IndexOf('*'); if (p3 != -1) p = p3 + 1;
            int p4 = s.IndexOf('/'); if (p4 != -1) p = p4 + 1;

            s = s.Remove(p);
            if (nr1 < 0)
                s = "-" + s;
            textBox1.Text = s + Convert.ToString(nr2 / 100 * nr1);
        }

        private void bRadical_Click(object sender, EventArgs e)
        {
            double nr = Convert.ToDouble(textBox1.Text);
            if (nr >= 0)
                textBox1.Text = Convert.ToString(Math.Sqrt(nr));
            else
                textBox1.Text = "Eroare";
        }

        private void bInvers_Click(object sender, EventArgs e)
        {
            double nr = Convert.ToDouble(textBox1.Text);
            if(nr != 0)
                textBox1.Text = Convert.ToString(1 / nr);
            else
                textBox1.Text = "Eroare";
        }


        private void bCE_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            if (s[s.Length - 1] == '+' || s[s.Length - 1] == '-' || s[s.Length - 1] == '*' || s[s.Length - 1] == '/')
            {
                textBox1.Text = "";
                return;
            }
                
            double nr1 = 1, nr2 = 1;
            if (s.IndexOf('-') == 0)
            {
                nr1 = -1;
                s = s.Remove(0, 1);
            }
            int poz = s.IndexOf('-');
            if (poz != -1 && (!(s[poz - 1] >= '0' && s[poz - 1] <= '9') || s[poz + 1] == '-'))
            {
                nr2 = -1;
                s = s.Remove(poz, 1);
            }

            int p = 0;
            int p1 = s.IndexOf('-'); if (p1 != -1) p = p1 + 1;
            int p2 = s.IndexOf('+'); if (p2 != -1) p = p2 + 1;
            int p3 = s.IndexOf('*'); if (p3 != -1) p = p3 + 1;
            int p4 = s.IndexOf('/'); if (p4 != -1) p = p4 + 1;

            s = s.Remove(p);
            if (nr1 == -1)
                s = "-" + s;
            textBox1.Text = s;
        }

        private void bC_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void bEgal_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            double nr1 = 1, nr2 = 1;
            if(s.IndexOf('-') == 0)
            {
                nr1 = -1;
                s = s.Remove(0, 1);
            }
            int poz = s.IndexOf('-');
            if(poz != -1 && (!(s[poz - 1] >= '0' && s[poz - 1] <='9') || s[poz + 1] == '-'))
            {
                nr2 = -1;
                s = s.Remove(poz, 1);
            }
            string[] op = s.Split('+', '-', '*', '/', '%');
            nr1 = nr1 * Convert.ToDouble(op[0]);
            nr2 = nr2 * Convert.ToDouble(op[1]);
            if (s.IndexOf('+') != -1) textBox1.Text = Convert.ToString(nr1 + nr2);
            else
                if (s.IndexOf('-') != -1) textBox1.Text = Convert.ToString(nr1 - nr2);
                else
                    if (s.IndexOf('*') != -1) textBox1.Text = Convert.ToString(nr1 * nr2);
                    else
                        if (s.IndexOf('/') != -1) textBox1.Text = Convert.ToString(nr1 / nr2);
                        else textBox1.Text = "Eroare!";
                }
    }
}
