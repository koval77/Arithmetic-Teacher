using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace UIMathprogram
{
    public partial class Certificate : Form
    {
        string stname = Form1.studname;
        private Button printButton = new Button();

        public Certificate()
        {
            InitializeComponent();
            textBox2.Text = DateTime.UtcNow.ToString();
            textBox1.Text = stname;
            printButton.Text = "Print Form";
            //printButton.Click += new EventHandler(printToolStripMenuItem.Click);
            //printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            //this.Controls.Add(printButton);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CaptureScreen();
            printDocument1.Print();
        }
        Bitmap memoryImage;

        private void CaptureScreen()
        {
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);
        }
    }
}
