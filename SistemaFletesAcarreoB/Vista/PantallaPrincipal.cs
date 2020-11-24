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
        Login PLogin;

        public Pantalla_Principal()
        {
            InitializeComponent();

            panel1.Location = new Point((300), (panel1.Height) / 3);
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

        private void btn_CerrarSesion_Click(object sender, EventArgs e)
        {
            PLogin = new Login();
            PLogin.Show();
            this.Hide();
        }
    }
}
