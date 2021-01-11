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

namespace SistemaFletesAcarreoB
{
    public partial class Login : Form
    {
        Pantalla_Principal principal;
        RegistroUsuario Registro;
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }


        private void btn_Iniciar_Click(object sender, EventArgs e)
        {
            int xd = (Convert.ToInt32(this.dgv_Usuarios.Rows.Count.ToString()));
            Console.WriteLine(xd);
            int control = 0;
            for (int i = 0; i < xd-1; i++)
            {
                if (dgv_Usuarios.Rows[i].Cells[1].Value.ToString() == txt_Usuario.Text)
                {
                    if ((dgv_Usuarios.Rows[i].Cells[2].Value.ToString() == txt_Contraeña.Text))
                    {
                        control = 1;
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

        private void btn_registro_Click(object sender, EventArgs e)
        {
            Registro = new RegistroUsuario();
            Registro.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sISTEMAFLETESACARREOSDataSet14.USUARIOS' Puede moverla o quitarla según sea necesario.
            this.uSUARIOSTableAdapter1.Fill(this.sISTEMAFLETESACARREOSDataSet14.USUARIOS);

        }

        private void Login_Activated(object sender, EventArgs e)
        {
            this.uSUARIOSTableAdapter1.Fill(this.sISTEMAFLETESACARREOSDataSet14.USUARIOS);
        }
    }
}
