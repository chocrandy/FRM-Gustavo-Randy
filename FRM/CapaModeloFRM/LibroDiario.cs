using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaControladorFRM;

namespace CapaModeloFRM
{
	public class LibroDiario
	{
		sql_LibroDiario Diario = new sql_LibroDiario();
		public void crearLibroDiario(string id, string empresa, string fecha) {
			string query = "INSERT INTO libro_diario_encabezados (id_libro_diario, empresa,fecha) " +
			"VALUES (" + id + ",'" + empresa + "', '" + fecha + "')";
			Diario.ejecutarQuery(query);
		}

		public void ModificarLibroDiario(string id, string empresa, string fecha, string estado)
		{
			string query = "UPDATE libro_diario_encabezados  SET empresa = '" + empresa + "', fecha = '" + fecha + "'," +
			" estado = " + estado + " WHERE id_libro_diario = " + id + ";";
			Diario.ejecutarQuery(query);
		}

		public OdbcDataAdapter llenarLibroDiario()
		{
			OdbcDataAdapter dataTable = Diario.LlenarTablaDiarioEncabezado();
			return dataTable;
		}

		public OdbcDataAdapter llenarPartidas(string id)
		{
			OdbcDataAdapter dataTable = Diario.LlenarTablaPartidas(id);
			return dataTable;
		}

		public string IdLibro() {
			return Diario.ObtenerIdLibro();
		}

		public string[] comboTabla()
		{
			string[] combo = Diario.llenarComboTablaMovimientos().Split(',');
			return combo;
		}
	}
}
