using System;
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
		public libro_Diario()
		{
			InitializeComponent();
			llenarLibros();
		}

		void llenarLibros() {
			OdbcDataAdapter dt = Libro.llenarLibroDiario();
			DataTable table = new DataTable();
			dt.Fill(table);
			Dtg_LibroDiario.DataSource = table;
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
	}
}
