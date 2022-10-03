using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace inicio.Administrador
{
    public partial class Inicio2 : Form
    {
        public Inicio2()
        {
            InitializeComponent();
        }

        private void botonAgregar_Click(object sender, EventArgs e)
        {

        }

        private void botonPersonalizado1_Click(object sender, EventArgs e)
        {
            BorrarMensajeError();
            if (ValidarCampos())
            {

                MessageBox.Show("Datos Ingresados correctamente");
            }
        }
        private void BorrarMensajeError()
        {
            errorProvider1.SetError(textBox1DEscripcion, "");
            errorProvider1.SetError(textBox2PrecioVenta, "");
            errorProvider1.SetError(textBox3Stock, "");
            
           
            errorProvider1.SetError(comboBox1Estado, "");
            errorProvider1.SetError(comboBox2Tipo, "");

        }
        private bool ValidarCampos()
        {
            bool ok = true;
            if (textBox1DEscripcion.Text == "")
            {
                ok = false;
                errorProvider1.SetError(textBox1DEscripcion, "Ingresar Descripción");
            }
            if (textBox2PrecioVenta.Text == "")
            {
                ok = false;
                errorProvider1.SetError(textBox2PrecioVenta, "Ingresar Precio Venta");
            }
            if (textBox3Stock.Text == "")
            {
                ok = false;
                errorProvider1.SetError(textBox3Stock, "Ingresar Stock");
            }
            if (comboBox1Estado.SelectedItem == null)
            {
                ok = false;
                errorProvider1.SetError(comboBox1Estado, "Seleccione una opción");
            }
            if (comboBox2Tipo.SelectedItem == null)
            {
                ok = false;
                errorProvider1.SetError(comboBox2Tipo, "Seleccione una opción");
            }
            return ok;
        }

        private void textBox3Stock_Validating(object sender, CancelEventArgs e)
        {

            int num;
            if (!int.TryParse(textBox3Stock.Text, out num))
            {
                errorProvider1.SetError(textBox3Stock, "Ingrese valor numerico");
            }
            else
            {
                errorProvider1.SetError(textBox3Stock, "");
            }
        }

        private void textBox1DEscripcion_Validating(object sender, CancelEventArgs e)
        {
            if (textBox1DEscripcion.Text != "")
                errorProvider1.SetError(textBox1DEscripcion, "");
            else
            {
                errorProvider1.SetError(textBox1DEscripcion, "Debe ingresar una descripción");
                e.Cancel = true;
            }
        }

        private void textBox3Stock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo Ingrese Nuneros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textBox1DEscripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
           /* if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo Ingrese Letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }*/
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            //MenuAdministrador formul = new MenuAdministrador();
            //formul.Show();
            this.Close();
        }

        private void botonPersonalizado2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
