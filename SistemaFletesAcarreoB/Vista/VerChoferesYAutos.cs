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
    public partial class VerChoferesYAutos : Form
    {
        Pantalla_Principal PPrincipal;
        ListaDeChoferes LDC;
        ListaDeAutos LDA;

        public VerChoferesYAutos()
        {
            InitializeComponent();
            panel1.Location = new Point(((panel1.Width / 2)), (panel1.Width) / 6);
        }

        private void btn_volverppvca_Click(object sender, EventArgs e)
        {
            PPrincipal = new Pantalla_Principal();
            PPrincipal.Show();
            this.Hide();
        }

        private void btn_VerChofer_Click(object sender, EventArgs e)
        {
            LDC = new ListaDeChoferes();
            LDC.Show();
            this.Hide();
        }

        private void btn_VerAutos_Click(object sender, EventArgs e)
        {
            LDA = new ListaDeAutos();
            LDA.Show();
            this.Hide();
        }
    }
}
