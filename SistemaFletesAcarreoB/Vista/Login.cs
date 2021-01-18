using SistemaFletesAcarreoB.Vista;
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
using SistemaFletesAcarreoB.GOF;

namespace SistemaFletesAcarreoB
{
    public partial class Login : Form
    {
        Pantalla_Principal principal;
        RegistroUsuarioLogin Registro;
        UsuarioManager usuario = new UsuarioManager();
        string UsuarioLogin = "Admi";
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            usuario[UsuarioLogin] = new Usuario("Admi");

            Usuario usuario1 = usuario[UsuarioLogin].Clone() as Usuario;
        }


        private void btn_Iniciar_Click(object sender, EventArgs e)
        {
            int xd = (Convert.ToInt32(this.dgv_Usuarios.Rows.Count.ToString()));
            Console.WriteLine(xd);
            int control = 0;
            for (int i = 0; i < xd; i++)
            {
                if (dgv_Usuarios.Rows[i].Cells[1].Value.ToString() == txt_Usuario.Text)
                {
                    if ((dgv_Usuarios.Rows[i].Cells[2].Value.ToString() == txt_Contraeña.Text))
                    {
                        control = 1;

                        var nuevoUsuario = new USUARIOS();
                        nuevoUsuario.Nombre = dgv_Usuarios.Rows[i].Cells[1].Value.ToString();
                        nuevoUsuario.Contra = dgv_Usuarios.Rows[i].Cells[2].Value.ToString();
                        nuevoUsuario.Nivel = dgv_Usuarios.Rows[i].Cells[3].Value.ToString();
                        nuevoUsuario.EnUso = "1";
                        ControladorUsuario.crearUsuario(nuevoUsuario);
                        int eliminar = Int32.Parse(dgv_Usuarios.Rows[i].Cells[0].Value.ToString());
                        ControladorUsuario.EliminarUsuario(eliminar);

                        principal = new Pantalla_Principal();
                        principal.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Contraseña Incorrecta", "Error", MessageBoxButtons.OK);
                        control = 1;
                    }
                }
            }
            if (control == 0)
            {
                MessageBox.Show("Usuario no encontrado. ", "Error", MessageBoxButtons.OK);
            }
            control = 0;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sISTEMAFLETESACARREOSDataSet16.USUARIOS' Puede moverla o quitarla según sea necesario.
            this.uSUARIOSTableAdapter2.Fill(this.sISTEMAFLETESACARREOSDataSet16.USUARIOS);

        }

        private void Login_Activated(object sender, EventArgs e)
        {
            this.uSUARIOSTableAdapter2.Fill(this.sISTEMAFLETESACARREOSDataSet16.USUARIOS);
        }

        private void btn_Registrar_Click(object sender, EventArgs e)
        {
            Registro = new RegistroUsuarioLogin();
            Registro.Show();
        }
    }
}
