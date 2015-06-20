using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HalloGitHub
{
    public partial class Form1 : Form
    {
        int i = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (i % 2 == 0)
            {
                richTextBox1.Text += "Hallo Git-Hub Welt\n";
                richTextBox1.Text += "Hallo bkwaechter10 Welt\n";
                i++;
            }
            else
            {
                richTextBox1.Text += " Hallo Puki Lala\n";
                i++;
            }
                
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }
    }
}
