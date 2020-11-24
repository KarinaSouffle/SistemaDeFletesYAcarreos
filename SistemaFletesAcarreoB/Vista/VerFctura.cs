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
    public partial class VerFctura : Form
    {
        Pantalla_Principal PPrincipal;
        public VerFctura()
        {
            InitializeComponent();
            panel1.Location = new Point(((panel1.Width / 3)), (panel1.Width) / 8);
        }

        private void btn_VolverPPVF_Click(object sender, EventArgs e)
        {
            PPrincipal = new Pantalla_Principal();
            PPrincipal.Show();
            this.Hide();
        }

        private void btn_BuscarFac_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aun no hay facturas registradas.");
        }
    }
}
