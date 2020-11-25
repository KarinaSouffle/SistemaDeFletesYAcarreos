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
    public partial class AgregarMaterial : Form
    {
        ListaDeMateriales PLDM;

        public AgregarMaterial()
        {
            InitializeComponent();
        }

        private void btn_VolverPKPP_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Añadido exitosamente");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_Añadir_Click(object sender, EventArgs e)
        {
            var nuevoMaterial = new MATERIALES();
            nuevoMaterial.Codigo = Convert.ToInt32(txt_IDMaterial.Text);
            nuevoMaterial.Nombre_M = txt_NombreMat.Text;
            nuevoMaterial.Precio = Convert.ToInt32(txt_Precio.Text);
            try
            {
                ModeloMateriales.crearMaterial(nuevoMaterial);

                var respuesta = MessageBox.Show(
                    "Material Guardado Correctamente, ¿Desea agregar otro?",
                    "Mensaje del sistema",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {
                    txt_IDMaterial.Text = string.Empty;
                    txt_NombreMat.Text = string.Empty;
                    txt_Precio.Text = string.Empty;
                }
                else
                {
                    Dispose();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
