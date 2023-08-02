namespace AppOlimpiadas
{
    partial class Nacionalidades
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Nacionalidades));
            System.Windows.Forms.Label iDNACIONALIDADLabel;
            System.Windows.Forms.Label nOMBRENACIONALIDADLabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.bddolimpiadasDataSet = new AppOlimpiadas.bddolimpiadasDataSet();
            this.tAB_NACIONALIDADESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tAB_NACIONALIDADESTableAdapter = new AppOlimpiadas.bddolimpiadasDataSetTableAdapters.TAB_NACIONALIDADESTableAdapter();
            this.tableAdapterManager = new AppOlimpiadas.bddolimpiadasDataSetTableAdapters.TableAdapterManager();
            this.tAB_NACIONALIDADESBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.tAB_NACIONALIDADESBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iDNACIONALIDADLabel1 = new System.Windows.Forms.Label();
            this.nOMBRENACIONALIDADTextBox = new System.Windows.Forms.TextBox();
            this.tAB_NACIONALIDADESDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            iDNACIONALIDADLabel = new System.Windows.Forms.Label();
            nOMBRENACIONALIDADLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bddolimpiadasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_NACIONALIDADESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_NACIONALIDADESBindingNavigator)).BeginInit();
            this.tAB_NACIONALIDADESBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_NACIONALIDADESDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(22, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 132);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(iDNACIONALIDADLabel);
            this.groupBox2.Controls.Add(this.iDNACIONALIDADLabel1);
            this.groupBox2.Controls.Add(nOMBRENACIONALIDADLabel);
            this.groupBox2.Controls.Add(this.nOMBRENACIONALIDADTextBox);
            this.groupBox2.Location = new System.Drawing.Point(22, 163);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(435, 136);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tAB_NACIONALIDADESDataGridView);
            this.groupBox3.Location = new System.Drawing.Point(420, 33);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(347, 299);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nacionalidad";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.tAB_NACIONALIDADESBindingSource;
            this.comboBox1.DisplayMember = "NOMBRENACIONALIDAD";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(115, 47);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.ValueMember = "IDNACIONALIDAD";
            // 
            // bddolimpiadasDataSet
            // 
            this.bddolimpiadasDataSet.DataSetName = "bddolimpiadasDataSet";
            this.bddolimpiadasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tAB_NACIONALIDADESBindingSource
            // 
            this.tAB_NACIONALIDADESBindingSource.DataMember = "TAB_NACIONALIDADES";
            this.tAB_NACIONALIDADESBindingSource.DataSource = this.bddolimpiadasDataSet;
            // 
            // tAB_NACIONALIDADESTableAdapter
            // 
            this.tAB_NACIONALIDADESTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TAB_CIUDADESTableAdapter = null;
            this.tableAdapterManager.TAB_DEPORTESTableAdapter = null;
            this.tableAdapterManager.TAB_DEPORTISTASTableAdapter = null;
            this.tableAdapterManager.TAB_EVENTOSTableAdapter = null;
            this.tableAdapterManager.TAB_NACIONALIDADESTableAdapter = this.tAB_NACIONALIDADESTableAdapter;
            this.tableAdapterManager.TAB_RESULTADOSTableAdapter = null;
            this.tableAdapterManager.TAB_SEDESOLIMPICASTableAdapter = null;
            this.tableAdapterManager.TAB_USUARIOSTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AppOlimpiadas.bddolimpiadasDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tAB_NACIONALIDADESBindingNavigator
            // 
            this.tAB_NACIONALIDADESBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tAB_NACIONALIDADESBindingNavigator.BindingSource = this.tAB_NACIONALIDADESBindingSource;
            this.tAB_NACIONALIDADESBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tAB_NACIONALIDADESBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tAB_NACIONALIDADESBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tAB_NACIONALIDADESBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tAB_NACIONALIDADESBindingNavigatorSaveItem});
            this.tAB_NACIONALIDADESBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tAB_NACIONALIDADESBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tAB_NACIONALIDADESBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tAB_NACIONALIDADESBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tAB_NACIONALIDADESBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tAB_NACIONALIDADESBindingNavigator.Name = "tAB_NACIONALIDADESBindingNavigator";
            this.tAB_NACIONALIDADESBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tAB_NACIONALIDADESBindingNavigator.Size = new System.Drawing.Size(786, 27);
            this.tAB_NACIONALIDADESBindingNavigator.TabIndex = 3;
            this.tAB_NACIONALIDADESBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 20);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // tAB_NACIONALIDADESBindingNavigatorSaveItem
            // 
            this.tAB_NACIONALIDADESBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tAB_NACIONALIDADESBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tAB_NACIONALIDADESBindingNavigatorSaveItem.Image")));
            this.tAB_NACIONALIDADESBindingNavigatorSaveItem.Name = "tAB_NACIONALIDADESBindingNavigatorSaveItem";
            this.tAB_NACIONALIDADESBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.tAB_NACIONALIDADESBindingNavigatorSaveItem.Text = "Guardar datos";
            this.tAB_NACIONALIDADESBindingNavigatorSaveItem.Click += new System.EventHandler(this.tAB_NACIONALIDADESBindingNavigatorSaveItem_Click);
            // 
            // iDNACIONALIDADLabel
            // 
            iDNACIONALIDADLabel.AutoSize = true;
            iDNACIONALIDADLabel.Location = new System.Drawing.Point(56, 55);
            iDNACIONALIDADLabel.Name = "iDNACIONALIDADLabel";
            iDNACIONALIDADLabel.Size = new System.Drawing.Size(126, 17);
            iDNACIONALIDADLabel.TabIndex = 0;
            iDNACIONALIDADLabel.Text = "IDNACIONALIDAD:";
            // 
            // iDNACIONALIDADLabel1
            // 
            this.iDNACIONALIDADLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tAB_NACIONALIDADESBindingSource, "IDNACIONALIDAD", true));
            this.iDNACIONALIDADLabel1.Location = new System.Drawing.Point(235, 55);
            this.iDNACIONALIDADLabel1.Name = "iDNACIONALIDADLabel1";
            this.iDNACIONALIDADLabel1.Size = new System.Drawing.Size(100, 23);
            this.iDNACIONALIDADLabel1.TabIndex = 1;
            this.iDNACIONALIDADLabel1.Text = "label2";
            // 
            // nOMBRENACIONALIDADLabel
            // 
            nOMBRENACIONALIDADLabel.AutoSize = true;
            nOMBRENACIONALIDADLabel.Location = new System.Drawing.Point(56, 84);
            nOMBRENACIONALIDADLabel.Name = "nOMBRENACIONALIDADLabel";
            nOMBRENACIONALIDADLabel.Size = new System.Drawing.Size(173, 17);
            nOMBRENACIONALIDADLabel.TabIndex = 2;
            nOMBRENACIONALIDADLabel.Text = "NOMBRENACIONALIDAD:";
            // 
            // nOMBRENACIONALIDADTextBox
            // 
            this.nOMBRENACIONALIDADTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tAB_NACIONALIDADESBindingSource, "NOMBRENACIONALIDAD", true));
            this.nOMBRENACIONALIDADTextBox.Location = new System.Drawing.Point(235, 81);
            this.nOMBRENACIONALIDADTextBox.Name = "nOMBRENACIONALIDADTextBox";
            this.nOMBRENACIONALIDADTextBox.Size = new System.Drawing.Size(100, 22);
            this.nOMBRENACIONALIDADTextBox.TabIndex = 3;
            // 
            // tAB_NACIONALIDADESDataGridView
            // 
            this.tAB_NACIONALIDADESDataGridView.AutoGenerateColumns = false;
            this.tAB_NACIONALIDADESDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tAB_NACIONALIDADESDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.tAB_NACIONALIDADESDataGridView.DataSource = this.tAB_NACIONALIDADESBindingSource;
            this.tAB_NACIONALIDADESDataGridView.Location = new System.Drawing.Point(64, 59);
            this.tAB_NACIONALIDADESDataGridView.Name = "tAB_NACIONALIDADESDataGridView";
            this.tAB_NACIONALIDADESDataGridView.RowTemplate.Height = 24;
            this.tAB_NACIONALIDADESDataGridView.Size = new System.Drawing.Size(249, 220);
            this.tAB_NACIONALIDADESDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IDNACIONALIDAD";
            this.dataGridViewTextBoxColumn1.HeaderText = "IDNACIONALIDAD";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NOMBRENACIONALIDAD";
            this.dataGridViewTextBoxColumn2.HeaderText = "NOMBRENACIONALIDAD";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // Nacionalidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 332);
            this.Controls.Add(this.tAB_NACIONALIDADESBindingNavigator);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Nacionalidades";
            this.Text = "Nacionalidades";
            this.Load += new System.EventHandler(this.Nacionalidades_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bddolimpiadasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_NACIONALIDADESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_NACIONALIDADESBindingNavigator)).EndInit();
            this.tAB_NACIONALIDADESBindingNavigator.ResumeLayout(false);
            this.tAB_NACIONALIDADESBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_NACIONALIDADESDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private bddolimpiadasDataSet bddolimpiadasDataSet;
        private System.Windows.Forms.BindingSource tAB_NACIONALIDADESBindingSource;
        private bddolimpiadasDataSetTableAdapters.TAB_NACIONALIDADESTableAdapter tAB_NACIONALIDADESTableAdapter;
        private bddolimpiadasDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tAB_NACIONALIDADESBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tAB_NACIONALIDADESBindingNavigatorSaveItem;
        private System.Windows.Forms.Label iDNACIONALIDADLabel1;
        private System.Windows.Forms.TextBox nOMBRENACIONALIDADTextBox;
        private System.Windows.Forms.DataGridView tAB_NACIONALIDADESDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}