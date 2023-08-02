using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppOlimpiadas
{
    public partial class Deportistas : Form
    {
        public Deportistas()
        {
            InitializeComponent();
        }

        private void tAB_DEPORTISTASBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tAB_DEPORTISTASBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bddolimpiadasDataSet);

        }

        private void Deportistas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bddolimpiadasDataSet.TAB_NACIONALIDADES' Puede moverla o quitarla según sea necesario.
            this.tAB_NACIONALIDADESTableAdapter.Fill(this.bddolimpiadasDataSet.TAB_NACIONALIDADES);
            // TODO: esta línea de código carga datos en la tabla 'bddolimpiadasDataSet.TAB_DEPORTISTAS' Puede moverla o quitarla según sea necesario.
            this.tAB_DEPORTISTASTableAdapter.Fill(this.bddolimpiadasDataSet.TAB_DEPORTISTAS);

        }
    }
}
