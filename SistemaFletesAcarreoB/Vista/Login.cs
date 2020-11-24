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
    public partial class Login : Form
    {
        Pantalla_Principal principal;
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }


        private void btn_Iniciar_Click(object sender, EventArgs e)
        {
            
               if((txt_Usuario.Text == "Admi") && (txt_Contraeña.Text == "1234"))
                {
                    principal = new Pantalla_Principal();
                    principal.Show();
                    this.Hide();
                }
               else 
                {
                    MessageBox.Show("Sus datos no son correctos...");
                }
        }
    }
}
