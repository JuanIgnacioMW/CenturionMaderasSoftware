using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;
using System.Drawing.Design;

namespace inicio.Controles
{
    [DefaultEvent("OnSelectedIndexChanged")]
    class ComboxPersonalizado : UserControl
    {
        //Campos
        private Color backColor = Color.Wheat;
        private Color iconColor = Color.MediumSlateBlue;
        private Color listBackColor = Color.PapayaWhip;
        private Color listTextColor = Color.DimGray;
        private Color borderColor = Color.MediumSlateBlue;
        private int borderSize = 1;

        //Items del Combo Box
        private ComboBox cmbList;
        private Label LblText;
        private Button btnIcon;

        //Propiedades
        [Category("Apariencia")]
        public new Color BackColor
        {
            get
            {
                return backColor;
            }

            set
            {
                backColor = value;
                LblText.BackColor = backColor;
                btnIcon.BackColor = backColor;
            }
        }

        [Category("Apariencia")]
        public Color IconColor
        {
            get
            {
                return iconColor;
            }

            set
            {
                iconColor = value;
                btnIcon.Invalidate();//redibujar el color del icono
            }
        }

        [Category("Apariencia")]
        public Color ListBackColor
        {
            get
            {
                return listBackColor;
            }

            set
            {
                listBackColor = value;
                cmbList.BackColor = backColor;
            }
        }

        [Category("Apariencia")]
        public Color ListTextColor
        {
            get
            {
                return listTextColor;
            }

            set
            {
                listTextColor = value;
                cmbList.ForeColor = listTextColor;
            }
        }

        [Category("Apariencia")]
        public Color BorderColor
        {
            get
            {
                return borderColor;
            }

            set
            {
                borderColor = value;
                base.BackColor = borderColor;
            }
        }

        [Category("Apariencia")]
        public int BorderSize
        {
            get
            {
                return borderSize;
            }

            set
            {
                borderSize = value;
                this.Padding = new Padding(borderSize);
                AdjustComboBoxDimensions();
            }
        }

        [Category("Apariencia")]
        public override Color ForeColor
        {
            get
            {
                return base.ForeColor;
            }

            set
            {
                base.ForeColor = value;
                LblText.ForeColor = value;
            }
        }

        [Category("Apariencia")]
        public override Font Font
        {
            get
            {
                return base.Font;
            }

            set
            {
                base.Font = value;
                LblText.Font = value;
                cmbList.Font = value;
            }
        }

        [Category("Apariencia")]
        public string Texts
        {
            get { return LblText.Text; }
            set { LblText.Text = value; }
        }

        [Category("Apariencia")]
        public ComboBoxStyle DropDownStyle
        {
            get { return cmbList.DropDownStyle; }
            set {
                if (cmbList.DropDownStyle != ComboBoxStyle.Simple)
                    cmbList.DropDownStyle = value; }
        }

        //Manipuacion de Datos

