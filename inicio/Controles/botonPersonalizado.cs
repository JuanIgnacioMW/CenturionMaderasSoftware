using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace InicioSistema.Controles
{
    public class botonPersonalizado : Button
    {
        //campos atributos
        private int borderSize = 0;
        private int borderRadius = 40;
        private Color borderColor = Color.PaleVioletRed;

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

        public int BorderRadius
        {
            get
            {
                return borderRadius;
            }

            set
            {
                borderRadius = value;
                this.Invalidate();
            }
        }


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

       
        public Color backGroundColor
        {
            get { return this.BackColor; }
            set { this.BackColor = value; }
        }

        public Color textColor
        {
            get { return this.ForeColor; }
            set { this.ForeColor = value; }
        }
        //Constructor
        public botonPersonalizado()
            {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Size = new Size(150,40);
            this.BackColor = Color.MediumSlateBlue;
            this.ForeColor = Color.White;
            }

        //Metodos para dibujar el boton personalizado

        private GraphicsPath GetFigurePath(RectangleF rec, float radius)
        {
            GraphicsPath ruta = new GraphicsPath();
            ruta.StartFigure();
            ruta.AddArc(rec.X, rec.Y, radius, radius, 180,90);
            ruta.AddArc(rec.Width-radius, rec.Y, radius, radius, 270, 90);
            ruta.AddArc(rec.Width - radius, rec.Height - radius, radius, radius, 0, 90);
            ruta.AddArc(rec.X, rec.Height - radius, radius, radius, 90, 90);
            ruta.CloseFigure();
            return ruta;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            RectangleF rectSurface = new RectangleF(0,0, this.Width, this.Height);
            RectangleF rectBorder = new RectangleF(1,1, this.Width-0.8F, this.Height-1);


            if (borderRadius > 2) // boton redondo
            {
                using (GraphicsPath rutaSurface = GetFigurePath(rectSurface, borderRadius))
                using (GraphicsPath rutaBorder = GetFigurePath(rectBorder, borderRadius - 1))
                using (Pen penSurface = new Pen(this.Parent.BackColor, 2))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    penBorder.Alignment = PenAlignment.Inset;
                    //para poder dibujar la superficie del boton
                    this.Region = new Region(rutaSurface);
                    //dibujo de la superficie
                    pevent.Graphics.DrawPath(penSurface, rutaSurface);


                    //borde de boton
                    if (borderSize >= 1)
                    {
                        //dibujo del borde 
                        pevent.Graphics.DrawPath(penBorder, rutaBorder);
                    }

                }
            }
            else //boton cuadrado
            {
                this.Region = new Region(rectSurface);
                if (borderSize >=1)
                {
                    using (Pen penBorder = new Pen(borderColor, borderSize))
                    {
                        penBorder.Alignment = PenAlignment.Inset;
                        pevent.Graphics.DrawRectangle(penBorder, 0,0, this.Width-1,this.Height-1);
                    }
                }
            }
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            this.Parent.BackColorChanged += new EventHandler(Container_BackColorChanged);
        }

        private void Container_BackColorChanged(object sender, EventArgs e)
        {
            this.Invalidate();
        }
    }
}
