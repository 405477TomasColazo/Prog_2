namespace ModeloParcialOrdenes
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtResponsable = new System.Windows.Forms.TextBox();
            this.cboMaterial = new System.Windows.Forms.ComboBox();
            this.nudStock = new System.Windows.Forms.NumericUpDown();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAcciones = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha: ";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(70, 20);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(79, 23);
            this.dtpFecha.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Responsable: ";
            // 
            // txtResponsable
            // 
            this.txtResponsable.Location = new System.Drawing.Point(105, 59);
            this.txtResponsable.Name = "txtResponsable";
            this.txtResponsable.Size = new System.Drawing.Size(302, 23);
            this.txtResponsable.TabIndex = 3;
            // 
            // cboMaterial
            // 
            this.cboMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaterial.FormattingEnabled = true;
            this.cboMaterial.Location = new System.Drawing.Point(20, 109);
            this.cboMaterial.Name = "cboMaterial";
            this.cboMaterial.Size = new System.Drawing.Size(277, 23);
            this.cboMaterial.TabIndex = 4;
            // 
            // nudStock
            // 
            this.nudStock.Location = new System.Drawing.Point(327, 109);
            this.nudStock.Name = "nudStock";
            this.nudStock.Size = new System.Drawing.Size(181, 23);
            this.nudStock.TabIndex = 5;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(549, 107);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(152, 32);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaterial,
            this.colStock,
            this.colCantidad,
            this.colAcciones});
            this.dataGridView1.Location = new System.Drawing.Point(19, 185);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(769, 187);
            this.dataGridView1.TabIndex = 7;
            // 
            // colMaterial
            // 
            this.colMaterial.HeaderText = "Material";
            this.colMaterial.Name = "colMaterial";
            this.colMaterial.ReadOnly = true;
            this.colMaterial.Width = 180;
            // 
            // colStock
            // 
            this.colStock.HeaderText = "Stock";
            this.colStock.Name = "colStock";
            this.colStock.ReadOnly = true;
            this.colStock.Width = 180;
            // 
            // colCantidad
            // 
            this.colCantidad.HeaderText = "Cantidad";
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.ReadOnly = true;
            this.colCantidad.Width = 180;
            // 
            // colAcciones
            // 
            this.colAcciones.HeaderText = "Acciones";
            this.colAcciones.Name = "colAcciones";
            this.colAcciones.ReadOnly = true;
            this.colAcciones.Width = 180;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(122, 393);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(136, 40);
            this.btnAceptar.TabIndex = 8;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(470, 393);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(136, 40);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.nudStock);
            this.Controls.Add(this.cboMaterial);
            this.Controls.Add(this.txtResponsable);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private DateTimePicker dtpFecha;
        private Label label2;
        private TextBox txtResponsable;
        private ComboBox cboMaterial;
        private NumericUpDown nudStock;
        private Button btnAgregar;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colMaterial;
        private DataGridViewTextBoxColumn colStock;
        private DataGridViewTextBoxColumn colCantidad;
        private DataGridViewButtonColumn colAcciones;
        private Button btnAceptar;
        private Button btnCancelar;
    }
}