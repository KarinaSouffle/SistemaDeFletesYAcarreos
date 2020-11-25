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
using SistemaFletesAcarreoB.Controlador;
using SistemaFletesAcarreoB.Modelo;

namespace SistemaFletesAcarreoB
{
    public partial class ListaDeMateriales : Form
    {
        AgregarMaterial PAM;
        Pantalla_Principal PPrincipal;

        public ListaDeMateriales()
        {
            InitializeComponent();
        }

        private void btn_VolverPKPP_Click(object sender, EventArgs e)
        {
            PAM = new AgregarMaterial();
            PAM.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PPrincipal = new Pantalla_Principal();
            PPrincipal.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var material = new MATERIALES();
            int indice = Int32.Parse(dgv_ListaMateriales.CurrentRow.Index.ToString());
            int IdParametro = Int32.Parse(dgv_ListaMateriales.Rows[indice].Cells[0].Value.ToString());


            ModeloMateriales.eliminarMaterial(IdParametro);
            var nuevoMaterial = new MATERIALES();
            nuevoMaterial.Codigo = IdParametro;
            nuevoMaterial.Nombre_M = dgv_ListaMateriales.Rows[indice].Cells[1].Value.ToString();
            nuevoMaterial.Precio = Convert.ToInt32(dgv_ListaMateriales.Rows[indice].Cells[2].Value.ToString());
            ModeloMateriales.crearMaterial(nuevoMaterial);

        }

        private void ListaDeMateriales_Load(object sender, EventArgs e)
        {
            this.mATERIALESTableAdapter.Fill(this.sISTEMAFLETESACARREOSDataSet.MATERIALES);
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            int resultado = Int32.Parse(dgv_ListaMateriales.Rows[Int32.Parse(dgv_ListaMateriales.CurrentRow.Index.ToString())].Cells[0].Value.ToString());
            ModeloMateriales.eliminarMaterial(resultado);
            MessageBox.Show("El Material " + resultado + " ha sido eliminado");
            this.mATERIALESTableAdapter.Fill(this.sISTEMAFLETESACARREOSDataSet.MATERIALES);
        }

        private void dgv_ListaMateriales_MouseEnter(object sender, EventArgs e)
        {
            this.mATERIALESTableAdapter.Fill(this.sISTEMAFLETESACARREOSDataSet.MATERIALES);
        }
    }
}
