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
    public partial class Nacionalidades : Form
    {
        public Nacionalidades()
        {
            InitializeComponent();
        }

        private void tAB_NACIONALIDADESBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tAB_NACIONALIDADESBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bddolimpiadasDataSet);

        }

        private void Nacionalidades_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bddolimpiadasDataSet.TAB_NACIONALIDADES' Puede moverla o quitarla según sea necesario.
            this.tAB_NACIONALIDADESTableAdapter.Fill(this.bddolimpiadasDataSet.TAB_NACIONALIDADES);

        }
    }
}
