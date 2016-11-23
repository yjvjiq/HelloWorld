using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gggProj_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int status = 0;
            
            if(status == 0)
            {
                label1.Text = "Hello World!\r\n";

                label2.Text = "I am ggg.";
                //status = 1;
                Form form = new Form();
                form.ShowDialog();
            }
            
            if(status == 1)
            {
                label1.Text = "it's toggled!\r\n";

                label2.Text = "ggg is me.";
                status = 1;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
