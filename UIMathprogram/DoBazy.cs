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
            mycon.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=studentDetails1.mdb";
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
                    MessageBox.Show("Record Successfuly Added");
                   // this.Close();
                }
                else
                {
                    MessageBox.Show("Record Fail to Added");
                }
                mycon.Close();
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
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();

            OleDbDataAdapter dAdapter = new OleDbDataAdapter("select * from Studentformathapp", mycon);
            OleDbCommandBuilder cBuilder = new OleDbCommandBuilder(dAdapter);

            DataTable dataTable = new DataTable();
            DataSet ds = new DataSet();

            dAdapter.Fill(dataTable);

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                dataGridView1.Rows.Add(dataTable.Rows[i][0], dataTable.Rows[i][1], dataTable.Rows[i][2], dataTable.Rows[i][3]);
            }
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

        private void exitGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void studentformathappBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
