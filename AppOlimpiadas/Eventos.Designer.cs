namespace AppOlimpiadas
{
    partial class Eventos
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
            System.Windows.Forms.Label iDDEPORTELabel;
            System.Windows.Forms.Label iDSEDELabel;
            System.Windows.Forms.Label nOMBREEVENTOLabel;
            System.Windows.Forms.Label fECHAEVENTOLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Eventos));
            System.Windows.Forms.Label iDEVENTOLabel1;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Buscartxt = new System.Windows.Forms.Button();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tAB_EVENTOSBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.tAB_EVENTOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.tAB_EVENTOSBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iDDEPORTEComboBox = new System.Windows.Forms.ComboBox();
            this.iDSEDEComboBox = new System.Windows.Forms.ComboBox();
            this.nOMBREEVENTOTextBox = new System.Windows.Forms.TextBox();
            this.fECHAEVENTODateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tAB_EVENTOSTableAdapter = new AppOlimpiadas.bddolimpiadasDataSetTableAdapters.TAB_EVENTOSTableAdapter();
            this.tableAdapterManager = new AppOlimpiadas.bddolimpiadasDataSetTableAdapters.TableAdapterManager();
            this.tAB_EVENTOSDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDEVENTOLabel2 = new System.Windows.Forms.Label();
            this.tABDEPORTESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tAB_DEPORTESTableAdapter = new AppOlimpiadas.bddolimpiadasDataSetTableAdapters.TAB_DEPORTESTableAdapter();
            this.tABSEDESOLIMPICASBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tAB_SEDESOLIMPICASTableAdapter = new AppOlimpiadas.bddolimpiadasDataSetTableAdapters.TAB_SEDESOLIMPICASTableAdapter();
            iDDEPORTELabel = new System.Windows.Forms.Label();
            iDSEDELabel = new System.Windows.Forms.Label();
            nOMBREEVENTOLabel = new System.Windows.Forms.Label();
            fECHAEVENTOLabel = new System.Windows.Forms.Label();
            iDEVENTOLabel1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_EVENTOSBindingNavigator)).BeginInit();
            this.tAB_EVENTOSBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_EVENTOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bddolimpiadasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_EVENTOSDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tABDEPORTESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tABSEDESOLIMPICASBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // iDDEPORTELabel
            // 
            iDDEPORTELabel.AutoSize = true;
            iDDEPORTELabel.Location = new System.Drawing.Point(27, 91);
            iDDEPORTELabel.Name = "iDDEPORTELabel";
            iDDEPORTELabel.Size = new System.Drawing.Size(73, 13);
            iDDEPORTELabel.TabIndex = 2;
            iDDEPORTELabel.Text = "IDDEPORTE:";
            // 
            // iDSEDELabel
            // 
            iDSEDELabel.AutoSize = true;
            iDSEDELabel.Location = new System.Drawing.Point(27, 118);
            iDSEDELabel.Name = "iDSEDELabel";
            iDSEDELabel.Size = new System.Drawing.Size(50, 13);
            iDSEDELabel.TabIndex = 4;
            iDSEDELabel.Text = "IDSEDE:";
            // 
            // nOMBREEVENTOLabel
            // 
            nOMBREEVENTOLabel.AutoSize = true;
            nOMBREEVENTOLabel.Location = new System.Drawing.Point(27, 145);
            nOMBREEVENTOLabel.Name = "nOMBREEVENTOLabel";
            nOMBREEVENTOLabel.Size = new System.Drawing.Size(101, 13);
            nOMBREEVENTOLabel.TabIndex = 6;
            nOMBREEVENTOLabel.Text = "NOMBREEVENTO:";
            // 
            // fECHAEVENTOLabel
            // 
            fECHAEVENTOLabel.AutoSize = true;
            fECHAEVENTOLabel.Location = new System.Drawing.Point(27, 172);
            fECHAEVENTOLabel.Name = "fECHAEVENTOLabel";
            fECHAEVENTOLabel.Size = new System.Drawing.Size(89, 13);
            fECHAEVENTOLabel.TabIndex = 8;
            fECHAEVENTOLabel.Text = "FECHAEVENTO:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Buscartxt);
            this.groupBox1.Controls.Add(this.txtnombre);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(55, 29);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(454, 99);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar";
            // 
            // Buscartxt
            // 
            this.Buscartxt.Location = new System.Drawing.Point(296, 15);
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(iDEVENTOLabel1);
            this.groupBox2.Controls.Add(this.iDEVENTOLabel2);
            this.groupBox2.Controls.Add(this.tAB_EVENTOSBindingNavigator);
            this.groupBox2.Controls.Add(iDDEPORTELabel);
            this.groupBox2.Controls.Add(this.iDDEPORTEComboBox);
            this.groupBox2.Controls.Add(iDSEDELabel);
            this.groupBox2.Controls.Add(this.iDSEDEComboBox);
            this.groupBox2.Controls.Add(nOMBREEVENTOLabel);
            this.groupBox2.Controls.Add(this.nOMBREEVENTOTextBox);
            this.groupBox2.Controls.Add(fECHAEVENTOLabel);
            this.groupBox2.Controls.Add(this.fECHAEVENTODateTimePicker);
            this.groupBox2.Location = new System.Drawing.Point(55, 154);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(425, 226);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Editar";
            // 
            // tAB_EVENTOSBindingNavigator
            // 
            this.tAB_EVENTOSBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tAB_EVENTOSBindingNavigator.BindingSource = this.tAB_EVENTOSBindingSource;
            this.tAB_EVENTOSBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tAB_EVENTOSBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tAB_EVENTOSBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.tAB_EVENTOSBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tAB_EVENTOSBindingNavigatorSaveItem});
            this.tAB_EVENTOSBindingNavigator.Location = new System.Drawing.Point(30, 15);
            this.tAB_EVENTOSBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tAB_EVENTOSBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tAB_EVENTOSBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tAB_EVENTOSBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tAB_EVENTOSBindingNavigator.Name = "tAB_EVENTOSBindingNavigator";
            this.tAB_EVENTOSBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tAB_EVENTOSBindingNavigator.Size = new System.Drawing.Size(280, 25);
            this.tAB_EVENTOSBindingNavigator.TabIndex = 5;
            this.tAB_EVENTOSBindingNavigator.Text = "bindingNavigator1";
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
            // tAB_EVENTOSBindingSource
            // 
            this.tAB_EVENTOSBindingSource.DataMember = "TAB_EVENTOS";
            this.tAB_EVENTOSBindingSource.DataSource = this.bddolimpiadasDataSet;
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
            // tAB_EVENTOSBindingNavigatorSaveItem
            // 
            this.tAB_EVENTOSBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tAB_EVENTOSBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tAB_EVENTOSBindingNavigatorSaveItem.Image")));
            this.tAB_EVENTOSBindingNavigatorSaveItem.Name = "tAB_EVENTOSBindingNavigatorSaveItem";
            this.tAB_EVENTOSBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tAB_EVENTOSBindingNavigatorSaveItem.Text = "Guardar datos";
            this.tAB_EVENTOSBindingNavigatorSaveItem.Click += new System.EventHandler(this.tAB_EVENTOSBindingNavigatorSaveItem_Click);
            // 
            // iDDEPORTEComboBox
            // 
            this.iDDEPORTEComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tAB_EVENTOSBindingSource, "IDDEPORTE", true));
            this.iDDEPORTEComboBox.DataSource = this.tABDEPORTESBindingSource;
            this.iDDEPORTEComboBox.DisplayMember = "NOMBREDEPORTE";
            this.iDDEPORTEComboBox.FormattingEnabled = true;
            this.iDDEPORTEComboBox.Location = new System.Drawing.Point(134, 88);
            this.iDDEPORTEComboBox.Name = "iDDEPORTEComboBox";
            this.iDDEPORTEComboBox.Size = new System.Drawing.Size(200, 21);
            this.iDDEPORTEComboBox.TabIndex = 3;
            this.iDDEPORTEComboBox.ValueMember = "IDDEPORTE";
            // 
            // iDSEDEComboBox
            // 
            this.iDSEDEComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tAB_EVENTOSBindingSource, "IDSEDE", true));
            this.iDSEDEComboBox.DataSource = this.tABSEDESOLIMPICASBindingSource;
            this.iDSEDEComboBox.DisplayMember = "NOMBRESEDE";
            this.iDSEDEComboBox.FormattingEnabled = true;
            this.iDSEDEComboBox.Location = new System.Drawing.Point(134, 115);
            this.iDSEDEComboBox.Name = "iDSEDEComboBox";
            this.iDSEDEComboBox.Size = new System.Drawing.Size(200, 21);
            this.iDSEDEComboBox.TabIndex = 5;
            this.iDSEDEComboBox.ValueMember = "IDSEDE";
            // 
            // nOMBREEVENTOTextBox
            // 
            this.nOMBREEVENTOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tAB_EVENTOSBindingSource, "NOMBREEVENTO", true));
            this.nOMBREEVENTOTextBox.Location = new System.Drawing.Point(134, 142);
            this.nOMBREEVENTOTextBox.Name = "nOMBREEVENTOTextBox";
            this.nOMBREEVENTOTextBox.Size = new System.Drawing.Size(200, 20);
            this.nOMBREEVENTOTextBox.TabIndex = 7;
            // 
            // fECHAEVENTODateTimePicker
            // 
            this.fECHAEVENTODateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tAB_EVENTOSBindingSource, "FECHAEVENTO", true));
            this.fECHAEVENTODateTimePicker.Location = new System.Drawing.Point(134, 168);
            this.fECHAEVENTODateTimePicker.Name = "fECHAEVENTODateTimePicker";
            this.fECHAEVENTODateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fECHAEVENTODateTimePicker.TabIndex = 9;
            // 
            // tAB_EVENTOSTableAdapter
            // 
            this.tAB_EVENTOSTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TAB_CIUDADESTableAdapter = null;
            this.tableAdapterManager.TAB_DEPORTESTableAdapter = null;
            this.tableAdapterManager.TAB_DEPORTISTASTableAdapter = null;
            this.tableAdapterManager.TAB_EVENTOSTableAdapter = this.tAB_EVENTOSTableAdapter;
            this.tableAdapterManager.TAB_NACIONALIDADESTableAdapter = null;
            this.tableAdapterManager.TAB_RESULTADOSTableAdapter = null;
            this.tableAdapterManager.TAB_SEDESOLIMPICASTableAdapter = null;
            this.tableAdapterManager.TAB_USUARIOSTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AppOlimpiadas.bddolimpiadasDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tAB_EVENTOSDataGridView
            // 
            this.tAB_EVENTOSDataGridView.AutoGenerateColumns = false;
            this.tAB_EVENTOSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tAB_EVENTOSDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.tAB_EVENTOSDataGridView.DataSource = this.tAB_EVENTOSBindingSource;
            this.tAB_EVENTOSDataGridView.Location = new System.Drawing.Point(12, 392);
            this.tAB_EVENTOSDataGridView.Name = "tAB_EVENTOSDataGridView";
            this.tAB_EVENTOSDataGridView.Size = new System.Drawing.Size(624, 220);
            this.tAB_EVENTOSDataGridView.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IDEVENTO";
            this.dataGridViewTextBoxColumn1.HeaderText = "IDEVENTO";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "IDDEPORTE";
            this.dataGridViewTextBoxColumn2.HeaderText = "IDDEPORTE";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "IDSEDE";
            this.dataGridViewTextBoxColumn3.HeaderText = "IDSEDE";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "NOMBREEVENTO";
            this.dataGridViewTextBoxColumn4.HeaderText = "NOMBREEVENTO";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "FECHAEVENTO";
            this.dataGridViewTextBoxColumn5.HeaderText = "FECHAEVENTO";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // iDEVENTOLabel1
            // 
            iDEVENTOLabel1.AutoSize = true;
            iDEVENTOLabel1.Location = new System.Drawing.Point(34, 62);
            iDEVENTOLabel1.Name = "iDEVENTOLabel1";
            iDEVENTOLabel1.Size = new System.Drawing.Size(65, 13);
            iDEVENTOLabel1.TabIndex = 4;
            iDEVENTOLabel1.Text = "IDEVENTO:";
            // 
            // iDEVENTOLabel2
            // 
            this.iDEVENTOLabel2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tAB_EVENTOSBindingSource, "IDEVENTO", true));
            this.iDEVENTOLabel2.Location = new System.Drawing.Point(134, 62);
            this.iDEVENTOLabel2.Name = "iDEVENTOLabel2";
            this.iDEVENTOLabel2.Size = new System.Drawing.Size(200, 23);
            this.iDEVENTOLabel2.TabIndex = 5;
            this.iDEVENTOLabel2.Text = "label2";
            // 
            // tABDEPORTESBindingSource
            // 
            this.tABDEPORTESBindingSource.DataMember = "TAB_DEPORTES";
            this.tABDEPORTESBindingSource.DataSource = this.bddolimpiadasDataSet;
            // 
            // tAB_DEPORTESTableAdapter
            // 
            this.tAB_DEPORTESTableAdapter.ClearBeforeFill = true;
            // 
            // tABSEDESOLIMPICASBindingSource
            // 
            this.tABSEDESOLIMPICASBindingSource.DataMember = "TAB_SEDESOLIMPICAS";
            this.tABSEDESOLIMPICASBindingSource.DataSource = this.bddolimpiadasDataSet;
            // 
            // tAB_SEDESOLIMPICASTableAdapter
            // 
            this.tAB_SEDESOLIMPICASTableAdapter.ClearBeforeFill = true;
            // 
            // Eventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 632);
            this.Controls.Add(this.tAB_EVENTOSDataGridView);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Eventos";
            this.Text = "Eventos";
            this.Load += new System.EventHandler(this.Eventos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_EVENTOSBindingNavigator)).EndInit();
            this.tAB_EVENTOSBindingNavigator.ResumeLayout(false);
            this.tAB_EVENTOSBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_EVENTOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bddolimpiadasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_EVENTOSDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tABDEPORTESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tABSEDESOLIMPICASBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Buscartxt;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private bddolimpiadasDataSet bddolimpiadasDataSet;
        private System.Windows.Forms.BindingSource tAB_EVENTOSBindingSource;
        private bddolimpiadasDataSetTableAdapters.TAB_EVENTOSTableAdapter tAB_EVENTOSTableAdapter;
        private bddolimpiadasDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tAB_EVENTOSBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tAB_EVENTOSBindingNavigatorSaveItem;
        private System.Windows.Forms.ComboBox iDDEPORTEComboBox;
        private System.Windows.Forms.ComboBox iDSEDEComboBox;
        private System.Windows.Forms.TextBox nOMBREEVENTOTextBox;
        private System.Windows.Forms.DateTimePicker fECHAEVENTODateTimePicker;
        private System.Windows.Forms.DataGridView tAB_EVENTOSDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Label iDEVENTOLabel2;
        private System.Windows.Forms.BindingSource tABDEPORTESBindingSource;
        private bddolimpiadasDataSetTableAdapters.TAB_DEPORTESTableAdapter tAB_DEPORTESTableAdapter;
        private System.Windows.Forms.BindingSource tABSEDESOLIMPICASBindingSource;
        private bddolimpiadasDataSetTableAdapters.TAB_SEDESOLIMPICASTableAdapter tAB_SEDESOLIMPICASTableAdapter;
    }
}