        [Category("Manipulacion")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Editor("System.Windows.Forms.Design.ListControlStringCollectionEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        [Localizable(true)]
        [MergableProperty(false)]
        public ComboBox.ObjectCollection Items
        {
            get
            {
                return cmbList.Items;
            }
        }

        [Category("Manipulacion")]
        [AttributeProvider(typeof(IListSource))]
        [DefaultValue(null)]
        [RefreshProperties(RefreshProperties.Repaint)]

        public object DataSource
        {
            get
            {
                return cmbList.DataSource;
            }
            set
            {
                cmbList.DataSource = value;
            }


        }

        [Category("Manipulacion")]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Editor("System.Windows.Forms.Design.ListControlStringCollectionEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Localizable(true)]
        public AutoCompleteStringCollection AutoCompleteCustomSource
        {
            get { return cmbList.AutoCompleteCustomSource; }
            set { cmbList.AutoCompleteCustomSource = value; }
        }


        [Category("Manipulacion")]
        [Browsable(true)]
        [DefaultValue(AutoCompleteMode.None)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public AutoCompleteMode AutoCompleteMode
        {
            get { return cmbList.AutoCompleteMode; }
            set { cmbList.AutoCompleteMode = value; }
        }

        [Category("Manipulacion")]
        [Browsable(true)]
        [DefaultValue(AutoCompleteSource.None)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public AutoCompleteSource AutoCompleteSource
        {
            get { return cmbList.AutoCompleteSource; }
            set { cmbList.AutoCompleteSource = value; }
                }


        [Category("Manipulacion")]
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int SelectedIndex
        {
            get
            {
                return cmbList.SelectedIndex;
            }
            set { cmbList.SelectedIndex = value; }
        }


        [Category("Manipulacion")]
        [Bindable(true)]
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        
        public object SelectedItem
        {
            get { return cmbList.SelectedItem; }
            set { cmbList.SelectedItem = value; }
        }

        //Eventos
        public event EventHandler OnSelectedIndexChanged; //evento por defecto


        //Constructor

        public ComboxPersonalizado()
        {
            cmbList = new ComboBox();
            LblText = new Label();
            btnIcon = new Button();
            this.SuspendLayout();

            //Lista Items del combox
            cmbList.BackColor = listBackColor;
            cmbList.Font = new Font(this.Font.Name, 10f);
            cmbList.ForeColor = listTextColor;
            cmbList.SelectedIndexChanged += new EventHandler(ComboBox_SelectedIndexChanged);
            cmbList.TextChanged += new EventHandler(ComboBox_textChanged);

            //apariencia del boton icono

            btnIcon.Dock = DockStyle.Right;
            btnIcon.FlatStyle = FlatStyle.Flat;
            btnIcon.FlatAppearance.BorderSize = 0;
            btnIcon.BackColor = backColor;
            btnIcon.Size = new Size(30,30);
            btnIcon.Cursor = Cursors.Hand;
            btnIcon.Click += new EventHandler(Icon_click);
            btnIcon.Paint += new PaintEventHandler(Icon_paint);


            //Apariencia del texto

            LblText.Dock = DockStyle.Fill;
            LblText.AutoSize = false;
            LblText.BackColor = backColor;
            LblText.TextAlign = ContentAlignment.MiddleLeft;
            LblText.Padding = new Padding(8,0,0,0);
            LblText.Font = new Font(this.Font.Name, 10f);
            LblText.Click += new EventHandler(Surface_Click);
            LblText.MouseEnter += new EventHandler(Surface_MouseEnter);
            LblText.MouseLeave += new EventHandler(Surface_MouseLeave);



            //control de usuario

            this.Controls.Add(LblText);
            this.Controls.Add(btnIcon);
            this.Controls.Add(cmbList);
            this.MinimumSize = new Size(200,30);
            this.Size = new Size(200, 30);
            this.ForeColor = Color.DimGray;
            this.Padding = new Padding(borderSize);
            base.BackColor = backColor;
            this.ResumeLayout();
            AdjustComboBoxDimensions();

        }

        

        //Metodos privados
        private void AdjustComboBoxDimensions()
        {
            cmbList.Width = LblText.Width;
            cmbList.Location = new Point()
            {
                X = this.Width - this.Padding.Right - cmbList.Width,
                Y = LblText.Bottom - cmbList.Height
            };
        }

        private void Surface_Click(object sender, EventArgs e)
        {
            //Selecion del Combobox
            this.OnClick(e);
            cmbList.Select();
            if (cmbList.DropDownStyle== ComboBoxStyle.DropDownList)
            {
                cmbList.DroppedDown = true; //abro items
            }
        }

        private void Surface_MouseLeave(object sender, EventArgs e)
        {
            this.OnMouseLeave(e);
        }

        private void Surface_MouseEnter(object sender, EventArgs e)
        {
            this.OnMouseEnter(e);
        }


        //icono del comboBox
        private void Icon_paint(object sender, PaintEventArgs e)
        {
            //campos para el icono
            int iconWidht = 14;
            int iconHeight = 6;
            var rectIcon = new Rectangle((btnIcon.Width - iconWidht)/2, (btnIcon.Height - iconHeight)/2, iconWidht, iconHeight);
            Graphics graph = e.Graphics;

            //para dibujar el icono de flecha hacia abajo

            using (GraphicsPath ruta = new GraphicsPath())
            using (Pen pen = new Pen(iconColor, 2))
            {
                graph.SmoothingMode = SmoothingMode.AntiAlias;
                ruta.AddLine(rectIcon.X, rectIcon.Y, rectIcon.X +(iconWidht/2), rectIcon.Bottom);
                ruta.AddLine(rectIcon.X + (iconWidht / 2), rectIcon.Bottom, rectIcon.Right, rectIcon.Y);
                graph.DrawPath(pen, ruta);
            }
        }

        private void Icon_click(object sender, EventArgs e)
        {
            //abro items
            cmbList.Select();
            cmbList.DroppedDown = true;
        }

        private void ComboBox_textChanged(object sender, EventArgs e)
        {
            //Actualizar el texto
            LblText.Text = cmbList.Text;
        }

        //Invocar el evento predeterminado por defecto
        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (OnSelectedIndexChanged != null)
            {
                OnSelectedIndexChanged.Invoke(sender, e);
                //Actualizar el texto
                LblText.Text = cmbList.Text;

            }
        }

        //anulacion de algunos metodos para ajustar dimension
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            AdjustComboBoxDimensions();
        }
    }
}
