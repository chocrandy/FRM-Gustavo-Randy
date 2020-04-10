using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaModeloFRM;

namespace CapaVistaFRM.Conta
{
	public partial class formato : Form
	{
		LibroDiario Libro = new LibroDiario();
		public formato()
		{
			InitializeComponent();
			Libro.crearLibroDiario("","");
		}

		private void Libro_Diario_Load(object sender, EventArgs e)
		{

		}
	}
}
