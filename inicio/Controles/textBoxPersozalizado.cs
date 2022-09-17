using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace inicio.Controles
{
    [ DefaultEvent ("_textChanged")]
    public partial class textBoxPersozalizado : UserControl
    {

        //Campos
        private Color borderColor = Color.MediumSlateBlue;
        private bool underLineStyle = false;
        private int borderSize = 2;
        private Color borderFocusColor = Color.Brown;
        private bool isFocused = false;
        //get abd set
        public Color BorderColor
        {
            get
            {
                return borderColor;
            }

            set
            {
                borderColor = value;
                this.Invalidate();
            }
        }

        public bool UnderLineStyle
        {
            get
            {
                return underLineStyle;
            }

            set
            {
                underLineStyle = value;
                this.Invalidate();
            }
        }

        public int BorderSize
        {
            get
            {
                return borderSize;
            }

            set
            {
                borderSize = value;
                this.Invalidate();
            }
        }

       public bool PassWordChar
        {
            get { return textBox1.UseSystemPasswordChar; }
            set { textBox1.UseSystemPasswordChar = value; }
        }

        public bool Multilinie
        {
            get { return textBox1.Multiline; }
            set { textBox1.Multiline = value; }
        }

        public override Color BackColor
        {
            get
            {
                return base.BackColor;
            }

            set
            {
                base.BackColor = value;
                textBox1.BackColor = value;
            }
        }

        public override Color ForeColor
        {
            get
            {
                return base.ForeColor;
            }

            set
            {
                base.ForeColor = value;
                textBox1.ForeColor = value;
            }
        }

        public override Font Font
        {
            get
            {
                return base.Font;
            }

            set
            {
                base.Font = value;
                textBox1.Font = value;
                if (this.DesignMode)
            
                    UpdateControlHeight();
            
            }
        }

        public string Texts
        {
            get
            {
                return textBox1.Text;
            }

            set
            {
                textBox1.Text = value;
            }
        }

        public Color BorderFocusColor
        {
            get
            {
                return borderFocusColor;
            }

            set
            {
                borderFocusColor = value;
            }
        }

 
        //constructor
        public textBoxPersozalizado()
        {
            InitializeComponent();
        }

        //eventos

        public event EventHandler _textChanged;

        //Anulacion de metodos de evenntos para poder redibujar el objeto

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics grafic = e.Graphics; // grafico de pintura

            //dibujo del borde del cuadro de texto
            using (Pen penborder = new Pen(borderColor, borderSize))
            {
                penborder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;

                if (!isFocused)
                {

                    //estilo de subrayado 
                    if (underLineStyle) //esta activado
                    {
                        grafic.DrawLine(penborder, 0, this.Height - 1, this.Width, this.Height - 1);//estilo borde subrayado
                    }
                    else //no esta activado
                    {
                        grafic.DrawRectangle(penborder, 0, 0, this.Width - 0.5F, this.Height - 0.5F); //estilo borde normal 

                    }
                }
                else
                {
                    //si esta enfocado cambia de color
                    penborder.Color = borderFocusColor;

                    //estilo de subrayado 
                    if (underLineStyle) //esta activado
                    {
                        grafic.DrawLine(penborder, 0, this.Height - 1, this.Width, this.Height - 1);//estilo borde subrayado
                    }
                    else //no esta activado
                    {
                        grafic.DrawRectangle(penborder, 0, 0, this.Width - 0.5F, this.Height - 0.5F); //estilo borde normal 

                    }
                }
            }
        }

        //establecer el alto adecuado del objeto
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if(this.DesignMode)
            UpdateControlHeight();
        }

        //carga en tiempo de ejecucion el cambio de diseño
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            UpdateControlHeight();
        }


        //metodo privao para realizar el alto adecudo mientras sea falso la opcion Multilinea
        private void UpdateControlHeight()
        {
           
            if (textBox1.Multiline == false)
            {
                int txtHeight = TextRenderer.MeasureText("text", this.Font).Height + 1;
                textBox1.Multiline = true;
                textBox1.MinimumSize = new Size(0, txtHeight);
                textBox1.Multiline = false;
                //asigna el alto adecuado al objeto
                this.Height = textBox1.Height + this.Padding.Top + this.Padding.Bottom;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (_textChanged != null)
            {
                _textChanged.Invoke(sender, e);
            }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            this.OnMouseEnter(e);
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            this.OnMouseLeave(e);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.OnKeyPress(e);
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            isFocused = true;
            this.Invalidate();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            isFocused = false;
            this.Invalidate();
        }
 
    }
}
