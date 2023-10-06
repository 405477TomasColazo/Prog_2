namespace prueba2._0
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
            this.SuspendLayout();
            // 
            // lbox_Vendedores
            // 
            this.lbox_Vendedores.FormattingEnabled = true;
            this.lbox_Vendedores.Location = new System.Drawing.Point(62, 71);
            this.lbox_Vendedores.Name = "lbox_Vendedores";
            this.lbox_Vendedores.Size = new System.Drawing.Size(200, 303);
            this.lbox_Vendedores.TabIndex = 0;
            this.lbox_Vendedores.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbox_Vendedores);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbox_Vendedores;
    }
}

