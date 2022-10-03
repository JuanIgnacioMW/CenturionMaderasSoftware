namespace inicio
{
    partial class bienvenido
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bienvenido));
            this.panel_bienvenida = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.msj_bienvenida = new System.Windows.Forms.Label();
            this.LNombreUsuario = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.barraProgresoPersonalizada1 = new inicio.Controles.BarraProgresoPersonalizada();
            this.panel_bienvenida.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_bienvenida
            // 
            this.panel_bienvenida.BackColor = System.Drawing.Color.Tan;
            this.panel_bienvenida.Controls.Add(this.pictureBox1);
            this.panel_bienvenida.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_bienvenida.Location = new System.Drawing.Point(0, 0);
            this.panel_bienvenida.Name = "panel_bienvenida";
            this.panel_bienvenida.Size = new System.Drawing.Size(708, 64);
            this.panel_bienvenida.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(568, -18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(139, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(2, 137);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(706, 289);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // msj_bienvenida
            // 
            this.msj_bienvenida.AutoSize = true;
            this.msj_bienvenida.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msj_bienvenida.Location = new System.Drawing.Point(11, 89);
            this.msj_bienvenida.Name = "msj_bienvenida";
            this.msj_bienvenida.Size = new System.Drawing.Size(187, 36);
            this.msj_bienvenida.TabIndex = 2;
            this.msj_bienvenida.Text = "BIENVENIDO";
            // 
            // LNombreUsuario
            // 
            this.LNombreUsuario.AutoSize = true;
            this.LNombreUsuario.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNombreUsuario.Location = new System.Drawing.Point(189, 88);
            this.LNombreUsuario.Name = "LNombreUsuario";
            this.LNombreUsuario.Size = new System.Drawing.Size(140, 36);
            this.LNombreUsuario.TabIndex = 1;
            this.LNombreUsuario.Text = "NOMBRE";
            // 
            // timer1
            // 
            this.timer1.Interval = 40;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 40;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // barraProgresoPersonalizada1
            // 
            this.barraProgresoPersonalizada1.ChannelColor = System.Drawing.Color.Tan;
            this.barraProgresoPersonalizada1.ChannelHeight = 13;
            this.barraProgresoPersonalizada1.ForeBackColor = System.Drawing.Color.Wheat;
            this.barraProgresoPersonalizada1.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.barraProgresoPersonalizada1.Location = new System.Drawing.Point(4, 144);
            this.barraProgresoPersonalizada1.Name = "barraProgresoPersonalizada1";
            this.barraProgresoPersonalizada1.ShowValue = inicio.Controles.TextPosition.right;
            this.barraProgresoPersonalizada1.Size = new System.Drawing.Size(562, 32);
            this.barraProgresoPersonalizada1.SliderColor = System.Drawing.Color.MediumSlateBlue;
            this.barraProgresoPersonalizada1.SliderHeight = 7;
            this.barraProgresoPersonalizada1.TabIndex = 3;
            // 
            // bienvenido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(708, 408);
            this.Controls.Add(this.barraProgresoPersonalizada1);
            this.Controls.Add(this.LNombreUsuario);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel_bienvenida);
            this.Controls.Add(this.msj_bienvenida);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "bienvenido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "bienvenido";
            this.Load += new System.EventHandler(this.bienvenido_Load);
            this.panel_bienvenida.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_bienvenida;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label msj_bienvenida;
        private System.Windows.Forms.Label LNombreUsuario;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private Controles.BarraProgresoPersonalizada barraProgresoPersonalizada1;
    }
}