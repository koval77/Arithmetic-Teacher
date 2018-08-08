using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Common;
using System.Data.OleDb;
using System.Drawing.Drawing2D;


namespace UIMathprogram
{
   

    public partial class Form1 : Form
    {
        public static string studname = "";
        public OleDbConnection mycon = new OleDbConnection(); 
        public Form1()
        {
            InitializeComponent();
           mycon.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\UIMathprogram2-Playingwithdatabases\UIMathprogram\Database31.mdb";
            
        }

    

        public void button1_Click(object sender, EventArgs e)
        {
            mycon.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = mycon;
            command.CommandText="select * from Studentformathapp where Login='"+textBox1.Text+"'and Pass='"+textBox2.Text+"'";
            OleDbDataReader reader= command.ExecuteReader();
            int count = 0;
            while (reader.Read())
            {
                count = count + 1;
            }
            if(count==1)
            {
                MessageBox.Show("Login and Password are correct!");
                studname = textBox1.Text;
                Form1 frm1 = new Form1();
                Form2 frm2 = new Form2();
                this.Hide();
                frm2.Show();
            }
            else if(count>1)
            {
                MessageBox.Show("Login and password are duplicated");
            }
            else
            {
                MessageBox.Show("Login or password is not correct");
            }
            mycon.Close();
            //OleDbCommand mycommand = new OleDbCommand("SELECT * FROM Studentformathapp WHERE Login='Kate';",mycon);
            //mycommand.Connection = mycon;
            ////mycommand.CommandText = "select Password from Studentformathapp where Login='Kate'";
            //mycommand.CommandText = "SELECT * FROM Studentformathapp WHERE Login='Kate';";
            //OleDbDataReader Reader= mycommand.ExecuteReader();
            //OleDbDataAdapter adapter = new OleDbDataAdapter(mycommand);
            //Console.WriteLine(mycommand.ToString());
            //Console.WriteLine(Reader.ToString());
            //Database31DataSet pers = new Database31DataSet();
            //Console.WriteLine(pers.Tables[0].Columns[0].);
            ////MessageBox.Show(x);
            //mycon.Close();
            //textBox1.Text = loginTextBox.Text;
            //if ((textBox1.Text == "admin") & (textBox2.Text == "admin"))
            //{
            //    MessageBox.Show("ok,go in");
            //    Form1 frm1 = new Form1();
            //    Form2 frm = new Form2();
            //    frm1.Close();
            //    frm.Show();
            //}
            //else
            //{
            //    MessageBox.Show("No, wrong password");


            //}
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 frm22 = new Form2();
            frm22.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DoBazy basa = new DoBazy();
            basa.Show();
            //TaDataBase baza = new TaDataBase();
            //baza.Show();
        }

        private void studentformathappBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studentformathappBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database31DataSet);

        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle,
                                                                       Color.FromArgb(6, 160, 174),
                                                                       Color.FromArgb(66,12,17),
                                                                       9F))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database31DataSet.Studentformathapp' table. You can move, or remove it, as needed.
            this.studentformathappTableAdapter.Fill(this.database31DataSet.Studentformathapp);

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Helpform helpform = new Helpform();
            helpform.Show();
        }
    }
}
