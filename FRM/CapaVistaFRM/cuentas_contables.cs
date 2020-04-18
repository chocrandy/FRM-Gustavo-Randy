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

namespace CapaVistaFRM
{
    public partial class cuentas_contables : Form
    {
		string usuario = "";
		CuentasContables mod = new CuentasContables();
        public cuentas_contables( string user )
        {
			usuario = user;
            InitializeComponent();
			llenarCuentas();
			llenarCombosTipos();
        }

		void llenarCuentas() {
			OdbcDataAdapter dt = mod.llenarCuentas();
			DataTable table = new DataTable();
			dt.Fill(table);
			Dtgv_Cuentas.Rows.Clear();
			foreach (DataRow row in table.Rows)
			{
				Dtgv_Cuentas.Rows.Add(row[0], row[1]);
			}
			
		}

		void llenarCombosTipos() {
			Cmb_Tipo.Items.AddRange(mod.ObtenerTIposCuentasContables());
			Cmb_filtro.Items.AddRange(mod.ObtenerTIposCuentasContables());
		}

		private void Cuentas_contables_Load(object sender, EventArgs e)
		{

		}

		private void Cmb_Tipo_SelectedIndexChanged(object sender, EventArgs e)
		{

			if (Cmb_Tipo.Text!="" && Cmb_Tipo.Text != " " && Cmb_Tipo.Text != null)
			{
				Txt_Id.Enabled = false;
				string idTipo = mod.ObtenerNextIdCuenta(mod.ObtenerIdTIpoCuenta(Cmb_Tipo.Text.ToString()));
				Txt_Id.Text = mod.ObtenerIdTIpoCuenta(Cmb_Tipo.Text.ToString());
				Txt_Id.Text += "." + (Convert.ToInt32(idTipo) + 1).ToString();
			}
			
		}

		private void Btn_plusLevel_Click(object sender, EventArgs e)
		{
			Txt_Id.Enabled = true;
		}

		private void Btn_guardar_Click(object sender, EventArgs e)
		{
			string idTipo = mod.ObtenerIdTIpoCuenta(Cmb_Tipo.Text.ToString());
			string cod = (Convert.ToInt32(mod.ObtenerNextIdCuenta(mod.ObtenerIdTIpoCuenta(Cmb_Tipo.Text.ToString())))+1).ToString();
			mod.GuardarCuenta(Txt_Id.Text, idTipo,cod,Txt_nombre.Text,Txt_desc.Text);
			llenarCuentas();
			Txt_Id.Text = "";
			Txt_desc.Text = "";
			Txt_nombre.Text = "";
			Txt_Id.Enabled = false;
		}
	}
}
