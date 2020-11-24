using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaFletesAcarreoB
{
    public partial class Form1 : Form
    {
        Pantalla_Principal pprincipal;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label_NusuarioLogIn_Click(object sender, EventArgs e)
        {

        }

        private void btn_Iniciar_Click(object sender, EventArgs e)
        {
            
               if((txt_Usuario.Text == "Admi") && (txt_Contraeña.Text == "1234"))
                {
                    pprincipal = new Pantalla_Principal();
                    pprincipal.Show();
                    this.Hide();
                }
               else 
                {
                    MessageBox.Show("Sus datos no son correctos...");
                }
        }
    }
}
