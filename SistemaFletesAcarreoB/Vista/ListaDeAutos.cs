using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using SistemaFletesAcarreoB.Controlador;
using SistemaFletesAcarreoB.Modelo;


namespace SistemaFletesAcarreoB
{
    public partial class ListaDeAutos : Form
    {
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
            this.Hide();
        }

        //Este es editar
        private void button2_Click(object sender, EventArgs e)
        {
            int xd = Int32.Parse(dgv_ListadoAutos.Rows.Count.ToString());
            int control = 0;
            string seleccionada = "";
            var auto = new AUTOS();
            int indice = Int32.Parse(dgv_ListadoAutos.CurrentRow.Index.ToString());
            int IdParametro = Int32.Parse(dgv_ListadoAutos.Rows[indice].Cells[0].Value.ToString());

            for (int i = 0; i <= xd - 1; i++)
            {
                string compara = dgv_ListadoAutos.Rows[i].Cells[1].Value.ToString();
                if (compara == dgv_ListadoAutos.CurrentRow.Cells[1].Value.ToString())
                {
                    control = control + 1;
                    if (control >= 2)
                    {
                        seleccionada = compara;
                    }
                }
            }
            if (seleccionada == string.Empty)
            {
                Validar validar = new Validar();

                if ((validar.FormatoPlaca(dgv_ListadoAutos.Rows[indice].Cells[1].Value.ToString()) == true &&
                    validar.ValidarNombre(dgv_ListadoAutos.Rows[indice].Cells[2].Value.ToString()) == true && 
                    validar.ValidarNum(dgv_ListadoAutos.Rows[indice].Cells[3].Value.ToString()) == true && 
                    validar.ValidarNum(dgv_ListadoAutos.Rows[indice].Cells[4].Value.ToString()) == true))
                {
                    try
                    {
                        var nuevoAuto = new AUTOS();
                        nuevoAuto.Num_Placas = dgv_ListadoAutos.Rows[indice].Cells[1].Value.ToString();
                        nuevoAuto.Marca = dgv_ListadoAutos.Rows[indice].Cells[2].Value.ToString();
                        nuevoAuto.Kilometraje = dgv_ListadoAutos.Rows[indice].Cells[3].Value.ToString();
                        nuevoAuto.Cap_A = (Math.Round(float.Parse(dgv_ListadoAutos.Rows[indice].Cells[4].Value.ToString()))).ToString();
                        nuevoAuto.Disponible = dgv_ListadoAutos.Rows[indice].Cells[5].Value.ToString();

                        ControladorAuto.CrearAuto(nuevoAuto);
                        int cantidaddatos = Int32.Parse(dgv_ListadoAutos.Rows.Count.ToString());
                        this.aUTOSTableAdapter7.Fill(this.sISTEMAFLETESACARREOSDataSet18.AUTOS);
                        int cantidadnuevosautos = Int32.Parse(dgv_ListadoAutos.Rows.Count.ToString());

                        if (cantidadnuevosautos == (cantidaddatos + 1))
                        {
                            ModeloAuto.eliminarAutos(IdParametro);
                            MessageBox.Show("Auto Actualizado", "Listo", MessageBoxButtons.OK);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hubo un error: " + ex + " ", "Error", MessageBoxButtons.OK);
                    }
                }
            }
            else
            {
                MessageBox.Show("Ya existe un auto registrado con el mismo numero de placas.", "Error", MessageBoxButtons.OK);
            }
            
        }

        private void ListaDeAutos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sISTEMAFLETESACARREOSDataSet18.AUTOS' Puede moverla o quitarla según sea necesario.
            this.aUTOSTableAdapter7.Fill(this.sISTEMAFLETESACARREOSDataSet18.AUTOS);
            // TODO: esta línea de código carga datos en la tabla 'sISTEMAFLETESACARREOSDataSet18.USUARIOS' Puede moverla o quitarla según sea necesario.
            this.uSUARIOSTableAdapter.Fill(this.sISTEMAFLETESACARREOSDataSet18.USUARIOS);

            int xd = (Convert.ToInt32(this.dgv_Usuarios.Rows.Count.ToString()));
            int us = 0;
            if (xd == 1)
            {
                for (int i = 0; i < xd - 1; i++)
                {
                    int usuarioset = Int32.Parse(dgv_Usuarios.Rows[i].Cells[4].Value.ToString());
                    us = usuarioset;
                    if (us == 1)
                    {
                        int usuarioadmin = Int32.Parse(dgv_Usuarios.Rows[i].Cells[3].Value.ToString());
                        if (usuarioadmin == 1)
                        {
                            btn_Editar.Visible = true;
                            btn_AñadirPKPP.Visible = true;
                            btn_Eliminar.Visible = true;
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < xd - 1; i++)
                {
                    int usuarioset = Int32.Parse(dgv_Usuarios.Rows[i].Cells[4].Value.ToString());
                    us = usuarioset;
                    if (us == 1)
                    {
                        int usuarioadmin = Int32.Parse(dgv_Usuarios.Rows[i].Cells[3].Value.ToString());
                        if (usuarioadmin == 1)
                        {
                            btn_Editar.Visible = true;
                            btn_AñadirPKPP.Visible = true;
                            btn_Eliminar.Visible = true;
                        }
                    }
                }
            }
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            int resultado = Int32.Parse(dgv_ListadoAutos.Rows[Int32.Parse(dgv_ListadoAutos.CurrentRow.Index.ToString())].Cells[0].Value.ToString());
            ModeloAuto.eliminarAutos(resultado);
            MessageBox.Show("El auto " + resultado + " ha sido eliminado");
            this.aUTOSTableAdapter7.Fill(this.sISTEMAFLETESACARREOSDataSet18.AUTOS);
            lbl_SetIdAuto.Text = "";
            lbl_SetPlaca.Text = "";
            lbl_SetMarca.Text = "";
            lbl_SetKilometraje.Text = "";
            lbl_SetCapacidad.Text = "";
        }

        private void ListaDeAutos_Activated(object sender, EventArgs e)
        {
            this.aUTOSTableAdapter7.Fill(this.sISTEMAFLETESACARREOSDataSet18.AUTOS);
        }

        private void dgv_ListadoAutos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int FilaIndice = Int32.Parse(dgv_ListadoAutos.CurrentRow.Index.ToString());
            if (dgv_ListadoAutos.Rows[FilaIndice].Cells[0].Selected == true)
            {
                dgv_ListadoAutos.Rows[FilaIndice].Cells[0].ReadOnly = true;
            }
        }

        private void ListaDeAutos_Enter(object sender, EventArgs e)
        {
            this.aUTOSTableAdapter7.Fill(this.sISTEMAFLETESACARREOSDataSet18.AUTOS);
        }

        private void dgv_ListadoAutos_CellClick(object sender, DataGridViewCellEventArgs e)
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
