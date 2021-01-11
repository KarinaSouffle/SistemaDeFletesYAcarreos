using SistemaFletesAcarreoB.Modelo;
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
    public partial class AgregarAuto : Form
    {
        ListaDeAutos PLDA;
        public AgregarAuto()
        {
            InitializeComponent();
        }

        private void btn_VolverPKPP_Click(object sender, EventArgs e)
        {
            try
            {
                var nuevoAuto = new AUTOS();
                nuevoAuto.Num_Placas = txt_NumPlaca.Text;
                nuevoAuto.Marca = txt_Marca.Text;
                nuevoAuto.Kilometraje = Convert.ToInt32(txt_Kilometraje.Text);
                nuevoAuto.Cap_A = Convert.ToInt32(txt_Capacidad.Text);
                ControladorAuto.CrearAuto(nuevoAuto);

                var respuesta = MessageBox.Show(
                    "Auto guardado correctamente, ¿Desea agregar otro?",
                    "Mensaje del sistema",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {
                    txt_NumPlaca.Text = string.Empty;
                    txt_Marca.Text = string.Empty;
                    txt_Kilometraje.Text = string.Empty;
                    txt_Capacidad.Text = string.Empty;
                }
                else
                {
                    Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Revisa los datos introducidos", "Error", MessageBoxButtons.OK);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
