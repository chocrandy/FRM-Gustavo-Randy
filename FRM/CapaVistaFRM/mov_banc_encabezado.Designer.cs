namespace CapaVistaFRM
{
    partial class mov_banc_encabezado
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
            this.label1 = new System.Windows.Forms.Label();
            this.Gpb_datos = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Cbo_cuentaBancaria = new System.Windows.Forms.ComboBox();
            this.Btn_siguiente = new System.Windows.Forms.Button();
            this.Gpb_datos.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Maroon;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(123, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Movimientos Bancarios";
            // 
            // Gpb_datos
            // 
            this.Gpb_datos.Controls.Add(this.Cbo_cuentaBancaria);
            this.Gpb_datos.Controls.Add(this.label2);
            this.Gpb_datos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_datos.Location = new System.Drawing.Point(25, 73);
            this.Gpb_datos.Name = "Gpb_datos";
            this.Gpb_datos.Size = new System.Drawing.Size(471, 127);
            this.Gpb_datos.TabIndex = 4;
            this.Gpb_datos.TabStop = false;
            this.Gpb_datos.Text = "Datos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(405, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cuenta Bancaria donde va registrar el movimiento:";
            // 
            // Cbo_cuentaBancaria
            // 
            this.Cbo_cuentaBancaria.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_cuentaBancaria.FormattingEnabled = true;
            this.Cbo_cuentaBancaria.Location = new System.Drawing.Point(25, 65);
            this.Cbo_cuentaBancaria.Name = "Cbo_cuentaBancaria";
            this.Cbo_cuentaBancaria.Size = new System.Drawing.Size(416, 29);
            this.Cbo_cuentaBancaria.TabIndex = 39;
            // 
            // Btn_siguiente
            // 
            this.Btn_siguiente.BackColor = System.Drawing.Color.White;
            this.Btn_siguiente.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Btn_siguiente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.Btn_siguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_siguiente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_siguiente.ForeColor = System.Drawing.Color.Black;
            this.Btn_siguiente.Image = global::CapaVistaFRM.Properties.Resources.search;
            this.Btn_siguiente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_siguiente.Location = new System.Drawing.Point(336, 224);
            this.Btn_siguiente.Name = "Btn_siguiente";
            this.Btn_siguiente.Size = new System.Drawing.Size(130, 47);
            this.Btn_siguiente.TabIndex = 37;
            this.Btn_siguiente.Text = "Siguiente";
            this.Btn_siguiente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_siguiente.UseVisualStyleBackColor = false;
            this.Btn_siguiente.Click += new System.EventHandler(this.Btn_siguiente_Click);
            // 
            // mov_banc_encabezado
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(521, 296);
            this.Controls.Add(this.Btn_siguiente);
            this.Controls.Add(this.Gpb_datos);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "mov_banc_encabezado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movimientos Bancarios";
            this.Load += new System.EventHandler(this.Mov_banc_encabezado_Load);
            this.Gpb_datos.ResumeLayout(false);
            this.Gpb_datos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox Gpb_datos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Cbo_cuentaBancaria;
        private System.Windows.Forms.Button Btn_siguiente;
    }
}