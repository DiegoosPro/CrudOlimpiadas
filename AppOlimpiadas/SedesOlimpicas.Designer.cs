namespace AppOlimpiadas
{
    partial class SedesOlimpicas
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
            System.Windows.Forms.Label iDSEDELabel;
            System.Windows.Forms.Label iDCIUDADLabel;
            System.Windows.Forms.Label nOMBRESEDELabel;
            System.Windows.Forms.Label aNIOCELEBRACIONLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SedesOlimpicas));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tAB_SEDESOLIMPICASBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.tAB_SEDESOLIMPICASBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bddolimpiadasDataSet = new AppOlimpiadas.bddolimpiadasDataSet();
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
            this.tAB_SEDESOLIMPICASBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iDSEDELabel1 = new System.Windows.Forms.Label();
            this.iDCIUDADComboBox = new System.Windows.Forms.ComboBox();
            this.tABCIUDADESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nOMBRESEDETextBox = new System.Windows.Forms.TextBox();
            this.aNIOCELEBRACIONTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Buscartxt = new System.Windows.Forms.Button();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tAB_SEDESOLIMPICASTableAdapter = new AppOlimpiadas.bddolimpiadasDataSetTableAdapters.TAB_SEDESOLIMPICASTableAdapter();
            this.tableAdapterManager = new AppOlimpiadas.bddolimpiadasDataSetTableAdapters.TableAdapterManager();
            this.tAB_SEDESOLIMPICASDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tAB_CIUDADESTableAdapter = new AppOlimpiadas.bddolimpiadasDataSetTableAdapters.TAB_CIUDADESTableAdapter();
            iDSEDELabel = new System.Windows.Forms.Label();
            iDCIUDADLabel = new System.Windows.Forms.Label();
            nOMBRESEDELabel = new System.Windows.Forms.Label();
            aNIOCELEBRACIONLabel = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_SEDESOLIMPICASBindingNavigator)).BeginInit();
            this.tAB_SEDESOLIMPICASBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_SEDESOLIMPICASBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bddolimpiadasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tABCIUDADESBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_SEDESOLIMPICASDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // iDSEDELabel
            // 
            iDSEDELabel.AutoSize = true;
            iDSEDELabel.Location = new System.Drawing.Point(33, 75);
            iDSEDELabel.Name = "iDSEDELabel";
            iDSEDELabel.Size = new System.Drawing.Size(50, 13);
            iDSEDELabel.TabIndex = 0;
            iDSEDELabel.Text = "IDSEDE:";
            // 
            // iDCIUDADLabel
            // 
            iDCIUDADLabel.AutoSize = true;
            iDCIUDADLabel.Location = new System.Drawing.Point(33, 104);
            iDCIUDADLabel.Name = "iDCIUDADLabel";
            iDCIUDADLabel.Size = new System.Drawing.Size(62, 13);
            iDCIUDADLabel.TabIndex = 2;
            iDCIUDADLabel.Text = "IDCIUDAD:";
            // 
            // nOMBRESEDELabel
            // 
            nOMBRESEDELabel.AutoSize = true;
            nOMBRESEDELabel.Location = new System.Drawing.Point(33, 131);
            nOMBRESEDELabel.Name = "nOMBRESEDELabel";
            nOMBRESEDELabel.Size = new System.Drawing.Size(86, 13);
            nOMBRESEDELabel.TabIndex = 4;
            nOMBRESEDELabel.Text = "NOMBRESEDE:";
            // 
            // aNIOCELEBRACIONLabel
            // 
            aNIOCELEBRACIONLabel.AutoSize = true;
            aNIOCELEBRACIONLabel.Location = new System.Drawing.Point(33, 157);
            aNIOCELEBRACIONLabel.Name = "aNIOCELEBRACIONLabel";
            aNIOCELEBRACIONLabel.Size = new System.Drawing.Size(111, 13);
            aNIOCELEBRACIONLabel.TabIndex = 6;
            aNIOCELEBRACIONLabel.Text = "ANIOCELEBRACION:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(iDSEDELabel);
            this.groupBox2.Controls.Add(this.tAB_SEDESOLIMPICASBindingNavigator);
            this.groupBox2.Controls.Add(this.iDSEDELabel1);
            this.groupBox2.Controls.Add(iDCIUDADLabel);
            this.groupBox2.Controls.Add(this.iDCIUDADComboBox);
            this.groupBox2.Controls.Add(nOMBRESEDELabel);
            this.groupBox2.Controls.Add(this.nOMBRESEDETextBox);
            this.groupBox2.Controls.Add(aNIOCELEBRACIONLabel);
            this.groupBox2.Controls.Add(this.aNIOCELEBRACIONTextBox);
            this.groupBox2.Location = new System.Drawing.Point(76, 128);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(342, 189);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Editar";
            // 
            // tAB_SEDESOLIMPICASBindingNavigator
            // 
            this.tAB_SEDESOLIMPICASBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tAB_SEDESOLIMPICASBindingNavigator.BindingSource = this.tAB_SEDESOLIMPICASBindingSource;
            this.tAB_SEDESOLIMPICASBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tAB_SEDESOLIMPICASBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tAB_SEDESOLIMPICASBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.tAB_SEDESOLIMPICASBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tAB_SEDESOLIMPICASBindingNavigatorSaveItem});
            this.tAB_SEDESOLIMPICASBindingNavigator.Location = new System.Drawing.Point(15, 24);
            this.tAB_SEDESOLIMPICASBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tAB_SEDESOLIMPICASBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tAB_SEDESOLIMPICASBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tAB_SEDESOLIMPICASBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tAB_SEDESOLIMPICASBindingNavigator.Name = "tAB_SEDESOLIMPICASBindingNavigator";
            this.tAB_SEDESOLIMPICASBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tAB_SEDESOLIMPICASBindingNavigator.Size = new System.Drawing.Size(280, 25);
            this.tAB_SEDESOLIMPICASBindingNavigator.TabIndex = 4;
            this.tAB_SEDESOLIMPICASBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // tAB_SEDESOLIMPICASBindingSource
            // 
            this.tAB_SEDESOLIMPICASBindingSource.DataMember = "TAB_SEDESOLIMPICAS";
            this.tAB_SEDESOLIMPICASBindingSource.DataSource = this.bddolimpiadasDataSet;
            // 
            // bddolimpiadasDataSet
            // 
            this.bddolimpiadasDataSet.DataSetName = "bddolimpiadasDataSet";
            this.bddolimpiadasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
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
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tAB_SEDESOLIMPICASBindingNavigatorSaveItem
            // 
            this.tAB_SEDESOLIMPICASBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tAB_SEDESOLIMPICASBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tAB_SEDESOLIMPICASBindingNavigatorSaveItem.Image")));
            this.tAB_SEDESOLIMPICASBindingNavigatorSaveItem.Name = "tAB_SEDESOLIMPICASBindingNavigatorSaveItem";
            this.tAB_SEDESOLIMPICASBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tAB_SEDESOLIMPICASBindingNavigatorSaveItem.Text = "Guardar datos";
            this.tAB_SEDESOLIMPICASBindingNavigatorSaveItem.Click += new System.EventHandler(this.tAB_SEDESOLIMPICASBindingNavigatorSaveItem_Click_2);
            // 
            // iDSEDELabel1
            // 
            this.iDSEDELabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tAB_SEDESOLIMPICASBindingSource, "IDSEDE", true));
            this.iDSEDELabel1.Location = new System.Drawing.Point(150, 75);
            this.iDSEDELabel1.Name = "iDSEDELabel1";
            this.iDSEDELabel1.Size = new System.Drawing.Size(121, 23);
            this.iDSEDELabel1.TabIndex = 1;
            this.iDSEDELabel1.Text = "label2";
            // 
            // iDCIUDADComboBox
            // 
            this.iDCIUDADComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tAB_SEDESOLIMPICASBindingSource, "IDCIUDAD", true));
            this.iDCIUDADComboBox.DataSource = this.tABCIUDADESBindingSource;
            this.iDCIUDADComboBox.DisplayMember = "NOMBRECIUDAD";
            this.iDCIUDADComboBox.FormattingEnabled = true;
            this.iDCIUDADComboBox.Location = new System.Drawing.Point(150, 101);
            this.iDCIUDADComboBox.Name = "iDCIUDADComboBox";
            this.iDCIUDADComboBox.Size = new System.Drawing.Size(121, 21);
            this.iDCIUDADComboBox.TabIndex = 3;
            this.iDCIUDADComboBox.ValueMember = "IDCIUDAD";
            // 
            // tABCIUDADESBindingSource
            // 
            this.tABCIUDADESBindingSource.DataMember = "TAB_CIUDADES";
            this.tABCIUDADESBindingSource.DataSource = this.bddolimpiadasDataSet;
            // 
            // nOMBRESEDETextBox
            // 
            this.nOMBRESEDETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tAB_SEDESOLIMPICASBindingSource, "NOMBRESEDE", true));
            this.nOMBRESEDETextBox.Location = new System.Drawing.Point(150, 128);
            this.nOMBRESEDETextBox.Name = "nOMBRESEDETextBox";
            this.nOMBRESEDETextBox.Size = new System.Drawing.Size(121, 20);
            this.nOMBRESEDETextBox.TabIndex = 5;
            // 
            // aNIOCELEBRACIONTextBox
            // 
            this.aNIOCELEBRACIONTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tAB_SEDESOLIMPICASBindingSource, "ANIOCELEBRACION", true));
            this.aNIOCELEBRACIONTextBox.Location = new System.Drawing.Point(150, 154);
            this.aNIOCELEBRACIONTextBox.Name = "aNIOCELEBRACIONTextBox";
            this.aNIOCELEBRACIONTextBox.Size = new System.Drawing.Size(121, 20);
            this.aNIOCELEBRACIONTextBox.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Buscartxt);
            this.groupBox1.Controls.Add(this.txtnombre);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(48, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(454, 99);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar";
            // 
            // Buscartxt
            // 
            this.Buscartxt.Location = new System.Drawing.Point(366, 17);
            this.Buscartxt.Name = "Buscartxt";
            this.Buscartxt.Size = new System.Drawing.Size(75, 23);
            this.Buscartxt.TabIndex = 6;
            this.Buscartxt.Text = "Buscar";
            this.Buscartxt.UseVisualStyleBackColor = true;
            this.Buscartxt.Click += new System.EventHandler(this.Buscartxt_Click);
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(164, 17);
            this.txtnombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(76, 20);
            this.txtnombre.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingresar  Nombre";
            // 
            // tAB_SEDESOLIMPICASTableAdapter
            // 
            this.tAB_SEDESOLIMPICASTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TAB_CIUDADESTableAdapter = null;
            this.tableAdapterManager.TAB_DEPORTESTableAdapter = null;
            this.tableAdapterManager.TAB_DEPORTISTASTableAdapter = null;
            this.tableAdapterManager.TAB_EVENTOSTableAdapter = null;
            this.tableAdapterManager.TAB_NACIONALIDADESTableAdapter = null;
            this.tableAdapterManager.TAB_RESULTADOSTableAdapter = null;
            this.tableAdapterManager.TAB_SEDESOLIMPICASTableAdapter = this.tAB_SEDESOLIMPICASTableAdapter;
            this.tableAdapterManager.TAB_USUARIOSTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AppOlimpiadas.bddolimpiadasDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tAB_SEDESOLIMPICASDataGridView
            // 
            this.tAB_SEDESOLIMPICASDataGridView.AutoGenerateColumns = false;
            this.tAB_SEDESOLIMPICASDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tAB_SEDESOLIMPICASDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.tAB_SEDESOLIMPICASDataGridView.DataSource = this.tAB_SEDESOLIMPICASBindingSource;
            this.tAB_SEDESOLIMPICASDataGridView.Location = new System.Drawing.Point(65, 350);
            this.tAB_SEDESOLIMPICASDataGridView.Name = "tAB_SEDESOLIMPICASDataGridView";
            this.tAB_SEDESOLIMPICASDataGridView.Size = new System.Drawing.Size(585, 220);
            this.tAB_SEDESOLIMPICASDataGridView.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IDSEDE";
            this.dataGridViewTextBoxColumn1.HeaderText = "IDSEDE";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "IDCIUDAD";
            this.dataGridViewTextBoxColumn2.HeaderText = "IDCIUDAD";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NOMBRESEDE";
            this.dataGridViewTextBoxColumn3.HeaderText = "NOMBRESEDE";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ANIOCELEBRACION";
            this.dataGridViewTextBoxColumn4.HeaderText = "ANIOCELEBRACION";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // tAB_CIUDADESTableAdapter
            // 
            this.tAB_CIUDADESTableAdapter.ClearBeforeFill = true;
            // 
            // SedesOlimpicas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 590);
            this.Controls.Add(this.tAB_SEDESOLIMPICASDataGridView);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "SedesOlimpicas";
            this.Text = "SedesOlimpicas";
            this.Load += new System.EventHandler(this.SedesOlimpicas_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_SEDESOLIMPICASBindingNavigator)).EndInit();
            this.tAB_SEDESOLIMPICASBindingNavigator.ResumeLayout(false);
            this.tAB_SEDESOLIMPICASBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_SEDESOLIMPICASBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bddolimpiadasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tABCIUDADESBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_SEDESOLIMPICASDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Button Buscartxt;
        private bddolimpiadasDataSet bddolimpiadasDataSet;
        private System.Windows.Forms.BindingSource tAB_SEDESOLIMPICASBindingSource;
        private bddolimpiadasDataSetTableAdapters.TAB_SEDESOLIMPICASTableAdapter tAB_SEDESOLIMPICASTableAdapter;
        private bddolimpiadasDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tAB_SEDESOLIMPICASBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tAB_SEDESOLIMPICASBindingNavigatorSaveItem;
        private System.Windows.Forms.Label iDSEDELabel1;
        private System.Windows.Forms.ComboBox iDCIUDADComboBox;
        private System.Windows.Forms.TextBox nOMBRESEDETextBox;
        private System.Windows.Forms.TextBox aNIOCELEBRACIONTextBox;
        private System.Windows.Forms.DataGridView tAB_SEDESOLIMPICASDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.BindingSource tABCIUDADESBindingSource;
        private bddolimpiadasDataSetTableAdapters.TAB_CIUDADESTableAdapter tAB_CIUDADESTableAdapter;
    }
}