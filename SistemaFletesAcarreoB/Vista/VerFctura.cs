using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaFletesAcarreoB.Controlador;
using SistemaFletesAcarreoB.Modelo;
using SistemaFletesAcarreoB.Vista;
using Microsoft.Reporting;
using Microsoft.ReportingServices;
using System.Data.SqlClient;
using System.Diagnostics;

namespace SistemaFletesAcarreoB
{
    public partial class VerFctura : Form
    {
        int i = 0;
        Pantalla_Principal PPrincipal;
        public VerFctura()
        {
            InitializeComponent();

        }

        private void btn_VolverPPVF_Click(object sender, EventArgs e)
        {
            PPrincipal = new Pantalla_Principal();
            PPrincipal.Show();
            this.Hide();
        }

        private void btn_BuscarFac_Click(object sender, EventArgs e)
        {
            string Busqueda = dtp_FechaFactura.Value.ToString("dd/MM/yyyy");
            var buscarFactura = ModeloFactura.buscarFacturaPorCriterio(Busqueda);
            dgv_Factura.DataSource = buscarFactura;
        }

        private void VerFctura_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sISTEMAFLETESACARREOSDataSet.FACTURA' Puede moverla o quitarla según sea necesario.
            this.fACTURATableAdapter.Fill(this.sISTEMAFLETESACARREOSDataSet.FACTURA);
        }

        private void dgv_Factura_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int FilaIndice = Int32.Parse(dgv_Factura.CurrentRow.Index.ToString());
            if (dgv_Factura.Rows[FilaIndice].Cells[0].Selected == true)
            {
                dgv_Factura.Rows[FilaIndice].Cells[0].ReadOnly = true;
            }
        }
        private void btn_Imprimir_Click(object sender, EventArgs e)
        {
            int FilaIndice = Int32.Parse(dgv_Factura.CurrentRow.Index.ToString());
            string path = dgv_Factura.Rows[FilaIndice].Cells[1].Value.ToString();
            try
            {
                Process.Start("C:/SistemaAcarreos/Facturas/" + path + ".pdf");
            }
            catch (Exception)
            {
                MessageBox.Show("La factura que esta intentando imprimir ha sido eliminada de la carpeta o otro programa la tiene en uso.");
            }
            
        }
    }
}
