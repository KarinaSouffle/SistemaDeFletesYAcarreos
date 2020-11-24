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
    public partial class AgregarChofer : Form
    {
        ListaDeChoferes PLDC;

        public AgregarChofer()
        {
            InitializeComponent();
        }

        private void btn_VolverPKPP_Click(object sender, EventArgs e)
        {
        MessageBox.Show("Datos añadidos exitosamente");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PLDC = new ListaDeChoferes();
            PLDC.Show();
            this.Hide();
        }
    }
}
