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
    public partial class VentanaDeVenta : Form
    {
        Pantalla_Principal VPPV;
        public VentanaDeVenta()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Venta cancelada");
        }

        private void btn_VolverPKPP_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Datos añadidos exitosamente");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VPPV = new Pantalla_Principal();
            VPPV.Show();
            this.Hide();

        }
    }
}
