namespace CapaVistaFRM
{
    partial class cuentas_contables
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			this.Cmb_Tipo = new System.Windows.Forms.ComboBox();
			this.Txt_nombre = new System.Windows.Forms.TextBox();
			this.Txt_desc = new System.Windows.Forms.TextBox();
			this.Btn_guardar = new System.Windows.Forms.Button();
			this.Txt_Id = new System.Windows.Forms.TextBox();
			this.Btn_plusLevel = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.Dtgv_Cuentas = new System.Windows.Forms.DataGridView();
			this.label5 = new System.Windows.Forms.Label();
			this.Cmb_filtro = new System.Windows.Forms.ComboBox();
			this.Código = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Cuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Dtgv_Cuentas)).BeginInit();
			this.SuspendLayout();
			// 
			// Cmb_Tipo
			// 
			this.Cmb_Tipo.FormattingEnabled = true;
			this.Cmb_Tipo.Location = new System.Drawing.Point(41, 145);
			this.Cmb_Tipo.Name = "Cmb_Tipo";
			this.Cmb_Tipo.Size = new System.Drawing.Size(185, 29);
			this.Cmb_Tipo.TabIndex = 0;
			this.Cmb_Tipo.SelectedIndexChanged += new System.EventHandler(this.Cmb_Tipo_SelectedIndexChanged);
			// 
			// Txt_nombre
			// 
			this.Txt_nombre.Location = new System.Drawing.Point(242, 145);
			this.Txt_nombre.Name = "Txt_nombre";
			this.Txt_nombre.Size = new System.Drawing.Size(222, 27);
			this.Txt_nombre.TabIndex = 1;
			// 
			// Txt_desc
			// 
			this.Txt_desc.Location = new System.Drawing.Point(488, 82);
			this.Txt_desc.Multiline = true;
			this.Txt_desc.Name = "Txt_desc";
			this.Txt_desc.Size = new System.Drawing.Size(423, 92);
			this.Txt_desc.TabIndex = 2;
			// 
			// Btn_guardar
			// 
			this.Btn_guardar.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Btn_guardar.Location = new System.Drawing.Point(934, 79);
			this.Btn_guardar.Name = "Btn_guardar";
			this.Btn_guardar.Size = new System.Drawing.Size(130, 95);
			this.Btn_guardar.TabIndex = 3;
			this.Btn_guardar.Text = "Guardar";
			this.Btn_guardar.UseVisualStyleBackColor = true;
			this.Btn_guardar.Click += new System.EventHandler(this.Btn_guardar_Click);
			// 
			// Txt_Id
			// 
			this.Txt_Id.Enabled = false;
			this.Txt_Id.Location = new System.Drawing.Point(38, 74);
			this.Txt_Id.Name = "Txt_Id";
			this.Txt_Id.Size = new System.Drawing.Size(185, 27);
			this.Txt_Id.TabIndex = 4;
			// 
			// Btn_plusLevel
			// 
			this.Btn_plusLevel.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Btn_plusLevel.Location = new System.Drawing.Point(239, 69);
			this.Btn_plusLevel.Name = "Btn_plusLevel";
			this.Btn_plusLevel.Size = new System.Drawing.Size(222, 32);
			this.Btn_plusLevel.TabIndex = 5;
			this.Btn_plusLevel.Text = "+ Nivel";
			this.Btn_plusLevel.UseVisualStyleBackColor = true;
			this.Btn_plusLevel.Click += new System.EventHandler(this.Btn_plusLevel_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.Txt_desc);
			this.groupBox1.Controls.Add(this.Btn_plusLevel);
			this.groupBox1.Controls.Add(this.Cmb_Tipo);
			this.groupBox1.Controls.Add(this.Txt_Id);
			this.groupBox1.Controls.Add(this.Txt_nombre);
			this.groupBox1.Controls.Add(this.Btn_guardar);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(1093, 192);
			this.groupBox1.TabIndex = 6;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Registro de Cuentas";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(44, 37);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(155, 21);
			this.label1.TabIndex = 6;
			this.label1.Text = "Código de Cuenta";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(60, 121);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(129, 21);
			this.label2.TabIndex = 7;
			this.label2.Text = "Tipo de Cuenta";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(283, 121);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(136, 21);
			this.label3.TabIndex = 8;
			this.label3.Text = "Nombre Cuenta";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(629, 58);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(164, 21);
			this.label4.TabIndex = 9;
			this.label4.Text = "Descripción Cuenta";
			// 
			// Dtgv_Cuentas
			// 
			this.Dtgv_Cuentas.AllowUserToAddRows = false;
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle7.BackColor = System.Drawing.Color.DarkRed;
			dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.IndianRed;
			dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.Dtgv_Cuentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
			this.Dtgv_Cuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.Dtgv_Cuentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Código,
            this.Cuenta});
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.DarkRed;
			dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.Dtgv_Cuentas.DefaultCellStyle = dataGridViewCellStyle8;
			this.Dtgv_Cuentas.Location = new System.Drawing.Point(25, 265);
			this.Dtgv_Cuentas.Name = "Dtgv_Cuentas";
			this.Dtgv_Cuentas.ReadOnly = true;
			this.Dtgv_Cuentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.Dtgv_Cuentas.Size = new System.Drawing.Size(1067, 423);
			this.Dtgv_Cuentas.TabIndex = 7;
			this.Dtgv_Cuentas.TabStop = false;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(25, 227);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(52, 21);
			this.label5.TabIndex = 10;
			this.label5.Text = "Filtrar";
			// 
			// Cmb_filtro
			// 
			this.Cmb_filtro.FormattingEnabled = true;
			this.Cmb_filtro.Location = new System.Drawing.Point(83, 224);
			this.Cmb_filtro.Name = "Cmb_filtro";
			this.Cmb_filtro.Size = new System.Drawing.Size(185, 29);
			this.Cmb_filtro.TabIndex = 10;
			// 
			// Código
			// 
			this.Código.HeaderText = "Código";
			this.Código.Name = "Código";
			this.Código.ReadOnly = true;
			this.Código.Width = 200;
			// 
			// Cuenta
			// 
			this.Cuenta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Cuenta.HeaderText = "Cuenta";
			this.Cuenta.Name = "Cuenta";
			this.Cuenta.ReadOnly = true;
			// 
			// cuentas_contables
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1117, 700);
			this.Controls.Add(this.Cmb_filtro);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.Dtgv_Cuentas);
			this.Controls.Add(this.groupBox1);
			this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.Color.Black;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Name = "cuentas_contables";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "cuentas_contables";
			this.Load += new System.EventHandler(this.Cuentas_contables_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.Dtgv_Cuentas)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.ComboBox Cmb_Tipo;
		private System.Windows.Forms.TextBox Txt_nombre;
		private System.Windows.Forms.TextBox Txt_desc;
		private System.Windows.Forms.Button Btn_guardar;
		private System.Windows.Forms.TextBox Txt_Id;
		private System.Windows.Forms.Button Btn_plusLevel;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView Dtgv_Cuentas;
		private System.Windows.Forms.DataGridViewTextBoxColumn Código;
		private System.Windows.Forms.DataGridViewTextBoxColumn Cuenta;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox Cmb_filtro;
	}
}