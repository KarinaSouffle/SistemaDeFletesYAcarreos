using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaFletesAcarreoB
{
    public partial class Pantalla_Principal : Form
    {
        PKilometro PPKilometro;
        VerFctura PVerFactura;
        VentanaDeVenta PVenta;
        ListaDeMateriales PLDM;
        VerChoferesYAutos VCYA;

        public Pantalla_Principal()
        {
            InitializeComponent();
        }

        private void btn_Materiales_Click(object sender, EventArgs e)
        {
            PLDM = new ListaDeMateriales();
            PLDM.Show();
            this.Hide();
        }

        private void btn_PrecioKilometro_Click(object sender, EventArgs e)
        {
            PPKilometro = new PKilometro();
            PPKilometro.Show();
            this.Hide();
        }

        private void btn_VerFacturas_Click(object sender, EventArgs e)
        {
            PVerFactura = new VerFctura();
            PVerFactura.Show();
            this.Hide();
        }

        private void btn_ChoferesAutos_Click(object sender, EventArgs e)
        {
            VCYA = new VerChoferesYAutos();
            VCYA.Show();
            this.Hide();
        }

        private void btn_Venta_Click(object sender, EventArgs e)
        {
            PVenta = new VentanaDeVenta();
            PVenta.Show();
            this.Hide();
        }
    }
}
