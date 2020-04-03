using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVistaFRM
{
    public partial class MDI_FRM : Form
    {
        private actualizacion_de_polizas frm_actualizacion_de_polizas;
        private balance_general frm_balance_General;
        private conciliacion_bancaria frm_conciliacion_bancaria;
        private consultar_conciliacion frm_consultar_conciliacion;
        private movimientos_bancarios frm_movimientos_bancarios;
        private tipo_de_cambio frm_tipo_de_cambio;
        public MDI_FRM()
        {
            InitializeComponent();
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }

        //==========Funciones para evitar que se habrá 2 veces la misma ventana==========
        private void frm_balance_General_FormClosed(Object sender, FormClosedEventArgs e)
        { frm_balance_General = null; }
        private void frm_actualizacion_de_polizas_FormClosed(Object sender, FormClosedEventArgs e)
        { frm_actualizacion_de_polizas = null; }
        private void frm_conciliacion_bancaria_FormClosed(Object sender, FormClosedEventArgs e)
        { frm_conciliacion_bancaria = null; }
        private void frm_consultar_conciliacion_FormClosed(Object sender, FormClosedEventArgs e)
        { frm_consultar_conciliacion = null; }
        private void frm_movimientos_bancarios_FormClosed(Object sender, FormClosedEventArgs e)
        { frm_movimientos_bancarios = null; }
        private void frm_tipo_de_cambio_FormClosed(Object sender, FormClosedEventArgs e)
        { frm_tipo_de_cambio = null; }
        //====================Funciones de declaración de Eventos====================

        private void ConciliaciónBancariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frm_conciliacion_bancaria == null)
            {
                frm_conciliacion_bancaria = new conciliacion_bancaria();
                frm_conciliacion_bancaria.MdiParent = this;
                frm_conciliacion_bancaria.FormClosed += new FormClosedEventHandler(frm_conciliacion_bancaria_FormClosed);
                frm_conciliacion_bancaria.Show();
            }
            else
            {
                frm_conciliacion_bancaria.Activate();
            }
        }

        private void BalanceGeneralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frm_balance_General == null)
            {
                frm_balance_General = new balance_general();
                frm_balance_General.MdiParent = this;
                frm_balance_General.FormClosed += new FormClosedEventHandler(frm_balance_General_FormClosed);
                frm_balance_General.Show();
            }
            else
            {
                frm_balance_General.Activate();
            }
        }

        private void TipoDeCambioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frm_tipo_de_cambio == null)
            {
                frm_tipo_de_cambio = new tipo_de_cambio();
                frm_tipo_de_cambio.MdiParent = this;
                frm_tipo_de_cambio.FormClosed += new FormClosedEventHandler(frm_tipo_de_cambio_FormClosed);
                frm_tipo_de_cambio.Show();
            }
            else
            {
                frm_tipo_de_cambio.Activate();
            }
        }

        private void ActualizaciónDePólizasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frm_actualizacion_de_polizas == null)
            {
                frm_actualizacion_de_polizas = new actualizacion_de_polizas();
                frm_actualizacion_de_polizas.MdiParent = this;
                frm_actualizacion_de_polizas.FormClosed += new FormClosedEventHandler(frm_actualizacion_de_polizas_FormClosed);
                frm_actualizacion_de_polizas.Show();
            }
            else
            {
                frm_actualizacion_de_polizas.Activate();
            }
        }

        private void ConsultarConciliaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frm_consultar_conciliacion == null)
            {
                frm_consultar_conciliacion = new consultar_conciliacion();
                frm_consultar_conciliacion.MdiParent = this;
                frm_consultar_conciliacion.FormClosed += new FormClosedEventHandler(frm_consultar_conciliacion_FormClosed);
                frm_consultar_conciliacion.Show();
            }
            else
            {
                frm_consultar_conciliacion.Activate();
            }
        }

        private void MovimientosBancariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frm_movimientos_bancarios == null)
            {
                frm_movimientos_bancarios = new movimientos_bancarios();
                frm_movimientos_bancarios.MdiParent = this;
                frm_movimientos_bancarios.FormClosed += new FormClosedEventHandler(frm_movimientos_bancarios_FormClosed);
                frm_movimientos_bancarios.Show();
            }
            else
            {
                frm_movimientos_bancarios.Activate();
            }
        }
    }
}
