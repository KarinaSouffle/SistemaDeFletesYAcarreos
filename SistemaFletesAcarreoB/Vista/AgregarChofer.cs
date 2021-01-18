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
            int xd = Int32.Parse(dgv_Chofer.Rows.Count.ToString());
            string seleccionada = "";
            Validar val = new Validar();
            for (int i = 0; i <= xd-1; i++)
            {
                string compara = dgv_Chofer.Rows[i].Cells[1].Value.ToString();
                if (compara == txt_Licencia.Text.ToString())
                {
                    seleccionada = compara;
                }
            }
            Validar validarChofer = new Validar();
            int dia = dt_FechaNac.Value.Day;
            int mes = dt_FechaNac.Value.Month;
            int anio = dt_FechaNac.Value.Year;
            DateTime fecha = new DateTime(anio, mes, dia);
            int edad = DateTime.Now.Subtract(fecha).Days / 365;
            string apellidos = txt_AMaterno.Text + txt_APaterno.Text;
            string direccion = txt_Domicilio.Text;
            if (seleccionada == string.Empty)
            {
                if (edad >= 18 && edad <= 65)//aca va edad
                {
                    if (validarChofer.ValidarLicencia(txt_Licencia.Text) == true && validarChofer.ValidarNombre(txt_Nombre.Text) == true
                        && validarChofer.ValidarNombre(apellidos) == true && validarChofer.ValidarNumeroTel(txt_Telefono.Text) == true
                        && validarChofer.ValidarCorreo(txt_Correo.Text) == true)
                    {
                        try
                        {
                            var nuevoChofer = new CHOFER();
                            nuevoChofer.lICENCIA_C = txt_Licencia.Text;
                            nuevoChofer.N_Chofer = txt_Nombre.Text;
                            nuevoChofer.ApellidoP_C = txt_APaterno.Text;
                            nuevoChofer.ApellidoM_C = txt_AMaterno.Text;
                            nuevoChofer.Sexo = txt_Sexo.Text;
                            nuevoChofer.Edad = edad.ToString();
                            nuevoChofer.Telefono = txt_Telefono.Text;
                            nuevoChofer.Correo = txt_Correo.Text;
                            nuevoChofer.F_Nac = dt_FechaNac.Value;
                            nuevoChofer.Direccion = txt_Domicilio.Text;
                            nuevoChofer.Disponible = "1";
                            ControladorChofer.CrearChofer(nuevoChofer);
                            int cantidaddatos = Int32.Parse(dgv_Chofer.Rows.Count.ToString());
                            this.cHOFERTableAdapter.Fill(this.sISTEMAFLETESACARREOSDataSet16.CHOFER);
                            int cantidadnuevosautos = Int32.Parse(dgv_Chofer.Rows.Count.ToString());

                            if (cantidadnuevosautos == (cantidaddatos + 1))
                            {
                                var respuesta = MessageBox.Show(
                                "Chofer registrado correctamente, ¿Desea agregar otro?",
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
                                    txt_Telefono.Text = string.Empty;
                                    txt_Correo.Text = string.Empty;
                                    txt_Domicilio.Text = string.Empty;
                                    dt_FechaNac.Text = string.Empty;
                                    this.cHOFERTableAdapter.Fill(this.sISTEMAFLETESACARREOSDataSet16.CHOFER);
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
                    MessageBox.Show("El chofer que se desea registrar esta fuera del rango de edad. (18 a 60 años)", "Error", MessageBoxButtons.OK);
                }

            }
            else
            {
                MessageBox.Show("Ya existe un chofer registrado con el mismo numero de licencia.", "Error", MessageBoxButtons.OK);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void AgregarChofer_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sISTEMAFLETESACARREOSDataSet16.CHOFER' Puede moverla o quitarla según sea necesario.
            this.cHOFERTableAdapter.Fill(this.sISTEMAFLETESACARREOSDataSet16.CHOFER);

        }
    }
}
