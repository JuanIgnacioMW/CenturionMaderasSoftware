using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;


namespace inicio.Controles
{
    public enum TextPosition
    {
        left,
        right,
        center,
        sliding,
        none
    }
    class BarraProgresoPersonalizada: ProgressBar
    {
        //campos
        private Color channelColor = Color.LightSteelBlue;
        private Color sliderColor = Color.RoyalBlue;
        private Color foreBackColor = Color.RoyalBlue;
        private int channelHeight = 6;
        private int sliderHeight = 6;
        private TextPosition showValue = TextPosition.right;

        //otros campos para evitar parpadeo de barra

        private bool paintedBack = false;
        private bool stopPainting = false;

        [Category("Personalizacion")]
         public Color ChannelColor
        {
            get
            {
                return channelColor;
            }

            set
            {
                channelColor = value;
                this.Invalidate();
            }
        }


        [Category("Personalizacion")]

        public Color SliderColor
        {
            get
            {
                return sliderColor;
            }

            set
            {
                sliderColor = value;
                this.Invalidate();
            }
        }

        [Category("Personalizacion")]
        public Color ForeBackColor
        {
            get
            {
                return foreBackColor;
            }

            set
            {
                foreBackColor = value;
                this.Invalidate();
            }
        }

        [Category("Personalizacion")]
        public int ChannelHeight
        {
            get
            {
                return channelHeight;
            }

            set
            {
                channelHeight = value;
                this.Invalidate();
            }
        }

        [Category("Personalizacion")]
        public int SliderHeight
        {
            get
            {
                return sliderHeight;
            }

            set
            {
                sliderHeight = value;
                this.Invalidate();
            }
        }

        [Category("Personalizacion")]
        public TextPosition ShowValue
        {
            get
            {
                return showValue;
            }

            set
            {
                showValue = value;
                this.Invalidate();
            }
        }

        //anulacion de fuente
        [Category("Personalizacion")]
        [Browsable(true)]
            [EditorBrowsable (EditorBrowsableState.Always)]
        public override Font Font
        {
            get
            {
                return base.Font;
            }

            set
            {
                base.Font = value;
                
            }
        }

        [Category ("Personalizacion")]
        public override Color ForeColor
        {
            get
            {
                return base.ForeColor;
            }

            set
            {
                base.ForeColor = value;
            }
        }

        //Constructor
        public BarraProgresoPersonalizada ()
        {
            this.SetStyle(ControlStyles.UserPaint, true);
            this.ForeColor = Color.White;
        }

        //Pintado de fono y del canal

        protected override void OnPaintBackground(PaintEventArgs pevent)
        {
            //se corrobora que no se pinto el fondo y si se dejo de pintar
            if (stopPainting == false)
            {
                if (paintedBack == false)
                {
                    //objetos a pintar
                    Graphics graph = pevent.Graphics;
                    Rectangle rectChannel = new Rectangle(0,0,this.Width,ChannelHeight);
                    using (var brushChannel = new SolidBrush(channelColor))
                    {
                        //canal externo y canal interno
                        if (channelHeight >= sliderHeight)
                        {
                            rectChannel.Y = this.Height - channelHeight;
                        }
                        else
                        {
                            rectChannel.Y = this.Height - ((channelHeight+sliderHeight) / 2);
                        }

                        //pintado
                        graph.Clear(this.Parent.BackColor);//surface
                        graph.FillRectangle(brushChannel, rectChannel); //canal

                        //parada de pintado de fondo y canal
                        if (this.DesignMode == false)
                        {
                            paintedBack = true;
                        }
                    }

                }
                //reinicio del pintado del canal y fondo
                if (this.Value==this.Maximum || this.Value == this.Minimum)
                {
                    paintedBack = false;
                }
            }
        }

        //pintado de deslizador

        protected override void OnPaint(PaintEventArgs e)
        {
            if (stopPainting==false)
            {
                //campos
                Graphics graph = e.Graphics;
                double scaleFactor = (((double)this.Value - this.Minimum) / ((double)this.Maximum - this.Minimum));
                int sliderWidth = (int)(this.Width * scaleFactor);
                Rectangle rectSlider = new Rectangle(0,0,sliderWidth,sliderHeight);
                using (var brushSlider = new SolidBrush(sliderColor))
                {
                    if (sliderHeight >= channelHeight)
                    {
                        rectSlider.Y = this.Height - sliderHeight;
                    }
                    else
                    {
                        rectSlider.Y = this.Height - ((sliderHeight + channelHeight)/2);
                    }
                    //pintado
                    if (sliderWidth >1)
                    {
                        graph.FillRectangle(brushSlider,rectSlider); //deslizador
                    }
                    if (showValue != TextPosition.none)
                    {
                        DrawValueText(graph,sliderWidth,rectSlider);//texto
                    }
                }
            }

            if(this.Value == this.Maximum)
            {
                stopPainting = true;
            }
            else
            {
                stopPainting = false;
            }
        }

        //pintado del texto del valor
        private void DrawValueText(Graphics graph, int sliderWidth, Rectangle rectSlider)
        {
            //campos

            string text = this.Value.ToString() + "%";
            var textSize = TextRenderer.MeasureText(text,this.Font);
            var rectText = new Rectangle(0,0,textSize.Width, textSize.Height+2);
            using (var brushText = new SolidBrush(this.ForeColor))
            using (var brushTexBack = new SolidBrush(this.foreBackColor))
            using (var textFormat = new StringFormat())
            {
                switch (showValue)
                {
                    case TextPosition.left:
                        rectText.X = 0;
                        textFormat.Alignment = StringAlignment.Near;
                        break;
                    case TextPosition.right:
                        rectText.X = this.Width-textSize.Width;
                        textFormat.Alignment = StringAlignment.Far;
                        break;
                    case TextPosition.center:
                        rectText.X = (this.Width - textSize.Width) / 2 ;
                        textFormat.Alignment = StringAlignment.Center;
                        break;
                    case TextPosition.sliding:
                        rectText.X = sliderWidth-textSize.Width;
                        textFormat.Alignment = StringAlignment.Center;
                        //se limpia la superficie el text previo
                        using (var brushClear = new SolidBrush(this.Parent.BackColor))
                        {
                            var rect = rectSlider;
                            rect.Y = rectText.Y;
                            rect.Height = rectText.Height;
                            graph.FillRectangle(brushClear,rect);
                        }
                            break;
                }
                //dibujo del texto y el valor de la barra de progreso
                graph.FillRectangle(brushTexBack,rectText);
                graph.DrawString(text,this.Font, brushText, rectText,textFormat);
            }
        }


       
    }
}
