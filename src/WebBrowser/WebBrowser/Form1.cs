using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBrowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Stop();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(toolStripTextBox1.Text);
        }
    }
}
