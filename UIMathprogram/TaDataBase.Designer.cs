namespace UIMathprogram
{
    partial class TaDataBase
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
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label loginLabel;
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label scoreLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaDataBase));
            this.database31DataSet = new UIMathprogram.Database31DataSet();
            this.studentformathappBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentformathappTableAdapter = new UIMathprogram.Database31DataSetTableAdapters.StudentformathappTableAdapter();
            this.tableAdapterManager = new UIMathprogram.Database31DataSetTableAdapters.TableAdapterManager();
            this.studentformathappBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.studentformathappBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.scoreTextBox = new System.Windows.Forms.TextBox();
            this.studentformathappDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            iDLabel = new System.Windows.Forms.Label();
            loginLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            scoreLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.database31DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentformathappBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentformathappBindingNavigator)).BeginInit();
            this.studentformathappBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentformathappDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(42, 106);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(25, 17);
            iDLabel.TabIndex = 1;
            iDLabel.Text = "ID:";
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Location = new System.Drawing.Point(42, 134);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new System.Drawing.Size(47, 17);
            loginLabel.TabIndex = 3;
            loginLabel.Text = "Login:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(42, 162);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(73, 17);
            passwordLabel.TabIndex = 5;
            passwordLabel.Text = "Password:";
            // 
            // scoreLabel
            // 
            scoreLabel.AutoSize = true;
            scoreLabel.Location = new System.Drawing.Point(42, 190);
            scoreLabel.Name = "scoreLabel";
            scoreLabel.Size = new System.Drawing.Size(49, 17);
            scoreLabel.TabIndex = 7;
            scoreLabel.Text = "Score:";
            // 
            // database31DataSet
            // 
            this.database31DataSet.DataSetName = "Database31DataSet";
            this.database31DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentformathappBindingSource
            // 
            this.studentformathappBindingSource.DataMember = "Studentformathapp";
            this.studentformathappBindingSource.DataSource = this.database31DataSet;
            // 
            // studentformathappTableAdapter
            // 
            this.studentformathappTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.StudentformathappTableAdapter = this.studentformathappTableAdapter;
            this.tableAdapterManager.UpdateOrder = UIMathprogram.Database31DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // studentformathappBindingNavigator
            // 
            this.studentformathappBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.studentformathappBindingNavigator.BindingSource = this.studentformathappBindingSource;
            this.studentformathappBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.studentformathappBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.studentformathappBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.studentformathappBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.studentformathappBindingNavigatorSaveItem});
            this.studentformathappBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.studentformathappBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.studentformathappBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.studentformathappBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.studentformathappBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.studentformathappBindingNavigator.Name = "studentformathappBindingNavigator";
            this.studentformathappBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.studentformathappBindingNavigator.Size = new System.Drawing.Size(844, 27);
            this.studentformathappBindingNavigator.TabIndex = 0;
            this.studentformathappBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // studentformathappBindingNavigatorSaveItem
            // 
            this.studentformathappBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.studentformathappBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("studentformathappBindingNavigatorSaveItem.Image")));
            this.studentformathappBindingNavigatorSaveItem.Name = "studentformathappBindingNavigatorSaveItem";
            this.studentformathappBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.studentformathappBindingNavigatorSaveItem.Text = "Save Data";
            this.studentformathappBindingNavigatorSaveItem.Click += new System.EventHandler(this.studentformathappBindingNavigatorSaveItem_Click_1);
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentformathappBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(121, 103);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(100, 22);
            this.iDTextBox.TabIndex = 2;
            // 
            // loginTextBox
            // 
            this.loginTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentformathappBindingSource, "Login", true));
            this.loginTextBox.Location = new System.Drawing.Point(121, 131);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(100, 22);
            this.loginTextBox.TabIndex = 4;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentformathappBindingSource, "Password", true));
            this.passwordTextBox.Location = new System.Drawing.Point(121, 159);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(100, 22);
            this.passwordTextBox.TabIndex = 6;
            // 
            // scoreTextBox
            // 
            this.scoreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentformathappBindingSource, "Score", true));
            this.scoreTextBox.Location = new System.Drawing.Point(121, 187);
            this.scoreTextBox.Name = "scoreTextBox";
            this.scoreTextBox.Size = new System.Drawing.Size(100, 22);
            this.scoreTextBox.TabIndex = 8;
            // 
            // studentformathappDataGridView
            // 
            this.studentformathappDataGridView.AutoGenerateColumns = false;
            this.studentformathappDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentformathappDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.studentformathappDataGridView.DataSource = this.studentformathappBindingSource;
            this.studentformathappDataGridView.Location = new System.Drawing.Point(361, 103);
            this.studentformathappDataGridView.Name = "studentformathappDataGridView";
            this.studentformathappDataGridView.RowTemplate.Height = 24;
            this.studentformathappDataGridView.Size = new System.Drawing.Size(463, 312);
            this.studentformathappDataGridView.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Login";
            this.dataGridViewTextBoxColumn2.HeaderText = "Login";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Password";
            this.dataGridViewTextBoxColumn3.HeaderText = "Password";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Score";
            this.dataGridViewTextBoxColumn4.HeaderText = "Score";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.button1.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Location = new System.Drawing.Point(106, 338);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 53);
            this.button1.TabIndex = 10;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.button2.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button2.Location = new System.Drawing.Point(65, 288);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(233, 53);
            this.button2.TabIndex = 11;
            this.button2.Text = "Add new person";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(27, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(219, 178);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Details:";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // TaDataBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.studentformathappDataGridView);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(loginLabel);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(passwordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(scoreLabel);
            this.Controls.Add(this.scoreTextBox);
            this.Controls.Add(this.studentformathappBindingNavigator);
            this.Controls.Add(this.groupBox1);
            this.Name = "TaDataBase";
            this.Text = "TaDataBase";
            this.Load += new System.EventHandler(this.TaDataBase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database31DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentformathappBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentformathappBindingNavigator)).EndInit();
            this.studentformathappBindingNavigator.ResumeLayout(false);
            this.studentformathappBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentformathappDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Database31DataSet database31DataSet;
        private System.Windows.Forms.BindingSource studentformathappBindingSource;
        private Database31DataSetTableAdapters.StudentformathappTableAdapter studentformathappTableAdapter;
        private Database31DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator studentformathappBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton studentformathappBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox scoreTextBox;
        private System.Windows.Forms.DataGridView studentformathappDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}