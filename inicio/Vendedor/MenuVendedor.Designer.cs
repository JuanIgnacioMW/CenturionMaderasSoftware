namespace inicio.Vendedor
{
    partial class MenuVendedor
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
            this.comboxPersonalizado1 = new inicio.Controles.ComboxPersonalizado();
            this.comboxPersonalizado2 = new inicio.Controles.ComboxPersonalizado();
            this.SuspendLayout();
            // 
            // comboxPersonalizado1
            // 
            this.comboxPersonalizado1.BackColor = System.Drawing.Color.Wheat;
            this.comboxPersonalizado1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.comboxPersonalizado1.BorderSize = 1;
            this.comboxPersonalizado1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.comboxPersonalizado1.ForeColor = System.Drawing.Color.DimGray;
            this.comboxPersonalizado1.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.comboxPersonalizado1.ListBackColor = System.Drawing.Color.PapayaWhip;
            this.comboxPersonalizado1.ListTextColor = System.Drawing.Color.DimGray;
            this.comboxPersonalizado1.Location = new System.Drawing.Point(59, 27);
            this.comboxPersonalizado1.MinimumSize = new System.Drawing.Size(200, 30);
            this.comboxPersonalizado1.Name = "comboxPersonalizado1";
            this.comboxPersonalizado1.Padding = new System.Windows.Forms.Padding(1);
            this.comboxPersonalizado1.Size = new System.Drawing.Size(200, 30);
            this.comboxPersonalizado1.TabIndex = 0;
            this.comboxPersonalizado1.Texts = "";
            // 
            // comboxPersonalizado2
            // 
            this.comboxPersonalizado2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboxPersonalizado2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboxPersonalizado2.BackColor = System.Drawing.Color.Wheat;
            this.comboxPersonalizado2.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.comboxPersonalizado2.BorderSize = 1;
            this.comboxPersonalizado2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.comboxPersonalizado2.ForeColor = System.Drawing.Color.DimGray;
            this.comboxPersonalizado2.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.comboxPersonalizado2.Items.AddRange(new object[] {
            "carlos",
            "gustavo",
            "navarro",
            "juan",
            "meza",
            "wakahayashi"});
            this.comboxPersonalizado2.ListBackColor = System.Drawing.Color.PapayaWhip;
            this.comboxPersonalizado2.ListTextColor = System.Drawing.Color.DimGray;
            this.comboxPersonalizado2.Location = new System.Drawing.Point(72, 125);
            this.comboxPersonalizado2.MinimumSize = new System.Drawing.Size(200, 30);
            this.comboxPersonalizado2.Name = "comboxPersonalizado2";
            this.comboxPersonalizado2.Padding = new System.Windows.Forms.Padding(1);
            this.comboxPersonalizado2.Size = new System.Drawing.Size(200, 30);
            this.comboxPersonalizado2.TabIndex = 1;
            this.comboxPersonalizado2.Texts = "";
            // 
            // MenuVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.comboxPersonalizado2);
            this.Controls.Add(this.comboxPersonalizado1);
            this.Name = "MenuVendedor";
            this.Text = "MenuVendedor";
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.ComboxPersonalizado comboxPersonalizado1;
        private Controles.ComboxPersonalizado comboxPersonalizado2;
    }
}