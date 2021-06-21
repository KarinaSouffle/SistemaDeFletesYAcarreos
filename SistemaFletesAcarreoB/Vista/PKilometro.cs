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
        }

        private void btn_VolverPKPP_Click(object sender, EventArgs e)
        {
            PPrincipal = new Pantalla_Principal();
            PPrincipal.Show();
            this.Hide();
        }

        private void btn_GuardarNPK_Click(object sender, EventArgs e)
        {
            int control = 0;
            Validar validar = new Validar();
            if (txt_NuevoPrecio.Text.ToString() == String.Empty)
            {
                MessageBox.Show("Hay campos vacios.", "Error", MessageBoxButtons.OK);
            }
            else
            {
                try
                {
                    float.Parse(txt_NuevoPrecio.Text.ToString());
                }
                catch (Exception)
                {
                    if (txt_NuevoPrecio.Text.ToString() == String.Empty )
                    {
                        MessageBox.Show("Hay campos vacios.", "Error", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Hay datos con el formato incorrecto.", "Error", MessageBoxButtons.OK);
                    }
                    control = 1;
                }
                if (control != 1)
                {
                    if (validar.ValidarNum(txt_NuevoPrecio.Text, "precio del kilometro") == true)
                    {
                        try
                        {
                            var nuevoKilometro = new KILOMETRO();
                            nuevoKilometro.Precio = (Math.Round(float.Parse(txt_NuevoPrecio.Text), 2)).ToString();
                            ControladorKilometro.CrearKilometro(nuevoKilometro);
                            lbl_SetPrecio.Text = txt_NuevoPrecio.Text;

                            int cantidaddatos = Int32.Parse(dgv_PrecioKilometro.Rows.Count.ToString());
                            this.kILOMETROTableAdapter5.Fill(this.sISTEMAFLETESACARREOSDataSet20.KILOMETRO);
                            int cantidadnuevoskilometros = Int32.Parse(dgv_PrecioKilometro.Rows.Count.ToString());
                            if (cantidadnuevoskilometros == (cantidaddatos + 1))
                            {
                                txt_NuevoPrecio.Text = " ";
                                MessageBox.Show("Actualizado");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Hubo un error: " + ex + " ", "Error", MessageBoxButtons.OK);
                        }
                    }
                    
                }
            }                                                                          
        }

        private void PKilometro_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sISTEMAFLETESACARREOSDataSet20.KILOMETRO' Puede moverla o quitarla según sea necesario.
            this.kILOMETROTableAdapter5.Fill(this.sISTEMAFLETESACARREOSDataSet20.KILOMETRO);
            int xd = Convert.ToInt32(this.dgv_PrecioKilometro.Rows.Count.ToString());
            if (xd >= 1)
            {
                lbl_SetPrecio.Text = dgv_PrecioKilometro.Rows[xd - 1].Cells[1].Value.ToString();
                Console.WriteLine(xd);
            }
            else
            {
                lbl_SetPrecio.Text = "----";
            }

        }

    }
}
