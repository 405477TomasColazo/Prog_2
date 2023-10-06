namespace Venta_8_Julio
{
    partial class frm_Pastelitos
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lst_Vendedores = new System.Windows.Forms.ListBox();
            this.lst_Clientes = new System.Windows.Forms.ListBox();
            this.txt_Membrillo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Batata = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lst_Vendedores
            // 
            this.lst_Vendedores.FormattingEnabled = true;
            this.lst_Vendedores.ItemHeight = 15;
            this.lst_Vendedores.Location = new System.Drawing.Point(30, 37);
            this.lst_Vendedores.Name = "lst_Vendedores";
            this.lst_Vendedores.Size = new System.Drawing.Size(213, 334);
            this.lst_Vendedores.TabIndex = 0;
            // 
            // lst_Clientes
            // 
            this.lst_Clientes.FormattingEnabled = true;
            this.lst_Clientes.ItemHeight = 15;
            this.lst_Clientes.Location = new System.Drawing.Point(252, 37);
            this.lst_Clientes.Name = "lst_Clientes";
            this.lst_Clientes.Size = new System.Drawing.Size(213, 334);
            this.lst_Clientes.TabIndex = 1;
            // 
            // txt_Membrillo
            // 
            this.txt_Membrillo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Membrillo.Location = new System.Drawing.Point(555, 94);
            this.txt_Membrillo.Name = "txt_Membrillo";
            this.txt_Membrillo.Size = new System.Drawing.Size(74, 36);
            this.txt_Membrillo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(536, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Membrillo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(703, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 30);
            this.label2.TabIndex = 5;
            this.label2.Text = "Batata";
            // 
            // txt_Batata
            // 
            this.txt_Batata.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Batata.Location = new System.Drawing.Point(702, 94);
            this.txt_Batata.Name = "txt_Batata";
            this.txt_Batata.Size = new System.Drawing.Size(74, 36);
            this.txt_Batata.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(71, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 30);
            this.label3.TabIndex = 6;
            this.label3.Text = "Vendedores";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(314, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 30);
            this.label4.TabIndex = 7;
            this.label4.Text = "Clientes";
            // 
            // frm_Pastelitos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 526);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Batata);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Membrillo);
            this.Controls.Add(this.lst_Clientes);
            this.Controls.Add(this.lst_Vendedores);
            this.Name = "frm_Pastelitos";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frm_Pastelitos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox lst_Vendedores;
        private ListBox lst_Clientes;
        private TextBox txt_Membrillo;
        private Label label1;
        private Label label2;
        private TextBox txt_Batata;
        private Label label3;
        private Label label4;
    }
}