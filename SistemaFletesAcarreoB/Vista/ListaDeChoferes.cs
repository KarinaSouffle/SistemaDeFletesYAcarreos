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
using SistemaFletesAcarreoB.GOF;

namespace SistemaFletesAcarreoB
{
    public partial class ListaDeChoferes : Form
    {
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
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int xd = Int32.Parse(dgv_Choferes.Rows.Count.ToString());
            int control = 0;
            string seleccionada = "";
            Validar validarChofer = new Validar();
            int indice = Int32.Parse(dgv_Choferes.CurrentRow.Index.ToString());
            int IdParametro = Int32.Parse(dgv_Choferes.Rows[indice].Cells[0].Value.ToString());
            for (int i = 0; i <= xd - 1; i++)
            {
                string compara = dgv_Choferes.Rows[i].Cells[1].Value.ToString();
                if (compara == dgv_Choferes.CurrentRow.Cells[1].Value.ToString())
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
                string apellidos = dgv_Choferes.Rows[indice].Cells[3].Value.ToString() + dgv_Choferes.Rows[indice].Cells[4].Value.ToString();
                if (validarChofer.ValidarLicencia(dgv_Choferes.Rows[indice].Cells[1].Value.ToString()) == true && 
                    validarChofer.ValidarNombre(dgv_Choferes.Rows[indice].Cells[2].Value.ToString(), "nombre") == true
                        && validarChofer.ValidarNombre(dgv_Choferes.Rows[indice].Cells[3].Value.ToString(), "apellido paterno") == true
                        && validarChofer.ValidarNombre(dgv_Choferes.Rows[indice].Cells[3].Value.ToString(), "apellido paterno") == true 
                        && validarChofer.ValidarNumeroTel(dgv_Choferes.Rows[indice].Cells[7].Value.ToString()) == true
                        && validarChofer.ValidarCorreo(dgv_Choferes.Rows[indice].Cells[8].Value.ToString()) == true)
                {
                    try
                    {

                        var nuevoChofer = new CHOFER();
                        nuevoChofer.lICENCIA_C = dgv_Choferes.Rows[indice].Cells[1].Value.ToString();
                        nuevoChofer.N_Chofer = dgv_Choferes.Rows[indice].Cells[2].Value.ToString();
                        nuevoChofer.ApellidoP_C = dgv_Choferes.Rows[indice].Cells[3].Value.ToString();
                        nuevoChofer.ApellidoM_C = dgv_Choferes.Rows[indice].Cells[4].Value.ToString();
                        nuevoChofer.Sexo = dgv_Choferes.Rows[indice].Cells[5].Value.ToString();
                        nuevoChofer.Edad = dgv_Choferes.Rows[indice].Cells[6].Value.ToString();
                        nuevoChofer.Telefono = dgv_Choferes.Rows[indice].Cells[7].Value.ToString();
                        nuevoChofer.Correo = dgv_Choferes.Rows[indice].Cells[8].Value.ToString();
                        nuevoChofer.F_Nac = Convert.ToDateTime(dgv_Choferes.Rows[indice].Cells[9].Value.ToString());
                        nuevoChofer.Direccion = dgv_Choferes.Rows[indice].Cells[10].Value.ToString();
                        nuevoChofer.Disponible = dgv_Choferes.Rows[indice].Cells[11].Value.ToString();
                        ControladorChofer.CrearChofer(nuevoChofer);

                        int cantidaddatos = Int32.Parse(dgv_Choferes.Rows.Count.ToString());
                        this.cHOFERTableAdapter.Fill(this.sISTEMAFLETESACARREOSDataSet.CHOFER);
                        int cantidadnuevosautos = Int32.Parse(dgv_Choferes.Rows.Count.ToString());
                        if (cantidadnuevosautos == (cantidaddatos + 1))
                        {
                            ModeloChofer.eliminarChofer(IdParametro);
                            this.cHOFERTableAdapter.Fill(this.sISTEMAFLETESACARREOSDataSet.CHOFER);
                            MessageBox.Show("Chofer Actualizado", "Listo", MessageBoxButtons.OK);
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
                MessageBox.Show("Ya existe un chofer registrado con el mismo numero de licencia.", "Error", MessageBoxButtons.OK);
            }
            
        }

        private void ListaDeChoferes_Load(object sender, EventArgs e)
        {
            this.cHOFERTableAdapter.Fill(this.sISTEMAFLETESACARREOSDataSet.CHOFER);
            if (Login.nivel == "1")
            {
                btn_Editar.Visible = true;
                btn_Eliminar.Visible = true;
            }
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            int resultado = Int32.Parse(dgv_Choferes.Rows[Int32.Parse(dgv_Choferes.CurrentRow.Index.ToString())].Cells[0].Value.ToString());
            ModeloChofer.eliminarChofer(resultado);
            MessageBox.Show("El Chofer " + resultado + " ha sido eliminado");
            this.cHOFERTableAdapter.Fill(this.sISTEMAFLETESACARREOSDataSet.CHOFER);
            lbl_SetIdChofer.Text = "";
            lbl_SetLicencia.Text = "";
            lbl_SetNombre.Text = "";
            lbl_SetAPaterno.Text = "";
            lbl_SetAMaterno.Text = "";
            lbl_SetSexo.Text = "";
            lbl_SetEdad.Text = "";
            lbl_SetTelefono.Text = "";
            lbl_SetCorreo.Text = "";
            lbl_SetDomicilio.Text = "";
        }


        private void ListaDeChoferes_Activated(object sender, EventArgs e)
        {
            this.cHOFERTableAdapter.Fill(this.sISTEMAFLETESACARREOSDataSet.CHOFER);
        }

        private void dgv_Choferes_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgv_Choferes_MouseEnter(object sender, EventArgs e)
        {
            int xd = Int32.Parse(dgv_Choferes.Rows.Count.ToString());
            if (xd != 0)
            {
                int indice = Int32.Parse(dgv_Choferes.CurrentRow.Index.ToString());
                int IdParametro = Int32.Parse(dgv_Choferes.Rows[indice].Cells[0].Value.ToString());

                lbl_SetIdChofer.Text = IdParametro.ToString();
                lbl_SetLicencia.Text = dgv_Choferes.Rows[indice].Cells[1].Value.ToString();
                lbl_SetNombre.Text = dgv_Choferes.Rows[indice].Cells[2].Value.ToString();
                lbl_SetAPaterno.Text = dgv_Choferes.Rows[indice].Cells[3].Value.ToString();
                lbl_SetAMaterno.Text = dgv_Choferes.Rows[indice].Cells[4].Value.ToString();
                lbl_SetSexo.Text = dgv_Choferes.Rows[indice].Cells[5].Value.ToString();
                lbl_SetEdad.Text = dgv_Choferes.Rows[indice].Cells[6].Value.ToString();
                lbl_SetTelefono.Text = dgv_Choferes.Rows[indice].Cells[7].Value.ToString();
                lbl_SetCorreo.Text = dgv_Choferes.Rows[indice].Cells[8].Value.ToString();
                dateTimePicker1.Value = Convert.ToDateTime(dgv_Choferes.Rows[indice].Cells[9].Value.ToString());
                lbl_SetDomicilio.Text = dgv_Choferes.Rows[indice].Cells[10].Value.ToString();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Context c = new Context(new Disponible());
            c.Request();

            int indice = Int32.Parse(dgv_Choferes.CurrentRow.Index.ToString());
            int IdParametro = Int32.Parse(dgv_Choferes.Rows[indice].Cells[0].Value.ToString());

            string xd = dgv_Choferes.Rows[indice].Cells[11].Value.ToString();
            if (xd == "1")
            {
                MessageBox.Show("El Chofer " + IdParametro + " esta disponible.");
            }
            else
            {
                MessageBox.Show("El Chofer " + IdParametro + " no esta disponible.");
            }
            
        }

        private void dgv_Choferes_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int FilaIndice = Int32.Parse(dgv_Choferes.CurrentRow.Index.ToString());
            if (dgv_Choferes.Rows[FilaIndice].Cells[0].Selected == true)
            {
                dgv_Choferes.Rows[FilaIndice].Cells[0].ReadOnly = true;
            }
        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            int xd = Int32.Parse(dgv_Choferes.Rows.Count.ToString());
            if (xd != 0)
            {
                int indice = Int32.Parse(dgv_Choferes.CurrentRow.Index.ToString());
                int IdParametro = Int32.Parse(dgv_Choferes.Rows[indice].Cells[0].Value.ToString());

                lbl_SetIdChofer.Text = IdParametro.ToString();
                lbl_SetLicencia.Text = dgv_Choferes.Rows[indice].Cells[1].Value.ToString();
                lbl_SetNombre.Text = dgv_Choferes.Rows[indice].Cells[2].Value.ToString();
                lbl_SetAPaterno.Text = dgv_Choferes.Rows[indice].Cells[3].Value.ToString();
                lbl_SetAMaterno.Text = dgv_Choferes.Rows[indice].Cells[4].Value.ToString();
                lbl_SetSexo.Text = dgv_Choferes.Rows[indice].Cells[5].Value.ToString();
                lbl_SetEdad.Text = dgv_Choferes.Rows[indice].Cells[6].Value.ToString();
                lbl_SetTelefono.Text = dgv_Choferes.Rows[indice].Cells[7].Value.ToString();
                lbl_SetCorreo.Text = dgv_Choferes.Rows[indice].Cells[8].Value.ToString();
                dateTimePicker1.Value = Convert.ToDateTime(dgv_Choferes.Rows[indice].Cells[9].Value.ToString());
                lbl_SetDomicilio.Text = dgv_Choferes.Rows[indice].Cells[10].Value.ToString();
            }
        }

        private void dgv_Choferes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int xd = Int32.Parse(dgv_Choferes.Rows.Count.ToString());
            if (xd != 0)
            {
                int indice = Int32.Parse(dgv_Choferes.CurrentRow.Index.ToString());
                int IdParametro = Int32.Parse(dgv_Choferes.Rows[indice].Cells[0].Value.ToString());

                lbl_SetIdChofer.Text = IdParametro.ToString();
                lbl_SetLicencia.Text = dgv_Choferes.Rows[indice].Cells[1].Value.ToString();
                lbl_SetNombre.Text = dgv_Choferes.Rows[indice].Cells[2].Value.ToString();
                lbl_SetAPaterno.Text = dgv_Choferes.Rows[indice].Cells[3].Value.ToString();
                lbl_SetAMaterno.Text = dgv_Choferes.Rows[indice].Cells[4].Value.ToString();
                lbl_SetSexo.Text = dgv_Choferes.Rows[indice].Cells[5].Value.ToString();
                lbl_SetEdad.Text = dgv_Choferes.Rows[indice].Cells[6].Value.ToString();
                lbl_SetTelefono.Text = dgv_Choferes.Rows[indice].Cells[7].Value.ToString();
                lbl_SetCorreo.Text = dgv_Choferes.Rows[indice].Cells[8].Value.ToString();
                dateTimePicker1.Value = Convert.ToDateTime(dgv_Choferes.Rows[indice].Cells[9].Value.ToString());
                lbl_SetDomicilio.Text = dgv_Choferes.Rows[indice].Cells[10].Value.ToString();
            }
        }

        private void ListaDeChoferes_MouseEnter(object sender, EventArgs e)
        {
            //this.cHOFERTableAdapter.Fill(this.sISTEMAFLETESACARREOSDataSet.CHOFER);
        }
    }
}
