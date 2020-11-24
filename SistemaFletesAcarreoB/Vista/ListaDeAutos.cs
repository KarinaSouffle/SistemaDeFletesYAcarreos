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
    


    public partial class ListaDeAutos : Form
    {
        VerChoferesYAutos VCYAA;
        AgregarAuto AA;
        
        public ListaDeAutos()
        {
            InitializeComponent();
        }

        private void btn_VolverPKPP_Click(object sender, EventArgs e)
        {
            AA = new AgregarAuto();
            AA.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VCYAA = new VerChoferesYAutos();
            VCYAA.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                       
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aun no hay Autos registrados.");
        }
    }
}
