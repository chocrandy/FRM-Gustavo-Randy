﻿using System;
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

		public void crearPartida(string id, string libro, string concepto, string fecha)
		{
			string query = "INSERT INTO partidas (id_partida, id_libro_diario, concepto, fecha) " +
			"VALUES (" + id + "," + libro + ", '" + concepto + "', '"+fecha+"')";
			Diario.ejecutarQuery(query);
		}

		public void crearDetalleLibroDiario(string mov, string libro, string partida, string cuenta, string debe, string haber)
		{
			string query = "INSERT INTO libro_diario_detalles (numero_movimiento, id_libro_diario, id_partida, cuenta_contable,  debe, haber) " +
			"VALUES (" + mov+ ", "+libro+", "+partida+",'" + cuenta + "' , "+debe+", "+haber+")";
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

		string CrearQueryPartida(string idLibro)
		{
			string query = "SELECT * FROM libro_diario_encabezados WHERE id_libro_diario=" + idLibro + "";


			int n = 0;
			string[] partidas = Diario.ObtenerPartidasLibro(idLibro).Split(',');
			if (partidas != null)
			{
				
				foreach (var partida in partidas)
				{
					
					if (partida != "" && partida != " " && partida != null)
					{
						query = "";
						if (n == partidas.Length - 2)
						{
							query += "SELECT  P.concepto as CONCEPTO, P.fecha as FECHA , '' as DEBE , '' as HABER " +
									"FROM partidas P WHERE P.id_partida = " + partida + " AND P.id_libro_diario = " + idLibro + " AND P.estado = 1 " +
									"UNION " +
									"SELECT '' as a, D.cuenta_contable AS cuenta , D.debe as Debe, D.haber as haber " +
									"FROM libro_diario_detalles D WHERe D.id_partida = " + partida + " AND D.id_libro_diario =" + idLibro + " ;";
						}
						else
						{
							query += "SELECT  P.concepto as CONCEPTO, P.fecha as FECHA , '' as DEBE , '' as HABER " +
									"FROM partidas P WHERE P.id_partida = " + partida + " AND P.id_libro_diario = " + idLibro + " AND P.estado = 1 " +
									"UNION " +
									"SELECT '' as a, D.cuenta_contable AS cuenta , D.debe as Debe, D.haber as haber " +
									"FROM libro_diario_detalles D WHERe D.id_partida = " + partida + " AND D.id_libro_diario =" + idLibro + " UNION ";
						}

					}
					n++;
				}
			}
			else
			{

				query = "SELECT * FROM libro_diario_encabezados WHERE id_libro_diario="+idLibro+"";
			}
			
			return query;
		}

		public OdbcDataAdapter llenarPartidas(string idLibro)
		{
			OdbcDataAdapter dataTable = Diario.LlenarTablaPartidas(CrearQueryPartida(idLibro));
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

		public void DeletePartida(string concepto, string libro)
		{
			string query = "UPDATE partidas SET estado = 0 WHERE concepto='"+concepto+"' AND id_libro_diario='"+libro+"'";
			Diario.ejecutarQuery(query);
		}


	}
}
