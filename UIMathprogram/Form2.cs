using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace UIMathprogram
{
    public partial class Form2 : Form
    {
        public OleDbConnection mycon = new OleDbConnection();
        string isgamestarted = "no";
        int timeLeft = 30;
        string studname1 = Form1.studname;
        

        public Form2()
        {
            InitializeComponent();
            label16.Text = studname1;
            mycon.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=  D:\UIMathprogram-Playingwithdatabases\UIMathprogram\Database31.mdb";


        }

        private void label2_Click(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void button2_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            Form2 frm2 = new Form2();
            //int number1, number2, result;
            //number1 = Convert.ToInt32(textBox1.Text);
            //number2 = Convert.ToInt32(textBox2.Text);
            //result = number1 + number2;
            //textBox3.Text = result.ToString();
            try
            {
                if ((Convert.ToInt32(res1.Text) == Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox2.Text)) &&
                    (Convert.ToInt32(res2.Text) == Convert.ToInt32(textBox3.Text) + Convert.ToInt32(textBox4.Text)) &&
                    (Convert.ToInt32(res3.Text) == Convert.ToInt32(textBox5.Text) + Convert.ToInt32(textBox6.Text)) &&
                    (Convert.ToInt32(res4.Text) == Convert.ToInt32(textBox7.Text) + Convert.ToInt32(textBox8.Text)))
                {
                    pictureBox1.Image = UIMathprogram.Properties.Resources.hb;
                    MessageBox.Show("All your answers are correct!!!", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    timer1.Enabled = false;
                    
                    this.Hide();
                    frm3.Show();
                    frm2.Dispose();
                   
                }
                else
                {
                    pictureBox1.Image = UIMathprogram.Properties.Resources.ab;
                    MessageBox.Show("Your answers are incorrect", "Result", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    pictureBox1.Image = UIMathprogram.Properties.Resources.ab;
                    if (Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox2.Text)!= (Convert.ToInt32(res1.Text)))
                        { label8.Text = "≠"; }
                    if (Convert.ToInt32(textBox3.Text) + Convert.ToInt32(textBox4.Text) != (Convert.ToInt32(res2.Text)))
                    { label11.Text = "≠"; }
                    if (Convert.ToInt32(textBox5.Text) + Convert.ToInt32(textBox6.Text) != (Convert.ToInt32(res3.Text)))
                    { label10.Text = "≠"; }
                    if (Convert.ToInt32(textBox7.Text) + Convert.ToInt32(textBox8.Text) != (Convert.ToInt32(res4.Text)))
                    { label9.Text = "≠"; }
                }
            }

            catch
            {
                MessageBox.Show("Something went wrong. Remember that you can enter numbers only!", "Errot", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        public void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = UIMathprogram.Properties.Resources.how_to_draw_a_spaceship;
            System.Random random = new System.Random();
            int num1, num2, num3,num4,num5,num6,num7,num8;
            res1.Text = "";
            res2.Text="";
            res3.Text="";
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
            textBox3.Text=num3.ToString();
            textBox4.Text=num4.ToString();
            textBox5.Text=num5.ToString();
            textBox6.Text=num6.ToString();
            textBox7.Text=num7.ToString();
            textBox8.Text=num8.ToString();

            label8.Text = "=";
            label9.Text="=";
            label10.Text="=";
            label11.Text = "=";

            timeLeft = 120;
            timeLabel.Text = "120 seconds";
            timer1.Start();
            isgamestarted = "yes";

         
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            /*   n1.Value--;
                   //Form2 frm22 = new Form2();
                   if (n1.Value == 0)
                   {
                       MessageBox.Show("Time finished. Do it again!");
                   timer1.Stop();


                    }*/
            //n1.Value--;
            timer1.Enabled = false;
            if (timeLeft > 0&&isgamestarted=="yes") {
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

        private static void FromHandle(Action resumeLayout)
        {
            throw new NotImplementedException();
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
     
        }



        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
           // Form3 frm3 = new Form3();
            //frm3.Show();
        }

        private void res1_TextChanged(object sender, EventArgs e)
        {
           
                // Select the whole answer in the NumericUpDown control.
                //TextBox answerBox = sender as TextBox;

                //if (answerBox != null)
                //{
                //    int lengthOfAnswer = answerBox.Text.ToString().Length;
                //    answerBox.Select(0, lengthOfAnswer);
                //}
            
        }

        private void timeLabel_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void exitGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveAndExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            res1.Enabled = false;
             res2.Enabled=false;
             res3.Enabled=false;
             res4.Enabled=false;
         
        }

        private void exitWithoutSavingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            res1.Enabled = true;
            res2.Enabled = true;
            res3.Enabled = true;
            res4.Enabled = true;
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Helpform helpform = new Helpform();
            helpform.Show();
        }
    }
}
