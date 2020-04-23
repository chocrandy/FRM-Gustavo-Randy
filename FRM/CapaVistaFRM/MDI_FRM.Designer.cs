namespace CapaVistaFRM
{
    partial class MDI_FRM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDI_FRM));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bancosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cuentasBancariasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chequeraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bancosToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.clasificadorDeMovimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monedasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bancosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movimientosBancariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoDeCambioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conciliaciónBancariaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarConciliaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.presupuestosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.revisiónDePresupuestosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiónPresupuestariaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seguridadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Lbl_usuario = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.mantenimientosToolStripMenuItem,
            this.bancosToolStripMenuItem,
            this.presupuestosToolStripMenuItem,
            this.seguridadToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.inicioToolStripMenuItem.Text = "Inicio";
            // 
            // mantenimientosToolStripMenuItem
            // 
            this.mantenimientosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bancosToolStripMenuItem1,
            this.otrosToolStripMenuItem});
            this.mantenimientosToolStripMenuItem.Name = "mantenimientosToolStripMenuItem";
            this.mantenimientosToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.mantenimientosToolStripMenuItem.Text = "Mantenimientos";
            // 
            // bancosToolStripMenuItem1
            // 
            this.bancosToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cuentasBancariasToolStripMenuItem,
            this.chequeraToolStripMenuItem,
            this.bancosToolStripMenuItem2,
            this.clasificadorDeMovimientosToolStripMenuItem});
            this.bancosToolStripMenuItem1.Name = "bancosToolStripMenuItem1";
            this.bancosToolStripMenuItem1.Size = new System.Drawing.Size(180, 24);
            this.bancosToolStripMenuItem1.Text = "5200 - Bancos";
            // 
            // cuentasBancariasToolStripMenuItem
            // 
            this.cuentasBancariasToolStripMenuItem.Name = "cuentasBancariasToolStripMenuItem";
            this.cuentasBancariasToolStripMenuItem.Size = new System.Drawing.Size(285, 24);
            this.cuentasBancariasToolStripMenuItem.Text = "5201 - Cuentas Bancarias";
            this.cuentasBancariasToolStripMenuItem.Click += new System.EventHandler(this.CuentasBancariasToolStripMenuItem_Click);
            // 
            // chequeraToolStripMenuItem
            // 
            this.chequeraToolStripMenuItem.Name = "chequeraToolStripMenuItem";
            this.chequeraToolStripMenuItem.Size = new System.Drawing.Size(285, 24);
            this.chequeraToolStripMenuItem.Text = "5202 - Chequera";
            this.chequeraToolStripMenuItem.Click += new System.EventHandler(this.ChequeraToolStripMenuItem_Click);
            // 
            // bancosToolStripMenuItem2
            // 
            this.bancosToolStripMenuItem2.Name = "bancosToolStripMenuItem2";
            this.bancosToolStripMenuItem2.Size = new System.Drawing.Size(285, 24);
            this.bancosToolStripMenuItem2.Text = "5203 - Bancos";
            this.bancosToolStripMenuItem2.Click += new System.EventHandler(this.BancosToolStripMenuItem2_Click);
            // 
            // clasificadorDeMovimientosToolStripMenuItem
            // 
            this.clasificadorDeMovimientosToolStripMenuItem.Name = "clasificadorDeMovimientosToolStripMenuItem";
            this.clasificadorDeMovimientosToolStripMenuItem.Size = new System.Drawing.Size(285, 24);
            this.clasificadorDeMovimientosToolStripMenuItem.Text = "Clasificador de movimientos";
            this.clasificadorDeMovimientosToolStripMenuItem.Click += new System.EventHandler(this.ClasificadorDeMovimientosToolStripMenuItem_Click);
            // 
            // otrosToolStripMenuItem
            // 
            this.otrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modulosToolStripMenuItem,
            this.monedasToolStripMenuItem1});
            this.otrosToolStripMenuItem.Name = "otrosToolStripMenuItem";
            this.otrosToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.otrosToolStripMenuItem.Text = "Otros";
            // 
            // modulosToolStripMenuItem
            // 
            this.modulosToolStripMenuItem.Name = "modulosToolStripMenuItem";
            this.modulosToolStripMenuItem.Size = new System.Drawing.Size(148, 24);
            this.modulosToolStripMenuItem.Text = "Modulos";
            this.modulosToolStripMenuItem.Click += new System.EventHandler(this.ModulosToolStripMenuItem_Click);
            // 
            // monedasToolStripMenuItem1
            // 
            this.monedasToolStripMenuItem1.Name = "monedasToolStripMenuItem1";
            this.monedasToolStripMenuItem1.Size = new System.Drawing.Size(148, 24);
            this.monedasToolStripMenuItem1.Text = "Monedas";
            this.monedasToolStripMenuItem1.Click += new System.EventHandler(this.MonedasToolStripMenuItem1_Click);
            // 
            // bancosToolStripMenuItem
            // 
            this.bancosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.movimientosBancariosToolStripMenuItem,
            this.tipoDeCambioToolStripMenuItem,
            this.conciliaciónBancariaToolStripMenuItem,
            this.consultarConciliaciónToolStripMenuItem});
            this.bancosToolStripMenuItem.Name = "bancosToolStripMenuItem";
            this.bancosToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.bancosToolStripMenuItem.Text = "Bancos";
            // 
            // movimientosBancariosToolStripMenuItem
            // 
            this.movimientosBancariosToolStripMenuItem.Name = "movimientosBancariosToolStripMenuItem";
            this.movimientosBancariosToolStripMenuItem.Size = new System.Drawing.Size(293, 24);
            this.movimientosBancariosToolStripMenuItem.Text = "5210 - Movimientos Bancarios";
            this.movimientosBancariosToolStripMenuItem.Click += new System.EventHandler(this.MovimientosBancariosToolStripMenuItem_Click);
            // 
            // tipoDeCambioToolStripMenuItem
            // 
            this.tipoDeCambioToolStripMenuItem.Name = "tipoDeCambioToolStripMenuItem";
            this.tipoDeCambioToolStripMenuItem.Size = new System.Drawing.Size(293, 24);
            this.tipoDeCambioToolStripMenuItem.Text = "5211 - Tipo de Cambio";
            this.tipoDeCambioToolStripMenuItem.Click += new System.EventHandler(this.TipoDeCambioToolStripMenuItem_Click);
            // 
            // conciliaciónBancariaToolStripMenuItem
            // 
            this.conciliaciónBancariaToolStripMenuItem.Name = "conciliaciónBancariaToolStripMenuItem";
            this.conciliaciónBancariaToolStripMenuItem.Size = new System.Drawing.Size(293, 24);
            this.conciliaciónBancariaToolStripMenuItem.Text = "5212 - Conciliación Bancaria";
            this.conciliaciónBancariaToolStripMenuItem.Click += new System.EventHandler(this.ConciliaciónBancariaToolStripMenuItem_Click);
            // 
            // consultarConciliaciónToolStripMenuItem
            // 
            this.consultarConciliaciónToolStripMenuItem.Name = "consultarConciliaciónToolStripMenuItem";
            this.consultarConciliaciónToolStripMenuItem.Size = new System.Drawing.Size(293, 24);
            this.consultarConciliaciónToolStripMenuItem.Text = "5213 - Consultar Conciliación";
            this.consultarConciliaciónToolStripMenuItem.Click += new System.EventHandler(this.ConsultarConciliaciónToolStripMenuItem_Click);
            // 
            // presupuestosToolStripMenuItem
            // 
            this.presupuestosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.revisiónDePresupuestosToolStripMenuItem,
            this.gestiónPresupuestariaToolStripMenuItem});
            this.presupuestosToolStripMenuItem.Name = "presupuestosToolStripMenuItem";
            this.presupuestosToolStripMenuItem.Size = new System.Drawing.Size(116, 24);
            this.presupuestosToolStripMenuItem.Text = "Presupuestos";
            // 
            // revisiónDePresupuestosToolStripMenuItem
            // 
            this.revisiónDePresupuestosToolStripMenuItem.Name = "revisiónDePresupuestosToolStripMenuItem";
            this.revisiónDePresupuestosToolStripMenuItem.Size = new System.Drawing.Size(261, 24);
            this.revisiónDePresupuestosToolStripMenuItem.Text = "Revisión de Presupuestos";
            this.revisiónDePresupuestosToolStripMenuItem.Click += new System.EventHandler(this.RevisiónDePresupuestosToolStripMenuItem_Click);
            // 
            // gestiónPresupuestariaToolStripMenuItem
            // 
            this.gestiónPresupuestariaToolStripMenuItem.Name = "gestiónPresupuestariaToolStripMenuItem";
            this.gestiónPresupuestariaToolStripMenuItem.Size = new System.Drawing.Size(261, 24);
            this.gestiónPresupuestariaToolStripMenuItem.Text = "Gestión Presupuestaria";
            // 
            // seguridadToolStripMenuItem
            // 
            this.seguridadToolStripMenuItem.Name = "seguridadToolStripMenuItem";
            this.seguridadToolStripMenuItem.Size = new System.Drawing.Size(95, 24);
            this.seguridadToolStripMenuItem.Text = "Seguridad";
            this.seguridadToolStripMenuItem.Click += new System.EventHandler(this.SeguridadToolStripMenuItem_Click);
            // 
            // Lbl_usuario
            // 
            this.Lbl_usuario.AutoSize = true;
            this.Lbl_usuario.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Lbl_usuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_usuario.Location = new System.Drawing.Point(0, 429);
            this.Lbl_usuario.Name = "Lbl_usuario";
            this.Lbl_usuario.Size = new System.Drawing.Size(66, 21);
            this.Lbl_usuario.TabIndex = 2;
            this.Lbl_usuario.Text = "Usuario";
            this.Lbl_usuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MDI_FRM
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Lbl_usuario);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MDI_FRM";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MDI_FRM";
            this.Load += new System.EventHandler(this.MDI_FRM_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bancosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem presupuestosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conciliaciónBancariaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarConciliaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movimientosBancariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoDeCambioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem revisiónDePresupuestosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestiónPresupuestariaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bancosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cuentasBancariasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chequeraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bancosToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem clasificadorDeMovimientosToolStripMenuItem;
        private System.Windows.Forms.Label Lbl_usuario;
        private System.Windows.Forms.ToolStripMenuItem seguridadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modulosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monedasToolStripMenuItem1;
	}
}