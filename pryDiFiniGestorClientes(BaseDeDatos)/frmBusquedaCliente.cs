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
    public partial class frmBusquedaCliente : Form
    {
        public frmBusquedaCliente()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtCodigoCliente.Text != "") 
            { 
                btnBuscar.Enabled = true; 
            } 
            else 
            { 
                btnBuscar.Enabled = false; 
            }
            Int32 idCliente = Convert.ToInt32(txtCodigoCliente.Text); 
            clsCliente x = new clsCliente();
            x.BuscarCliente(idCliente);

            if(x.idCliente == 0)
            {
                MessageBox.Show("Cliente no existente");
                txtCodigoCliente.Text = ""; 
                lblNombre.Text = "";
                lblDeuda.Text = "";
                lblLimiteCredito.Text = "";
            }
            else
            {
                txtCodigoCliente.Text = "";
                lblNombre.Text = x.Nombre;
                lblDeuda.Text = x.Deuda.ToString();
                lblLimiteCredito.Text = x.Limite.ToString();
            }
                
        }

        private void txtCodigoCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Bloquea la tecla
            }

        }
    }
}
