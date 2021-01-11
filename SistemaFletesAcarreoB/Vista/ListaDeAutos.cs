using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using SistemaFletesAcarreoB.Controlador;
using SistemaFletesAcarreoB.Modelo;


namespace SistemaFletesAcarreoB
{
    public partial class ListaDeAutos : Form
    {
        VerChoferesYAutos VCYAA;
        AgregarAuto AA;
        
        public ListaDeAutos()
        {
            InitializeComponent();
        }

        //Este es añadir
        private void btn_VolverPKPP_Click(object sender, EventArgs e)
        {
            AA = new AgregarAuto();
            AA.Show();
        }

        //Este es VOLVER
        private void button1_Click(object sender, EventArgs e)
        {
            VCYAA = new VerChoferesYAutos();
            VCYAA.Show();
            this.Hide();
        }

        //Este es editar
        private void button2_Click(object sender, EventArgs e)
        {
            var auto = new AUTOS();
            int indice = Int32.Parse(dgv_ListadoAutos.CurrentRow.Index.ToString());
            int IdParametro = Int32.Parse(dgv_ListadoAutos.Rows[indice].Cells[0].Value.ToString());

            Console.WriteLine(indice);
            Console.WriteLine(IdParametro);
            ControladorAuto.EliminarAutos(IdParametro);
            var nuevoAuto = new AUTOS();
            nuevoAuto.Num_Placas = dgv_ListadoAutos.Rows[indice].Cells[1].Value.ToString();
            nuevoAuto.Marca = dgv_ListadoAutos.Rows[indice].Cells[2].Value.ToString();
            nuevoAuto.Kilometraje = Convert.ToInt32(dgv_ListadoAutos.Rows[indice].Cells[3].Value.ToString());
            nuevoAuto.Cap_A = Convert.ToInt32(dgv_ListadoAutos.Rows[indice].Cells[4].Value.ToString());

            ControladorAuto.CrearAuto(nuevoAuto);
            this.aUTOSTableAdapter4.Fill(this.sISTEMAFLETESACARREOSDataSet14.AUTOS);
        }

        private void ListaDeAutos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sISTEMAFLETESACARREOSDataSet14.AUTOS' Puede moverla o quitarla según sea necesario.
            this.aUTOSTableAdapter4.Fill(this.sISTEMAFLETESACARREOSDataSet14.AUTOS);
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            int resultado = Int32.Parse(dgv_ListadoAutos.Rows[Int32.Parse(dgv_ListadoAutos.CurrentRow.Index.ToString())].Cells[0].Value.ToString());
            ModeloAuto.eliminarAutos(resultado);
            MessageBox.Show("El auto " + resultado + " ha sido eliminado");
            this.aUTOSTableAdapter4.Fill(this.sISTEMAFLETESACARREOSDataSet14.AUTOS);
            lbl_SetIdAuto.Text = "";
            lbl_SetPlaca.Text = "";
            lbl_SetMarca.Text = "";
            lbl_SetKilometraje.Text = "";
            lbl_SetCapacidad.Text = "";
        }

        private void ListaDeAutos_Activated(object sender, EventArgs e)
        {
            this.aUTOSTableAdapter4.Fill(this.sISTEMAFLETESACARREOSDataSet14.AUTOS);
        }

        private void dgv_ListadoAutos_MouseEnter(object sender, EventArgs e)
        {
            int xd = Int32.Parse(dgv_ListadoAutos.Rows.Count.ToString());
            if (xd != 0)
            {
                int indice = Int32.Parse(dgv_ListadoAutos.CurrentRow.Index.ToString());
                int IdParametro = Int32.Parse(dgv_ListadoAutos.Rows[indice].Cells[0].Value.ToString());

                lbl_SetIdAuto.Text = IdParametro.ToString();
                lbl_SetPlaca.Text = dgv_ListadoAutos.Rows[indice].Cells[1].Value.ToString();
                lbl_SetMarca.Text = dgv_ListadoAutos.Rows[indice].Cells[2].Value.ToString();
                lbl_SetKilometraje.Text = dgv_ListadoAutos.Rows[indice].Cells[3].Value.ToString();
                lbl_SetCapacidad.Text = dgv_ListadoAutos.Rows[indice].Cells[4].Value.ToString();
            }
                
        }
    }
}
