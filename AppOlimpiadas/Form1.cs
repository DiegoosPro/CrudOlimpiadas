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
    public partial class Form1 : Form
    {
        private bddolimpiadasDataSetTableAdapters.TAB_USUARIOSTableAdapter usuario = new bddolimpiadasDataSetTableAdapters.TAB_USUARIOSTableAdapter();
        private bddolimpiadasDataSet.TAB_USUARIOSDataTable usuariosDataTable = new bddolimpiadasDataSet.TAB_USUARIOSDataTable();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            usuario.FillByUsuarioClave(usuariosDataTable, txtUsuario.Text, txtContraseña.Text);
            if (usuariosDataTable.Rows.Count > 0)
            {
                bddolimpiadasDataSet.TAB_USUARIOSRow row =
               (bddolimpiadasDataSet.TAB_USUARIOSRow)usuariosDataTable.Rows[0];
                MessageBox.Show("WELCOME " + row.NOMBREUSUARIO);
                Principal frm = new Principal();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("ERROR datos incorrectos");
            }

        }
    }
}
