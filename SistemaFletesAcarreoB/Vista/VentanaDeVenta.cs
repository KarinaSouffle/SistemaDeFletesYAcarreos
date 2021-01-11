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
    public partial class VentanaDeVenta : Form
    {
        Pantalla_Principal VPPV;
        public VentanaDeVenta()
        {
            InitializeComponent();
            panel1.Location = new Point(((panel1.Width / 8)), (panel1.Width) / 8);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Venta cancelada");
            VPPV = new Pantalla_Principal();
            VPPV.Show();
            this.Hide();
        }

        private void btn_VolverPKPP_Click(object sender, EventArgs e)
        {
            int TotalVentas = (Int32.Parse(dgv_Venta.Rows.Count.ToString()));
            int xd = Convert.ToInt32(this.dgv_Kilometro.Rows.Count.ToString());
            for (int i = 0; i < TotalVentas - 1; i++)
            {
                var nuevaFactura = new FACTURA();
                nuevaFactura.Maquina = Int32.Parse(dgv_Venta.Rows[i].Cells[0].Value.ToString());
                nuevaFactura.Fecha = dtp_FechaHora.Value.ToString("dd/MM/yyyy");
                nuevaFactura.Hora = dtp_FechaHora.Value.ToString("HH:mm");
                nuevaFactura.Materiales = dgv_Venta.Rows[i].Cells[3].Value.ToString();
                nuevaFactura.Total_metros = Int32.Parse(dgv_Venta.Rows[i].Cells[4].Value.ToString());
                nuevaFactura.Total_viajes = Int32.Parse(dgv_Venta.Rows[i].Cells[5].Value.ToString());
                nuevaFactura.Subtotal = Int32.Parse(lbl_SetSubtotal.Text);
                nuevaFactura.IVA = Int32.Parse(lbl_SetIVA.Text);
                nuevaFactura.Total = Int32.Parse(lbl_SetTotal.Text);
                nuevaFactura.Fact_material = Int32.Parse(dgv_Venta.Rows[i].Cells[2].Value.ToString()); ;
                nuevaFactura.Fact_licencia = Int32.Parse(lbl_SetChofer.Text);
                nuevaFactura.Fact_placas = Int32.Parse(dgv_Venta.Rows[i].Cells[1].Value.ToString()); ;
                nuevaFactura.Fact_Kilometro = Int32.Parse(dgv_Kilometro.Rows[xd - 2].Cells[0].Value.ToString());
                try
                {
                    ControladorFactura.CrearFactura(nuevaFactura);
                }
                catch (Exception ex)
                {

                    throw new Exception("Error en los datos: " + ex.Message);
                }
            }
            MessageBox.Show("Datos añadidos exitosamente");
            VPPV = new Pantalla_Principal();
            VPPV.Show();
            this.Hide();
        }

        private void btn_AMaterial_Click(object sender, EventArgs e)
        {
            dgv_Material.Visible = true;
            this.mATERIALESTableAdapter.Fill(this.sISTEMAFLETESACARREOSDataSet8.MATERIALES);

        }

        private void btn_AChofer_Click(object sender, EventArgs e)
        {
            dgv_Chofer.Visible = true;
            this.cHOFERTableAdapter.Fill(this.sISTEMAFLETESACARREOSDataSet8.CHOFER);
        }

        private void btn_AVehiculo_Click(object sender, EventArgs e)
        {
            dgv_Auto.Visible = true;
            this.aUTOSTableAdapter.Fill(this.sISTEMAFLETESACARREOSDataSet8.AUTOS);
        }

        private void panel1_MouseHover(object sender, EventArgs e)
        {
        }

        private void VentanaDeVenta_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sISTEMAFLETESACARREOSDataSet8.FACTURA' Puede moverla o quitarla según sea necesario.
            this.fACTURATableAdapter.Fill(this.sISTEMAFLETESACARREOSDataSet8.FACTURA);
            // TODO: esta línea de código carga datos en la tabla 'sISTEMAFLETESACARREOSDataSet8.KILOMETRO' Puede moverla o quitarla según sea necesario.
            this.kILOMETROTableAdapter.Fill(this.sISTEMAFLETESACARREOSDataSet8.KILOMETRO);
            // TODO: esta línea de código carga datos en la tabla 'sISTEMAFLETESACARREOSDataSet8.AUTOS' Puede moverla o quitarla según sea necesario.
            this.aUTOSTableAdapter.Fill(this.sISTEMAFLETESACARREOSDataSet8.AUTOS);
            // TODO: esta línea de código carga datos en la tabla 'sISTEMAFLETESACARREOSDataSet8.CHOFER' Puede moverla o quitarla según sea necesario.
            this.cHOFERTableAdapter.Fill(this.sISTEMAFLETESACARREOSDataSet8.CHOFER);
            // TODO: esta línea de código carga datos en la tabla 'sISTEMAFLETESACARREOSDataSet8.MATERIALES' Puede moverla o quitarla según sea necesario.
            this.mATERIALESTableAdapter.Fill(this.sISTEMAFLETESACARREOSDataSet8.MATERIALES);

            lbl_SetIVA.Text = 16 + "";
            int indice = Int32.Parse(dgv_Venta.Rows.Count.ToString());
            int xd = Convert.ToInt32(this.dgv_FacturacionConsulta.Rows.Count.ToString());

            if (xd > 1)
            {
                int valor = Convert.ToInt32(dgv_FacturacionConsulta.Rows[xd - 2].Cells[1].Value.ToString());
                dgv_Venta.Rows[indice - 1].Cells[0].Value = valor+1;
                lbl_SetNumero.Text = (valor+1).ToString();
            }
            else
            {
                dgv_Venta.Rows[indice - 1].Cells[0].Value = 1;
                lbl_SetNumero.Text = 1 + "";
            }

        }

        private void dgv_Material_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                int FilaVenta = Convert.ToInt32(this.dgv_Venta.Rows.Count.ToString());
                if (FilaVenta == 1)
                {
                    int indicematerial = Int32.Parse(dgv_Material.CurrentRow.Index.ToString());
                    int IdParametromaterial = Int32.Parse(dgv_Material.Rows[indicematerial].Cells[0].Value.ToString());
                    int xd = Convert.ToInt32(this.dgv_Kilometro.Rows.Count.ToString());

                    if (indicematerial >= 1)
                    {
                        dgv_Venta.Rows[indicematerial - 1].Cells[2].Value = IdParametromaterial;
                        if (xd > 1)
                        {
                            dgv_Venta.Rows[indicematerial - 1].Cells[6].Value = dgv_Kilometro.Rows[xd - 2].Cells[1].Value.ToString();
                        }
                    }
                    else
                    {
                        dgv_Venta.Rows[indicematerial].Cells[2].Value = IdParametromaterial;
                        if (xd > 1)
                        {
                            dgv_Venta.Rows[indicematerial].Cells[6].Value = dgv_Kilometro.Rows[xd - 2].Cells[1].Value.ToString();
                        }
                    }
                    if (indicematerial >= 1)
                    {
                        dgv_Venta.Rows[indicematerial - 1].Cells[3].Value = dgv_Material.Rows[indicematerial].Cells[1].Value.ToString();
                    }
                    else
                    {
                        dgv_Venta.Rows[indicematerial].Cells[3].Value = dgv_Material.Rows[indicematerial].Cells[1].Value.ToString();
                    }

                }
                else
                {
                    int indiceventa = (Int32.Parse(this.dgv_Venta.Rows.Count.ToString())) - 1;
                    int indicematerial = Int32.Parse(dgv_Material.CurrentRow.Index.ToString());
                    int IdParametromaterial = Int32.Parse(dgv_Material.Rows[indicematerial].Cells[0].Value.ToString());
                    int xd = Convert.ToInt32(this.dgv_Kilometro.Rows.Count.ToString());

                    dgv_Venta.Rows[indiceventa].Cells[2].Value = IdParametromaterial;
                    dgv_Venta.Rows[indiceventa].Cells[3].Value = dgv_Material.Rows[indicematerial].Cells[1].Value.ToString();
                    if (xd > 1)
                    {
                        dgv_Venta.Rows[indicematerial].Cells[6].Value = dgv_Kilometro.Rows[xd - 2].Cells[1].Value.ToString();
                    }
                }
                int indice = (Int32.Parse(dgv_Venta.Rows.Count.ToString()));
                for (int i = 1; i < indice; i++)
                {
                    dgv_Venta.Rows[indice - 1].Cells[0].Value = dgv_Venta.Rows[0].Cells[0].Value;
                    dgv_Venta.Rows[indice - 1].Cells[6].Value = dgv_Venta.Rows[0].Cells[6].Value;
                }
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show("Seleccionaste una opcion fuera de rango, repite la operacion.", "Error", MessageBoxButtons.OK);
            }
            dgv_Material.Visible = false;
        }

        private void dgv_Chofer_MouseClick(object sender, MouseEventArgs e)
        {
            int indice = Int32.Parse(dgv_Chofer.CurrentRow.Index.ToString());
            int IdParametro = Int32.Parse(dgv_Chofer.Rows[indice].Cells[0].Value.ToString());
            if (IdParametro > 0)
            {
                lbl_SetChofer.Text = IdParametro.ToString();
                dgv_Chofer.Visible = false;
            }
            else
            {
                MessageBox.Show("Seleccionaste una opcion fuera de rango, repite la operacion.", "Error", MessageBoxButtons.OK);
            }
        }

        private void dgv_Auto_MouseClick(object sender, MouseEventArgs e)
        {
            int FilaVenta = Convert.ToInt32(this.dgv_Venta.Rows.Count.ToString());
            if (FilaVenta == 1)
            {
                int indiceauto = Int32.Parse(dgv_Auto.CurrentRow.Index.ToString());
                int IdParametroauto = Int32.Parse(dgv_Auto.Rows[indiceauto].Cells[0].Value.ToString());
                if (IdParametroauto > 0)
                {
                    if (indiceauto >= 1)
                    {
                        dgv_Venta.Rows[indiceauto - 1].Cells[1].Value = IdParametroauto;
                    }
                    else
                    {
                        dgv_Venta.Rows[indiceauto].Cells[1].Value = IdParametroauto;
                    }
                }
                else
                {
                    MessageBox.Show("Seleccionaste una opcion fuera de rango, repite la operacion.", "Error", MessageBoxButtons.OK);
                }
            }
            else
            {
                int indiceventa = (Int32.Parse(this.dgv_Venta.Rows.Count.ToString())) - 1;
                int indiceauto = Int32.Parse(dgv_Auto.CurrentRow.Index.ToString());
                int IdParametroauto = Int32.Parse(dgv_Auto.Rows[indiceauto].Cells[0].Value.ToString());

                dgv_Venta.Rows[indiceventa].Cells[1].Value = IdParametroauto;
            }
            dgv_Auto.Visible = false;
        }

        private void dgv_Venta_MouseEnter(object sender, EventArgs e)
        {
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            int TotalVentas = (Int32.Parse(dgv_Venta.Rows.Count.ToString()));
            int SumadorKilometro = 0;
            for (int i = 0; i < TotalVentas-1; i++)
            {
                int KMRec = Int32.Parse(dgv_Venta.Rows[i].Cells[5].Value.ToString());
                int PrecKM = Int32.Parse(dgv_Venta.Rows[0].Cells[6].Value.ToString());
                SumadorKilometro = SumadorKilometro + (KMRec * PrecKM);
            }
            double SumaIva = SumadorKilometro * .16;
            lbl_SetSubtotal.Text = SumadorKilometro + "";
            SumadorKilometro = SumadorKilometro + Convert.ToInt32(SumaIva);
            lbl_SetTotal.Text = SumadorKilometro + "";
            btn_Aceptar.Visible = true;
        }
    }
}
