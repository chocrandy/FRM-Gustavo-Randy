﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaModeloFRM;

namespace CapaVistaFRM.Conta
{
	public partial class libro_Diario : Form
	{
		LibroDiario Libro = new LibroDiario();
		string idLibro = "";
		public libro_Diario()
		{
			InitializeComponent();
			Dtg_Fecha_Crear.Format = DateTimePickerFormat.Custom;
			Dtg_Fecha_Crear.CustomFormat = "yyyy-MM-dd";
			Dtg_Fecha_Modificar.Format = DateTimePickerFormat.Custom;
			Dtg_Fecha_Modificar.CustomFormat = "yyyy-MM-dd";
			Txt_Libro.Text = Libro.IdLibro();
			llenarLibros();
			tablaMovimientos();
			
		}

		void llenarLibros() {
			// 
			//// LLENAR TABLA DE LIBROS EN INGRESO
			OdbcDataAdapter dt = Libro.llenarLibroDiario();
			DataTable table = new DataTable();
			dt.Fill(table);
			Dtg_LibroDiario.DataSource = table;
		}

		void tablaMovimientos() {

			DataGridViewComboBoxColumn cuenta = new DataGridViewComboBoxColumn();
			cuenta.HeaderText = "Cuenta";
			cuenta.Items.AddRange(Libro.comboTabla());

			DataGridViewTextBoxColumn fecha = new DataGridViewTextBoxColumn();
			fecha.HeaderText = "Fecha";
			DataGridViewTextBoxColumn debe = new DataGridViewTextBoxColumn();
			debe.HeaderText = "Debe";
			DataGridViewTextBoxColumn haber = new DataGridViewTextBoxColumn();
			haber.HeaderText = "Haber";

			Dtg_Movimientos.Columns.Add(fecha);
			Dtg_Movimientos.Columns.Add(cuenta);
			Dtg_Movimientos.Columns.Add(debe);
			Dtg_Movimientos.Columns.Add(haber);
		}
		
		
		private void Libro_Diario_Load(object sender, EventArgs e)
		{

		}

		private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void GroupBox1_Enter(object sender, EventArgs e)
		{

		}

		private void GroupBox2_Enter(object sender, EventArgs e)
		{

		}

		private void Label10_Click(object sender, EventArgs e)
		{

		}

		private void Cmb_Empresa_Crear_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void Btn_Guardar_Click(object sender, EventArgs e)
		{
			
			Libro.crearLibroDiario(Txt_Libro.Text.ToString(), Cmb_Empresa_Crear.Text.ToString(),Dtg_Fecha_Crear.Text.ToString());
			llenarLibros();
			Txt_Libro.Text = Libro.IdLibro();
		}

		private void Dtg_LibroDiario_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			Gpb_Crear.Enabled = false;
			Btn_Partidas.Enabled = false;
			Cmb_Empresa_Modificar.Text =	Dtg_LibroDiario.CurrentRow.Cells[1].Value.ToString();
			Dtg_Fecha_Modificar.Text = Dtg_LibroDiario.CurrentRow.Cells[2].Value.ToString();
			if (Dtg_LibroDiario.CurrentRow.Cells[3].Value.ToString() == "0")
			{
				Chk_Estado.Checked = false;
			}
			else {
				Chk_Estado.Checked = true;
			}
			Gpb_Modificar.Enabled = true;
		}

		private void Btn_actualizar_Click(object sender, EventArgs e)
		{
			string estado = "0";
			if (Chk_Estado.Checked)
			{
				estado = "1";
			}
			Libro.ModificarLibroDiario(Dtg_LibroDiario.CurrentRow.Cells[0].Value.ToString(),Cmb_Empresa_Modificar.Text.ToString(),Dtg_Fecha_Modificar.Text.ToString(),estado);
			Gpb_Modificar.Enabled = false;
			llenarLibros();
			Gpb_Crear.Enabled = true;
			Btn_Partidas.Enabled = true;
		}

		private void Btn_Partidas_Click(object sender, EventArgs e)
		{
			
			idLibro = Dtg_LibroDiario.CurrentRow.Cells[0].Value.ToString();
			Tbc_LibroDiario.SelectedIndex = 1;
			OdbcDataAdapter dt = Libro.llenarPartidas(Dtg_LibroDiario.CurrentRow.Cells[0].Value.ToString());
			DataTable table = new DataTable();
			dt.Fill(table);
			 Dtg_Partidas.DataSource = table;
			
		}

		private void Btn_Guardar_partia_Click(object sender, EventArgs e)
		{
			bool proceder = true;
			int fil = Dtg_Movimientos.Rows.Count - 1;
			int col = Dtg_Movimientos.Columns.Count;
			for (int i = 0; i < fil; i++)
			{
				for (int j = 0; j < col; j++)
				{
					if (Dtg_Movimientos.Rows[i].Cells[j].Value == null)
					{
						MessageBox.Show("Por Favor llene la tabla en la fila " + (i+1).ToString()+" y Columna " + (j+1).ToString());
						proceder = false;
					}
				}
			}

			if (proceder)
			{
				Libro.crearPartida(Txt_partida.Text.ToString(), idLibro, Txt_Concepto.Text.ToString());
				foreach (DataGridViewRow row in Dtg_Movimientos.Rows)
				{
					if (Dtg_Movimientos.Rows.Count - 1 != row.Index)
					{
						Libro.crearDetalleLibroDiario(row.Index.ToString(), idLibro, Txt_partida.Text.ToString(), row.Cells[1].Value.ToString(), row.Cells[0].Value.ToString(), row.Cells[2].Value.ToString(), row.Cells[3].Value.ToString());

					}
				}
				Txt_partida.Text = Libro.IdPartida(idLibro);
				Dtg_Movimientos.Rows.Clear();
				OdbcDataAdapter dt = Libro.llenarPartidas(Dtg_LibroDiario.CurrentRow.Cells[0].Value.ToString());
				DataTable table = new DataTable();
				dt.Fill(table);
				Dtg_Partidas.DataSource = table;
			}
		}

		private void Btn_quiat_Click(object sender, EventArgs e)
		{
			Dtg_Partidas.Rows.RemoveAt(Dtg_Partidas.CurrentRow.Index);
		}

		private void Tbc_LibroDiario_SelectedIndexChanged(object sender, EventArgs e)
		{
			idLibro = Dtg_LibroDiario.CurrentRow.Cells[0].Value.ToString();
			Txt_partida.Text = Libro.IdPartida(idLibro);
		}
	}
}
