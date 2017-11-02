using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_v2
{
    
    public partial class Form1 : Form
    {
        double n1;
        double n2;
        double Result;
        string O;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void b1_Click(object sender, EventArgs e)
        {
            if (display.Text == "0" && display.Text != null)
            {
                display.Text = "1";
            }
            else
            {
                display.Text = display.Text + "1";
            }

            
        }

        private void b2_Click(object sender, EventArgs e)
        {
            if (display.Text == "0" && display.Text != null)
            {
                display.Text = "2";
            }
            else
            {
                display.Text += "2";
            }
        }

        private void b3_Click(object sender, EventArgs e)
        {
            if (display.Text == "0" && display.Text != null)
            {
                display.Text = "3";
            }
            else
            {
                display.Text += "3";
            }
        }

        private void b4_Click(object sender, EventArgs e)
        {
            if (display.Text == "0" && display.Text != null)
            {
                display.Text = "4";
            }
            else
            {
                display.Text += "4";
            }
        }

        private void b5_Click(object sender, EventArgs e)
        {
            if (display.Text == "0" && display.Text != null)
            {
                display.Text = "5";
            }
            else
            {
                display.Text += "5";
            }
        }

        private void b6_Click(object sender, EventArgs e)
        {
            if (display.Text == "0" && display.Text != null)
            {
                display.Text = "6";
            }
            else
            {
                display.Text += "6";
            }
        }

        private void b7_Click(object sender, EventArgs e)
        {
            if (display.Text == "0" && display.Text != null)
            {
                display.Text = "7";
            }
            else
            {
                display.Text += "7";
            }
        }

        private void b8_Click(object sender, EventArgs e)
        {
            if (display.Text == "0" && display.Text != null)
            {
                display.Text = "8";
            }
            else
            {
                display.Text += "8";
            }
        }

        private void b9_Click(object sender, EventArgs e)
        {
            if (display.Text == "0" && display.Text != null)
            {
                display.Text = "9";
            }
            else
            {
                display.Text = display.Text += "9";
            }
        }

        private void badd_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble(display.Text);
            display.Text = "0";
            O = "+";
        }

        private void bmin_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble(display.Text);
            display.Text = "0";
            O = "-";
        }

        private void bmul_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble(display.Text);
            display.Text = "0";
            O = "x";
        }

        private void bdiv_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble(display.Text);
            display.Text = "0";
            O = "/";
        }

        private void bperc_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble(display.Text);
            display.Text = "0";
            O = "%";
        }

        private void bclear_Click(object sender, EventArgs e)
        {
            display.Text = "0";
        }

        private void bis_Click(object sender, EventArgs e)
        {
            n2 = Convert.ToDouble(display.Text) ;
            switch (O)
            {
                case "+":
                    Result = n1 + n2;
                    break;
                case "-":
                    Result = n1 - n2;
                    break;
                case "/":
                    Result = n1 / n2;
                    break;
                case "x":
                    Result = n1 * n2;
                    break;
                case "%":
                    Result = n1 / n2 * 100;
                    break;
            }
            display.Text = Convert.ToString(Result);
        }

        private void currencyConverterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Form2 = new Form2();
            Form2.Show();
        }

        private void b0_Click(object sender, EventArgs e)
        {
            if (display.Text == "0" && display.Text != null)
            {
                display.Text = "0";
            }
            else
            {
                display.Text = display.Text + "0";
            }

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
