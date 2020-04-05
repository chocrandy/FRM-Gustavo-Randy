namespace CapaVistaFRM
{
    partial class revision_presupuestaria
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
            this.Dgv_presupuestos = new System.Windows.Forms.DataGridView();
            this.Gpb_buscar = new System.Windows.Forms.GroupBox();
            this.Gpb_revisar = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Txt_id = new System.Windows.Forms.TextBox();
            this.Txt_nombre = new System.Windows.Forms.TextBox();
            this.Txt_monto = new System.Windows.Forms.TextBox();
            this.Txt_moneda = new System.Windows.Forms.TextBox();
            this.Txt_area = new System.Windows.Forms.TextBox();
            this.Txt_descripcion = new System.Windows.Forms.TextBox();
            this.Txt_buscar = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Btn_buscar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.Cbo_estado = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_presupuestos)).BeginInit();
            this.Gpb_buscar.SuspendLayout();
            this.Gpb_revisar.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Maroon;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(250, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Revisión de Presupuestos";
            // 
            // Dgv_presupuestos
            // 
            this.Dgv_presupuestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_presupuestos.Location = new System.Drawing.Point(30, 71);
            this.Dgv_presupuestos.Name = "Dgv_presupuestos";
            this.Dgv_presupuestos.Size = new System.Drawing.Size(726, 172);
            this.Dgv_presupuestos.TabIndex = 3;
            // 
            // Gpb_buscar
            // 
            this.Gpb_buscar.Controls.Add(this.Btn_buscar);
            this.Gpb_buscar.Controls.Add(this.label8);
            this.Gpb_buscar.Controls.Add(this.Txt_buscar);
            this.Gpb_buscar.Location = new System.Drawing.Point(30, 257);
            this.Gpb_buscar.Name = "Gpb_buscar";
            this.Gpb_buscar.Size = new System.Drawing.Size(726, 87);
            this.Gpb_buscar.TabIndex = 4;
            this.Gpb_buscar.TabStop = false;
            this.Gpb_buscar.Text = "Buscar";
            // 
            // Gpb_revisar
            // 
            this.Gpb_revisar.Controls.Add(this.Cbo_estado);
            this.Gpb_revisar.Controls.Add(this.label9);
            this.Gpb_revisar.Controls.Add(this.Txt_descripcion);
            this.Gpb_revisar.Controls.Add(this.Txt_area);
            this.Gpb_revisar.Controls.Add(this.Txt_moneda);
            this.Gpb_revisar.Controls.Add(this.Txt_monto);
            this.Gpb_revisar.Controls.Add(this.Txt_nombre);
            this.Gpb_revisar.Controls.Add(this.Txt_id);
            this.Gpb_revisar.Controls.Add(this.label7);
            this.Gpb_revisar.Controls.Add(this.label6);
            this.Gpb_revisar.Controls.Add(this.label5);
            this.Gpb_revisar.Controls.Add(this.label4);
            this.Gpb_revisar.Controls.Add(this.label3);
            this.Gpb_revisar.Controls.Add(this.label2);
            this.Gpb_revisar.Location = new System.Drawing.Point(30, 353);
            this.Gpb_revisar.Name = "Gpb_revisar";
            this.Gpb_revisar.Size = new System.Drawing.Size(726, 192);
            this.Gpb_revisar.TabIndex = 5;
            this.Gpb_revisar.TabStop = false;
            this.Gpb_revisar.Text = "Revisar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Id: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Monto:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(386, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "Moneda:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(414, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 21);
            this.label6.TabIndex = 7;
            this.label6.Text = "Área:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(363, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 21);
            this.label7.TabIndex = 8;
            this.label7.Text = "Descripción: ";
            // 
            // Txt_id
            // 
            this.Txt_id.Location = new System.Drawing.Point(105, 26);
            this.Txt_id.Name = "Txt_id";
            this.Txt_id.Size = new System.Drawing.Size(200, 27);
            this.Txt_id.TabIndex = 15;
            // 
            // Txt_nombre
            // 
            this.Txt_nombre.Location = new System.Drawing.Point(105, 64);
            this.Txt_nombre.Name = "Txt_nombre";
            this.Txt_nombre.Size = new System.Drawing.Size(200, 27);
            this.Txt_nombre.TabIndex = 16;
            // 
            // Txt_monto
            // 
            this.Txt_monto.Location = new System.Drawing.Point(105, 102);
            this.Txt_monto.Name = "Txt_monto";
            this.Txt_monto.Size = new System.Drawing.Size(200, 27);
            this.Txt_monto.TabIndex = 17;
            // 
            // Txt_moneda
            // 
            this.Txt_moneda.Location = new System.Drawing.Point(473, 26);
            this.Txt_moneda.Name = "Txt_moneda";
            this.Txt_moneda.Size = new System.Drawing.Size(200, 27);
            this.Txt_moneda.TabIndex = 18;
            // 
            // Txt_area
            // 
            this.Txt_area.Location = new System.Drawing.Point(473, 64);
            this.Txt_area.Name = "Txt_area";
            this.Txt_area.Size = new System.Drawing.Size(200, 27);
            this.Txt_area.TabIndex = 19;
            // 
            // Txt_descripcion
            // 
            this.Txt_descripcion.Location = new System.Drawing.Point(473, 102);
            this.Txt_descripcion.Name = "Txt_descripcion";
            this.Txt_descripcion.Size = new System.Drawing.Size(200, 27);
            this.Txt_descripcion.TabIndex = 20;
            // 
            // Txt_buscar
            // 
            this.Txt_buscar.Location = new System.Drawing.Point(292, 35);
            this.Txt_buscar.Name = "Txt_buscar";
            this.Txt_buscar.Size = new System.Drawing.Size(264, 27);
            this.Txt_buscar.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(264, 21);
            this.label8.TabIndex = 16;
            this.label8.Text = "Ingrese Nombre del Presupuesto:";
            // 
            // Btn_buscar
            // 
            this.Btn_buscar.BackColor = System.Drawing.Color.White;
            this.Btn_buscar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Btn_buscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.Btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_buscar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_buscar.ForeColor = System.Drawing.Color.Black;
            this.Btn_buscar.Image = global::CapaVistaFRM.Properties.Resources.search;
            this.Btn_buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_buscar.Location = new System.Drawing.Point(591, 27);
            this.Btn_buscar.Name = "Btn_buscar";
            this.Btn_buscar.Size = new System.Drawing.Size(115, 42);
            this.Btn_buscar.TabIndex = 17;
            this.Btn_buscar.Text = "Buscar";
            this.Btn_buscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_buscar.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(248, 153);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 21);
            this.label9.TabIndex = 21;
            this.label9.Text = "ESTADO:";
            // 
            // Cbo_estado
            // 
            this.Cbo_estado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_estado.FormattingEnabled = true;
            this.Cbo_estado.Items.AddRange(new object[] {
            "Aprobado",
            "Rechazado"});
            this.Cbo_estado.Location = new System.Drawing.Point(332, 150);
            this.Cbo_estado.Name = "Cbo_estado";
            this.Cbo_estado.Size = new System.Drawing.Size(169, 29);
            this.Cbo_estado.TabIndex = 22;
            this.Cbo_estado.Text = "Seleccione";
            // 
            // revision_presupuestaria
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(800, 567);
            this.Controls.Add(this.Gpb_revisar);
            this.Controls.Add(this.Gpb_buscar);
            this.Controls.Add(this.Dgv_presupuestos);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "revision_presupuestaria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formato";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_presupuestos)).EndInit();
            this.Gpb_buscar.ResumeLayout(false);
            this.Gpb_buscar.PerformLayout();
            this.Gpb_revisar.ResumeLayout(false);
            this.Gpb_revisar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Dgv_presupuestos;
        private System.Windows.Forms.GroupBox Gpb_buscar;
        private System.Windows.Forms.GroupBox Gpb_revisar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Txt_buscar;
        private System.Windows.Forms.TextBox Txt_descripcion;
        private System.Windows.Forms.TextBox Txt_area;
        private System.Windows.Forms.TextBox Txt_moneda;
        private System.Windows.Forms.TextBox Txt_monto;
        private System.Windows.Forms.TextBox Txt_nombre;
        private System.Windows.Forms.TextBox Txt_id;
        private System.Windows.Forms.Button Btn_buscar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox Cbo_estado;
    }
}