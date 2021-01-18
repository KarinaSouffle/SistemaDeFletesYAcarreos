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

namespace SistemaFletesAcarreoB
{
    public partial class VerFctura : Form
    {
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
            string  Busqueda = dtp_FechaFactura.Value.ToString("dd/MM/yyyy");
            string xd = dtp_FechaFactura.Value.ToString("HH:mm");
            var buscarFactura = ControladorFactura.BuscarFacturaPorCriterio(Busqueda);
            Console.WriteLine(Busqueda);
            Console.WriteLine(xd);

            dgv_Factura.DataSource = buscarFactura;

        }

        private void VerFctura_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sISTEMAFLETESACARREOSDataSet20.FACTURA' Puede moverla o quitarla según sea necesario.
            this.fACTURATableAdapter5.Fill(this.sISTEMAFLETESACARREOSDataSet20.FACTURA);

        }

        private void dgv_Factura_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int FilaIndice = Int32.Parse(dgv_Factura.CurrentRow.Index.ToString());
            if (dgv_Factura.Rows[FilaIndice].Cells[0].Selected == true)
            {
                dgv_Factura.Rows[FilaIndice].Cells[0].ReadOnly = true;
            }
        }
    }
}
