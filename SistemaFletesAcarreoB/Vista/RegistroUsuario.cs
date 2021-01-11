using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaFletesAcarreoB.Modelo;
using SistemaFletesAcarreoB.Controlador;

namespace SistemaFletesAcarreoB.Vista
{
    public partial class RegistroUsuario : Form
    {
        public RegistroUsuario()
        {
            InitializeComponent();
        }

        private void cb_Jefe_CheckedChanged(object sender, EventArgs e)
        {
            
            if (cb_Jefe.Checked == true)
            {
                lbl_Codigo.Visible = true;
                txt_Codigo.Visible = true;
                cb_Empleado.Checked = false;
            }
            else
            {
                lbl_Codigo.Visible = false;
                txt_Codigo.Visible = false;
            }
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {

            String cb_nivel = "";
            if (txt_contraseña.Text == txt_ccontraseña.Text)
            {
                try
                {
                    if (cb_Jefe.Checked == true)
                    {
                        if (txt_Codigo.Text == "1234")
                        {
                            cb_nivel = "1";
                        }
                        else
                        {
                            MessageBox.Show("Codigo de Jefe erroneo. ", "Error", MessageBoxButtons.OK);
                        }
                    }else if(cb_Empleado.Checked == true)
                    {
                        cb_nivel = "2";
                    }

                    var nuevoUsuario = new USUARIOS();
                    nuevoUsuario.Nombre = txt_Usuario.Text;
                    nuevoUsuario.Contra = txt_contraseña.Text;
                    nuevoUsuario.Nivel = cb_nivel;
                    ControladorUsuario.crearUsuario(nuevoUsuario);

                    var respuesta = MessageBox.Show(
                        "Auto guardado correctamente, ¿Desea agregar otro?",
                        "Mensaje del sistema",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);
                    if (respuesta == DialogResult.Yes)
                    {
                        txt_Usuario.Text = string.Empty;
                        txt_contraseña.Text = string.Empty;
                        txt_ccontraseña.Text = string.Empty;
                        txt_Codigo.Text = string.Empty;
                    }
                    else
                    {
                        Dispose();
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("Revisa los datos introducidos", "Error", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Las contraseñas no coinciden.", "Error", MessageBoxButtons.OK);
            }
            
        }

        private void RegistroUsuario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sISTEMAFLETESACARREOSDataSet14.USUARIOS' Puede moverla o quitarla según sea necesario.
            this.uSUARIOSTableAdapter1.Fill(this.sISTEMAFLETESACARREOSDataSet14.USUARIOS);

        }

        private void cb_Empleado_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_Jefe.Checked == true)
            {
                cb_Jefe.Checked = false;
            }
        }
    }
}
