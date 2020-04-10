using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaControladorFRM
{
	public class sql_LibroDiario
	{
		conexionFRM conectar = new conexionFRM();
		public OdbcDataAdapter LlenarTablaDiarioEncabezado()
		{
			string sql = "SELECT * FROM libro_diario_encabezados";
			OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, conectar.conexion("ERP"));
			return dataTable;
		}
		public OdbcDataAdapter LlenarTablaPartidas(string id)
		{
			string sql = "SELECT P.concepto as concepto,D.fecha as Fecha, D.cuenta_contable AS cuenta , D.debe as Debe, D.haber as haber " +
				"FROM partidas P, libro_diario_detalles D WHERE P.id_libro_diario = D.id_libro_diario  AND D.id_libro_diario = "+id+ " ORDER BY P.concepto ";
			OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, conectar.conexion("ERP"));
			return dataTable;
		}
		public string[] llenarCombo()
		{
			string[] Combo = new string[30];
			int i = 0;
			OdbcCommand command = new OdbcCommand("SELECT tipo_poliza FROM poliza_encabezados WHERE estado=1 GROUP BY tipo_poliza ;", conectar.conexion("ERP"));
			OdbcDataReader reader = command.ExecuteReader();
			while (reader.Read())
			{
				Combo[i] = reader.GetValue(0).ToString();
				i++;
			}
			return Combo;
		}

		public string llenarComboTablaMovimientos()
		{
			string Combo = "";
			OdbcCommand command = new OdbcCommand("SELECT nombre FROM cuentas ;", conectar.conexion("ERP"));
			OdbcDataReader reader = command.ExecuteReader();
			while (reader.Read())
			{
				Combo += reader.GetValue(0).ToString() + ",";
			}
			Combo.TrimEnd(',');
			return Combo;
		}
		public string ObtenerIdLibro()
		{
			string id = "";
			OdbcCommand command = new OdbcCommand("SELECT MAX(id_libro_diario) FROM libro_diario_encabezados;", conectar.conexion("ERP"));
			OdbcDataReader reader = command.ExecuteReader();
			if (reader.Read())
			{
				id= reader.GetValue(0).ToString();
				int n = Convert.ToInt32(id)+1;
				id = n.ToString();

			}
			if (id=="" || id == null)
			{
				id = "1";
			}
			
			return id;
		}

		public void ejecutarQuery(string query)// ejecuta un query en la BD
		{
			try
			{
				OdbcCommand consulta = new OdbcCommand(query, conectar.conexion("ERP"));
				consulta.ExecuteNonQuery();
			}
			catch (OdbcException ex) {
				Console.WriteLine(ex.Errors.ToString());
				Console.WriteLine("---------------------------------------");
				Console.WriteLine(query);
			}

		}
	}
}
