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
    public partial class Ciudadescs : Form
    {
        public Ciudadescs()
        {
            InitializeComponent();
        }

        private void tAB_CIUDADESBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tAB_CIUDADESBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bddolimpiadasDataSet);

        }

        private void Ciudadescs_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bddolimpiadasDataSet.TAB_CIUDADES' Puede moverla o quitarla según sea necesario.
            this.tAB_CIUDADESTableAdapter.Fill(this.bddolimpiadasDataSet.TAB_CIUDADES);

        }
    }
}
