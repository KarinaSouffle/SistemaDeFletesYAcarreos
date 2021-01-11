using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaFletesAcarreoB.Controlador;
using SistemaFletesAcarreoB.Modelo;

namespace SistemaFletesAcarreoB
{
    public partial class PKilometro : Form
    {
        Pantalla_Principal PPrincipal;
        public PKilometro()
        {
            InitializeComponent();
            panel1.Location = new Point(((panel1.Width / 2)), (panel1.Width) / 8);
        }

        private void btn_VolverPKPP_Click(object sender, EventArgs e)
        {
            PPrincipal = new Pantalla_Principal();
            PPrincipal.Show();
            this.Hide();
        }

        private void btn_GuardarNPK_Click(object sender, EventArgs e)
        {
            try
            {
                var nuevoKilometro = new KILOMETRO();
                nuevoKilometro.Precio = Convert.ToInt32(txt_NuevoPrecio.Text);
                ControladorKilometro.CrearKilometro(nuevoKilometro);
                lbl_SetPrecio.Text = txt_NuevoPrecio.Text;

                txt_NuevoPrecio.Text = " ";
                MessageBox.Show("Actualizado");
            }
            catch (Exception)
            {
                MessageBox.Show("Revisa los datos introducidos", "Error", MessageBoxButtons.OK);
            }
                                                                                                         
        }

        private void PKilometro_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sISTEMAFLETESACARREOSDataSet7.KILOMETRO' Puede moverla o quitarla según sea necesario.
            this.kILOMETROTableAdapter.Fill(this.sISTEMAFLETESACARREOSDataSet7.KILOMETRO);

        }

        private void panel1_MouseHover(object sender, EventArgs e)
        {
            this.kILOMETROTableAdapter.Fill(this.sISTEMAFLETESACARREOSDataSet7.KILOMETRO);
            int xd = Convert.ToInt32(this.dgv_PrecioKilometro.Rows.Count.ToString());
            if (xd > 1)
            {
                lbl_SetPrecio.Text = dgv_PrecioKilometro.Rows[xd - 2].Cells[1].Value.ToString();
                Console.WriteLine(xd);
            }
            else
            {
                lbl_SetPrecio.Text = "----";
            }
        }
    }
}
