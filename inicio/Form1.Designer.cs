namespace inicio
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cerrar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPersozalizado2 = new inicio.Controles.textBoxPersozalizado();
            this.textBoxPersozalizado1 = new inicio.Controles.textBoxPersozalizado();
            this.label2 = new System.Windows.Forms.Label();
            this.lUsuario = new System.Windows.Forms.Label();
            this.lContraseña = new System.Windows.Forms.Label();
            this.Iniciar = new InicioSistema.Controles.botonPersonalizado();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 430);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // cerrar
            // 
            this.cerrar.AutoSize = true;
            this.cerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cerrar.Location = new System.Drawing.Point(674, 0);
            this.cerrar.Name = "cerrar";
            this.cerrar.Size = new System.Drawing.Size(27, 25);
            this.cerrar.TabIndex = 2;
            this.cerrar.Text = "X";
            this.cerrar.Click += new System.EventHandler(this.cerrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(421, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 65);
            this.label1.TabIndex = 3;
            this.label1.Text = "Iniciar";
            // 
            // textBoxPersozalizado2
            // 
            this.textBoxPersozalizado2.BackColor = System.Drawing.Color.Wheat;
            this.textBoxPersozalizado2.BorderColor = System.Drawing.Color.Peru;
            this.textBoxPersozalizado2.BorderFocusColor = System.Drawing.Color.MediumSlateBlue;
            this.textBoxPersozalizado2.BorderSize = 1;
            this.textBoxPersozalizado2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPersozalizado2.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxPersozalizado2.Location = new System.Drawing.Point(420, 302);
            this.textBoxPersozalizado2.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPersozalizado2.Multilinie = false;
            this.textBoxPersozalizado2.Name = "textBoxPersozalizado2";
            this.textBoxPersozalizado2.Padding = new System.Windows.Forms.Padding(7);
            this.textBoxPersozalizado2.PassWordChar = true;
            this.textBoxPersozalizado2.Size = new System.Drawing.Size(250, 31);
            this.textBoxPersozalizado2.TabIndex = 5;
            this.textBoxPersozalizado2.Texts = "";
            this.textBoxPersozalizado2.UnderLineStyle = false;
            // 
            // textBoxPersozalizado1
            // 
            this.textBoxPersozalizado1.BackColor = System.Drawing.Color.Wheat;
            this.textBoxPersozalizado1.BorderColor = System.Drawing.Color.Peru;
            this.textBoxPersozalizado1.BorderFocusColor = System.Drawing.Color.MediumSlateBlue;
            this.textBoxPersozalizado1.BorderSize = 1;
            this.textBoxPersozalizado1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPersozalizado1.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxPersozalizado1.Location = new System.Drawing.Point(420, 235);
            this.textBoxPersozalizado1.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPersozalizado1.Multilinie = false;
            this.textBoxPersozalizado1.Name = "textBoxPersozalizado1";
            this.textBoxPersozalizado1.Padding = new System.Windows.Forms.Padding(7);
            this.textBoxPersozalizado1.PassWordChar = false;
            this.textBoxPersozalizado1.Size = new System.Drawing.Size(250, 31);
            this.textBoxPersozalizado1.TabIndex = 4;
            this.textBoxPersozalizado1.Texts = "";
            this.textBoxPersozalizado1.UnderLineStyle = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(562, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 40);
            this.label2.TabIndex = 6;
            this.label2.Text = "Sesión";
            // 
            // lUsuario
            // 
            this.lUsuario.AutoSize = true;
            this.lUsuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lUsuario.Location = new System.Drawing.Point(417, 211);
            this.lUsuario.Name = "lUsuario";
            this.lUsuario.Size = new System.Drawing.Size(82, 21);
            this.lUsuario.TabIndex = 7;
            this.lUsuario.Text = "USUARIO";
            // 
            // lContraseña
            // 
            this.lContraseña.AutoSize = true;
            this.lContraseña.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lContraseña.Location = new System.Drawing.Point(419, 279);
            this.lContraseña.Name = "lContraseña";
            this.lContraseña.Size = new System.Drawing.Size(122, 21);
            this.lContraseña.TabIndex = 8;
            this.lContraseña.Text = "CONTRASEÑA";
            // 
            // Iniciar
            // 
            this.Iniciar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Iniciar.backGroundColor = System.Drawing.Color.MediumSlateBlue;
            this.Iniciar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Iniciar.BorderRadius = 40;
            this.Iniciar.BorderSize = 0;
            this.Iniciar.FlatAppearance.BorderSize = 0;
            this.Iniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Iniciar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Iniciar.ForeColor = System.Drawing.Color.White;
            this.Iniciar.Location = new System.Drawing.Point(538, 378);
            this.Iniciar.Name = "Iniciar";
            this.Iniciar.Size = new System.Drawing.Size(150, 40);
            this.Iniciar.TabIndex = 32;
            this.Iniciar.Text = "Iniciar";
            this.Iniciar.textColor = System.Drawing.Color.White;
            this.Iniciar.UseVisualStyleBackColor = false;
            this.Iniciar.Click += new System.EventHandler(this.Iniciar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(700, 430);
            this.Controls.Add(this.Iniciar);
            this.Controls.Add(this.lContraseña);
            this.Controls.Add(this.lUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPersozalizado2);
            this.Controls.Add(this.textBoxPersozalizado1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cerrar);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label cerrar;
        private System.Windows.Forms.Label label1;
        private Controles.textBoxPersozalizado textBoxPersozalizado1;
        private Controles.textBoxPersozalizado textBoxPersozalizado2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lUsuario;
        private System.Windows.Forms.Label lContraseña;
        private InicioSistema.Controles.botonPersonalizado Iniciar;
    }
}

