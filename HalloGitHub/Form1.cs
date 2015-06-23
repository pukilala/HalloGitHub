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
<<<<<<< HEAD
        private IO_Control io = new IO_Control();
=======
>>>>>>> ff934d240a41a024d77af61abe6f1d5fc22deb23
        int i = 0;
        public Form1()
        {
            InitializeComponent();
<<<<<<< HEAD
  
=======
>>>>>>> ff934d240a41a024d77af61abe6f1d5fc22deb23
        }

        private void button1_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            io.findTest();
            if (i % 2 == 0)
            {
                richTextBox1.Text += "Hallo Git-Hub Welt\n";
                richTextBox1.Text += "Hallo bkwaehcter\n";
                richTextBox1.Text += "Puki Lala\n";
=======
            if (i % 2 == 0)
            {
                richTextBox1.Text += "Hallo Git-Hub Welt";
>>>>>>> ff934d240a41a024d77af61abe6f1d5fc22deb23
                i++;
            }
            else
            {
                richTextBox1.Text += " Hallo Puki Lala\n";
                i++;
<<<<<<< HEAD
            }                     
        }
=======
            }
                
        
        }

>>>>>>> ff934d240a41a024d77af61abe6f1d5fc22deb23
        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }
    }
}
