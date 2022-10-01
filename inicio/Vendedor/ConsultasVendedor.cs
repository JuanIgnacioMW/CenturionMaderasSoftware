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
    public partial class ConsultasVendedor : Form
    {
        public ConsultasVendedor()
        {
            InitializeComponent();
        }

        private void btnConsultarProductos_Click(object sender, EventArgs e)
        {
            if (panelSubMenuProd.Visible == false) {
                panelSubMenuProd.Visible = true;
            }
            else
            {
                panelSubMenuProd.Visible = false;
            }
        }

        private void btnConsultarClientes_Click(object sender, EventArgs e)
        {
            if (panelSubMenuCliente.Visible == false)
            {
                panelSubMenuCliente.Visible = true;
            }
            else
            {
                panelSubMenuCliente.Visible = false;
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
