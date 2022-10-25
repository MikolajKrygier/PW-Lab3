using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pw_Lab3
{
    public partial class Form2 : Form
    {
       
        public Form2()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            Form1.Autortext = textBox2.Text;
            Form1.Tytułtext = textBox1.Text;
        }
    }
}
