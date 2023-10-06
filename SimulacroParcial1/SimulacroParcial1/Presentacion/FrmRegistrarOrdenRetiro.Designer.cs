namespace SimulacroParcial1.Presentacion
{
    partial class FrmRegistrarOrdenRetiro
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
            this.dvgDetalles = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.cboMateriales = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtResponsable = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.MATERIAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STOCK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CANTIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quitar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dvgDetalles)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgDetalles
            // 
            this.dvgDetalles.AllowUserToAddRows = false;
            this.dvgDetalles.AllowUserToDeleteRows = false;
            this.dvgDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgDetalles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MATERIAL,
            this.STOCK,
            this.CANTIDAD,
            this.Quitar});
            this.dvgDetalles.Location = new System.Drawing.Point(36, 106);
            this.dvgDetalles.Name = "dvgDetalles";
            this.dvgDetalles.ReadOnly = true;
            this.dvgDetalles.Size = new System.Drawing.Size(474, 198);
            this.dvgDetalles.TabIndex = 0;
            this.dvgDetalles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgDetalles_CellContentClick);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(393, 78);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(117, 23);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(285, 337);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(174, 337);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(114, 23);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(204, 20);
            this.dtpFecha.TabIndex = 4;
            // 
            // cboMateriales
            // 
            this.cboMateriales.FormattingEnabled = true;
            this.cboMateriales.Location = new System.Drawing.Point(36, 79);
            this.cboMateriales.Name = "cboMateriales";
            this.cboMateriales.Size = new System.Drawing.Size(282, 21);
            this.cboMateriales.TabIndex = 6;
            this.cboMateriales.SelectedIndexChanged += new System.EventHandler(this.cbMateriales_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Fecha: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Responsable: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtResponsable
            // 
            this.txtResponsable.Location = new System.Drawing.Point(114, 49);
            this.txtResponsable.Name = "txtResponsable";
            this.txtResponsable.Size = new System.Drawing.Size(204, 20);
            this.txtResponsable.TabIndex = 9;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(324, 79);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(63, 20);
            this.txtCantidad.TabIndex = 10;
            // 
            // MATERIAL
            // 
            this.MATERIAL.HeaderText = "MATERIAL";
            this.MATERIAL.Name = "MATERIAL";
            this.MATERIAL.ReadOnly = true;
            // 
            // STOCK
            // 
            this.STOCK.HeaderText = "STOCK";
            this.STOCK.Name = "STOCK";
            this.STOCK.ReadOnly = true;
            // 
            // CANTIDAD
            // 
            this.CANTIDAD.HeaderText = "CANTIDAD";
            this.CANTIDAD.Name = "CANTIDAD";
            this.CANTIDAD.ReadOnly = true;
            // 
            // Quitar
            // 
            this.Quitar.HeaderText = "Acciones";
            this.Quitar.Name = "Quitar";
            this.Quitar.ReadOnly = true;
            // 
            // FrmRegistrarOrdenRetiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 372);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtResponsable);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboMateriales);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dvgDetalles);
            this.Name = "FrmRegistrarOrdenRetiro";
            this.Text = "Registrar Orden de Retiro";
            this.Load += new System.EventHandler(this.FrmRegistrarOrdenRetiro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgDetalles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgDetalles;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.ComboBox cboMateriales;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtResponsable;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn MATERIAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn STOCK;
        private System.Windows.Forms.DataGridViewTextBoxColumn CANTIDAD;
        private System.Windows.Forms.DataGridViewButtonColumn Quitar;
    }
}