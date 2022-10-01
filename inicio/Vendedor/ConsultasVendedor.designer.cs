namespace inicio.Vendedor
{
    partial class ConsultasVendedor
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnConsultarClientes = new System.Windows.Forms.Button();
            this.btnConsultarProductos = new System.Windows.Forms.Button();
            this.btnConsultarMasVendido = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelSubMenuProd = new System.Windows.Forms.Panel();
            this.lCodigoNombre = new System.Windows.Forms.Label();
            this.textBoxConsulProduc = new inicio.Controles.textBoxPersozalizado();
            this.btnConsultarProd = new InicioSistema.Controles.botonPersonalizado();
            this.panelSubMenuCliente = new System.Windows.Forms.Panel();
            this.lDniNombreCliente = new System.Windows.Forms.Label();
            this.textBoxConsulCliente = new inicio.Controles.textBoxPersozalizado();
            this.btnConsulCliente = new InicioSistema.Controles.botonPersonalizado();
            this.btnVolver = new InicioSistema.Controles.botonPersonalizado();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelSubMenuProd.SuspendLayout();
            this.panelSubMenuCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnConsultarClientes);
            this.panel1.Controls.Add(this.btnConsultarProductos);
            this.panel1.Controls.Add(this.btnConsultarMasVendido);
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(807, 72);
            this.panel1.TabIndex = 0;
            // 
            // btnConsultarClientes
            // 
            this.btnConsultarClientes.FlatAppearance.BorderSize = 0;
            this.btnConsultarClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarClientes.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarClientes.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnConsultarClientes.Location = new System.Drawing.Point(552, 15);
            this.btnConsultarClientes.Name = "btnConsultarClientes";
            this.btnConsultarClientes.Size = new System.Drawing.Size(187, 32);
            this.btnConsultarClientes.TabIndex = 25;
            this.btnConsultarClientes.Text = "Consutar Clientes";
            this.btnConsultarClientes.UseVisualStyleBackColor = true;
            this.btnConsultarClientes.Click += new System.EventHandler(this.btnConsultarClientes_Click);
            // 
            // btnConsultarProductos
            // 
            this.btnConsultarProductos.FlatAppearance.BorderSize = 0;
            this.btnConsultarProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarProductos.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarProductos.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnConsultarProductos.Location = new System.Drawing.Point(263, 15);
            this.btnConsultarProductos.Name = "btnConsultarProductos";
            this.btnConsultarProductos.Size = new System.Drawing.Size(220, 32);
            this.btnConsultarProductos.TabIndex = 24;
            this.btnConsultarProductos.Text = "Consultar Productos";
            this.btnConsultarProductos.UseVisualStyleBackColor = true;
            this.btnConsultarProductos.Click += new System.EventHandler(this.btnConsultarProductos_Click);
            // 
            // btnConsultarMasVendido
            // 
            this.btnConsultarMasVendido.FlatAppearance.BorderSize = 0;
            this.btnConsultarMasVendido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarMasVendido.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarMasVendido.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnConsultarMasVendido.Location = new System.Drawing.Point(2, 15);
            this.btnConsultarMasVendido.Name = "btnConsultarMasVendido";
            this.btnConsultarMasVendido.Size = new System.Drawing.Size(233, 32);
            this.btnConsultarMasVendido.TabIndex = 23;
            this.btnConsultarMasVendido.Text = "Producto Mas Vendido";
            this.btnConsultarMasVendido.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultarMasVendido.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 257);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(801, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // panelSubMenuProd
            // 
            this.panelSubMenuProd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSubMenuProd.Controls.Add(this.lCodigoNombre);
            this.panelSubMenuProd.Controls.Add(this.textBoxConsulProduc);
            this.panelSubMenuProd.Controls.Add(this.btnConsultarProd);
            this.panelSubMenuProd.Location = new System.Drawing.Point(261, 81);
            this.panelSubMenuProd.Name = "panelSubMenuProd";
            this.panelSubMenuProd.Size = new System.Drawing.Size(238, 155);
            this.panelSubMenuProd.TabIndex = 2;
            this.panelSubMenuProd.Visible = false;
            // 
            // lCodigoNombre
            // 
            this.lCodigoNombre.AutoSize = true;
            this.lCodigoNombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCodigoNombre.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lCodigoNombre.Location = new System.Drawing.Point(13, 7);
            this.lCodigoNombre.Name = "lCodigoNombre";
            this.lCodigoNombre.Size = new System.Drawing.Size(210, 21);
            this.lCodigoNombre.TabIndex = 39;
            this.lCodigoNombre.Text = "Ingrese Codigo o Nombre";
            // 
            // textBoxConsulProduc
            // 
            this.textBoxConsulProduc.BackColor = System.Drawing.Color.Wheat;
            this.textBoxConsulProduc.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.textBoxConsulProduc.BorderFocusColor = System.Drawing.Color.Brown;
            this.textBoxConsulProduc.BorderSize = 2;
            this.textBoxConsulProduc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxConsulProduc.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxConsulProduc.Location = new System.Drawing.Point(4, 53);
            this.textBoxConsulProduc.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxConsulProduc.Multilinie = false;
            this.textBoxConsulProduc.Name = "textBoxConsulProduc";
            this.textBoxConsulProduc.Padding = new System.Windows.Forms.Padding(7);
            this.textBoxConsulProduc.PassWordChar = false;
            this.textBoxConsulProduc.Size = new System.Drawing.Size(230, 31);
            this.textBoxConsulProduc.TabIndex = 1;
            this.textBoxConsulProduc.Texts = "";
            this.textBoxConsulProduc.UnderLineStyle = false;
            // 
            // btnConsultarProd
            // 
            this.btnConsultarProd.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnConsultarProd.backGroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnConsultarProd.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnConsultarProd.BorderRadius = 40;
            this.btnConsultarProd.BorderSize = 0;
            this.btnConsultarProd.FlatAppearance.BorderSize = 0;
            this.btnConsultarProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarProd.ForeColor = System.Drawing.Color.White;
            this.btnConsultarProd.Location = new System.Drawing.Point(43, 112);
            this.btnConsultarProd.Name = "btnConsultarProd";
            this.btnConsultarProd.Size = new System.Drawing.Size(150, 40);
            this.btnConsultarProd.TabIndex = 0;
            this.btnConsultarProd.Text = "Consultar";
            this.btnConsultarProd.textColor = System.Drawing.Color.White;
            this.btnConsultarProd.UseVisualStyleBackColor = false;
            // 
            // panelSubMenuCliente
            // 
            this.panelSubMenuCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSubMenuCliente.Controls.Add(this.lDniNombreCliente);
            this.panelSubMenuCliente.Controls.Add(this.textBoxConsulCliente);
            this.panelSubMenuCliente.Controls.Add(this.btnConsulCliente);
            this.panelSubMenuCliente.Location = new System.Drawing.Point(551, 80);
            this.panelSubMenuCliente.Name = "panelSubMenuCliente";
            this.panelSubMenuCliente.Size = new System.Drawing.Size(238, 155);
            this.panelSubMenuCliente.TabIndex = 3;
            this.panelSubMenuCliente.Visible = false;
            // 
            // lDniNombreCliente
            // 
            this.lDniNombreCliente.AutoSize = true;
            this.lDniNombreCliente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDniNombreCliente.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lDniNombreCliente.Location = new System.Drawing.Point(31, 7);
            this.lDniNombreCliente.Name = "lDniNombreCliente";
            this.lDniNombreCliente.Size = new System.Drawing.Size(181, 21);
            this.lDniNombreCliente.TabIndex = 39;
            this.lDniNombreCliente.Text = "Ingrese DNI o Nombre";
            // 
            // textBoxConsulCliente
            // 
            this.textBoxConsulCliente.BackColor = System.Drawing.Color.Wheat;
            this.textBoxConsulCliente.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.textBoxConsulCliente.BorderFocusColor = System.Drawing.Color.Brown;
            this.textBoxConsulCliente.BorderSize = 2;
            this.textBoxConsulCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxConsulCliente.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxConsulCliente.Location = new System.Drawing.Point(4, 53);
            this.textBoxConsulCliente.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxConsulCliente.Multilinie = false;
            this.textBoxConsulCliente.Name = "textBoxConsulCliente";
            this.textBoxConsulCliente.Padding = new System.Windows.Forms.Padding(7);
            this.textBoxConsulCliente.PassWordChar = false;
            this.textBoxConsulCliente.Size = new System.Drawing.Size(230, 31);
            this.textBoxConsulCliente.TabIndex = 1;
            this.textBoxConsulCliente.Texts = "";
            this.textBoxConsulCliente.UnderLineStyle = false;
            // 
            // btnConsulCliente
            // 
            this.btnConsulCliente.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnConsulCliente.backGroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnConsulCliente.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnConsulCliente.BorderRadius = 40;
            this.btnConsulCliente.BorderSize = 0;
            this.btnConsulCliente.FlatAppearance.BorderSize = 0;
            this.btnConsulCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsulCliente.ForeColor = System.Drawing.Color.White;
            this.btnConsulCliente.Location = new System.Drawing.Point(43, 112);
            this.btnConsulCliente.Name = "btnConsulCliente";
            this.btnConsulCliente.Size = new System.Drawing.Size(150, 40);
            this.btnConsulCliente.TabIndex = 0;
            this.btnConsulCliente.Text = "Consultar";
            this.btnConsulCliente.textColor = System.Drawing.Color.White;
            this.btnConsulCliente.UseVisualStyleBackColor = false;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnVolver.backGroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnVolver.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnVolver.BorderRadius = 40;
            this.btnVolver.BorderSize = 0;
            this.btnVolver.FlatAppearance.BorderSize = 0;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.ForeColor = System.Drawing.Color.White;
            this.btnVolver.Location = new System.Drawing.Point(345, 428);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(96, 40);
            this.btnVolver.TabIndex = 32;
            this.btnVolver.Text = "Volver";
            this.btnVolver.textColor = System.Drawing.Color.White;
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // ConsultasVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(825, 473);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.panelSubMenuCliente);
            this.Controls.Add(this.panelSubMenuProd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConsultasVendedor";
            this.Text = "ConsultasVendedor";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelSubMenuProd.ResumeLayout(false);
            this.panelSubMenuProd.PerformLayout();
            this.panelSubMenuCliente.ResumeLayout(false);
            this.panelSubMenuCliente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnConsultarClientes;
        private System.Windows.Forms.Button btnConsultarProductos;
        private System.Windows.Forms.Button btnConsultarMasVendido;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panelSubMenuProd;
        private InicioSistema.Controles.botonPersonalizado btnConsultarProd;
        private Controles.textBoxPersozalizado textBoxConsulProduc;
        private System.Windows.Forms.Label lCodigoNombre;
        private System.Windows.Forms.Panel panelSubMenuCliente;
        private System.Windows.Forms.Label lDniNombreCliente;
        private Controles.textBoxPersozalizado textBoxConsulCliente;
        private InicioSistema.Controles.botonPersonalizado btnConsulCliente;
        private InicioSistema.Controles.botonPersonalizado btnVolver;
    }
}