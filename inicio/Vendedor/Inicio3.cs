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
    public partial class Inicio3 : Form
    {
        public Inicio3()
        {
            InitializeComponent();
        }

        private void BtnListar_Click(object sender, EventArgs e)
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

            dataGridListado.DataSource = datos;
        }
    }
}
