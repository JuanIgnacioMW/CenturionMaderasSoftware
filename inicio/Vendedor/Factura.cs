using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace inicio.Vendedor
{
    public partial class Factura : Form
    {
        public Factura()
        {
            InitializeComponent();
        }

        private void btnCancelarFac_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }

        private void botonConfirmarDatos_Click(object sender, EventArgs e)
        {

                this.panelDatosCab.Visible = false;
               
                panelCabecera.Visible = true;
                panelProductoDetalle.Visible = true;
                lPrecioSubTotal.Visible = true;
                lPrecioTotal.Visible = true;
                btnQuitarDet.Visible = true;
                btnRegistrar.Visible = true;
                btnCancelarFac.Visible = true;
            GridDetalle.Visible = true;
            lSubTotal.Visible = true;
            lTotal.Visible = true;
            
           
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se Registro Con EXITO la Factura Numero ******", "Registracion con Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
