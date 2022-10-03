using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace inicio.Administrador
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
                mostrar();
                /*              aca agregar metodo para que aparezca la nueva insecion en el data grid
                                 este metedo es afuera de este boton es decir un listar aparte        
                                 
    */
                                comboBox2Rol.Text = "";
                                textBox2Apellido.Text = "";
                                textBox1Nombre.Text = "";
                                textBox3NombreUsuario.Text = "";
                                textBox4Pass.Text = "";
                                comboBox3Estado.Text = "";
                                comboBox1Genero.Text = "";
                                textBox9Edad.Text = "";
                                comboBox4EstadoCivil.Text = "";
                                textBox8Telefono.Text = "";
                                textBox6Direccion.Text = "";
                                textBox5Correo.Text = "";
                                textBox10DNI.Text = "";
                                textBox7FechaNaci.Text = "";
                
                conexion.Close();

            }

        }

        private void mostrar()
        {
            //definio una estructura de datos de tipo tabla
            DataTable datos = new DataTable();
            datos.Columns.Add("id usuario");
            datos.Columns.Add("id rol");
            datos.Columns.Add("nombre");
            datos.Columns.Add("apellido");
            datos.Columns.Add("nombre usuario");
            datos.Columns.Add("contraseña");
            datos.Columns.Add("Estado Vigencia");
            datos.Columns.Add("Sexo");
            datos.Columns.Add("Edad");
            datos.Columns.Add("Estado Civil");
            datos.Columns.Add("Telefono");
            datos.Columns.Add("Domicilio");
            datos.Columns.Add("Correo");
            datos.Columns.Add("DNI");
            datos.Columns.Add("Fecha Nacimiento");
            //se establece la conexion
            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString = inicio.Properties.Settings.Default.rutaConex;
            //realizo la consulta
            SqlCommand consulta = new SqlCommand();
            consulta.CommandText = "select u.Id_usuario as id_usu,u.Id_rol_usuario as id_rol,u.apellido as apellido, u.nombre as nombre, u.nombre_usuario as usuario_nombre, u.pass as contraseña, u.estado_vigencia as estadoV,u.sexo as sexo, u.edad as edad, u.estado_civil as civil_est, u.telefono as telefono,  u.domicilio as direccion, u.correo as email, u.dni as DNI, u.fecha_Nacimiento as nacimiento from Usuarios u; ";
            consulta.Connection = conexion;
            //verifico si esta abierto la conxion
            if (conexion.State != ConnectionState.Open)
            {
                conexion.Open();
            }
            //defino un variable para recorrer los datos obtenidos
            SqlDataReader lectura = consulta.ExecuteReader();

            if (lectura.HasRows)
            {
                while (lectura.Read())
                {
                    datos.Rows.Add(lectura["Id_usu"].ToString(), lectura["Id_rol"].ToString(), lectura["apellido"].ToString(),
                        lectura["nombre"].ToString(), lectura["usuario_nombre"].ToString(), lectura["contraseña"].ToString(),
                        lectura["estadoV"].ToString(), lectura["sexo"].ToString(), lectura["edad"].ToString(),
                        lectura["civil_est"].ToString(), lectura["telefono"].ToString(), lectura["direccion"].ToString(),
                        lectura["email"].ToString(), lectura["DNI"].ToString(), lectura["nacimiento"].ToString());
                }//fin mientras
                lectura.Close();
            }//fin if hasRows

            if (conexion.State != ConnectionState.Closed)
            {
                conexion.Close();
            }

            dataGridView1.DataSource = datos;

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
            if (textBox8Telefono.Text != "")
                errorProvider1.SetError(textBox8Telefono, "");
            else
            {
                errorProvider1.SetError(textBox8Telefono, "Debe ingresar telefono");
                e.Cancel = true;
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
            //CONDICION QUE NOS PERMITE UTILIZAR LA TECLA
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            //CONDICION QUE NOS PERMITE UTILIZAR LA TECLA
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            //CONDICION QUE NOS PERMITE UTILIZAR LA TECLA
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten Letras", "::::::::::", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //textBox1Nombre.CharacterCasing = CharacterCasing.Upper; //para mayuscula
            }
        }

        private void textBox2Apellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            //CONDICION QUE NOS PERMITE UTILIZAR LA TECLA
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            //CONDICION QUE NOS PERMITE UTILIZAR LA TECLA
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            //CONDICION QUE NOS PERMITE UTILIZAR LA TECLA
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten Letras", "::::::::::", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
            }
        }
        public static bool ValidarEmail(string comprobarEmail)
        {
            string emailFormato;
            emailFormato = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(comprobarEmail, emailFormato))
            {
                if (Regex.Replace(comprobarEmail, emailFormato, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textCorreo(object sender, EventArgs e)
        {
            if (ValidarEmail(textBox5Correo.Text) == false)
            {
                MessageBox.Show("Ingrese un email Valido", "nombre@dominio.com", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                
            }
        }

        private void botonPersonalizado3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox6Direccion_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
