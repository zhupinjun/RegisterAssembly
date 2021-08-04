using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppDe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var oldtxt = this.richTextBox1.Text;
            if (!string.IsNullOrEmpty(oldtxt))
            {
                oldtxt= "\""+ oldtxt.Replace("\n","\",\"")+"\"";
                this.richTextBox2.Text = oldtxt;
            }
        }
    }
}
