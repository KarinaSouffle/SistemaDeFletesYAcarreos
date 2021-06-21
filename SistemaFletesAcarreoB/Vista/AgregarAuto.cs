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
            int Cont_Filas = Int32.Parse(dgv_Autos.Rows.Count.ToString());
            string seleccionada = "";
            for (int i = 0; i <= Cont_Filas-1; i++)
            {
                string compara = dgv_Autos.Rows[i].Cells[1].Value.ToString();
                if (compara == txt_NumPlaca.Text.ToString())
                {
                    seleccionada = compara;
                }
            }
            if (seleccionada == string.Empty)
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
                    this.aUTOSTableAdapter2.Fill(this.sISTEMAFLETESACARREOSDataSet20.AUTOS);
                    int cantidadnuevosautos = Int32.Parse(dgv_Autos.Rows.Count.ToString());
                    if (cantidadnuevosautos == (cantidaddatos + 1))
                    {
                        var respuesta = MessageBox.Show(
                        "Auto guardado correctamente",
                        "Mensaje del sistema",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                        txt_NumPlaca.Text = string.Empty;
                        txt_Marca.Text = string.Empty;
                        txt_Kilometraje.Text = string.Empty;
                        txt_Capacidad.Text = string.Empty;
                        this.aUTOSTableAdapter2.Fill(this.sISTEMAFLETESACARREOSDataSet20.AUTOS);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hubo un error: " + ex + " ", "Error", MessageBoxButtons.OK);
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
            // TODO: esta línea de código carga datos en la tabla 'sISTEMAFLETESACARREOSDataSet20.AUTOS' Puede moverla o quitarla según sea necesario.
            this.aUTOSTableAdapter2.Fill(this.sISTEMAFLETESACARREOSDataSet20.AUTOS);
        }

        private void txt_NumPlaca_Validating(object sender, CancelEventArgs e)
        {
            Validar validar = new Validar();
            if (validar.FormatoPlaca(txt_NumPlaca.Text) == true)
            {
                lbl_ValPlaca.Visible = false;
            }
            else
            {
                lbl_ValPlaca.Visible = true;
                txt_NumPlaca.Focus();
            }
        }

        private void txt_Marca_Validating(object sender, CancelEventArgs e)
        {
            Validar validar = new Validar();
            if (validar.ValidarNombre(txt_Marca.Text, "marca") == true)
            {
                lbl_ValMarca.Visible = false;
            }
            else
            {
                lbl_ValMarca.Visible = true;
                txt_Marca.Focus();
            }
        }

        private void txt_Kilometraje_Validating(object sender, CancelEventArgs e)
        {
            Validar validar = new Validar();
            if (validar.ValidarNum(txt_Kilometraje.Text, "kilometraje") == true)
            {
                lbl_ValKilo.Visible = false;
            }
            else
            {
                lbl_ValKilo.Visible = true;
                txt_Kilometraje.Focus();
            }
        }

        private void txt_Capacidad_Validating(object sender, CancelEventArgs e)
        {
            Validar validar = new Validar();
            if (validar.ValidarNum(txt_Capacidad.Text, "capacidad del auto") == true)
            {
                lbl_ValCap.Visible = false;
            }
            else
            {
                lbl_ValCap.Visible = true;
                txt_Capacidad.Focus();
            }
        }
    }
}
