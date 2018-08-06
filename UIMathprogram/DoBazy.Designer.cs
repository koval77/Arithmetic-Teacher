namespace UIMathprogram
{
    partial class DoBazy
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.database31DataSet1 = new UIMathprogram.Database31DataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.studentformathappBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database31DataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentformathappTableAdapter = new UIMathprogram.Database31DataSetTableAdapters.StudentformathappTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.passtextBox4 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.logintextBox3 = new System.Windows.Forms.TextBox();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.database31DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentformathappBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database31DataSet1BindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.fillByToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.button2.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button2.Location = new System.Drawing.Point(26, 223);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(233, 53);
            this.button2.TabIndex = 13;
            this.button2.Text = "Add new person";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.button1.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Location = new System.Drawing.Point(67, 273);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 53);
            this.button1.TabIndex = 12;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // database31DataSet1
            // 
            this.database31DataSet1.DataSetName = "Database31DataSet";
            this.database31DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.studentformathappBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(432, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(450, 397);
            this.dataGridView1.TabIndex = 14;
            // 
            // studentformathappBindingSource
            // 
            this.studentformathappBindingSource.DataSource = this.database31DataSet1BindingSource;
            this.studentformathappBindingSource.Position = 0;
            // 
            // database31DataSet1BindingSource
            // 
            this.database31DataSet1BindingSource.DataSource = this.database31DataSet1;
            this.database31DataSet1BindingSource.Position = 0;
            // 
            // studentformathappTableAdapter
            // 
            this.studentformathappTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.passtextBox4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.logintextBox3);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.groupBox1.Location = new System.Drawing.Point(26, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(393, 160);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New user details";
            // 
            // passtextBox4
            // 
            this.passtextBox4.Location = new System.Drawing.Point(181, 132);
            this.passtextBox4.Name = "passtextBox4";
            this.passtextBox4.Size = new System.Drawing.Size(206, 22);
            this.passtextBox4.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 35);
            this.label3.TabIndex = 19;
            this.label3.Text = "Login";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 35);
            this.label4.TabIndex = 20;
            this.label4.Text = "Password";
            // 
            // logintextBox3
            // 
            this.logintextBox3.Location = new System.Drawing.Point(181, 40);
            this.logintextBox3.Name = "logintextBox3";
            this.logintextBox3.Size = new System.Drawing.Size(206, 22);
            this.logintextBox3.TabIndex = 19;
            this.logintextBox3.TextChanged += new System.EventHandler(this.logintextBox3_TextChanged);
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(955, 27);
            this.fillByToolStrip.TabIndex = 17;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(48, 24);
            this.fillByToolStripButton.Text = "FillBy";
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click);
            // 
            // DoBazy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 458);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "DoBazy";
            this.Text = "DoBazy";
            this.Load += new System.EventHandler(this.DoBazy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database31DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentformathappBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database31DataSet1BindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private Database31DataSet database31DataSet1;
        private System.Windows.Forms.BindingSource database31DataSet1BindingSource;
        private System.Windows.Forms.BindingSource studentformathappBindingSource;
        private Database31DataSetTableAdapters.StudentformathappTableAdapter studentformathappTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox logintextBox3;
        private System.Windows.Forms.TextBox passtextBox4;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
    }
}