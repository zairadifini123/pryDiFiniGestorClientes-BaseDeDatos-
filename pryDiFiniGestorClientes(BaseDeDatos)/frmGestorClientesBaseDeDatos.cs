using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryDiFiniGestorClientes_BaseDeDatos_
{
    public partial class frmGestorClientesBaseDeDatos : Form
    {
        public frmGestorClientesBaseDeDatos()
        {
            InitializeComponent();
        }

        private void listadoDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListadoDeClientes x = new frmListadoDeClientes();
            x.ShowDialog(); 
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
