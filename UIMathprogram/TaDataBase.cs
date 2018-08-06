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
    public partial class TaDataBase : Form
    {
        public TaDataBase()
        {
            InitializeComponent();
        }

        private void studentformathappBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studentformathappBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database31DataSet);

        }

        private void studentformathappBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.studentformathappBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database31DataSet);

        }

        private void TaDataBase_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database31DataSet.Studentformathapp' table. You can move, or remove it, as needed.
            this.studentformathappTableAdapter.Fill(this.database31DataSet.Studentformathapp);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                studentformathappBindingSource.EndEdit();
                studentformathappTableAdapter.Update(this.database31DataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.studentformathappBindingSource.AddNew();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
