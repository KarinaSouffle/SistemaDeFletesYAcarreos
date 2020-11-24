using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaFletesAcarreoB
{
    public partial class ListaDeChoferes : Form
    {
        VerChoferesYAutos VCYA;
        AgregarChofer PAC;

        public ListaDeChoferes()
        {
            InitializeComponent();
        }

        private void btn_VolverPKPP_Click(object sender, EventArgs e)
        {
            PAC = new AgregarChofer();
            PAC.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VCYA = new VerChoferesYAutos();
            VCYA.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aun no hay Choferes registrados.");

        }
    }
}
