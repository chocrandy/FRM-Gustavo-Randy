﻿namespace CapaVistaFRM
{
	partial class libro_Mayor
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
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
			this.Tbc_LibroDiario = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.Btn_Partidas = new System.Windows.Forms.Button();
			this.Dtg_LibroDiario = new System.Windows.Forms.DataGridView();
			this.Gpb_Modificar = new System.Windows.Forms.GroupBox();
			this.label8 = new System.Windows.Forms.Label();
			this.Chk_Estado = new System.Windows.Forms.CheckBox();
			this.Btn_actualizar = new System.Windows.Forms.Button();
			this.Dtg_Fecha_Modificar = new System.Windows.Forms.DateTimePicker();
			this.Cmb_Empresa_Modificar = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.Gpb_Crear = new System.Windows.Forms.GroupBox();
			this.Btn_Guardar = new System.Windows.Forms.Button();
			this.Dtg_Fecha_Crear = new System.Windows.Forms.DateTimePicker();
			this.Cmb_Empresa_Crear = new System.Windows.Forms.ComboBox();
			this.Txt_Libro = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.Btn_Guardar_partia = new System.Windows.Forms.Button();
			this.Dtg_Partidas = new System.Windows.Forms.DataGridView();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.button2 = new System.Windows.Forms.Button();
			this.Dtg_Resumen = new System.Windows.Forms.DataGridView();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.Tbc_LibroDiario.SuspendLayout();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Dtg_LibroDiario)).BeginInit();
			this.Gpb_Modificar.SuspendLayout();
			this.Gpb_Crear.SuspendLayout();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Dtg_Partidas)).BeginInit();
			this.tabPage3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Dtg_Resumen)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// Tbc_LibroDiario
			// 
			this.Tbc_LibroDiario.Controls.Add(this.tabPage1);
			this.Tbc_LibroDiario.Controls.Add(this.tabPage2);
			this.Tbc_LibroDiario.Controls.Add(this.tabPage3);
			this.Tbc_LibroDiario.Location = new System.Drawing.Point(2, 110);
			this.Tbc_LibroDiario.Name = "Tbc_LibroDiario";
			this.Tbc_LibroDiario.SelectedIndex = 0;
			this.Tbc_LibroDiario.Size = new System.Drawing.Size(1278, 563);
			this.Tbc_LibroDiario.TabIndex = 0;
			this.Tbc_LibroDiario.SelectedIndexChanged += new System.EventHandler(this.Tbc_LibroDiario_SelectedIndexChanged);
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.Btn_Partidas);
			this.tabPage1.Controls.Add(this.Dtg_LibroDiario);
			this.tabPage1.Controls.Add(this.Gpb_Modificar);
			this.tabPage1.Controls.Add(this.Gpb_Crear);
			this.tabPage1.Location = new System.Drawing.Point(4, 30);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(1270, 529);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = " Libros";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// Btn_Partidas
			// 
			this.Btn_Partidas.BackColor = System.Drawing.Color.Firebrick;
			this.Btn_Partidas.FlatAppearance.BorderSize = 0;
			this.Btn_Partidas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
			this.Btn_Partidas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Btn_Partidas.ForeColor = System.Drawing.Color.White;
			this.Btn_Partidas.Location = new System.Drawing.Point(1130, 472);
			this.Btn_Partidas.Name = "Btn_Partidas";
			this.Btn_Partidas.Size = new System.Drawing.Size(119, 35);
			this.Btn_Partidas.TabIndex = 8;
			this.Btn_Partidas.Text = "Ver Detalle";
			this.Btn_Partidas.UseVisualStyleBackColor = false;
			this.Btn_Partidas.Click += new System.EventHandler(this.Btn_Partidas_Click);
			// 
			// Dtg_LibroDiario
			// 
			this.Dtg_LibroDiario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle15.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.IndianRed;
			dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.Dtg_LibroDiario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle15;
			this.Dtg_LibroDiario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle16.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.IndianRed;
			dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.Dtg_LibroDiario.DefaultCellStyle = dataGridViewCellStyle16;
			this.Dtg_LibroDiario.Location = new System.Drawing.Point(452, 16);
			this.Dtg_LibroDiario.Name = "Dtg_LibroDiario";
			this.Dtg_LibroDiario.ReadOnly = true;
			this.Dtg_LibroDiario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.Dtg_LibroDiario.Size = new System.Drawing.Size(797, 443);
			this.Dtg_LibroDiario.TabIndex = 9;
			this.Dtg_LibroDiario.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dtg_LibroDiario_CellContentDoubleClick);
			// 
			// Gpb_Modificar
			// 
			this.Gpb_Modificar.Controls.Add(this.label8);
			this.Gpb_Modificar.Controls.Add(this.Chk_Estado);
			this.Gpb_Modificar.Controls.Add(this.Btn_actualizar);
			this.Gpb_Modificar.Controls.Add(this.Dtg_Fecha_Modificar);
			this.Gpb_Modificar.Controls.Add(this.Cmb_Empresa_Modificar);
			this.Gpb_Modificar.Controls.Add(this.label5);
			this.Gpb_Modificar.Controls.Add(this.label6);
			this.Gpb_Modificar.Enabled = false;
			this.Gpb_Modificar.Location = new System.Drawing.Point(6, 270);
			this.Gpb_Modificar.Name = "Gpb_Modificar";
			this.Gpb_Modificar.Size = new System.Drawing.Size(418, 253);
			this.Gpb_Modificar.TabIndex = 8;
			this.Gpb_Modificar.TabStop = false;
			this.Gpb_Modificar.Text = "Modificar";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(52, 64);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(94, 21);
			this.label8.TabIndex = 9;
			this.label8.Text = "Libro Diario";
			// 
			// Chk_Estado
			// 
			this.Chk_Estado.AutoSize = true;
			this.Chk_Estado.Location = new System.Drawing.Point(167, 149);
			this.Chk_Estado.Name = "Chk_Estado";
			this.Chk_Estado.Size = new System.Drawing.Size(15, 14);
			this.Chk_Estado.TabIndex = 8;
			this.Chk_Estado.UseVisualStyleBackColor = true;
			// 
			// Btn_actualizar
			// 
			this.Btn_actualizar.BackColor = System.Drawing.Color.Firebrick;
			this.Btn_actualizar.FlatAppearance.BorderSize = 0;
			this.Btn_actualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
			this.Btn_actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Btn_actualizar.ForeColor = System.Drawing.Color.White;
			this.Btn_actualizar.Location = new System.Drawing.Point(90, 202);
			this.Btn_actualizar.Name = "Btn_actualizar";
			this.Btn_actualizar.Size = new System.Drawing.Size(200, 35);
			this.Btn_actualizar.TabIndex = 6;
			this.Btn_actualizar.Text = "Actualizar";
			this.Btn_actualizar.UseVisualStyleBackColor = false;
			this.Btn_actualizar.Click += new System.EventHandler(this.Btn_actualizar_Click);
			// 
			// Dtg_Fecha_Modificar
			// 
			this.Dtg_Fecha_Modificar.Location = new System.Drawing.Point(167, 99);
			this.Dtg_Fecha_Modificar.Name = "Dtg_Fecha_Modificar";
			this.Dtg_Fecha_Modificar.Size = new System.Drawing.Size(200, 27);
			this.Dtg_Fecha_Modificar.TabIndex = 5;
			// 
			// Cmb_Empresa_Modificar
			// 
			this.Cmb_Empresa_Modificar.FormattingEnabled = true;
			this.Cmb_Empresa_Modificar.Location = new System.Drawing.Point(167, 56);
			this.Cmb_Empresa_Modificar.Name = "Cmb_Empresa_Modificar";
			this.Cmb_Empresa_Modificar.Size = new System.Drawing.Size(200, 29);
			this.Cmb_Empresa_Modificar.TabIndex = 4;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(51, 104);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(59, 21);
			this.label5.TabIndex = 2;
			this.label5.Text = "Fecha";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(52, 146);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(64, 21);
			this.label6.TabIndex = 0;
			this.label6.Text = "Estado";
			// 
			// Gpb_Crear
			// 
			this.Gpb_Crear.Controls.Add(this.Btn_Guardar);
			this.Gpb_Crear.Controls.Add(this.Dtg_Fecha_Crear);
			this.Gpb_Crear.Controls.Add(this.Cmb_Empresa_Crear);
			this.Gpb_Crear.Controls.Add(this.Txt_Libro);
			this.Gpb_Crear.Controls.Add(this.label4);
			this.Gpb_Crear.Controls.Add(this.label2);
			this.Gpb_Crear.Controls.Add(this.label3);
			this.Gpb_Crear.Location = new System.Drawing.Point(6, 6);
			this.Gpb_Crear.Name = "Gpb_Crear";
			this.Gpb_Crear.Size = new System.Drawing.Size(418, 253);
			this.Gpb_Crear.TabIndex = 3;
			this.Gpb_Crear.TabStop = false;
			this.Gpb_Crear.Text = "Crear";
			// 
			// Btn_Guardar
			// 
			this.Btn_Guardar.BackColor = System.Drawing.Color.Firebrick;
			this.Btn_Guardar.FlatAppearance.BorderSize = 0;
			this.Btn_Guardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
			this.Btn_Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Btn_Guardar.ForeColor = System.Drawing.Color.White;
			this.Btn_Guardar.Location = new System.Drawing.Point(90, 198);
			this.Btn_Guardar.Name = "Btn_Guardar";
			this.Btn_Guardar.Size = new System.Drawing.Size(200, 35);
			this.Btn_Guardar.TabIndex = 6;
			this.Btn_Guardar.Text = "Guardar";
			this.Btn_Guardar.UseVisualStyleBackColor = false;
			this.Btn_Guardar.Click += new System.EventHandler(this.Btn_Guardar_Click);
			// 
			// Dtg_Fecha_Crear
			// 
			this.Dtg_Fecha_Crear.Location = new System.Drawing.Point(167, 149);
			this.Dtg_Fecha_Crear.Name = "Dtg_Fecha_Crear";
			this.Dtg_Fecha_Crear.Size = new System.Drawing.Size(200, 27);
			this.Dtg_Fecha_Crear.TabIndex = 5;
			// 
			// Cmb_Empresa_Crear
			// 
			this.Cmb_Empresa_Crear.FormattingEnabled = true;
			this.Cmb_Empresa_Crear.Location = new System.Drawing.Point(167, 99);
			this.Cmb_Empresa_Crear.Name = "Cmb_Empresa_Crear";
			this.Cmb_Empresa_Crear.Size = new System.Drawing.Size(200, 29);
			this.Cmb_Empresa_Crear.TabIndex = 4;
			this.Cmb_Empresa_Crear.SelectedIndexChanged += new System.EventHandler(this.Cmb_Empresa_Crear_SelectedIndexChanged);
			// 
			// Txt_Libro
			// 
			this.Txt_Libro.Enabled = false;
			this.Txt_Libro.Location = new System.Drawing.Point(167, 47);
			this.Txt_Libro.Name = "Txt_Libro";
			this.Txt_Libro.Size = new System.Drawing.Size(200, 27);
			this.Txt_Libro.TabIndex = 3;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(51, 149);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(59, 21);
			this.label4.TabIndex = 2;
			this.label4.Text = "Fecha";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(51, 50);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(76, 21);
			this.label2.TabIndex = 0;
			this.label2.Text = "Libro No.";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(51, 102);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(94, 21);
			this.label3.TabIndex = 1;
			this.label3.Text = "Libro Diario";
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.progressBar1);
			this.tabPage2.Controls.Add(this.Btn_Guardar_partia);
			this.tabPage2.Controls.Add(this.Dtg_Partidas);
			this.tabPage2.Location = new System.Drawing.Point(4, 30);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(1270, 529);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Detalles";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// Btn_Guardar_partia
			// 
			this.Btn_Guardar_partia.BackColor = System.Drawing.Color.Firebrick;
			this.Btn_Guardar_partia.FlatAppearance.BorderSize = 0;
			this.Btn_Guardar_partia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
			this.Btn_Guardar_partia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Btn_Guardar_partia.ForeColor = System.Drawing.Color.White;
			this.Btn_Guardar_partia.Location = new System.Drawing.Point(54, 191);
			this.Btn_Guardar_partia.Name = "Btn_Guardar_partia";
			this.Btn_Guardar_partia.Size = new System.Drawing.Size(129, 73);
			this.Btn_Guardar_partia.TabIndex = 4;
			this.Btn_Guardar_partia.Text = "Guardar";
			this.Btn_Guardar_partia.UseVisualStyleBackColor = false;
			this.Btn_Guardar_partia.Click += new System.EventHandler(this.Btn_Guardar_partia_Click);
			// 
			// Dtg_Partidas
			// 
			this.Dtg_Partidas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle13.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.IndianRed;
			dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.Dtg_Partidas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
			this.Dtg_Partidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle14.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.IndianRed;
			dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.Dtg_Partidas.DefaultCellStyle = dataGridViewCellStyle14;
			this.Dtg_Partidas.Location = new System.Drawing.Point(251, 19);
			this.Dtg_Partidas.Name = "Dtg_Partidas";
			this.Dtg_Partidas.ReadOnly = true;
			this.Dtg_Partidas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.Dtg_Partidas.Size = new System.Drawing.Size(965, 471);
			this.Dtg_Partidas.StandardTab = true;
			this.Dtg_Partidas.TabIndex = 12;
			this.Dtg_Partidas.TabStop = false;
			this.Dtg_Partidas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
			this.Dtg_Partidas.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dtg_Partidas_CellContentDoubleClick);
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.button2);
			this.tabPage3.Controls.Add(this.Dtg_Resumen);
			this.tabPage3.Location = new System.Drawing.Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage3.Size = new System.Drawing.Size(1270, 537);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Visualizar";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.Firebrick;
			this.button2.FlatAppearance.BorderSize = 0;
			this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.ForeColor = System.Drawing.Color.White;
			this.button2.Location = new System.Drawing.Point(1031, 470);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(192, 35);
			this.button2.TabIndex = 18;
			this.button2.Text = "PDF";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.Button2_Click);
			// 
			// Dtg_Resumen
			// 
			this.Dtg_Resumen.AllowUserToAddRows = false;
			this.Dtg_Resumen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle17.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.IndianRed;
			dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.Dtg_Resumen.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
			this.Dtg_Resumen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle18.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.IndianRed;
			dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.Dtg_Resumen.DefaultCellStyle = dataGridViewCellStyle18;
			this.Dtg_Resumen.Location = new System.Drawing.Point(55, 29);
			this.Dtg_Resumen.Name = "Dtg_Resumen";
			this.Dtg_Resumen.ReadOnly = true;
			this.Dtg_Resumen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.Dtg_Resumen.Size = new System.Drawing.Size(931, 476);
			this.Dtg_Resumen.TabIndex = 17;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Firebrick;
			this.panel1.Controls.Add(this.label1);
			this.panel1.ForeColor = System.Drawing.Color.Black;
			this.panel1.Location = new System.Drawing.Point(2, 2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1278, 102);
			this.panel1.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(10, 7);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(396, 79);
			this.label1.TabIndex = 0;
			this.label1.Text = "Libro Mayor";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// progressBar1
			// 
			this.progressBar1.Location = new System.Drawing.Point(35, 300);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(164, 23);
			this.progressBar1.TabIndex = 13;
			this.progressBar1.Visible = false;
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
			// 
			// libro_Mayor
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(1279, 673);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.Tbc_LibroDiario);
			this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Name = "libro_Mayor";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Load += new System.EventHandler(this.libro_Mayor_Load);
			this.Tbc_LibroDiario.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.Dtg_LibroDiario)).EndInit();
			this.Gpb_Modificar.ResumeLayout(false);
			this.Gpb_Modificar.PerformLayout();
			this.Gpb_Crear.ResumeLayout(false);
			this.Gpb_Crear.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.Dtg_Partidas)).EndInit();
			this.tabPage3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.Dtg_Resumen)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl Tbc_LibroDiario;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView Dtg_LibroDiario;
		private System.Windows.Forms.GroupBox Gpb_Modificar;
		private System.Windows.Forms.CheckBox Chk_Estado;
		private System.Windows.Forms.Button Btn_actualizar;
		private System.Windows.Forms.DateTimePicker Dtg_Fecha_Modificar;
		private System.Windows.Forms.ComboBox Cmb_Empresa_Modificar;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.GroupBox Gpb_Crear;
		private System.Windows.Forms.Button Btn_Guardar;
		private System.Windows.Forms.DateTimePicker Dtg_Fecha_Crear;
		private System.Windows.Forms.ComboBox Cmb_Empresa_Crear;
		private System.Windows.Forms.TextBox Txt_Libro;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DataGridView Dtg_Partidas;
		private System.Windows.Forms.Button Btn_Partidas;
		private System.Windows.Forms.Button Btn_Guardar_partia;
		private System.Windows.Forms.DataGridView Dtg_Resumen;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.Timer timer1;
	}
}