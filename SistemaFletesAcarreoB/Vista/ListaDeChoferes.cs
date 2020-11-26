using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using SistemaFletesAcarreoB.Controlador;
using SistemaFletesAcarreoB.Modelo;

namespace SistemaFletesAcarreoB
{
    public partial class ListaDeChoferes : Form
    {
        VerChoferesYAutos VCYA;
        AgregarChofer PAC;

        public ListaDeChoferes()
        {
            InitializeComponent();
        }

        private void btn_VolverPKPP_Click(object sender, EventArgs e)
        {
            PAC = new AgregarChofer();
            PAC.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VCYA = new VerChoferesYAutos();
            VCYA.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var material = new MATERIALES();
            int indice = Int32.Parse(dgv_Choferes.CurrentRow.Index.ToString());
            int IdParametro = Int32.Parse(dgv_Choferes.Rows[indice].Cells[0].Value.ToString());

            ModeloChofer.eliminarChofer(IdParametro);
            var nuevoChofer = new CHOFER();
            nuevoChofer.lICENCIA_C = IdParametro;
            nuevoChofer.N_Chofer = dgv_Choferes.Rows[indice].Cells[1].Value.ToString();
            nuevoChofer.ApellidoP_C = dgv_Choferes.Rows[indice].Cells[2].Value.ToString();
            nuevoChofer.ApellidoM_C = dgv_Choferes.Rows[indice].Cells[3].Value.ToString();
            nuevoChofer.Sexo = dgv_Choferes.Rows[indice].Cells[4].Value.ToString();
            nuevoChofer.Edad = Convert.ToInt32(dgv_Choferes.Rows[indice].Cells[5].Value.ToString());
            nuevoChofer.Telefono = dgv_Choferes.Rows[indice].Cells[6].Value.ToString();
            nuevoChofer.Correo = dgv_Choferes.Rows[indice].Cells[7].Value.ToString();
            nuevoChofer.F_Nac = Convert.ToDateTime(dgv_Choferes.Rows[indice].Cells[8].Value.ToString());
            nuevoChofer.Chofer_Direccion = dgv_Choferes.Rows[indice].Cells[9].Value.ToString();

            ModeloChofer.crearChofer(nuevoChofer);
        }

        private void ListaDeChoferes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sISTEMAFLETESACARREOSDataSet5.CHOFER' Puede moverla o quitarla según sea necesario.
            this.cHOFERTableAdapter2.Fill(this.sISTEMAFLETESACARREOSDataSet5.CHOFER);
            // TODO: esta línea de código carga datos en la tabla 'sISTEMAFLETESACARREOSDataSet1.CHOFER' Puede moverla o quitarla según sea necesario.
            //this.cHOFERTableAdapter1.Fill(this.sISTEMAFLETESACARREOSDataSet1.CHOFER);
            // TODO: esta línea de código carga datos en la tabla 'sISTEMAFLETESACARREOSDataSet.CHOFER' Puede moverla o quitarla según sea necesario.
            //this.cHOFERTableAdapter.Fill(this.sISTEMAFLETESACARREOSDataSet.CHOFER);

        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            int resultado = Int32.Parse(dgv_Choferes.Rows[Int32.Parse(dgv_Choferes.CurrentRow.Index.ToString())].Cells[0].Value.ToString());
            ModeloChofer.eliminarChofer(resultado);
            MessageBox.Show("El Chofer " + resultado + " ha sido eliminado");
            this.cHOFERTableAdapter2.Fill(this.sISTEMAFLETESACARREOSDataSet5.CHOFER);
        }


        private void ListaDeChoferes_Activated(object sender, EventArgs e)
        {
            this.cHOFERTableAdapter2.Fill(this.sISTEMAFLETESACARREOSDataSet5.CHOFER);

        }

        private void dgv_Choferes_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            int indice = Int32.Parse(dgv_Choferes.CurrentRow.Index.ToString());
            int IdParametro = Int32.Parse(dgv_Choferes.Rows[indice].Cells[0].Value.ToString());

            lbl_SetLicencia.Text = IdParametro.ToString();
            lbl_SetNombre.Text = dgv_Choferes.Rows[indice].Cells[1].Value.ToString();
            lbl_SetAPaterno.Text = dgv_Choferes.Rows[indice].Cells[2].Value.ToString();
            lbl_SetAMaterno.Text = dgv_Choferes.Rows[indice].Cells[3].Value.ToString();
            lbl_SetSexo.Text = dgv_Choferes.Rows[indice].Cells[4].Value.ToString();
            lbl_SetEdad.Text = dgv_Choferes.Rows[indice].Cells[5].Value.ToString();
            lbl_SetTelefono.Text = dgv_Choferes.Rows[indice].Cells[6].Value.ToString();
            lbl_SetCorreo.Text = dgv_Choferes.Rows[indice].Cells[7].Value.ToString();
            dateTimePicker1.Value = Convert.ToDateTime(dgv_Choferes.Rows[indice].Cells[8].Value.ToString());
            lbl_SetDomicilio.Text = dgv_Choferes.Rows[indice].Cells[9].Value.ToString();
        }
    }
}
