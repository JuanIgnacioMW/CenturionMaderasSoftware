namespace inicio.Administrador
{
    partial class Inicio2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio2));
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1Estado = new System.Windows.Forms.ComboBox();
            this.comboBox2Tipo = new System.Windows.Forms.ComboBox();
            this.textBox1DEscripcion = new System.Windows.Forms.TextBox();
            this.textBox2PrecioVenta = new System.Windows.Forms.TextBox();
            this.textBox3Stock = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.botonPersonalizado2 = new InicioSistema.Controles.botonPersonalizado();
            this.botonPersonalizado1 = new InicioSistema.Controles.botonPersonalizado();
            this.btnVolver = new InicioSistema.Controles.botonPersonalizado();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(125, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 48;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 281);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(714, 216);
            this.dataGridView1.TabIndex = 57;
            // 
            // comboBox1Estado
            // 
            this.comboBox1Estado.FormattingEnabled = true;
            this.comboBox1Estado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.comboBox1Estado.Location = new System.Drawing.Point(53, 86);
            this.comboBox1Estado.Name = "comboBox1Estado";
            this.comboBox1Estado.Size = new System.Drawing.Size(150, 21);
            this.comboBox1Estado.TabIndex = 58;
            // 
            // comboBox2Tipo
            // 
            this.comboBox2Tipo.FormattingEnabled = true;
            this.comboBox2Tipo.Items.AddRange(new object[] {
            "Duras",
            "Semi Duras"});
            this.comboBox2Tipo.Location = new System.Drawing.Point(53, 143);
            this.comboBox2Tipo.Name = "comboBox2Tipo";
            this.comboBox2Tipo.Size = new System.Drawing.Size(150, 21);
            this.comboBox2Tipo.TabIndex = 59;
            // 
            // textBox1DEscripcion
            // 
            this.textBox1DEscripcion.Location = new System.Drawing.Point(53, 30);
            this.textBox1DEscripcion.Name = "textBox1DEscripcion";
            this.textBox1DEscripcion.Size = new System.Drawing.Size(240, 20);
            this.textBox1DEscripcion.TabIndex = 60;
            this.textBox1DEscripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1DEscripcion_KeyPress);
            this.textBox1DEscripcion.Validating += new System.ComponentModel.CancelEventHandler(this.textBox1DEscripcion_Validating);
            // 
            // textBox2PrecioVenta
            // 
            this.textBox2PrecioVenta.Location = new System.Drawing.Point(53, 198);
            this.textBox2PrecioVenta.Name = "textBox2PrecioVenta";
            this.textBox2PrecioVenta.Size = new System.Drawing.Size(114, 20);
            this.textBox2PrecioVenta.TabIndex = 61;
            // 
            // textBox3Stock
            // 
            this.textBox3Stock.Location = new System.Drawing.Point(193, 198);
            this.textBox3Stock.Name = "textBox3Stock";
            this.textBox3Stock.Size = new System.Drawing.Size(100, 20);
            this.textBox3Stock.TabIndex = 62;
            this.textBox3Stock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3Stock_KeyPress);
            this.textBox3Stock.Validating += new System.ComponentModel.CancelEventHandler(this.textBox3Stock_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 18);
            this.label1.TabIndex = 63;
            this.label1.Text = "Descripción:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 18);
            this.label2.TabIndex = 64;
            this.label2.Text = "Estado: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(68, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 18);
            this.label3.TabIndex = 65;
            this.label3.Text = "Tipo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 18);
            this.label4.TabIndex = 66;
            this.label4.Text = "Precio Venta:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(190, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 18);
            this.label5.TabIndex = 67;
            this.label5.Text = "Stock:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(315, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 272);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 70;
            this.pictureBox1.TabStop = false;
            // 
            // botonPersonalizado2
            // 
            this.botonPersonalizado2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.botonPersonalizado2.backGroundColor = System.Drawing.Color.MediumSlateBlue;
            this.botonPersonalizado2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.botonPersonalizado2.BorderRadius = 40;
            this.botonPersonalizado2.BorderSize = 0;
            this.botonPersonalizado2.FlatAppearance.BorderSize = 0;
            this.botonPersonalizado2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonPersonalizado2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonPersonalizado2.ForeColor = System.Drawing.Color.White;
            this.botonPersonalizado2.Location = new System.Drawing.Point(178, 233);
            this.botonPersonalizado2.Name = "botonPersonalizado2";
            this.botonPersonalizado2.Size = new System.Drawing.Size(115, 33);
            this.botonPersonalizado2.TabIndex = 69;
            this.botonPersonalizado2.Text = "Cancelar";
            this.botonPersonalizado2.textColor = System.Drawing.Color.White;
            this.botonPersonalizado2.UseVisualStyleBackColor = false;
            this.botonPersonalizado2.Click += new System.EventHandler(this.botonPersonalizado2_Click);
            // 
            // botonPersonalizado1
            // 
            this.botonPersonalizado1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.botonPersonalizado1.backGroundColor = System.Drawing.Color.MediumSlateBlue;
            this.botonPersonalizado1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.botonPersonalizado1.BorderRadius = 40;
            this.botonPersonalizado1.BorderSize = 0;
            this.botonPersonalizado1.FlatAppearance.BorderSize = 0;
            this.botonPersonalizado1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonPersonalizado1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonPersonalizado1.ForeColor = System.Drawing.Color.White;
            this.botonPersonalizado1.Location = new System.Drawing.Point(39, 233);
            this.botonPersonalizado1.Name = "botonPersonalizado1";
            this.botonPersonalizado1.Size = new System.Drawing.Size(128, 33);
            this.botonPersonalizado1.TabIndex = 68;
            this.botonPersonalizado1.Text = "Confirmar";
            this.botonPersonalizado1.textColor = System.Drawing.Color.White;
            this.botonPersonalizado1.UseVisualStyleBackColor = false;
            this.botonPersonalizado1.Click += new System.EventHandler(this.botonPersonalizado1_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnVolver.backGroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnVolver.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnVolver.BorderRadius = 40;
            this.btnVolver.BorderSize = 0;
            this.btnVolver.FlatAppearance.BorderSize = 0;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.Color.White;
            this.btnVolver.Location = new System.Drawing.Point(265, 503);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(150, 40);
            this.btnVolver.TabIndex = 53;
            this.btnVolver.Text = "Volver";
            this.btnVolver.textColor = System.Drawing.Color.White;
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // Inicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(716, 545);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.botonPersonalizado2);
            this.Controls.Add(this.botonPersonalizado1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3Stock);
            this.Controls.Add(this.textBox2PrecioVenta);
            this.Controls.Add(this.textBox1DEscripcion);
            this.Controls.Add(this.comboBox2Tipo);
            this.Controls.Add(this.comboBox1Estado);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Inicio2";
            this.Text = "Inicio2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private InicioSistema.Controles.botonPersonalizado btnVolver;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1Estado;
        private System.Windows.Forms.ComboBox comboBox2Tipo;
        private System.Windows.Forms.TextBox textBox1DEscripcion;
        private System.Windows.Forms.TextBox textBox2PrecioVenta;
        private System.Windows.Forms.TextBox textBox3Stock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private InicioSistema.Controles.botonPersonalizado botonPersonalizado1;
        private InicioSistema.Controles.botonPersonalizado botonPersonalizado2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}