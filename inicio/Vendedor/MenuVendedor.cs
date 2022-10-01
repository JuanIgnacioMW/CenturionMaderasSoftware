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
    public partial class MenuVendedor : Form
    {
        
        public MenuVendedor()
        {
            InitializeComponent();
        }

        public MenuVendedor(string nombre)
        {
            InitializeComponent();
           nombreVend.Text = nombre;
           // usuario = labelNombreVen.Text;
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 loguin = new Form1();
            loguin.Show();
        }

        private void timerFechaHora_Tick(object sender, EventArgs e)
        {
            lHora.Text = DateTime.Now.ToString("HH:mm:ss");
            lFecha.Text = DateTime.Now.ToShortDateString();
        }

       

        private void btnAnular_Click(object sender, EventArgs e)
        {
            /*  panelCabecera.Visible = false;
              GridDetalle.Visible = false;
              btnAnular.Visible = false;
              btnRegistrar.Visible = false;
              btnAgregarDet.Visible = false;*/
            pictureBoxFondo.Visible = true;
           // panelDatosCabecera.Visible = false;

          //  panelSuperficial.Visible = false;
        }

        private void btnAgregarDet_Click(object sender, EventArgs e)
        {
            
            
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            
        }

        private void AbrirFormulario(object FormHija)
        {
            if (this.panelContenedor.Controls.Count > 0)
            {
                this.panelContenedor.Controls.RemoveAt(0);
            }
            Form OpenForm = FormHija as Form;
            OpenForm.TopLevel = false;
            OpenForm.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(OpenForm);
            this.panelContenedor.Tag = OpenForm;
            OpenForm.Show();
        }
        private void btnConfirmarDatoCab_Click(object sender, EventArgs e)
        {
         
           
            //panelDatosCabecera.Visible = false;
            // panelCabecera.Visible = true;
            //GridDetalle.Visible = true;
            //panelSuperficial.Visible = true;
            // panelDatosCabecera.Visible = true;
            pictureBoxFondo.Visible = true;
            
            
            // panelSuperficial.Visible = false;


        }

      
        private void btnVenta_Click(object sender, EventArgs e)
        {
            /*
                     if (panelCabecera.Visible == false)
                     {


                 panelCabecera.Visible = true;
             }
             */



            AbrirFormulario(new Factura());

        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            if (panelSubMenu.Visible == false)
            {
                panelSubMenu.Visible = true;
            }
            else
            {
                panelSubMenu.Visible = false;
            }
        }

     
        private void botonConfirmarDatos_Click(object sender, EventArgs e)
        {
          

        }



        

        private void BtnConsulta_Click(object sender, EventArgs e)
        {
            pictureBoxFondo.Visible = false;
            AbrirFormulario(new ConsultasVendedor());
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Inicio());
        }

        private void botonConfirmarDatos_Click_1(object sender, EventArgs e)
        {
            //pprueba
     
           
                
               


        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Inicio3());
        }
    }
}
