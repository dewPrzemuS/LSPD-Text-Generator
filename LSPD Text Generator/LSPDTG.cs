using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LSPD_Text_Generator
{
    public partial class LSPDTG : Form
    {
        public LSPDTG()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            string output = text.Replace("{1}", textBox2.Text).Replace("{2}", textBox3.Text).Replace("{3}", textBox4.Text).Replace("{4}", textBox5.Text).Replace("{5}", textBox6.Text);
            Clipboard.SetText(output);
        }
    }
}
