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
            int xd = Int32.Parse(dgv_Materiales.Rows.Count.ToString());
            string seleccionada = "";
            for (int i = 0; i <= xd-1; i++)
            {
                string compara = dgv_Materiales.Rows[i].Cells[1].Value.ToString();
                if (compara == txt_NombreMat.Text.ToString())
                {
                    seleccionada = compara;
                }
            }
            if (seleccionada == string.Empty)
            {
                Validar validar = new Validar();
                if (validar.ValidarNombre(txt_NombreMat.Text) == true && validar.ValidarNum(txt_Precio.Text))
                {
                    try
                    {
                        var nuevoMaterial = new MATERIALES();
                        nuevoMaterial.Nombre_M = txt_NombreMat.Text;
                        nuevoMaterial.Precio = txt_Precio.Text;
                        ControladorMateriales.CrearMaterial(nuevoMaterial);
                        int cantidaddatos = Int32.Parse(dgv_Materiales.Rows.Count.ToString());
                        this.mATERIALESTableAdapter.Fill(this.sISTEMAFLETESACARREOSDataSet16.MATERIALES);
                        int cantidadnuevosmateriales = Int32.Parse(dgv_Materiales.Rows.Count.ToString());
                        if (cantidadnuevosmateriales == (cantidaddatos + 1))
                        {
                            var respuesta = MessageBox.Show(
                            "Material Guardado Correctamente, ¿Desea agregar otro?",
                            "Mensaje del sistema",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question);
                            if (respuesta == DialogResult.Yes)
                            {
                                txt_NombreMat.Text = string.Empty;
                                txt_Precio.Text = string.Empty;
                                this.mATERIALESTableAdapter.Fill(this.sISTEMAFLETESACARREOSDataSet16.MATERIALES);
                            }
                            else
                            {
                                Dispose();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hubo un error: " + ex + " ", "Error", MessageBoxButtons.OK);
                    }
                }

            }
            else
            {
                MessageBox.Show("Ya existe un material registrado con el mismo nombre.", "Error", MessageBoxButtons.OK);
            }
        }

        private void AgregarMaterial_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sISTEMAFLETESACARREOSDataSet16.MATERIALES' Puede moverla o quitarla según sea necesario.
            this.mATERIALESTableAdapter.Fill(this.sISTEMAFLETESACARREOSDataSet16.MATERIALES);

        }
    }
}
