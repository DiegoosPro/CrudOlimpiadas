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
    public partial class SedesOlimpicas : Form
    {
        public SedesOlimpicas()
        {
            InitializeComponent();
        }

        private void tAB_SEDESOLIMPICASBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tAB_SEDESOLIMPICASBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bddolimpiadasDataSet);

        }

        private void tAB_SEDESOLIMPICASBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.tAB_SEDESOLIMPICASBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bddolimpiadasDataSet);

        }

        private void tAB_SEDESOLIMPICASBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.tAB_SEDESOLIMPICASBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bddolimpiadasDataSet);

        }

        private void SedesOlimpicas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bddolimpiadasDataSet.TAB_CIUDADES' Puede moverla o quitarla según sea necesario.
            this.tAB_CIUDADESTableAdapter.Fill(this.bddolimpiadasDataSet.TAB_CIUDADES);
            // TODO: esta línea de código carga datos en la tabla 'bddolimpiadasDataSet.TAB_SEDESOLIMPICAS' Puede moverla o quitarla según sea necesario.
            this.tAB_SEDESOLIMPICASTableAdapter.Fill(this.bddolimpiadasDataSet.TAB_SEDESOLIMPICAS);

        }

        private void Buscartxt_Click(object sender, EventArgs e)
        {
            this.tAB_SEDESOLIMPICASTableAdapter.FillByParametros(bddolimpiadasDataSet.TAB_SEDESOLIMPICAS,
                "%" + txtnombre.Text + "%");
        }
    }
}
