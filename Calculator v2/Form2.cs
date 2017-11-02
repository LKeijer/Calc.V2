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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            webBrowser1.Navigate("https://finance.google.com/finance/converter");
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {


        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Form1 = new Form1();
            Form1.Show();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            webBrowser1.Dispose();
        }
    }
}
