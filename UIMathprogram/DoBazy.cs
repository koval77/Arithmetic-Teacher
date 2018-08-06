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
using System.Drawing.Drawing2D;

namespace UIMathprogram
{
    public partial class DoBazy : Form
    {
        public OleDbConnection mycon = new OleDbConnection();
        private OleDbCommand oleDbCmd = new OleDbCommand();

        public DoBazy()
        {
            InitializeComponent();
            mycon.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\UIMathprogram2-Playingwithdatabases\UIMathprogram\Database31.mdb";
        }

        private void DoBazy_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database31DataSet1.Studentformathapp' table. You can move, or remove it, as needed.
            this.studentformathappTableAdapter.Fill(this.database31DataSet1.Studentformathapp);

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle,
                                                                       Color.FromArgb(6,12,7),
                                                                       Color.FromArgb(6,166,210),
                                                                       90F))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                mycon.Close();
                mycon.Open();
                oleDbCmd.Connection = mycon;
                oleDbCmd.CommandText = "INSERT INTO Studentformathapp (Login,Pass) VALUES ('" + logintextBox3.Text + "','" + passtextBox4.Text + "')";
                int temp = oleDbCmd.ExecuteNonQuery();
                if (temp > 0)
                {
                    logintextBox3.Text = null;
                    passtextBox4.Text = null;
                    //dataGridView1.DataSource = null;
                    //studentformathappBindingSource.DataSource = null;
                    //studentformathappBindingSource.DataSource = database31DataSet1BindingSource;
                    //dataGridView1.DataSource = studentformathappBindingSource;
                    MessageBox.Show("Record Successfuly Added");
                    //dataGridView1.Update();
                    //this.database31DataSet1BindingSource.AddNew();
                    //this.studentformathappBindingSource.AddNew();
                }
                else
                {
                    MessageBox.Show("Record Fail to Added");
                }
                mycon.Close();
                //studentformathappTableAdapter.InsertQuerymoja(loginTextBox.Text, passwordTextBox.Text, 0);
                //studentformathappTableAdapter.InsertQuerymoja(loginTextBox.Text,passwordTextBox.Text,0);
                //studentformathappTableAdapter.Insert("xxx", "xxxx", 3);
                //studentformathappBindingSource.EndEdit();
                //studentformathappTableAdapter.Update(this.database31DataSet);
                //Console.WriteLine(mycon.ConnectionString.ToString());
                //Console.WriteLine(mycon.Container.ToString());
                //Console.WriteLine(mycon.DataSource.ToString());
                //Console.WriteLine(mycon.Database.ToString());
                //Console.WriteLine(mycon.Site);
                //mycon.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw;
            }
        }

        private void logintextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.BeginEdit(true);
            studentformathappBindingSource.ResetBindings(true);
            dataGridView1.DataSource = studentformathappBindingSource;
            dataGridView1.Refresh();
            dataGridView1.Update();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.studentformathappTableAdapter.FillBy(this.database31DataSet1.Studentformathapp);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
