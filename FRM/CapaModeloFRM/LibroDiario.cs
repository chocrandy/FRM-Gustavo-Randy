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
		public void crearLibroDiario(string empresa ,string fecha) {
			string query = "INSERT INTO libro_diario_encabezados (empresa,fecha)" +
			"VALUES ("+empresa+", "+fecha+")";
			Diario.ejecutarQuery(query);
		}

		public OdbcDataAdapter llenarLibroDiario()
		{
			OdbcDataAdapter dataTable = Diario.LlenarTablaDiarioEncabezado();
			return dataTable;
		}
	}
}
