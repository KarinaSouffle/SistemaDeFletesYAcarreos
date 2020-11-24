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
    public partial class AgregarAuto : Form
    {
        ListaDeAutos PLDA;
        public AgregarAuto()
        {
            InitializeComponent();
        }

        private void btn_VolverPKPP_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Añadido");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PLDA = new ListaDeAutos();
            PLDA.Show();
            this.Hide();
        }
    }
}
