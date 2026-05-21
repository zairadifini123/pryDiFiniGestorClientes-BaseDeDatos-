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
    public partial class frmListadoDeudores : Form
    {
        public frmListadoDeudores()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void btnListarDeudores_Click(object sender, EventArgs e)
        {
            clsCliente x = new clsCliente();
            x.ListarDeudores(dgvClientes);
            lblCantidadClientes.Text = x.CantidadDeudores.ToString();
            lblTotalDeuda.Text = x.TotalDeuda.ToString("0.00");
            lblPromedioDeudas.Text = x.PromedioDeuda.ToString("0.00"); 
        }

        private void btnReportar_Click(object sender, EventArgs e)
        {
            clsCliente x = new clsCliente();
            x.ReporteCliente();
            MessageBox.Show("El reporte se generó correctamente");

        }
    }
}
