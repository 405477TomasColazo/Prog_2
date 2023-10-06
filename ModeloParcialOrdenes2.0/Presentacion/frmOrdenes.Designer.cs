namespace ModeloParcialOrdenes2._0
{
    partial class frmOrdenes
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
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtResponsable = new System.Windows.Forms.TextBox();
            this.cboMaterial = new System.Windows.Forms.ComboBox();
            this.nudStock = new System.Windows.Forms.NumericUpDown();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dgvOrdenes = new System.Windows.Forms.DataGridView();
            this.colMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAcciones = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.nudStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdenes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha: ";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(82, 12);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(89, 20);
            this.dtpFecha.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Responsable: ";
            // 
            // txtResponsable
            // 
            this.txtResponsable.Location = new System.Drawing.Point(99, 57);
            this.txtResponsable.Name = "txtResponsable";
            this.txtResponsable.Size = new System.Drawing.Size(157, 20);
            this.txtResponsable.TabIndex = 3;
            // 
            // cboMaterial
            // 
            this.cboMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaterial.FormattingEnabled = true;
            this.cboMaterial.Location = new System.Drawing.Point(14, 102);
            this.cboMaterial.Name = "cboMaterial";
            this.cboMaterial.Size = new System.Drawing.Size(272, 21);
            this.cboMaterial.TabIndex = 4;
            // 
            // nudStock
            // 
            this.nudStock.Location = new System.Drawing.Point(313, 103);
            this.nudStock.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudStock.Name = "nudStock";
            this.nudStock.Size = new System.Drawing.Size(172, 20);
            this.nudStock.TabIndex = 5;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(539, 96);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(182, 31);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(74, 407);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(182, 31);
            this.btnAceptar.TabIndex = 7;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(446, 407);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(182, 31);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // dgvOrdenes
            // 
            this.dgvOrdenes.AllowUserToAddRows = false;
            this.dgvOrdenes.AllowUserToDeleteRows = false;
            this.dgvOrdenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrdenes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaterial,
            this.colStock,
            this.colCantidad,
            this.colAcciones,
            this.colCodigo});
            this.dgvOrdenes.Location = new System.Drawing.Point(6, 159);
            this.dgvOrdenes.Name = "dgvOrdenes";
            this.dgvOrdenes.ReadOnly = true;
            this.dgvOrdenes.Size = new System.Drawing.Size(768, 216);
            this.dgvOrdenes.TabIndex = 9;
            this.dgvOrdenes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrdenes_CellContentClick);
            // 
            // colMaterial
            // 
            this.colMaterial.HeaderText = "MATERIAL";
            this.colMaterial.Name = "colMaterial";
            this.colMaterial.ReadOnly = true;
            this.colMaterial.Width = 180;
            // 
            // colStock
            // 
            this.colStock.HeaderText = "STOCK";
            this.colStock.Name = "colStock";
            this.colStock.ReadOnly = true;
            this.colStock.Width = 180;
            // 
            // colCantidad
            // 
            this.colCantidad.HeaderText = "CANTIDAD";
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.ReadOnly = true;
            this.colCantidad.Width = 180;
            // 
            // colAcciones
            // 
            this.colAcciones.HeaderText = "ACCIONES";
            this.colAcciones.Name = "colAcciones";
            this.colAcciones.ReadOnly = true;
            this.colAcciones.Width = 180;
            // 
            // colCodigo
            // 
            this.colCodigo.HeaderText = "Codigo";
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.ReadOnly = true;
            this.colCodigo.Visible = false;
            // 
            // frmOrdenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvOrdenes);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.nudStock);
            this.Controls.Add(this.cboMaterial);
            this.Controls.Add(this.txtResponsable);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.label1);
            this.Name = "frmOrdenes";
            this.Text = "Ordenes";
            this.Load += new System.EventHandler(this.frmOrdenes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdenes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtResponsable;
        private System.Windows.Forms.ComboBox cboMaterial;
        private System.Windows.Forms.NumericUpDown nudStock;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dgvOrdenes;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
        private System.Windows.Forms.DataGridViewButtonColumn colAcciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
    }
}

