using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace inicio
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
        private void botonPersonalizado1_Click(object sender, EventArgs e)
        {
            string usuario;
            string contraseña;
            //MessageBox.Show(textBoxPersozalizado2.Texts, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //"Debe completar Usuario"

            if (textBoxPersozalizado1.Texts.Length == 0)
            {
                MessageBox.Show("Debe completar Usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
               if (textBoxPersozalizado2.Texts.Length == 0)
            {
                MessageBox.Show("Debe completar la Contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                usuario = "Nestor";
                contraseña = "1111";

                if (textBoxPersozalizado1.Texts == usuario && textBoxPersozalizado2.Texts == contraseña)
                {
                    this.Hide();
                    bienvenido msj = new bienvenido(usuario);
                    msj.ShowDialog();


                    Gerente.MenuGerente menuGerente= new Gerente.MenuGerente();
                    menuGerente.Show();

                }
                else
                {
                    usuario = "Carlos";
                    contraseña = "2222";
                    if (textBoxPersozalizado1.Texts == usuario && textBoxPersozalizado2.Texts == contraseña)
                    {
                        this.Hide();
                        bienvenido msj = new bienvenido(usuario);
                        msj.ShowDialog();

                       Administrador.MenuAdministrador menuAdministrador = new Administrador.MenuAdministrador(usuario);
                        menuAdministrador.Show();


                    }
                    else
                    {
                        usuario = "Juan";
                        contraseña = "3333";
                        if (textBoxPersozalizado1.Texts == usuario && textBoxPersozalizado2.Texts == contraseña)
                        {
                            this.Hide();
                            bienvenido msj = new bienvenido(usuario);

                            msj.ShowDialog();


                            Vendedor.MenuVendedor menuVendedor = new Vendedor.MenuVendedor(usuario);
                            menuVendedor.Show();
                        }
                        else
                        {
                            MessageBox.Show("Usuario o Contraseña Incorrectos Intente De Nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }

            }
            
            //textBoxPersozalizado1.Clear();
            //textBoxPersozalizado2.Clear();
        }
    }
 }


