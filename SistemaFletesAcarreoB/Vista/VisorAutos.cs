using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaFletesAcarreoB.Vista
{
    public partial class VisorAutos : Form
    {
        Form fh;
        int control = 0;
        public VisorAutos()
        {
            InitializeComponent();
        }
        private void AbrirFormularios(object formhijo)
        {
            if (this.pnl_Contenedor2.Controls.Count > 0)
            {
                this.pnl_Contenedor2.Controls.RemoveAt(0);
            }
            fh = formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.pnl_Contenedor2.Controls.Add(fh);
            this.pnl_Contenedor2.Tag = fh;
            fh.Show();

        }

        private void btn_VolverPKPP_Click(object sender, EventArgs e)
        {
            AbrirFormularios(new AgregarAuto());
            btn_Regresar.Visible = true;
            btn_VolverPKPP.Visible = false;
        }

        private void btn_Regresar_Click(object sender, EventArgs e)
        {
            AbrirFormularios(new ListaDeAutos());
            btn_Regresar.Visible = false;
            if (control == 1)
            {
                btn_VolverPKPP.Visible = true;
            }
        }

        private void VisorAutos_Load(object sender, EventArgs e)
        {
            AbrirFormularios(new ListaDeAutos());

            if (Login.nivel == "1")
            {
                btn_VolverPKPP.Visible = true;
                control = 1;
            }
        }
    }
}
