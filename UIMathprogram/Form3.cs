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
    public partial class Form3 : Form
    {
        string isgamestarted = "no";
        int timeLeft = 30;

        public Form3()
        {
            InitializeComponent();
            label16.Text = Form1.studname;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {
          
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            pictureBox1.Image = UIMathprogram.Properties.Resources.how_to_draw_a_spaceship;
            System.Random random = new System.Random();
            int num1, num2, num3, num4, num5, num6, num7, num8;
            res1.Text = "";
            res2.Text = "";
            res3.Text = "";
            res4.Text = "";

            num1 = random.Next(1, 10);
            textBox1.Text = num1.ToString();
            num2 = random.Next(1, 10);
            num3 = random.Next(1, 10);
            num4 = random.Next(1, 10);
            num5 = random.Next(1, 10);
            num6 = random.Next(1, 10);
            num7 = random.Next(1, 10);
            num8 = random.Next(1, 10);
            textBox2.Text = num2.ToString();
            textBox3.Text = num3.ToString();
            textBox4.Text = num4.ToString();
            textBox5.Text = num5.ToString();
            textBox6.Text = num6.ToString();
            textBox7.Text = num7.ToString();
            textBox8.Text = num8.ToString();
            label8.Text = "=";
            label9.Text = "=";
            label10.Text = "=";
            label11.Text = "=";

            timeLeft = 120;
            timeLabel.Text = "120 seconds";
            timer1.Start();
            isgamestarted = "yes";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4();
            Form3 frm3 = new Form3();
            //int number1, number2, result;
            //number1 = Convert.ToInt32(textBox1.Text);
            //number2 = Convert.ToInt32(textBox2.Text);
            //result = number1 + number2;
            //textBox3.Text = result.ToString();
            try
            {
                if ((Convert.ToInt32(res1.Text) == Convert.ToInt32(textBox1.Text) - Convert.ToInt32(textBox2.Text)) &&
                    (Convert.ToInt32(res2.Text) == Convert.ToInt32(textBox3.Text) - Convert.ToInt32(textBox4.Text)) &&
                    (Convert.ToInt32(res3.Text) == Convert.ToInt32(textBox5.Text) - Convert.ToInt32(textBox6.Text)) &&
                    (Convert.ToInt32(res4.Text) == Convert.ToInt32(textBox7.Text) - Convert.ToInt32(textBox8.Text)))
                {
                    pictureBox1.Image = UIMathprogram.Properties.Resources.hb;
                    MessageBox.Show("Your answers are correct!!!", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    timer1.Enabled = false;
                    this.Hide();
                    frm4.Show();
                    frm3.Dispose();

                }
                else
                {
                    pictureBox1.Image = UIMathprogram.Properties.Resources.ab;
                    if (Convert.ToInt32(textBox1.Text) - Convert.ToInt32(textBox2.Text) != (Convert.ToInt32(res1.Text)))
                    { label8.Text = "≠"; }
                    if (Convert.ToInt32(textBox3.Text) - Convert.ToInt32(textBox4.Text) != (Convert.ToInt32(res2.Text)))
                    { label11.Text = "≠"; }
                    if (Convert.ToInt32(textBox5.Text) - Convert.ToInt32(textBox6.Text) != (Convert.ToInt32(res3.Text)))
                    { label10.Text = "≠"; }
                    if (Convert.ToInt32(textBox7.Text) - Convert.ToInt32(textBox8.Text) != (Convert.ToInt32(res4.Text)))
                    { label9.Text = "≠"; }
                    MessageBox.Show("Your answers are incorrect", "Result", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            catch
            {
                MessageBox.Show("Something went wrong. Remember that you can enter numbers only!", "Errot", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            if (timeLeft > 0 && isgamestarted == "yes")
            {
                timer1.Enabled = true;
                timeLeft = timeLeft - 1;
                timeLabel.Text = timeLeft + "seconds";
            }
            else if (isgamestarted == "no") { timer1.Stop(); }
            else
            {
                timer1.Stop();
                timeLabel.Text = "Time is up!";
                MessageBox.Show("You didnt finish in time. Try again");

            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Helpform helpform = new Helpform();
            helpform.Show();
        }
    }
}
