namespace SimulacroParcial1.Presentacion
{
    partial class FrmPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenDeRetiroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaOrdenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.ordenDeRetiroToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 20);
            // 
            // ordenDeRetiroToolStripMenuItem
            // 
            this.ordenDeRetiroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaOrdenToolStripMenuItem});
            this.ordenDeRetiroToolStripMenuItem.Name = "ordenDeRetiroToolStripMenuItem";
            this.ordenDeRetiroToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.ordenDeRetiroToolStripMenuItem.Text = "Orden de Retiro";
            this.ordenDeRetiroToolStripMenuItem.Click += new System.EventHandler(this.ordenDeRetiroToolStripMenuItem_Click);
            // 
            // nuevaOrdenToolStripMenuItem
            // 
            this.nuevaOrdenToolStripMenuItem.Name = "nuevaOrdenToolStripMenuItem";
            this.nuevaOrdenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nuevaOrdenToolStripMenuItem.Text = "Nueva Orden ";
            this.nuevaOrdenToolStripMenuItem.Click += new System.EventHandler(this.nuevaOrdenToolStripMenuItem_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipal";
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ordenDeRetiroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaOrdenToolStripMenuItem;
    }
}