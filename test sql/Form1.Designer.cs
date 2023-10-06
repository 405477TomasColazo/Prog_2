namespace test_sql
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tbx_data1 = new System.Windows.Forms.TextBox();
            this.tbx_data2 = new System.Windows.Forms.TextBox();
            this.lb_id = new System.Windows.Forms.Label();
            this.lb_data1 = new System.Windows.Forms.Label();
            this.lb_data2 = new System.Windows.Forms.Label();
            this.btn_insertar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 71);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // tbx_data1
            // 
            this.tbx_data1.Location = new System.Drawing.Point(147, 71);
            this.tbx_data1.Name = "tbx_data1";
            this.tbx_data1.Size = new System.Drawing.Size(100, 20);
            this.tbx_data1.TabIndex = 1;
            // 
            // tbx_data2
            // 
            this.tbx_data2.Location = new System.Drawing.Point(282, 71);
            this.tbx_data2.Name = "tbx_data2";
            this.tbx_data2.Size = new System.Drawing.Size(100, 20);
            this.tbx_data2.TabIndex = 2;
            // 
            // lb_id
            // 
            this.lb_id.AutoSize = true;
            this.lb_id.Location = new System.Drawing.Point(45, 36);
            this.lb_id.Name = "lb_id";
            this.lb_id.Size = new System.Drawing.Size(15, 13);
            this.lb_id.TabIndex = 3;
            this.lb_id.Text = "id";
            this.lb_id.Click += new System.EventHandler(this.label1_Click);
            // 
            // lb_data1
            // 
            this.lb_data1.AutoSize = true;
            this.lb_data1.Location = new System.Drawing.Point(178, 36);
            this.lb_data1.Name = "lb_data1";
            this.lb_data1.Size = new System.Drawing.Size(34, 13);
            this.lb_data1.TabIndex = 4;
            this.lb_data1.Text = "data1";
            // 
            // lb_data2
            // 
            this.lb_data2.AutoSize = true;
            this.lb_data2.Location = new System.Drawing.Point(318, 36);
            this.lb_data2.Name = "lb_data2";
            this.lb_data2.Size = new System.Drawing.Size(34, 13);
            this.lb_data2.TabIndex = 5;
            this.lb_data2.Text = "data2";
            // 
            // btn_insertar
            // 
            this.btn_insertar.Location = new System.Drawing.Point(37, 176);
            this.btn_insertar.Name = "btn_insertar";
            this.btn_insertar.Size = new System.Drawing.Size(75, 23);
            this.btn_insertar.TabIndex = 6;
            this.btn_insertar.Text = "Insertar";
            this.btn_insertar.UseVisualStyleBackColor = true;
            this.btn_insertar.Click += new System.EventHandler(this.btn_insertar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_insertar);
            this.Controls.Add(this.lb_data2);
            this.Controls.Add(this.lb_data1);
            this.Controls.Add(this.lb_id);
            this.Controls.Add(this.tbx_data2);
            this.Controls.Add(this.tbx_data1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox tbx_data1;
        private System.Windows.Forms.TextBox tbx_data2;
        private System.Windows.Forms.Label lb_id;
        private System.Windows.Forms.Label lb_data1;
        private System.Windows.Forms.Label lb_data2;
        private System.Windows.Forms.Button btn_insertar;
    }
}

