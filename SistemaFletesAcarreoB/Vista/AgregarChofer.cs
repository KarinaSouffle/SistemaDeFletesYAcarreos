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
            int Cont_Filas = Int32.Parse(dgv_Chofer.Rows.Count.ToString());
            string seleccionada = "";
            Validar val = new Validar();
            for (int i = 0; i <= Cont_Filas - 1; i++)
            {
                string compara = dgv_Chofer.Rows[i].Cells[1].Value.ToString();
                if (compara == txt_Licencia.Text.ToString())
                {
                    seleccionada = compara;
                }
            }
            Validar validarChofer = new Validar();
            
            string apellidos = txt_AMaterno.Text + txt_APaterno.Text;
            string direccion = txt_Domicilio.Text;
            int dia = dt_FechaNac.Value.Day;
            int mes = dt_FechaNac.Value.Month;
            int anio = dt_FechaNac.Value.Year;
            DateTime fecha = new DateTime(anio, mes, dia);
            int edad = DateTime.Now.Subtract(fecha).Days / 365;
            if (seleccionada == string.Empty)
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
                    this.cHOFERTableAdapter1.Fill(this.sISTEMAFLETESACARREOSDataSet20.CHOFER);
                    int cantidadnuevosautos = Int32.Parse(dgv_Chofer.Rows.Count.ToString());

                    if (cantidadnuevosautos == (cantidaddatos + 1))
                    {
                        var respuesta = MessageBox.Show(
                        "Chofer registrado correctamente",
                        "Mensaje del sistema",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                        txt_Licencia.Text = string.Empty;
                        txt_Nombre.Text = string.Empty;
                        txt_APaterno.Text = string.Empty;
                        txt_AMaterno.Text = string.Empty;
                        txt_Sexo.Text = string.Empty;
                        txt_Telefono.Text = string.Empty;
                        txt_Correo.Text = string.Empty;
                        txt_Domicilio.Text = string.Empty;
                        dt_FechaNac.Text = string.Empty;
                        this.cHOFERTableAdapter1.Fill(this.sISTEMAFLETESACARREOSDataSet20.CHOFER);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hubo un error: " + ex + " ", "Error", MessageBoxButtons.OK);
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
            // TODO: esta línea de código carga datos en la tabla 'sISTEMAFLETESACARREOSDataSet20.CHOFER' Puede moverla o quitarla según sea necesario.
            this.cHOFERTableAdapter1.Fill(this.sISTEMAFLETESACARREOSDataSet20.CHOFER);
        }

        private void txt_Nombre_Validating(object sender, CancelEventArgs e)
        {
            Validar validar = new Validar();
            if (validar.ValidarNombre(txt_Nombre.Text, "nombre") == true)
            {
                lbl_ValNom.Visible = false;
            }
            else
            {
                lbl_ValNom.Visible = true;
                txt_Nombre.Focus();
            }
        }

        private void txt_APaterno_Validating(object sender, CancelEventArgs e)
        {
            Validar validar = new Validar();
            if (validar.ValidarNombre(txt_APaterno.Text, "apellido paterno") == true)
            {
                lbl_ValAPat.Visible = false;
            }
            else
            {
                lbl_ValAPat.Visible = true;
                txt_APaterno.Focus();
            }
        }

        private void txt_AMaterno_Validating(object sender, CancelEventArgs e)
        {
            Validar validar = new Validar();
            if (validar.ValidarNombre(txt_AMaterno.Text, "apellido materno") == true)
            {
                lbl_ValAMat.Visible = false;
            }
            else
            {
                lbl_ValAMat.Visible = true;
                txt_AMaterno.Focus();
            }
        }

        private void txt_Telefono_Validating(object sender, CancelEventArgs e)
        {
            Validar validar = new Validar();
            if (validar.ValidarNumeroTel(txt_Telefono.Text) == true)
            {
                lbl_ValTel.Visible = false;
            }
            else
            {
                lbl_ValTel.Visible = true;
                txt_Telefono.Focus();
            }
        }

        private void txt_Correo_Validating(object sender, CancelEventArgs e)
        {
            Validar validar = new Validar();
            if (validar.ValidarCorreo(txt_Correo.Text) == true)
            {
                lbl_ValCorreo.Visible = false;
            }
            else
            {
                lbl_ValCorreo.Visible = true;
                txt_Correo.Focus();
            }
        }

        private void txt_Sexo_Validating(object sender, CancelEventArgs e)
        {
            if (txt_Sexo.Text != string.Empty)
            {
                lbl_ValSexo.Visible = false;
            }
            else
            {
                MessageBox.Show("El campo del sexo del chofer esta vacio.", "Error", MessageBoxButtons.OK);
                lbl_ValSexo.Visible = true;
                txt_Sexo.Focus();
            }
        }

        private void txt_Domicilio_Validating(object sender, CancelEventArgs e)
        {
            Validar validar = new Validar();
            if (validar.ValidarNombre(txt_Domicilio.Text, "domicilio") == true)
            {
                lbl_ValDom.Visible = false;
            }
            else
            {
                lbl_ValDom.Visible = true;
                txt_Domicilio.Focus();
            }
        }

        private void dt_FechaNac_Validating(object sender, CancelEventArgs e)
        {
            int dia = dt_FechaNac.Value.Day;
            int mes = dt_FechaNac.Value.Month;
            int anio = dt_FechaNac.Value.Year;
            DateTime fecha = new DateTime(anio, mes, dia);
            int edad = DateTime.Now.Subtract(fecha).Days / 365;

            if (edad >= 18 && edad <= 65)//aca va edad
            {
                lbl_ValFecha.Visible = false;
            }
            else
            {
                MessageBox.Show("El chofer que se desea registrar esta fuera del rango de edad. (18 a 60 años)", "Error", MessageBoxButtons.OK);
                lbl_ValFecha.Visible = true;
                dt_FechaNac.Focus();
            }
        }

        private void txt_Licencia_Validating(object sender, CancelEventArgs e)
        {
            Validar validar = new Validar();
            if (validar.ValidarLicencia(txt_Licencia.Text) == true)
            {
                lbl_ValLice.Visible = false;
            }
            else
            {
                lbl_ValLice.Visible = true;
                txt_Licencia.Focus();
            }
        }
    }
}
