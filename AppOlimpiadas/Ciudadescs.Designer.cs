namespace AppOlimpiadas
{
    partial class Ciudadescs
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
            System.Windows.Forms.Label iDCIUDADLabel;
            System.Windows.Forms.Label nOMBRECIUDADLabel;
            System.Windows.Forms.Label pAISLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ciudadescs));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbopais = new System.Windows.Forms.ComboBox();
            this.tAB_CIUDADESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bddolimpiadasDataSet = new AppOlimpiadas.bddolimpiadasDataSet();
            this.cbociudad = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.iDCIUDADLabel1 = new System.Windows.Forms.Label();
            this.nOMBRECIUDADTextBox = new System.Windows.Forms.TextBox();
            this.pAISTextBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tAB_CIUDADESDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tAB_CIUDADESTableAdapter = new AppOlimpiadas.bddolimpiadasDataSetTableAdapters.TAB_CIUDADESTableAdapter();
            this.tableAdapterManager = new AppOlimpiadas.bddolimpiadasDataSetTableAdapters.TableAdapterManager();
            this.tAB_CIUDADESBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.tAB_CIUDADESBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            iDCIUDADLabel = new System.Windows.Forms.Label();
            nOMBRECIUDADLabel = new System.Windows.Forms.Label();
            pAISLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_CIUDADESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bddolimpiadasDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_CIUDADESDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_CIUDADESBindingNavigator)).BeginInit();
            this.tAB_CIUDADESBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // iDCIUDADLabel
            // 
            iDCIUDADLabel.AutoSize = true;
            iDCIUDADLabel.Location = new System.Drawing.Point(16, 24);
            iDCIUDADLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            iDCIUDADLabel.Name = "iDCIUDADLabel";
            iDCIUDADLabel.Size = new System.Drawing.Size(62, 13);
            iDCIUDADLabel.TabIndex = 0;
            iDCIUDADLabel.Text = "IDCIUDAD:";
            // 
            // nOMBRECIUDADLabel
            // 
            nOMBRECIUDADLabel.AutoSize = true;
            nOMBRECIUDADLabel.Location = new System.Drawing.Point(14, 52);
            nOMBRECIUDADLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            nOMBRECIUDADLabel.Name = "nOMBRECIUDADLabel";
            nOMBRECIUDADLabel.Size = new System.Drawing.Size(98, 13);
            nOMBRECIUDADLabel.TabIndex = 2;
            nOMBRECIUDADLabel.Text = "NOMBRECIUDAD:";
            // 
            // pAISLabel
            // 
            pAISLabel.AutoSize = true;
            pAISLabel.Location = new System.Drawing.Point(19, 83);
            pAISLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            pAISLabel.Name = "pAISLabel";
            pAISLabel.Size = new System.Drawing.Size(34, 13);
            pAISLabel.TabIndex = 4;
            pAISLabel.Text = "PAIS:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbopais);
            this.groupBox1.Controls.Add(this.cbociudad);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(10, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(284, 99);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // cbopais
            // 
            this.cbopais.DataSource = this.tAB_CIUDADESBindingSource;
            this.cbopais.DisplayMember = "PAIS";
            this.cbopais.FormattingEnabled = true;
            this.cbopais.Location = new System.Drawing.Point(100, 46);
            this.cbopais.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbopais.Name = "cbopais";
            this.cbopais.Size = new System.Drawing.Size(92, 21);
            this.cbopais.TabIndex = 3;
            this.cbopais.ValueMember = "IDCIUDAD";
            // 
            // tAB_CIUDADESBindingSource
            // 
            this.tAB_CIUDADESBindingSource.DataMember = "TAB_CIUDADES";
            this.tAB_CIUDADESBindingSource.DataSource = this.bddolimpiadasDataSet;
            // 
            // bddolimpiadasDataSet
            // 
            this.bddolimpiadasDataSet.DataSetName = "bddolimpiadasDataSet";
            this.bddolimpiadasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbociudad
            // 
            this.cbociudad.DataSource = this.tAB_CIUDADESBindingSource;
            this.cbociudad.DisplayMember = "NOMBRECIUDAD";
            this.cbociudad.FormattingEnabled = true;
            this.cbociudad.Location = new System.Drawing.Point(100, 25);
            this.cbociudad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbociudad.Name = "cbociudad";
            this.cbociudad.Size = new System.Drawing.Size(92, 21);
            this.cbociudad.TabIndex = 2;
            this.cbociudad.ValueMember = "IDCIUDAD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(iDCIUDADLabel);
            this.groupBox2.Controls.Add(this.iDCIUDADLabel1);
            this.groupBox2.Controls.Add(nOMBRECIUDADLabel);
            this.groupBox2.Controls.Add(this.nOMBRECIUDADTextBox);
            this.groupBox2.Controls.Add(pAISLabel);
            this.groupBox2.Controls.Add(this.pAISTextBox);
            this.groupBox2.Location = new System.Drawing.Point(10, 115);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(284, 117);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // iDCIUDADLabel1
            // 
            this.iDCIUDADLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tAB_CIUDADESBindingSource, "IDCIUDAD", true));
            this.iDCIUDADLabel1.Location = new System.Drawing.Point(130, 24);
            this.iDCIUDADLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.iDCIUDADLabel1.Name = "iDCIUDADLabel1";
            this.iDCIUDADLabel1.Size = new System.Drawing.Size(75, 19);
            this.iDCIUDADLabel1.TabIndex = 1;
            this.iDCIUDADLabel1.Text = "label3";
            // 
            // nOMBRECIUDADTextBox
            // 
            this.nOMBRECIUDADTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tAB_CIUDADESBindingSource, "NOMBRECIUDAD", true));
            this.nOMBRECIUDADTextBox.Location = new System.Drawing.Point(130, 50);
            this.nOMBRECIUDADTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nOMBRECIUDADTextBox.Name = "nOMBRECIUDADTextBox";
            this.nOMBRECIUDADTextBox.Size = new System.Drawing.Size(76, 20);
            this.nOMBRECIUDADTextBox.TabIndex = 3;
            // 
            // pAISTextBox
            // 
            this.pAISTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tAB_CIUDADESBindingSource, "PAIS", true));
            this.pAISTextBox.Location = new System.Drawing.Point(132, 79);
            this.pAISTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pAISTextBox.Name = "pAISTextBox";
            this.pAISTextBox.Size = new System.Drawing.Size(76, 20);
            this.pAISTextBox.TabIndex = 5;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tAB_CIUDADESDataGridView);
            this.groupBox3.Location = new System.Drawing.Point(10, 237);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(292, 275);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // tAB_CIUDADESDataGridView
            // 
            this.tAB_CIUDADESDataGridView.AutoGenerateColumns = false;
            this.tAB_CIUDADESDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tAB_CIUDADESDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.tAB_CIUDADESDataGridView.DataSource = this.tAB_CIUDADESBindingSource;
            this.tAB_CIUDADESDataGridView.Location = new System.Drawing.Point(16, 27);
            this.tAB_CIUDADESDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tAB_CIUDADESDataGridView.Name = "tAB_CIUDADESDataGridView";
            this.tAB_CIUDADESDataGridView.RowTemplate.Height = 24;
            this.tAB_CIUDADESDataGridView.Size = new System.Drawing.Size(268, 179);
            this.tAB_CIUDADESDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IDCIUDAD";
            this.dataGridViewTextBoxColumn1.HeaderText = "IDCIUDAD";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NOMBRECIUDAD";
            this.dataGridViewTextBoxColumn2.HeaderText = "NOMBRECIUDAD";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PAIS";
            this.dataGridViewTextBoxColumn3.HeaderText = "PAIS";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // tAB_CIUDADESTableAdapter
            // 
            this.tAB_CIUDADESTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TAB_CIUDADESTableAdapter = this.tAB_CIUDADESTableAdapter;
            this.tableAdapterManager.TAB_DEPORTESTableAdapter = null;
            this.tableAdapterManager.TAB_DEPORTISTASTableAdapter = null;
            this.tableAdapterManager.TAB_EVENTOSTableAdapter = null;
            this.tableAdapterManager.TAB_NACIONALIDADESTableAdapter = null;
            this.tableAdapterManager.TAB_RESULTADOSTableAdapter = null;
            this.tableAdapterManager.TAB_SEDESOLIMPICASTableAdapter = null;
            this.tableAdapterManager.TAB_USUARIOSTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AppOlimpiadas.bddolimpiadasDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tAB_CIUDADESBindingNavigator
            // 
            this.tAB_CIUDADESBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tAB_CIUDADESBindingNavigator.BindingSource = this.tAB_CIUDADESBindingSource;
            this.tAB_CIUDADESBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tAB_CIUDADESBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tAB_CIUDADESBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tAB_CIUDADESBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tAB_CIUDADESBindingNavigatorSaveItem});
            this.tAB_CIUDADESBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tAB_CIUDADESBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tAB_CIUDADESBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tAB_CIUDADESBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tAB_CIUDADESBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tAB_CIUDADESBindingNavigator.Name = "tAB_CIUDADESBindingNavigator";
            this.tAB_CIUDADESBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tAB_CIUDADESBindingNavigator.Size = new System.Drawing.Size(379, 27);
            this.tAB_CIUDADESBindingNavigator.TabIndex = 3;
            this.tAB_CIUDADESBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 24);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
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
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(38, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // tAB_CIUDADESBindingNavigatorSaveItem
            // 
            this.tAB_CIUDADESBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tAB_CIUDADESBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tAB_CIUDADESBindingNavigatorSaveItem.Image")));
            this.tAB_CIUDADESBindingNavigatorSaveItem.Name = "tAB_CIUDADESBindingNavigatorSaveItem";
            this.tAB_CIUDADESBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.tAB_CIUDADESBindingNavigatorSaveItem.Text = "Guardar datos";
            this.tAB_CIUDADESBindingNavigatorSaveItem.Click += new System.EventHandler(this.tAB_CIUDADESBindingNavigatorSaveItem_Click);
            // 
            // Ciudadescs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 464);
            this.Controls.Add(this.tAB_CIUDADESBindingNavigator);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Ciudadescs";
            this.Text = "Ciudadescs";
            this.Load += new System.EventHandler(this.Ciudadescs_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_CIUDADESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bddolimpiadasDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tAB_CIUDADESDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_CIUDADESBindingNavigator)).EndInit();
            this.tAB_CIUDADESBindingNavigator.ResumeLayout(false);
            this.tAB_CIUDADESBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbopais;
        private System.Windows.Forms.ComboBox cbociudad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private bddolimpiadasDataSet bddolimpiadasDataSet;
        private System.Windows.Forms.BindingSource tAB_CIUDADESBindingSource;
        private bddolimpiadasDataSetTableAdapters.TAB_CIUDADESTableAdapter tAB_CIUDADESTableAdapter;
        private bddolimpiadasDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tAB_CIUDADESBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tAB_CIUDADESBindingNavigatorSaveItem;
        private System.Windows.Forms.Label iDCIUDADLabel1;
        private System.Windows.Forms.TextBox nOMBRECIUDADTextBox;
        private System.Windows.Forms.TextBox pAISTextBox;
        private System.Windows.Forms.DataGridView tAB_CIUDADESDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}