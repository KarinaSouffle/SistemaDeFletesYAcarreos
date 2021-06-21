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
using System.IO;

namespace SistemaFletesAcarreoB
{
    public partial class Login : Form
    {
        public static string nombre;
        public static string nivel;
        Pantalla_Principal principal;
        RegistroUsuarioLogin Registro;
        UsuarioManager usuario = new UsuarioManager();
        string UsuarioLogin = "Admi";
        public Login()
        {
            InitializeComponent();
        }

        private void btn_Iniciar_Click(object sender, EventArgs e)
        {
            int Filas = (Convert.ToInt32(this.dgv_Usuarios.Rows.Count.ToString()));
            int control = 0;
            int stop = Filas;
            for (int i = 0; i < Filas; i++)
            {
                if (dgv_Usuarios.Rows[i].Cells[1].Value.ToString() == txt_Usuario.Text)
                {
                    if ((dgv_Usuarios.Rows[i].Cells[2].Value.ToString() == txt_Contraeña.Text))
                    {
                        control = 1;
                        nombre = dgv_Usuarios.Rows[i].Cells[1].Value.ToString();
                        nivel = dgv_Usuarios.Rows[i].Cells[3].Value.ToString();
                        i = Filas;
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
            try
            {
                this.uSUARIOSTableAdapter.Fill(this.sISTEMAFLETESACARREOSDataSet.USUARIOS);
                if (Convert.ToInt32(dgv_Usuarios.Rows.Count.ToString()) == 0)
                {
                    if (ModeloUsuario.buscarUsuariosPorCriterios("Admi") == null)
                    {
                        Console.WriteLine("Entro");
                        var nuevoUsuario = new USUARIOS();
                        nuevoUsuario.Nombre = "Admi";
                        nuevoUsuario.Contra = "1234";
                        nuevoUsuario.Nivel = "1";
                        nuevoUsuario.EnUso = "2";
                        ControladorUsuario.crearUsuario(nuevoUsuario);
                    }
                }
                this.uSUARIOSTableAdapter.Fill(this.sISTEMAFLETESACARREOSDataSet.USUARIOS);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error en la conexion a la Base de Datos, comuníquese con el administrador. ", "Error en la Base de Datos", MessageBoxButtons.OK);
            }
            
            if (!Directory.Exists(@"c:\SistemaAcarreos"))
            {
                Directory.CreateDirectory(@"c:\SistemaAcarreos");
                if (!Directory.Exists(@"c:\SistemaAcarreos\Facturas") || !Directory.Exists(@"c:\SistemaAcarreos\Respaldo"))
                {
                    Directory.CreateDirectory(@"c:\SistemaAcarreos\Facturas");
                    Directory.CreateDirectory(@"c:\SistemaAcarreos\Respaldo");
                }
            }

        }
        private void btn_Registrar_Click(object sender, EventArgs e)
        {
            Registro = new RegistroUsuarioLogin();
            Registro.Show();
        }

        private void Login_Activated(object sender, EventArgs e)
        {

        }
    }
}
