namespace CapaVistaFRM
{
    partial class tipo_de_cambio
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Cbo_monedaDe = new System.Windows.Forms.ComboBox();
            this.Cbo_monedaA = new System.Windows.Forms.ComboBox();
            this.Gpb_consultar = new System.Windows.Forms.GroupBox();
            this.Btn_consultar = new System.Windows.Forms.Button();
            this.Gpb_cambioAlDia = new System.Windows.Forms.GroupBox();
            this.Lbl_cambioAlDia = new System.Windows.Forms.Label();
            this.Gpb_consultar.SuspendLayout();
            this.Gpb_cambioAlDia.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Maroon;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(172, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tipo de Cambio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "De: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "A: ";
            // 
            // Cbo_monedaDe
            // 
            this.Cbo_monedaDe.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_monedaDe.FormattingEnabled = true;
            this.Cbo_monedaDe.Location = new System.Drawing.Point(54, 39);
            this.Cbo_monedaDe.Name = "Cbo_monedaDe";
            this.Cbo_monedaDe.Size = new System.Drawing.Size(224, 29);
            this.Cbo_monedaDe.TabIndex = 4;
            this.Cbo_monedaDe.Text = "Seleccione moneda";
            // 
            // Cbo_monedaA
            // 
            this.Cbo_monedaA.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_monedaA.FormattingEnabled = true;
            this.Cbo_monedaA.Location = new System.Drawing.Point(54, 94);
            this.Cbo_monedaA.Name = "Cbo_monedaA";
            this.Cbo_monedaA.Size = new System.Drawing.Size(224, 29);
            this.Cbo_monedaA.TabIndex = 5;
            this.Cbo_monedaA.Text = "Seleccione moneda";
            // 
            // Gpb_consultar
            // 
            this.Gpb_consultar.Controls.Add(this.Btn_consultar);
            this.Gpb_consultar.Controls.Add(this.Cbo_monedaDe);
            this.Gpb_consultar.Controls.Add(this.label2);
            this.Gpb_consultar.Controls.Add(this.Cbo_monedaA);
            this.Gpb_consultar.Controls.Add(this.label3);
            this.Gpb_consultar.Location = new System.Drawing.Point(22, 78);
            this.Gpb_consultar.Name = "Gpb_consultar";
            this.Gpb_consultar.Size = new System.Drawing.Size(301, 204);
            this.Gpb_consultar.TabIndex = 7;
            this.Gpb_consultar.TabStop = false;
            this.Gpb_consultar.Text = "Consulta";
            // 
            // Btn_consultar
            // 
            this.Btn_consultar.BackColor = System.Drawing.Color.White;
            this.Btn_consultar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Btn_consultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.Btn_consultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_consultar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_consultar.ForeColor = System.Drawing.Color.Black;
            this.Btn_consultar.Image = global::CapaVistaFRM.Properties.Resources.search;
            this.Btn_consultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_consultar.Location = new System.Drawing.Point(84, 150);
            this.Btn_consultar.Name = "Btn_consultar";
            this.Btn_consultar.Size = new System.Drawing.Size(130, 37);
            this.Btn_consultar.TabIndex = 6;
            this.Btn_consultar.Text = "Consultar";
            this.Btn_consultar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_consultar.UseVisualStyleBackColor = false;
            // 
            // Gpb_cambioAlDia
            // 
            this.Gpb_cambioAlDia.Controls.Add(this.Lbl_cambioAlDia);
            this.Gpb_cambioAlDia.Location = new System.Drawing.Point(350, 78);
            this.Gpb_cambioAlDia.Name = "Gpb_cambioAlDia";
            this.Gpb_cambioAlDia.Size = new System.Drawing.Size(170, 204);
            this.Gpb_cambioAlDia.TabIndex = 8;
            this.Gpb_cambioAlDia.TabStop = false;
            this.Gpb_cambioAlDia.Text = "Cambio al día";
            // 
            // Lbl_cambioAlDia
            // 
            this.Lbl_cambioAlDia.AutoSize = true;
            this.Lbl_cambioAlDia.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_cambioAlDia.Location = new System.Drawing.Point(36, 88);
            this.Lbl_cambioAlDia.Name = "Lbl_cambioAlDia";
            this.Lbl_cambioAlDia.Size = new System.Drawing.Size(98, 32);
            this.Lbl_cambioAlDia.TabIndex = 0;
            this.Lbl_cambioAlDia.Text = "0.0000";
            // 
            // tipo_de_cambio
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(548, 310);
            this.Controls.Add(this.Gpb_cambioAlDia);
            this.Controls.Add(this.Gpb_consultar);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "tipo_de_cambio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tipo de Cambio";
            this.Gpb_consultar.ResumeLayout(false);
            this.Gpb_consultar.PerformLayout();
            this.Gpb_cambioAlDia.ResumeLayout(false);
            this.Gpb_cambioAlDia.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Cbo_monedaDe;
        private System.Windows.Forms.ComboBox Cbo_monedaA;
        private System.Windows.Forms.GroupBox Gpb_consultar;
        private System.Windows.Forms.GroupBox Gpb_cambioAlDia;
        private System.Windows.Forms.Label Lbl_cambioAlDia;
        private System.Windows.Forms.Button Btn_consultar;
    }
}