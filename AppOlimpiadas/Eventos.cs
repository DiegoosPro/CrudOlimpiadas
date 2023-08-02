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
    public partial class Eventos : Form
    {
        public Eventos()
        {
            InitializeComponent();
        }

        private void tAB_EVENTOSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tAB_EVENTOSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bddolimpiadasDataSet);

        }

        private void Eventos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bddolimpiadasDataSet.TAB_SEDESOLIMPICAS' Puede moverla o quitarla según sea necesario.
            this.tAB_SEDESOLIMPICASTableAdapter.Fill(this.bddolimpiadasDataSet.TAB_SEDESOLIMPICAS);
            // TODO: esta línea de código carga datos en la tabla 'bddolimpiadasDataSet.TAB_DEPORTES' Puede moverla o quitarla según sea necesario.
            this.tAB_DEPORTESTableAdapter.Fill(this.bddolimpiadasDataSet.TAB_DEPORTES);
            // TODO: esta línea de código carga datos en la tabla 'bddolimpiadasDataSet.TAB_EVENTOS' Puede moverla o quitarla según sea necesario.
            this.tAB_EVENTOSTableAdapter.Fill(this.bddolimpiadasDataSet.TAB_EVENTOS);

        }

        private void Buscartxt_Click(object sender, EventArgs e)
        {
            this.tAB_EVENTOSTableAdapter.FillByParametros(bddolimpiadasDataSet.TAB_EVENTOS,
               "%" + txtnombre.Text + "%");
        }
    }
}
