using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace inicio.Vendedor
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }
        int idRolConvertido = 0;
        bool estadoVigenciaConvertido;

        private void botonAgregar_Click(object sender, EventArgs e)
        {
            panelDatos.Visible = true;

            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            
            panelDatos.Visible = true;
        }

        private void textBoxNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo Ingrese Letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textBoxApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo Ingrese Letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void botonInsertar_Click(object sender, EventArgs e)
        {
            BorrarMensajeError();
            if (ValidarCampos())
            {
               
               

                int edadConvertido = Int32.Parse(textBox9Edad.Text);
                // MessageBox.Show("Datos Ingresados correctamente");

              
                SqlConnection conexion = new SqlConnection();
                conexion.ConnectionString = inicio.Properties.Settings.Default.rutaConex;

                object itemComboxRol = comboBox2Rol.SelectedItem;
                string variableCompara = itemComboxRol.ToString();

                if (variableCompara == "Administrador")
                {
                    idRolConvertido = 1;
                }
                else
                {
                    if (variableCompara == "Gerente")
                    {
                        idRolConvertido = 2;
                    }
                    else
                    {
                        idRolConvertido = 3;
                    }
                }

                object itemComboxEstadoV = comboBox3Estado.SelectedItem;
                string variableCompara1 = itemComboxRol.ToString();

                if (variableCompara == "Activo")
                {
                    estadoVigenciaConvertido = true;
                }
                else
                {
                    if (variableCompara == "Inactivo")
                    {
                        estadoVigenciaConvertido = false;
                    }
                    
                }

                conexion.Open();

                string cadenaInsert = "insert into Usuarios (Id_rol_usuario, apellido, nombre, nombre_usuario, pass, estado_vigencia, sexo, edad, estado_civil,telefono, domicilio, correo, dni, fecha_Nacimiento)values('" + idRolConvertido + "', '" + textBox2Apellido.Text + "', '" + textBox1Nombre.Text + "', '" + textBox3NombreUsuario.Text + "', '" + textBox4Pass.Text + "', '" + estadoVigenciaConvertido + "', '" + comboBox1Genero.Text + "', '" + edadConvertido + "', '" + comboBox4EstadoCivil.Text + "', '" + textBox8Telefono.Text + "', '" + textBox6Direccion.Text + "', '" + textBox5Correo.Text + "','" + textBox10DNI.Text + "', CAST(N'" + textBox7FechaNaci.Text + "' AS Date)); ";
                SqlCommand comando2 = new SqlCommand(cadenaInsert, conexion);
                comando2.ExecuteNonQuery();

                MessageBox.Show("Se Agrego con Exito el Usuario: " + textBox1Nombre.Text);
                /*              aca agregar metodo para que aparezca la nueva insecion en el data grid
                                 este metedo es afuera de este boton es decir un listar aparte        


                                textBoxRol.Text = "";
                                textBoxAp.Text = "";
                                textBoxNombre.Text = "";
                                textBoxNomUsu.Text = "";
                                textBoxPass.Text = "";
                                textBoxEstVig.Text = "";
                                textBoxSexo.Text = "";
                                textBoxEdad.Text = "";
                                textBoxEstCiv.Text = "";
                                textBoxTel.Text = "";
                                textBoxDom.Text = "";
                                textBox1Correo.Text = "";
                                textBoxDni.Text = "";
                                textBoxfecha.Text = "";
                */
                conexion.Close();

            }

        }

        private void BorrarMensajeError()
        {
            errorProvider1.SetError(textBox1Nombre, "");
            errorProvider1.SetError(textBox2Apellido, "");
            errorProvider1.SetError(textBox3NombreUsuario, "");
            errorProvider1.SetError(textBox4Pass, "");
            errorProvider1.SetError(textBox5Correo, "");
            errorProvider1.SetError(textBox6Direccion, "");
            errorProvider1.SetError(textBox7FechaNaci, "");
            errorProvider1.SetError(textBox8Telefono, "");
            errorProvider1.SetError(textBox9Edad, "");
            


            errorProvider1.SetError(comboBox1Genero, "");
            errorProvider1.SetError(comboBox2Rol, "");
            errorProvider1.SetError(comboBox3Estado, "");
            errorProvider1.SetError(comboBox4EstadoCivil, "");

        }
        private bool ValidarCampos()
        {
            bool ok = true;
            if (textBox1Nombre.Text == "")
            {
                ok = false;
                errorProvider1.SetError(textBox1Nombre, "Ingresar Nombre");
            }
            if (textBox4Pass.Text == "")
            {
                ok = false;
                errorProvider1.SetError(textBox4Pass, "Ingresar Contraseña");
            }
            if (textBox8Telefono.Text == "")
            {
                ok = false;
                errorProvider1.SetError(textBox8Telefono, "Ingresar Tèlefono");
            }
            if (textBox2Apellido.Text == "")
            {
                ok = false;
                errorProvider1.SetError(textBox2Apellido, "Ingresar Apelido");
            }
            if (textBox10DNI.Text == "")
            {
                ok = false;
                errorProvider1.SetError(textBox10DNI, "Ingresar Dni");
            }
            if (comboBox1Genero.SelectedItem == null)
            {
                ok = false;
                errorProvider1.SetError(comboBox1Genero, "Seleccione una opción");
            }
            if (comboBox2Rol.SelectedItem == null)
            {
                ok = false;
                errorProvider1.SetError(comboBox2Rol, "Seleccione una opción");
            }
            if (comboBox4EstadoCivil.SelectedItem == null)
            {
                ok = false;
                errorProvider1.SetError(comboBox4EstadoCivil, "Seleccione una opción");
            }
            if (comboBox3Estado.SelectedItem == null)
            {
                ok = false;
                errorProvider1.SetError(comboBox3Estado, "Seleccione una opción");
            }
            if (textBox5Correo.Text == "")
            {
                ok = false;
                errorProvider1.SetError(textBox5Correo, "Ingresar Correo Eléctronico");
            }
            if (textBox6Direccion.Text == "")
            {
                ok = false;
                errorProvider1.SetError(textBox6Direccion, "Ingresar Dirección");
            }
            if (textBox9Edad.Text == "")
            {
                ok = false;
                errorProvider1.SetError(textBox9Edad, "Ingresar Edad");
            }
            if (textBox7FechaNaci.Text == "")
            {
                ok = false;
                errorProvider1.SetError(textBox7FechaNaci, "Ingresar Fecha Nacimiento");
            }
            return ok;
        }

        private void textBox9Edad_Validating(object sender, CancelEventArgs e)
        {
            int num;
            if (!int.TryParse(textBox9Edad.Text, out num))
            {
                errorProvider1.SetError(textBox9Edad, "Ingrese valor numerico");
            }
            else
            {
                errorProvider1.SetError(textBox9Edad, "");
            }
        }

        private void textBox7FechaNaci_Validating(object sender, CancelEventArgs e)
        {
            DateTime cumple;
            if (!DateTime.TryParse(textBox7FechaNaci.Text, out cumple))
            {
                errorProvider1.SetError(textBox7FechaNaci, "El formato debe ser DD-MM-YY");
            }
            else
            {
                errorProvider1.SetError(textBox7FechaNaci, "");
            }
        }

        private void textBox10DNI_Validating(object sender, CancelEventArgs e)
        {
            int num;
            if (!int.TryParse(textBox10DNI.Text, out num))
            {
                errorProvider1.SetError(textBox10DNI, "Ingrese valor numerico");
            }
            else
            {
                errorProvider1.SetError(textBox10DNI, "");
            }
        }

        private void textBox8Telefono_Validating(object sender, CancelEventArgs e)
        {
            int num;
            if (!int.TryParse(textBox8Telefono.Text, out num))
            {
                errorProvider1.SetError(textBox8Telefono, "Ingrese valor numerico");
            }
            else
            {
                errorProvider1.SetError(textBox8Telefono, "");
            }
        }

        private void textBox9Edad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo Ingrese Nuneros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textBox10DNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo Ingrese Nuneros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textBox1Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo Ingrese Letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textBox2Apellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo Ingrese Letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
