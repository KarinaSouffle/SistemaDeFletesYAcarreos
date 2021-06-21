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
using SistemaFletesAcarreoB.GOF;

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
            int xd = Int32.Parse(dgv_ListaMateriales.Rows.Count.ToString());
            int control = 0;
            string seleccionada = "";
            var material = new MATERIALES();
            int indice = Int32.Parse(dgv_ListaMateriales.CurrentRow.Index.ToString());
            int IdParametro = Int32.Parse(dgv_ListaMateriales.Rows[indice].Cells[0].Value.ToString());
            for (int i = 0; i <= xd - 1; i++)
            {
                string compara = dgv_ListaMateriales.Rows[i].Cells[1].Value.ToString();
                if (compara == dgv_ListaMateriales.CurrentRow.Cells[1].Value.ToString())
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
                if (validar.ValidarNombre(dgv_ListaMateriales.Rows[indice].Cells[1].Value.ToString(), "nombre del material") == true &&
                    validar.ValidarNum(dgv_ListaMateriales.Rows[indice].Cells[2].Value.ToString(), "precio del material"))
                {
                    try
                    {
                        var nuevoMaterial = new MATERIALES();
                        nuevoMaterial.Codigo = IdParametro;
                        nuevoMaterial.Nombre_M = dgv_ListaMateriales.Rows[indice].Cells[1].Value.ToString();
                        nuevoMaterial.Precio = dgv_ListaMateriales.Rows[indice].Cells[2].Value.ToString();
                        ControladorMateriales.CrearMaterial(nuevoMaterial);

                        int cantidaddatos = Int32.Parse(dgv_ListaMateriales.Rows.Count.ToString());
                        this.mATERIALESTableAdapter.Fill(this.sISTEMAFLETESACARREOSDataSet.MATERIALES);
                        int cantidadnuevosmateriales = Int32.Parse(dgv_ListaMateriales.Rows.Count.ToString());
                        if (cantidadnuevosmateriales == (cantidaddatos + 1))
                        {
                            ModeloMateriales.eliminarMaterial(IdParametro);
                            this.mATERIALESTableAdapter.Fill(this.sISTEMAFLETESACARREOSDataSet.MATERIALES);
                            MessageBox.Show("Material Actualizado", "Listo", MessageBoxButtons.OK);
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
                MessageBox.Show("Ya existe un material registrado con el mismo nombre.", "Error", MessageBoxButtons.OK);
            }
            
        }

        private void ListaDeMateriales_Load(object sender, EventArgs e)
        {
            this.mATERIALESTableAdapter.Fill(this.sISTEMAFLETESACARREOSDataSet.MATERIALES);
            if (Login.nivel == "1")
            {
                btn_Editar.Visible = true;
                btn_Eliminar.Visible = true;
            }
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            int resultado = Int32.Parse(dgv_ListaMateriales.Rows[Int32.Parse(dgv_ListaMateriales.CurrentRow.Index.ToString())].Cells[0].Value.ToString());
            
            //if (resultado != 1)
            //{
                ModeloMateriales.eliminarMaterial(resultado);
                MessageBox.Show("El Material " + resultado + " ha sido eliminado");
            this.mATERIALESTableAdapter.Fill(this.sISTEMAFLETESACARREOSDataSet.MATERIALES);
            lbl_SetIdMaterial.Text = "";
                lbl_SetNombre.Text = "";
                lbl_SetPrecio.Text = "";
            //}
            //else
            //{
            //ModeloMateriales.eliminarMaterial(resultado);

            //int indice = Int32.Parse(dgv_ListaMateriales.CurrentRow.Index.ToString());
            //int IdParametro = Int32.Parse(dgv_ListaMateriales.Rows[indice].Cells[0].Value.ToString());
            //string nombre = dgv_ListaMateriales.Rows[indice].Cells[1].Value.ToString();
            //int precio = Int32.Parse(dgv_ListaMateriales.Rows[indice].Cells[2].Value.ToString());
            //mATERIALESTableAdapter2.Delete(IdParametro, nombre, precio);
            //MessageBox.Show("El Material " + resultado + " ha sido eliminado");
            //this.mATERIALESTableAdapter2.Fill(this.sISTEMAFLETESACARREOSDataSet7.MATERIALES);
            //lbl_SetIdMaterial.Text = "";
            //lbl_SetNombre.Text = "";
            //lbl_SetPrecio.Text = "";
            //}
            this.mATERIALESTableAdapter.Fill(this.sISTEMAFLETESACARREOSDataSet.MATERIALES);
        }

        private void ListaDeMateriales_Activated(object sender, EventArgs e)
        {
            this.mATERIALESTableAdapter.Fill(this.sISTEMAFLETESACARREOSDataSet.MATERIALES);
        }

        private void dgv_ListaMateriales_MouseEnter(object sender, EventArgs e)
        {
            int xd = Int32.Parse(dgv_ListaMateriales.Rows.Count.ToString());
            if (xd != 0)
            {
                int indice = Int32.Parse(dgv_ListaMateriales.CurrentRow.Index.ToString());
                int IdParametro = Int32.Parse(dgv_ListaMateriales.Rows[indice].Cells[0].Value.ToString());
                lbl_SetIdMaterial.Text = IdParametro.ToString();
                lbl_SetNombre.Text = dgv_ListaMateriales.Rows[indice].Cells[1].Value.ToString();
                lbl_SetPrecio.Text = dgv_ListaMateriales.Rows[indice].Cells[2].Value.ToString();
            }
        }

        private void btnInvertir_Click(object sender, EventArgs e)
        {
            var collection = new WordsCollection();
            collection.AddItem(lbl_SetIdMaterial.Text);

            collection.ReverseDirection();

            dgv_ListaMateriales.Sort(dgv_ListaMateriales.Columns[0], ListSortDirection.Descending);
        }

        private void dgv_ListaMateriales_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int FilaIndice = Int32.Parse(dgv_ListaMateriales.CurrentRow.Index.ToString());
            if (dgv_ListaMateriales.Rows[FilaIndice].Cells[0].Selected == true)
            {
                dgv_ListaMateriales.Rows[FilaIndice].Cells[0].ReadOnly = true;
            }
        }

        private void dgv_ListaMateriales_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int xd = Int32.Parse(dgv_ListaMateriales.Rows.Count.ToString());
            if (xd != 0)
            {
                int indice = Int32.Parse(dgv_ListaMateriales.CurrentRow.Index.ToString());
                int IdParametro = Int32.Parse(dgv_ListaMateriales.Rows[indice].Cells[0].Value.ToString());
                lbl_SetIdMaterial.Text = IdParametro.ToString();
                lbl_SetNombre.Text = dgv_ListaMateriales.Rows[indice].Cells[1].Value.ToString();
                lbl_SetPrecio.Text = dgv_ListaMateriales.Rows[indice].Cells[2].Value.ToString();
            }
        }
    }
}
