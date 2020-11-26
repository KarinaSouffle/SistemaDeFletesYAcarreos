using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using SistemaFletesAcarreoB.Controlador;
using SistemaFletesAcarreoB.Modelo;

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
            var nuevoChofer = new CHOFER();
            nuevoChofer.lICENCIA_C = Convert.ToInt32(txt_Licencia.Text);
            nuevoChofer.N_Chofer = txt_Nombre.Text;
            nuevoChofer.ApellidoP_C = txt_APaterno.Text;
            nuevoChofer.ApellidoM_C = txt_AMaterno.Text;
            nuevoChofer.Sexo = txt_Sexo.Text;
            nuevoChofer.Edad = Convert.ToInt32(txt_Edad.Text);
            nuevoChofer.Telefono = txt_Telefono.Text;
            nuevoChofer.Correo = txt_Correo.Text;
            nuevoChofer.F_Nac = dt_FechaNac.Value;
            nuevoChofer.Chofer_Direccion = txt_Domicilio.Text;
            try
            {
                ModeloChofer.crearChofer(nuevoChofer);

                var respuesta = MessageBox.Show(
                    "Material Guardado Correctamente, ¿Desea agregar otro?",
                    "Mensaje del sistema",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {
                    txt_Licencia.Text = string.Empty;
                    txt_Nombre.Text = string.Empty;
                    txt_APaterno.Text = string.Empty;
                    txt_AMaterno.Text = string.Empty;
                    txt_Sexo.Text = string.Empty;
                    txt_Edad.Text = string.Empty;
                    txt_Telefono.Text = string.Empty;
                    txt_Correo.Text = string.Empty;
                    txt_Domicilio.Text = string.Empty;
                    dt_FechaNac.Text = string.Empty;
                }
                else
                {
                    Dispose();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message); ;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
