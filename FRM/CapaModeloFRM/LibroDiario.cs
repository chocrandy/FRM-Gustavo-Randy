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

		public void crearPartida(string id, string libro, string concepto)
		{
			string query = "INSERT INTO partidas (id_partida, id_libro_diario, concepto) " +
			"VALUES (" + id + "," + libro + ", '" + concepto + "')";
			Diario.ejecutarQuery(query);
		}

		public void crearDetalleLibroDiario(string mov, string libro, string partida, string cuenta, string fecha, string debe, string haber)
		{
			string query = "INSERT INTO libro_diario_detalles (numero_movimiento, id_libro_diario, id_partida, cuenta_contable, fecha, debe, haber) " +
			"VALUES (" + mov+ ", "+libro+", "+partida+",'" + cuenta + "' ,'" + fecha + "', "+debe+", "+haber+")";
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

		public string IdPartida(string no)
		{
			return Diario.ObtenerIdPartida(no);
		}

		public string[] comboTabla()
		{
			string[] combo = Diario.llenarComboTablaMovimientos().Split(',');
			return combo;
		}
	}
}
