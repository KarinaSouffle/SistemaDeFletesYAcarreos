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
    public partial class PKilometro : Form
    {
        Pantalla_Principal PPrincipal;
        public PKilometro()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_VolverPKPP_Click(object sender, EventArgs e)
        {
            PPrincipal = new Pantalla_Principal();
            PPrincipal.Show();
            this.Hide();
        }

        private void btn_GuardarNPK_Click(object sender, EventArgs e)
        {
            txt_NuevoPrecio.Text = " ";
            MessageBox.Show("Actualizado");
        }
    }
}
