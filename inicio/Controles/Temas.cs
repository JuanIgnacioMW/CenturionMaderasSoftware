using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace InicioSistema.Controles
{
    public class Temas : CheckBox
    {
        //campos de aparincia
        //color de fondo para estado enncendido
        private Color onBackColor = Color.Coral; //palanca on
        private Color onTema = Color.WhiteSmoke; //fondo
        private Color offBackColor = Color.Gray; //palanca off
        private Color offTema = Color.Gainsboro; //fondo
        private bool solidStyle = true;

        //atributos
        public Color OnBackColor
        {
            get
            {
                return onBackColor;
            }

            set
            {
                onBackColor = value;
                this.Invalidate();
            }
        }

        public Color OnTema
        {
            get
            {
                return onTema;
            }

            set
            {
                onTema = value;
                this.Invalidate();
            }
        }
       
        public Color OffBackColor
        {
            get
            {
                return offBackColor;
            }

            set
            {
                offBackColor = value;
                this.Invalidate();
            }
        }

        public Color OffTema
        {
            get
            {
                return offTema;
            }

            set
            {
                offTema = value;
                this.Invalidate();
            }
        }

        public override string Text
        {
            get
            {
                return base.Text;
            }

            set
            {

            }
        }

        [DefaultValue(true)]
        public bool SolidStyle
        {
            get
            {
                return solidStyle;
            }

            set
            {
                solidStyle = value;
                this.Invalidate();
            }
        }

        //Constructor

        public Temas()
        {
            //Tamaño minimo del control
            this.MinimumSize = new Size(45, 22);

        }

        //Metodos

        //ruta de grafico ppara la superficie del control
        private GraphicsPath GetFigurePath()
        {
            //para bordes redondeados
            int arcTamano = this.Height - 1;
            Rectangle arcoIzquierdo = new Rectangle(0, 0, arcTamano, arcTamano);
            Rectangle arcoDerecho = new Rectangle(this.Width - arcTamano - 2, 0, arcTamano, arcTamano);

            //ruta de grafico

            GraphicsPath ruta = new GraphicsPath();

            //iniciamo la figura de la ruta
            ruta.StartFigure();
            //agregamos arco al arco izquierdo
            ruta.AddArc(arcoIzquierdo, 90, 180);
            //agregamos arco al arco derecho
            ruta.AddArc(arcoDerecho, 270, 180);
            //se cierra la figura 
            ruta.CloseFigure();
            //devolver la ruta de grafico
            return ruta;
        }

        //se anula el evento de pintura de control

        protected override void OnPaint(PaintEventArgs pevent)
        {
            //tamaño de la palanca
            int tamano = this.Height - 5;
            //uso dell parametro pevent para realizar el dibujo
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            pevent.Graphics.Clear(this.Parent.BackColor);

            //encendido-apagado

            if (this.Checked) //encendido
            {
                if (solidStyle)
                {
                    //color de superficie del control (boton)
                    pevent.Graphics.FillPath(new SolidBrush(onBackColor), GetFigurePath());
                }    //palanca de control 
                else pevent.Graphics.DrawPath(new Pen(onBackColor, 2), GetFigurePath());
               pevent.Graphics.FillEllipse(new SolidBrush(onTema), new Rectangle(this.Width - this.Height + 1, 2, tamano, tamano));
                
                
            }
            else //apagado
            {
                if (solidStyle)
                {
                    //color de superficie del control (boton)
                    pevent.Graphics.FillPath(new SolidBrush(offBackColor), GetFigurePath());
                }
                else pevent.Graphics.DrawPath(new Pen(offBackColor, 2), GetFigurePath());
                //palanca de control 
                pevent.Graphics.FillEllipse(new SolidBrush(offTema), new Rectangle(2, 2, tamano, tamano));
                
            }
        }
    }
}
