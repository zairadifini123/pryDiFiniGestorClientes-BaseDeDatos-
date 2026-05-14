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
    public partial class frmListadoDeClientes : Form
    {
        public frmListadoDeClientes()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            clsCliente x = new clsCliente();
            x.Listar(dgvListadoDeClientes);
        }
    }
}
