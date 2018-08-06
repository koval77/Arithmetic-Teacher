using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIMathprogram
{
    public partial class Certificate : Form
    {
        string stname = Form1.studname;
        public Certificate()
        {
            InitializeComponent();
            textBox2.Text = DateTime.UtcNow.ToString();
            textBox1.Text = stname;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
