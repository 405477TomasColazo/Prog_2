namespace Venta_pastelitos
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
            this.lbox_Vendedores = new System.Windows.Forms.ListBox();
            this.lbl_Vendedores = new System.Windows.Forms.Label();
            this.lbl_Clientes = new System.Windows.Forms.Label();
            this.lbox_clientes = new System.Windows.Forms.ListBox();
            this.text_Membrillo = new System.Windows.Forms.TextBox();
            this.text_Batata = new System.Windows.Forms.TextBox();
            this.lbl_Membrillo = new System.Windows.Forms.Label();
            this.lbl_Batata = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbox_Vendedores
            // 
            this.lbox_Vendedores.FormattingEnabled = true;
            this.lbox_Vendedores.Location = new System.Drawing.Point(43, 64);
            this.lbox_Vendedores.Name = "lbox_Vendedores";
            this.lbox_Vendedores.Size = new System.Drawing.Size(216, 381);
            this.lbox_Vendedores.TabIndex = 0;
            this.lbox_Vendedores.SelectedIndexChanged += new System.EventHandler(this.lbox_Vendedores_SelectedIndexChanged);
            this.lbox_Vendedores.Layout += new System.Windows.Forms.LayoutEventHandler(this.lbox_Vendedores_Layout);
            // 
            // lbl_Vendedores
            // 
            this.lbl_Vendedores.AutoSize = true;
            this.lbl_Vendedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Vendedores.Location = new System.Drawing.Point(94, 35);
            this.lbl_Vendedores.Name = "lbl_Vendedores";
            this.lbl_Vendedores.Size = new System.Drawing.Size(115, 24);
            this.lbl_Vendedores.TabIndex = 2;
            this.lbl_Vendedores.Text = "Vendedores";
            // 
            // lbl_Clientes
            // 
            this.lbl_Clientes.AutoSize = true;
            this.lbl_Clientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Clientes.Location = new System.Drawing.Point(378, 35);
            this.lbl_Clientes.Name = "lbl_Clientes";
            this.lbl_Clientes.Size = new System.Drawing.Size(77, 24);
            this.lbl_Clientes.TabIndex = 3;
            this.lbl_Clientes.Text = "Clientes";
            // 
            // lbox_clientes
            // 
            this.lbox_clientes.FormattingEnabled = true;
            this.lbox_clientes.Location = new System.Drawing.Point(308, 64);
            this.lbox_clientes.Name = "lbox_clientes";
            this.lbox_clientes.Size = new System.Drawing.Size(216, 381);
            this.lbox_clientes.TabIndex = 4;
            // 
            // text_Membrillo
            // 
            this.text_Membrillo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_Membrillo.Location = new System.Drawing.Point(676, 114);
            this.text_Membrillo.Name = "text_Membrillo";
            this.text_Membrillo.Size = new System.Drawing.Size(34, 35);
            this.text_Membrillo.TabIndex = 5;
            this.text_Membrillo.Tag = "Membrillo";
            this.text_Membrillo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // text_Batata
            // 
            this.text_Batata.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_Batata.Location = new System.Drawing.Point(676, 225);
            this.text_Batata.Name = "text_Batata";
            this.text_Batata.Size = new System.Drawing.Size(34, 35);
            this.text_Batata.TabIndex = 6;
            this.text_Batata.Tag = "Batata";
            // 
            // lbl_Membrillo
            // 
            this.lbl_Membrillo.AutoSize = true;
            this.lbl_Membrillo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Membrillo.Location = new System.Drawing.Point(601, 64);
            this.lbl_Membrillo.Name = "lbl_Membrillo";
            this.lbl_Membrillo.Size = new System.Drawing.Size(184, 24);
            this.lbl_Membrillo.TabIndex = 7;
            this.lbl_Membrillo.Text = "Docenas de mebrillo";
            // 
            // lbl_Batata
            // 
            this.lbl_Batata.AutoSize = true;
            this.lbl_Batata.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Batata.Location = new System.Drawing.Point(610, 175);
            this.lbl_Batata.Name = "lbl_Batata";
            this.lbl_Batata.Size = new System.Drawing.Size(167, 24);
            this.lbl_Batata.TabIndex = 8;
            this.lbl_Batata.Text = "Docenas de Batata";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 607);
            this.Controls.Add(this.lbl_Batata);
            this.Controls.Add(this.lbl_Membrillo);
            this.Controls.Add(this.text_Batata);
            this.Controls.Add(this.text_Membrillo);
            this.Controls.Add(this.lbox_clientes);
            this.Controls.Add(this.lbl_Clientes);
            this.Controls.Add(this.lbl_Vendedores);
            this.Controls.Add(this.lbox_Vendedores);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbox_Vendedores;
        private System.Windows.Forms.Label lbl_Vendedores;
        private System.Windows.Forms.Label lbl_Clientes;
        private System.Windows.Forms.ListBox lbox_clientes;
        private System.Windows.Forms.TextBox text_Membrillo;
        private System.Windows.Forms.TextBox text_Batata;
        private System.Windows.Forms.Label lbl_Membrillo;
        private System.Windows.Forms.Label lbl_Batata;
    }
}

