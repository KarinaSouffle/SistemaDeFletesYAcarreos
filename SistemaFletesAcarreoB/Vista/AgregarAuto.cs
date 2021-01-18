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
            int xd = Int32.Parse(dgv_Autos.Rows.Count.ToString());
            string seleccionada = "";
            for (int i = 0; i <= xd-1; i++)
            {
                string compara = dgv_Autos.Rows[i].Cells[1].Value.ToString();
                if (compara == txt_NumPlaca.Text.ToString())
                {
                    seleccionada = compara;
                }
            }
            if (seleccionada == string.Empty)
            {
                Validar validar = new Validar();

                if ((validar.FormatoPlaca(txt_NumPlaca.Text) && validar.ValidarNombre(txt_Marca.Text) && validar.ValidarNum(txt_Kilometraje.Text) && validar.ValidarNum(txt_Capacidad.Text)) == true)
                {
                    try
                    {
                        var nuevoAuto = new AUTOS();
                        nuevoAuto.Num_Placas = txt_NumPlaca.Text;
                        nuevoAuto.Marca = txt_Marca.Text;
                        nuevoAuto.Kilometraje = txt_Kilometraje.Text;
                        nuevoAuto.Cap_A = txt_Capacidad.Text;
                        nuevoAuto.Disponible = "1";
                        ControladorAuto.CrearAuto(nuevoAuto);
                        int cantidaddatos = Int32.Parse(dgv_Autos.Rows.Count.ToString());
                        this.aUTOSTableAdapter1.Fill(this.sISTEMAFLETESACARREOSDataSet16.AUTOS);
                        int cantidadnuevosautos = Int32.Parse(dgv_Autos.Rows.Count.ToString());
                        if (cantidadnuevosautos == (cantidaddatos + 1))
                        {
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
                                this.aUTOSTableAdapter1.Fill(this.sISTEMAFLETESACARREOSDataSet16.AUTOS);
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
                MessageBox.Show("Ya existe un auto registrado con el mismo numero de placas.", "Error", MessageBoxButtons.OK);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void AgregarAuto_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sISTEMAFLETESACARREOSDataSet16.AUTOS' Puede moverla o quitarla según sea necesario.
            this.aUTOSTableAdapter1.Fill(this.sISTEMAFLETESACARREOSDataSet16.AUTOS);
        }
    }
}
