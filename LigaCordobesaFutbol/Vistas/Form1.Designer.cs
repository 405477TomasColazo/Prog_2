namespace LigaCordobesaFutbol
{
    partial class frmRegistroEquipos
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
            this.lblEquipoNro = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDT = new System.Windows.Forms.Label();
            this.txtDT = new System.Windows.Forms.TextBox();
            this.dgvJugadores = new System.Windows.Forms.DataGridView();
            this.lblJugador = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.cboJugador = new System.Windows.Forms.ComboBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.cboPosicion = new System.Windows.Forms.ComboBox();
            this.lblPosicion = new System.Windows.Forms.Label();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPosicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBorrar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblNro = new System.Windows.Forms.Label();
            this.txtNro = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJugadores)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEquipoNro
            // 
            this.lblEquipoNro.AutoSize = true;
            this.lblEquipoNro.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEquipoNro.Location = new System.Drawing.Point(31, 24);
            this.lblEquipoNro.Name = "lblEquipoNro";
            this.lblEquipoNro.Size = new System.Drawing.Size(129, 25);
            this.lblEquipoNro.TabIndex = 0;
            this.lblEquipoNro.Text = "Equipo Nro:";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(174, 86);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(190, 29);
            this.txtNombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(32, 89);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(130, 21);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre Equipo";
            // 
            // lblDT
            // 
            this.lblDT.AutoSize = true;
            this.lblDT.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDT.Location = new System.Drawing.Point(32, 147);
            this.lblDT.Name = "lblDT";
            this.lblDT.Size = new System.Drawing.Size(136, 21);
            this.lblDT.TabIndex = 4;
            this.lblDT.Text = "Director Tecnico";
            // 
            // txtDT
            // 
            this.txtDT.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDT.Location = new System.Drawing.Point(174, 144);
            this.txtDT.Name = "txtDT";
            this.txtDT.Size = new System.Drawing.Size(190, 29);
            this.txtDT.TabIndex = 3;
            // 
            // dgvJugadores
            // 
            this.dgvJugadores.AllowUserToAddRows = false;
            this.dgvJugadores.AllowUserToDeleteRows = false;
            this.dgvJugadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJugadores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colNombre,
            this.colNro,
            this.colPosicion,
            this.colDni,
            this.colNac,
            this.colBorrar});
            this.dgvJugadores.Location = new System.Drawing.Point(36, 226);
            this.dgvJugadores.Name = "dgvJugadores";
            this.dgvJugadores.ReadOnly = true;
            this.dgvJugadores.Size = new System.Drawing.Size(634, 170);
            this.dgvJugadores.TabIndex = 5;
            this.dgvJugadores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lblJugador
            // 
            this.lblJugador.AutoSize = true;
            this.lblJugador.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJugador.Location = new System.Drawing.Point(618, 9);
            this.lblJugador.Name = "lblJugador";
            this.lblJugador.Size = new System.Drawing.Size(135, 21);
            this.lblJugador.TabIndex = 7;
            this.lblJugador.Text = "Nombre Jugador";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(622, 191);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(117, 26);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // cboJugador
            // 
            this.cboJugador.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboJugador.FormattingEnabled = true;
            this.cboJugador.Location = new System.Drawing.Point(611, 33);
            this.cboJugador.Name = "cboJugador";
            this.cboJugador.Size = new System.Drawing.Size(152, 29);
            this.cboJugador.TabIndex = 9;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(535, 413);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(162, 25);
            this.btnConfirmar.TabIndex = 10;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // cboPosicion
            // 
            this.cboPosicion.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPosicion.FormattingEnabled = true;
            this.cboPosicion.Location = new System.Drawing.Point(611, 100);
            this.cboPosicion.Name = "cboPosicion";
            this.cboPosicion.Size = new System.Drawing.Size(152, 29);
            this.cboPosicion.TabIndex = 12;
            // 
            // lblPosicion
            // 
            this.lblPosicion.AutoSize = true;
            this.lblPosicion.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosicion.Location = new System.Drawing.Point(645, 76);
            this.lblPosicion.Name = "lblPosicion";
            this.lblPosicion.Size = new System.Drawing.Size(75, 21);
            this.lblPosicion.TabIndex = 11;
            this.lblPosicion.Text = "Posicion";
            // 
            // colId
            // 
            this.colId.HeaderText = "ID";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Visible = false;
            this.colId.Width = 50;
            // 
            // colNombre
            // 
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.ReadOnly = true;
            this.colNombre.Width = 150;
            // 
            // colNro
            // 
            this.colNro.HeaderText = "Nro";
            this.colNro.Name = "colNro";
            this.colNro.ReadOnly = true;
            this.colNro.Width = 50;
            // 
            // colPosicion
            // 
            this.colPosicion.HeaderText = "Posicion";
            this.colPosicion.Name = "colPosicion";
            this.colPosicion.ReadOnly = true;
            this.colPosicion.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colPosicion.Width = 115;
            // 
            // colDni
            // 
            this.colDni.HeaderText = "Dni";
            this.colDni.Name = "colDni";
            this.colDni.ReadOnly = true;
            this.colDni.Width = 85;
            // 
            // colNac
            // 
            this.colNac.HeaderText = "Fecha nacimiento";
            this.colNac.Name = "colNac";
            this.colNac.ReadOnly = true;
            this.colNac.Width = 90;
            // 
            // colBorrar
            // 
            this.colBorrar.HeaderText = "Acciones";
            this.colBorrar.Name = "colBorrar";
            this.colBorrar.ReadOnly = true;
            // 
            // lblNro
            // 
            this.lblNro.AutoSize = true;
            this.lblNro.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNro.Location = new System.Drawing.Point(627, 132);
            this.lblNro.Name = "lblNro";
            this.lblNro.Size = new System.Drawing.Size(112, 21);
            this.lblNro.TabIndex = 13;
            this.lblNro.Text = "Camiseta Nro";
            // 
            // txtNro
            // 
            this.txtNro.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNro.Location = new System.Drawing.Point(661, 156);
            this.txtNro.Name = "txtNro";
            this.txtNro.Size = new System.Drawing.Size(46, 29);
            this.txtNro.TabIndex = 14;
            // 
            // frmRegistroEquipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNro);
            this.Controls.Add(this.lblNro);
            this.Controls.Add(this.cboPosicion);
            this.Controls.Add(this.lblPosicion);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.cboJugador);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblJugador);
            this.Controls.Add(this.dgvJugadores);
            this.Controls.Add(this.lblDT);
            this.Controls.Add(this.txtDT);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblEquipoNro);
            this.Name = "frmRegistroEquipos";
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.frmRegistroEquipos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJugadores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEquipoNro;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDT;
        private System.Windows.Forms.TextBox txtDT;
        private System.Windows.Forms.DataGridView dgvJugadores;
        private System.Windows.Forms.Label lblJugador;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ComboBox cboJugador;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPosicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDni;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNac;
        private System.Windows.Forms.DataGridViewButtonColumn colBorrar;
        private System.Windows.Forms.ComboBox cboPosicion;
        private System.Windows.Forms.Label lblPosicion;
        private System.Windows.Forms.Label lblNro;
        private System.Windows.Forms.TextBox txtNro;
    }
}

