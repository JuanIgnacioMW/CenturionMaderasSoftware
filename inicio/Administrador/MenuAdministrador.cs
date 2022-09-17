using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using System.Runtime.InteropServices;

namespace inicio.Administrador
{
    public partial class MenuAdministrador : Form
    {
        string usuario;
        public MenuAdministrador()
        {
            InitializeComponent();
        }

        
        public MenuAdministrador(string nombre)
        {
            InitializeComponent();
            nombreAdmin.Text = nombre;
            usuario = nombreAdmin.Text;
        }
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //para capturar y poder mover el fomrulario
  /*      [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void releaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMenssage")]
        private extern static void SendMenssage(System.IntPtr hWnd, int wMsg, int wParam,  int lPparam);
        */

        int posy = 0;
        int posx = 0;

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            //releaseCapture();
            //SendMenssage(this.Handle, 0x112, 0xf012, 0);

            if (e.Button != MouseButtons.Left)
            {
                posx = e.X;
                posy = e.Y;
            }
            else
            {
                Left = Left + (e.X - posx);
                Top = Top + (e.Y - posy);
            }
        }

        private void BtnProductos_Click(object sender, EventArgs e)
        {

          

            

        }

        private void AgregarP_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnUusuarios_Click(object sender, EventArgs e)
        {
           

        }

        private void agregarUsuario_Click(object sender, EventArgs e)
        {
            
        }

        private void modificarUsuario_Click(object sender, EventArgs e)
        {
            
        }

        private void eliminarUsuario_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 loguin = new Form1();
            loguin.Show();
        }

        private void TfechaHora_Tick(object sender, EventArgs e)
        {
            lHora.Text = DateTime.Now.ToString("HH:mm:ss");
            lFecha.Text = DateTime.Now.ToShortDateString();
        }
    }
}
