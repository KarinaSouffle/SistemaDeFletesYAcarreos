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
using SistemaFletesAcarreoB.Vista;

namespace SistemaFletesAcarreoB
{
    public partial class VentanaDeVenta : Form
    {
        Pantalla_Principal VPPV;
        public VentanaDeVenta()
        {
            InitializeComponent();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            lbl_SetIVA.Text = 16 + "";
            int indice = Int32.Parse(dgv_Venta.Rows.Count.ToString());
            int xd = Convert.ToInt32(this.dgv_FacturacionConsulta.Rows.Count.ToString());

            if (xd > 1)
            {
                int valor = Convert.ToInt32(dgv_FacturacionConsulta.Rows[xd - 2].Cells[1].Value.ToString());
                dgv_Venta.Rows[indice - 1].Cells[0].Value = valor + 1;
                lbl_SetNumero.Text = (valor + 1).ToString();
            }
            else
            {
                dgv_Venta.Rows[indice - 1].Cells[0].Value = 1;
                lbl_SetNumero.Text = 1 + "";
            }
        }

        private void btn_VolverPKPP_Click(object sender, EventArgs e)
        {
            VisorFactura vf = new VisorFactura();
            btn_Aceptar.Visible = false;
            int TotalVentas = (Int32.Parse(dgv_Venta.Rows.Count.ToString()));
            int xd = Convert.ToInt32(this.dgv_Kilometro.Rows.Count.ToString());
            int cantidaddatos = Int32.Parse(dgv_FacturacionConsulta.Rows.Count.ToString());
            Validar validar = new Validar();
            if (TotalVentas >= 1)
            {
                if (TotalVentas >= 1)
                {
                    for (int i = 0; i < TotalVentas - 1; i++)
                    {
                        try
                        {
                            var nuevaFactura = new FACTURA();
                            nuevaFactura.Num_Factura = Int32.Parse(lbl_SetNumero.Text);
                            nuevaFactura.Fecha = dtp_FechaHora.Value.ToString("dd/MM/yyyy");
                            nuevaFactura.Hora = dtp_FechaHora.Value.ToString("HH:mm");
                            nuevaFactura.Materiales = dgv_Venta.Rows[i].Cells[4].Value.ToString();
                            nuevaFactura.Total_metros = dgv_Venta.Rows[i].Cells[5].Value.ToString();
                            nuevaFactura.Total_viajes = Math.Round(float.Parse(dgv_Venta.Rows[i].Cells[6].Value.ToString()), 2);
                            nuevaFactura.Total_Kilometros = Math.Round(float.Parse(dgv_Venta.Rows[i].Cells[7].Value.ToString()), 2);
                            nuevaFactura.Subtotal = Math.Round(float.Parse(lbl_SetSubtotal.Text), 2);
                            nuevaFactura.IVA = Math.Round(float.Parse(lbl_SetIVA.Text), 2);
                            nuevaFactura.Total = Math.Round(float.Parse(lbl_SetTotal.Text), 2);
                            nuevaFactura.Fact_material = dgv_Venta.Rows[i].Cells[2].Value.ToString(); ;
                            nuevaFactura.Fact_licencia = lbl_SetChofer.Text.ToString();
                            nuevaFactura.Fact_placas = dgv_Venta.Rows[i].Cells[9].Value.ToString();
                            nuevaFactura.Fact_Kilometro = dgv_Kilometro.Rows[xd - 2].Cells[1].Value.ToString();
                            ControladorFactura.CrearFactura(nuevaFactura);

                            
                            
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Hubo un error: " + ex + " ", "Error", MessageBoxButtons.OK);
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < TotalVentas - 1; i++)
                    {
                        try
                        {
                            var nuevaFactura = new FACTURA();
                            nuevaFactura.Num_Factura = Int32.Parse(lbl_SetNumero.Text);
                            nuevaFactura.Fecha = dtp_FechaHora.Value.ToString("dd/MM/yyyy");
                            nuevaFactura.Hora = dtp_FechaHora.Value.ToString("HH:mm");
                            nuevaFactura.Materiales = dgv_Venta.Rows[i].Cells[4].Value.ToString();
                            nuevaFactura.Total_metros = dgv_Venta.Rows[i].Cells[5].Value.ToString();
                            nuevaFactura.Total_viajes = Math.Round(float.Parse(dgv_Venta.Rows[i].Cells[6].Value.ToString()), 2);
                            nuevaFactura.Total_Kilometros = Math.Round(float.Parse(dgv_Venta.Rows[i].Cells[7].Value.ToString()), 2);
                            nuevaFactura.Subtotal = Math.Round(float.Parse(lbl_SetSubtotal.Text), 2);
                            nuevaFactura.IVA = Math.Round(float.Parse(lbl_SetIVA.Text), 2);
                            nuevaFactura.Total = Math.Round(float.Parse(lbl_SetTotal.Text), 2);
                            nuevaFactura.Fact_material = dgv_Venta.Rows[i].Cells[2].Value.ToString();
                            nuevaFactura.Fact_licencia = lbl_SetChofer.Text.ToString();
                            nuevaFactura.Fact_placas = dgv_Venta.Rows[i].Cells[9].Value.ToString();
                            nuevaFactura.Fact_Kilometro = dgv_Kilometro.Rows[xd - 2].Cells[1].Value.ToString();
                            ControladorFactura.CrearFactura(nuevaFactura);
                            
                            
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Hubo un error: " + ex + " ", "Error", MessageBoxButtons.OK);
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < TotalVentas - 1; i++)
                {
                    try
                    {
                        var nuevaFactura = new FACTURA();
                        nuevaFactura.Num_Factura = Int32.Parse(lbl_SetNumero.Text);
                        nuevaFactura.Fecha = dtp_FechaHora.Value.ToString("dd/MM/yyyy");
                        nuevaFactura.Hora = dtp_FechaHora.Value.ToString("HH:mm");
                        nuevaFactura.Materiales = dgv_Venta.Rows[i].Cells[4].Value.ToString();
                        nuevaFactura.Total_metros = dgv_Venta.Rows[i].Cells[5].Value.ToString();
                        nuevaFactura.Total_viajes = Math.Round(float.Parse(dgv_Venta.Rows[i].Cells[6].Value.ToString()), 2);
                        nuevaFactura.Total_Kilometros = Math.Round(float.Parse(dgv_Venta.Rows[i].Cells[7].Value.ToString()), 2);
                        nuevaFactura.Subtotal = Math.Round(float.Parse(lbl_SetSubtotal.Text), 2);
                        nuevaFactura.IVA = Math.Round(float.Parse(lbl_SetIVA.Text), 2);
                        nuevaFactura.Total = Math.Round(float.Parse(lbl_SetTotal.Text), 2);
                        nuevaFactura.Fact_material = dgv_Venta.Rows[i].Cells[2].Value.ToString();
                        nuevaFactura.Fact_licencia = lbl_SetChofer.Text.ToString();
                        nuevaFactura.Fact_placas = dgv_Venta.Rows[i].Cells[9].Value.ToString();
                        nuevaFactura.Fact_Kilometro = dgv_Kilometro.Rows[xd - 2].Cells[1].Value.ToString();
                        ControladorFactura.CrearFactura(nuevaFactura);
                        
                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hubo un error: " + ex + " ", "Error", MessageBoxButtons.OK);
                    }
                }
            }
            MessageBox.Show("Factura Registrada", "Listo", MessageBoxButtons.OK);
            loading();
            vf.Show();

            int indicechofer = Int32.Parse(dgv_Chofer.CurrentRow.Index.ToString());
            int IdParametrochofer = Int32.Parse(dgv_Chofer.Rows[indicechofer].Cells[0].Value.ToString());

            string disp = dgv_Chofer.Rows[indicechofer].Cells[11].Value.ToString();
            if (IdParametrochofer > 0)
            {
                if (disp == "1")
                {
                    if (indicechofer >= 1)
                    {
                        if (indicechofer >= 1)
                        {
                            var nuevoChofer = new CHOFER();
                            nuevoChofer.lICENCIA_C = dgv_Chofer.Rows[indicechofer].Cells[1].Value.ToString();
                            nuevoChofer.N_Chofer = dgv_Chofer.Rows[indicechofer].Cells[2].Value.ToString();
                            nuevoChofer.ApellidoP_C = dgv_Chofer.Rows[indicechofer].Cells[3].Value.ToString();
                            nuevoChofer.ApellidoM_C = dgv_Chofer.Rows[indicechofer].Cells[4].Value.ToString();
                            nuevoChofer.Sexo = dgv_Chofer.Rows[indicechofer].Cells[5].Value.ToString();
                            nuevoChofer.Edad = dgv_Chofer.Rows[indicechofer].Cells[6].Value.ToString();
                            nuevoChofer.Telefono = dgv_Chofer.Rows[indicechofer].Cells[7].Value.ToString();
                            nuevoChofer.Correo = dgv_Chofer.Rows[indicechofer].Cells[8].Value.ToString();
                            nuevoChofer.F_Nac = Convert.ToDateTime(dgv_Chofer.Rows[indicechofer].Cells[9].Value.ToString());
                            nuevoChofer.Direccion = dgv_Chofer.Rows[indicechofer].Cells[10].Value.ToString();
                            nuevoChofer.Disponible = "2";
                            ControladorChofer.EliminarChofer(IdParametrochofer);
                            ControladorChofer.CrearChofer(nuevoChofer);
                        }
                        else
                        {
                            var nuevoChofer = new CHOFER();
                            nuevoChofer.lICENCIA_C = dgv_Chofer.Rows[indicechofer].Cells[1].Value.ToString();
                            nuevoChofer.N_Chofer = dgv_Chofer.Rows[indicechofer].Cells[2].Value.ToString();
                            nuevoChofer.ApellidoP_C = dgv_Chofer.Rows[indicechofer].Cells[3].Value.ToString();
                            nuevoChofer.ApellidoM_C = dgv_Chofer.Rows[indicechofer].Cells[4].Value.ToString();
                            nuevoChofer.Sexo = dgv_Chofer.Rows[indicechofer].Cells[5].Value.ToString();
                            nuevoChofer.Edad = dgv_Chofer.Rows[indicechofer].Cells[6].Value.ToString();
                            nuevoChofer.Telefono = dgv_Chofer.Rows[indicechofer].Cells[7].Value.ToString();
                            nuevoChofer.Correo = dgv_Chofer.Rows[indicechofer].Cells[8].Value.ToString();
                            nuevoChofer.F_Nac = Convert.ToDateTime(dgv_Chofer.Rows[indicechofer].Cells[9].Value.ToString());
                            nuevoChofer.Direccion = dgv_Chofer.Rows[indicechofer].Cells[10].Value.ToString();
                            nuevoChofer.Disponible = "2";
                            ControladorChofer.EliminarChofer(IdParametrochofer);
                            ControladorChofer.CrearChofer(nuevoChofer);
                        }
                    }
                    else
                    {
                        var nuevoChofer = new CHOFER();
                        nuevoChofer.lICENCIA_C = dgv_Chofer.Rows[indicechofer].Cells[1].Value.ToString();
                        nuevoChofer.N_Chofer = dgv_Chofer.Rows[indicechofer].Cells[2].Value.ToString();
                        nuevoChofer.ApellidoP_C = dgv_Chofer.Rows[indicechofer].Cells[3].Value.ToString();
                        nuevoChofer.ApellidoM_C = dgv_Chofer.Rows[indicechofer].Cells[4].Value.ToString();
                        nuevoChofer.Sexo = dgv_Chofer.Rows[indicechofer].Cells[5].Value.ToString();
                        nuevoChofer.Edad = dgv_Chofer.Rows[indicechofer].Cells[6].Value.ToString();
                        nuevoChofer.Telefono = dgv_Chofer.Rows[indicechofer].Cells[7].Value.ToString();
                        nuevoChofer.Correo = dgv_Chofer.Rows[indicechofer].Cells[8].Value.ToString();
                        nuevoChofer.F_Nac = Convert.ToDateTime(dgv_Chofer.Rows[indicechofer].Cells[9].Value.ToString());
                        nuevoChofer.Direccion = dgv_Chofer.Rows[indicechofer].Cells[10].Value.ToString();
                        nuevoChofer.Disponible = "2";
                        ControladorChofer.EliminarChofer(IdParametrochofer);
                        ControladorChofer.CrearChofer(nuevoChofer);

                    }
                }
            }

            this.fACTURATableAdapter.Fill(this.sISTEMAFLETESACARREOSDataSet.FACTURA);
            //int cantidadnuevasventas = Int32.Parse(dgv_FacturacionConsulta.Rows.Count.ToString());
            //if (cantidadnuevasventas > cantidaddatos)
            //{
            //    MessageBox.Show("Factura Registrada", "Listo", MessageBoxButtons.OK);
            //}
            dgv_Venta.Rows.Clear();
            lbl_SetChofer.Text = "";
            lbl_SetSubtotal.Text = "";
            lbl_SetTotal.Text = "";
            lbl_SetIVA.Text = 16 + "";
            int indice = Int32.Parse(dgv_Venta.Rows.Count.ToString());
            int xdFac = Convert.ToInt32(this.dgv_FacturacionConsulta.Rows.Count.ToString());

            if (xdFac > 1)
            {
                int valor = Convert.ToInt32(dgv_FacturacionConsulta.Rows[xdFac - 2].Cells[1].Value.ToString());
                dgv_Venta.Rows[indice - 1].Cells[0].Value = valor + 1;
                lbl_SetNumero.Text = (valor + 1).ToString();
            }
            else
            {
                dgv_Venta.Rows[indice - 1].Cells[0].Value = 1;
                lbl_SetNumero.Text = 1 + "";
            }
            VentanaDeVenta nv = new VentanaDeVenta();
            loading();
            int indicexd = Int32.Parse(dgv_Venta.Rows.Count.ToString());
            int xdd = Convert.ToInt32(this.dgv_FacturacionConsulta.Rows.Count.ToString());

            if (xdd > 1)
            {
                int valor = Convert.ToInt32(dgv_FacturacionConsulta.Rows[xdd - 2].Cells[1].Value.ToString());
                dgv_Venta.Rows[indicexd - 1].Cells[0].Value = valor + 1;
                lbl_SetNumero.Text = (valor + 1).ToString();
            }
            else
            {
                dgv_Venta.Rows[indicexd - 1].Cells[0].Value = 1;
                lbl_SetNumero.Text = 1 + "";
            }
        }

        private void btn_AMaterial_Click(object sender, EventArgs e)
        {
            if (dgv_Material.Visible == true)
            {
                dgv_Material.Visible = false;
            }
            else
            {
                dgv_Material.Visible = true;
            }
            this.mATERIALESTableAdapter.Fill(this.sISTEMAFLETESACARREOSDataSet.MATERIALES);

        }

        private void btn_AChofer_Click(object sender, EventArgs e)
        {
            if (dgv_Chofer.Visible == true)
            {
                dgv_Chofer.Visible = false;
            }
            else
            {
                dgv_Chofer.Visible = true;
            }
            string busqueda = "1";
            var buscardisponible = ControladorChofer.BuscarChoferesPorDisponibilidad(busqueda);

            dgv_Chofer.DataSource = buscardisponible;

        }

        private void btn_AVehiculo_Click(object sender, EventArgs e)
        {
            if (dgv_Auto.Visible == true)
            {
                dgv_Auto.Visible = false;
            }
            else
            {
                dgv_Auto.Visible = true;
            }
            this.aUTOSTableAdapter3.Fill(this.sISTEMAFLETESACARREOSDataSet20.AUTOS);
        }

        private void panel1_MouseHover(object sender, EventArgs e)
        {
        }

        public void loading()
        {
            // TODO: esta línea de código carga datos en la tabla 'sISTEMAFLETESACARREOSDataSet19.FACTURA' Puede moverla o quitarla según sea necesario.
            this.fACTURATableAdapter.Fill(this.sISTEMAFLETESACARREOSDataSet.FACTURA);
            // TODO: esta línea de código carga datos en la tabla 'sISTEMAFLETESACARREOSDataSet16.KILOMETRO' Puede moverla o quitarla según sea necesario.
            this.kILOMETROTableAdapter.Fill(this.sISTEMAFLETESACARREOSDataSet.KILOMETRO);
            // TODO: esta línea de código carga datos en la tabla 'sISTEMAFLETESACARREOSDataSet16.AUTOS' Puede moverla o quitarla según sea necesario.
            this.aUTOSTableAdapter.Fill(this.sISTEMAFLETESACARREOSDataSet.AUTOS);
            // TODO: esta línea de código carga datos en la tabla 'sISTEMAFLETESACARREOSDataSet16.CHOFER' Puede moverla o quitarla según sea necesario.
            this.cHOFERTableAdapter.Fill(this.sISTEMAFLETESACARREOSDataSet.CHOFER);
            // TODO: esta línea de código carga datos en la tabla 'sISTEMAFLETESACARREOSDataSet16.MATERIALES' Puede moverla o quitarla según sea necesario.
            this.mATERIALESTableAdapter.Fill(this.sISTEMAFLETESACARREOSDataSet.MATERIALES);

            lbl_SetIVA.Text = 16 + "";
            int indice = Int32.Parse(dgv_Venta.Rows.Count.ToString());
            int xd = Convert.ToInt32(this.dgv_FacturacionConsulta.Rows.Count.ToString());

            if (xd > 1)
            {
                int valor = Convert.ToInt32(dgv_FacturacionConsulta.Rows[xd - 2].Cells[1].Value.ToString());
                dgv_Venta.Rows[indice - 1].Cells[0].Value = valor + 1;
                dgv_Venta.Rows[indice - 1].Cells[8].Value = dgv_Kilometro.Rows[Convert.ToInt32(dgv_Kilometro.Rows.Count.ToString())-1].Cells[1].Value.ToString();
                lbl_SetNumero.Text = (valor + 1).ToString();
            }
            else
            {
                dgv_Venta.Rows[indice - 1].Cells[0].Value = 1;
                dgv_Venta.Rows[indice - 1].Cells[8].Value = dgv_Kilometro.Rows[Convert.ToInt32(dgv_Kilometro.Rows.Count.ToString())-1].Cells[1].Value.ToString();
                lbl_SetNumero.Text = 1 + "";
            }
        }
        public void VentanaDeVenta_Load(object sender, EventArgs e)
        {
            loading();
        }

        private void dgv_Material_MouseClick(object sender, MouseEventArgs e)//MATERIAL
        {
            int FilaVenta = Convert.ToInt32(this.dgv_Venta.Rows.Count.ToString());
            if (FilaVenta == 1)
            {
                int indiceventa = (Int32.Parse(this.dgv_Venta.Rows.Count.ToString())) - 1;
                int indicematerial = Int32.Parse(dgv_Material.CurrentRow.Index.ToString());
                int IdParametromaterial = Int32.Parse(dgv_Material.Rows[indicematerial].Cells[0].Value.ToString());
                if (IdParametromaterial > 0)
                {
                    if (indicematerial >= 1)
                    {
                        dgv_Venta.Rows[indiceventa].Cells[2].Value = IdParametromaterial;
                        dgv_Venta.Rows[indiceventa].Cells[3].Value = dgv_Material.Rows[indicematerial].Cells[2].Value.ToString();
                        dgv_Venta.Rows[indiceventa].Cells[4].Value = dgv_Material.Rows[indicematerial].Cells[1].Value.ToString();
                    }
                    else
                    {
                        dgv_Venta.Rows[indiceventa].Cells[2].Value = IdParametromaterial;
                        dgv_Venta.Rows[indiceventa].Cells[3].Value = dgv_Material.Rows[indicematerial].Cells[2].Value.ToString();
                        dgv_Venta.Rows[indiceventa].Cells[4].Value = dgv_Material.Rows[indicematerial].Cells[1].Value.ToString();
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
                int indicematerial = Int32.Parse(dgv_Material.CurrentRow.Index.ToString());
                int IdParametromaterial = Int32.Parse(dgv_Material.Rows[indicematerial].Cells[0].Value.ToString());

                dgv_Venta.Rows[indiceventa].Cells[2].Value = IdParametromaterial;
                dgv_Venta.Rows[indiceventa].Cells[3].Value = dgv_Material.Rows[indicematerial].Cells[2].Value.ToString();
                dgv_Venta.Rows[indiceventa].Cells[4].Value = dgv_Material.Rows[indicematerial].Cells[1].Value.ToString();
            }
            dgv_Material.Visible = false;
            if (dgv_Material.AllowUserToAddRows == false)
            {
                dgv_Material.AllowUserToAddRows = true;
            }

        }

        private void dgv_Chofer_MouseClick(object sender, MouseEventArgs e)
        {
            int indiceventa = (Int32.Parse(this.dgv_Venta.Rows.Count.ToString())) - 1;
            int indicechofer = Int32.Parse(dgv_Chofer.CurrentRow.Index.ToString());
            int IdParametrochofer = Int32.Parse(dgv_Chofer.Rows[indicechofer].Cells[0].Value.ToString());
            string lice = dgv_Chofer.Rows[indicechofer].Cells[1].Value.ToString();

            string disp = dgv_Chofer.Rows[indicechofer].Cells[11].Value.ToString();
            if (IdParametrochofer > 0)
            {
                if (disp == "1")
                {
                    if (indicechofer >= 1)
                    {
                        //MessageBox.Show("El Chofer esta disponible.", "Disponible", MessageBoxButtons.OK);
                        lbl_SetChofer.Text = lice.ToString();
                    }
                    else
                    {
                        //MessageBox.Show("El Chofer esta disponible.", "Disponible", MessageBoxButtons.OK);
                        lbl_SetChofer.Text = lice.ToString();

                    }
                }
                else
                {
                    //MessageBox.Show("El Chofer no esta disponible.", "Error", MessageBoxButtons.OK);
                }
                dgv_Chofer.Visible = false;
            }
            else
            {
                MessageBox.Show("Seleccionaste una opcion fuera de rango, repite la operacion.", "Error", MessageBoxButtons.OK);
            }
            if (dgv_Venta.AllowUserToAddRows == false)
            {
                dgv_Venta.AllowUserToAddRows = true;
            }
        }

        private void dgv_Auto_MouseClick(object sender, MouseEventArgs e)
        {
            int FilaVenta = Convert.ToInt32(this.dgv_Venta.Rows.Count.ToString());
            if (FilaVenta == 1)
            {
                int indiceventa = (Int32.Parse(this.dgv_Venta.Rows.Count.ToString())) - 1;
                int indiceauto = Int32.Parse(dgv_Auto.CurrentRow.Index.ToString());
                int IdParametroauto = Int32.Parse(dgv_Auto.Rows[indiceauto].Cells[0].Value.ToString());
                string placasset = dgv_Auto.Rows[indiceauto].Cells[1].Value.ToString();
                string CapAuto = dgv_Auto.Rows[indiceauto].Cells[4].Value.ToString();
                if (IdParametroauto > 0)
                {
                    if (indiceauto >= 1)
                    {
                        dgv_Venta.Rows[indiceventa].Cells[9].Value = placasset;
                        dgv_Venta.Rows[indiceventa].Cells[1].Value = IdParametroauto;
                        dgv_Venta.Rows[indiceventa].Cells[10].Value = CapAuto;
                    }
                    else
                    {
                        dgv_Venta.Rows[indiceauto].Cells[9].Value = placasset;
                        dgv_Venta.Rows[indiceventa].Cells[1].Value = IdParametroauto;
                        dgv_Venta.Rows[indiceventa].Cells[10].Value = CapAuto;
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
                string placasset = dgv_Auto.Rows[indiceauto].Cells[1].Value.ToString();
                string CapAuto = dgv_Auto.Rows[indiceauto].Cells[4].Value.ToString();

                dgv_Venta.Rows[indiceventa].Cells[9].Value = placasset;
                dgv_Venta.Rows[indiceventa].Cells[1].Value = IdParametroauto;
                dgv_Venta.Rows[indiceventa].Cells[10].Value = CapAuto;
            }
            dgv_Auto.Visible = false;
            if (dgv_Venta.AllowUserToAddRows == false)
            {
                dgv_Venta.AllowUserToAddRows = true;
            }
        }

        private void dgv_Venta_MouseEnter(object sender, EventArgs e)
        {
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            int TotalVentas = (Int32.Parse(dgv_Venta.Rows.Count.ToString()));
            int Columnas = (Int32.Parse(dgv_Venta.Columns.Count.ToString())); ; ;
            float SumMat = 0, SumMat1 = 0, SumMat2 = 1, SumKilo = 0, SumKilo1 = 1, SumKilo2 = 1, SumKilo3 = 0, Total = 0;
            int xd = Int32.Parse(dgv_Material.Rows.Count.ToString());
            int control = 0;
            int filaval = 0;
            int contsel = 0;
            int cd = 0;
            Validar validar = new Validar();
            for (int i = 0; i < TotalVentas - 1; i++)
            {
                try
                {
                    if (dgv_Venta.Rows[i].Cells[10].Value == null)
                    {
                        MessageBox.Show("No hay Auto seleccionado en la fila " + i + 1 + ".", "Error", MessageBoxButtons.OK);
                        dgv_Venta.AllowUserToAddRows = false;
                        control = 1;
                    }
                    else if (dgv_Venta.Rows[i].Cells[2].Value == null)
                    {
                        MessageBox.Show("No hay Material seleccionado en la fila " + i + 1 + ".", "Error", MessageBoxButtons.OK);
                        dgv_Venta.AllowUserToAddRows = false;
                        control = 1;
                    }
                    else if (lbl_SetChofer.Text.ToString() == "------")
                    {
                        MessageBox.Show("No hay Chofer seleccionado.", "Error", MessageBoxButtons.OK);
                        dgv_Venta.AllowUserToAddRows = false;
                        control = 1;
                    }
                    else if (dgv_Venta.Rows[i].Cells[5].Value == null ||
                        dgv_Venta.Rows[i].Cells[6].Value == null ||
                        dgv_Venta.Rows[i].Cells[7].Value == null)
                    {
                        control = 1;
                    }
                    else
                    {
                        string letras = dgv_Venta.Rows[i].Cells[5].Value.ToString() + dgv_Venta.Rows[i].Cells[6].Value.ToString() + dgv_Venta.Rows[i].Cells[7].Value.ToString();
                        for (int x = 0; x < letras.Length; x++)
                        {
                            if (Char.IsLetter(letras[x]))
                            {
                                control = 2;
                            }
                        }
                    }
                    if (dgv_Venta.Rows[i].Cells[5].Value != null &&
                        dgv_Venta.Rows[i].Cells[6].Value != null &&
                        dgv_Venta.Rows[i].Cells[7].Value != null)
                    {
                        if (control != 2 || control != 1)
                        {
                            if (validar.ValidarNum(dgv_Venta.Rows[i].Cells[5].Value.ToString(), "total de metros del material") == true &&
                                validar.ValidarNum(dgv_Venta.Rows[i].Cells[6].Value.ToString(), "total de viajes") == true &&
                                validar.ValidarNum(dgv_Venta.Rows[i].Cells[7].Value.ToString(), "total de kilometros recorridos por viaje") == true)
                            {
                                if (dgv_Venta.Rows[i].Cells[3].Value != null || dgv_Venta.Rows[i].Cells[1].Value != null)
                                {
                                    for (int x = 0; x < Columnas - 1; x++)
                                    {
                                        if (x == 3)
                                        {
                                            if (dgv_Venta.Rows[i].Cells[3].Value != null && dgv_Venta.Rows[i].Cells[5].Value != null)
                                            {
                                                SumMat1 = float.Parse(dgv_Venta.Rows[i].Cells[3].Value.ToString(), System.Globalization.CultureInfo.InvariantCulture);
                                                if (dgv_Venta.Rows[i].Cells[5].Value == null)
                                                {
                                                    control = 2;
                                                }
                                                else
                                                {
                                                    SumMat2 = float.Parse(dgv_Venta.Rows[i].Cells[5].Value.ToString(), System.Globalization.CultureInfo.InvariantCulture);
                                                }
                                                SumMat = SumMat1 * SumMat2;
                                            }
                                            else
                                            {
                                                contsel = 1;
                                            }
                                        }
                                        else if (x == 6 || x == 7 || x == 8)
                                        {
                                            if (dgv_Venta.Rows[i].Cells[6].Value != null &&
                                                dgv_Venta.Rows[i].Cells[7].Value != null &&
                                                dgv_Venta.Rows[i].Cells[8].Value != null)
                                            {
                                                if (dgv_Venta.Rows[i].Cells[6].Value == null ||
                                                dgv_Venta.Rows[i].Cells[7].Value == null)
                                                {
                                                    control = 2;
                                                }
                                                else
                                                {
                                                    SumKilo1 = float.Parse(dgv_Venta.Rows[i].Cells[6].Value.ToString(), System.Globalization.CultureInfo.InvariantCulture);
                                                    SumKilo2 = float.Parse(dgv_Venta.Rows[i].Cells[7].Value.ToString(), System.Globalization.CultureInfo.InvariantCulture);
                                                }
                                                SumKilo3 = float.Parse(dgv_Venta.Rows[i].Cells[8].Value.ToString(), System.Globalization.CultureInfo.InvariantCulture);
                                                SumKilo = SumKilo1 * SumKilo2 * SumKilo3;
                                            }
                                            else
                                            {
                                                contsel = 1;
                                            }

                                        }
                                    }
                                    Total = Total + SumMat + SumKilo;
                                }
                            }
                        }
                        else
                        {
                            control = 2;
                        }
                    }
                    else
                    {
                        control = 2;
                        filaval = i;
                    }

                }
                catch (Exception ex)
                {
                    if (control == 2)
                    {
                        MessageBox.Show("Hay valores con formato incorrecto", "Error", MessageBoxButtons.OK);
                        cd = 1;
                        btn_Aceptar.Visible = false;
                    }
                }
            }


            float SumaIva = float.Parse((Total * .16).ToString());
            lbl_SetIVA.Text = (Math.Round(SumaIva, 2)).ToString();
            lbl_SetSubtotal.Text = (Math.Round(Total, 2).ToString());
            float Total2 = Total + SumaIva;
            lbl_SetTotal.Text = (Math.Round(Total2, 2).ToString());
            int controlcapacidad = 0;
            if (cd != 1)
            {
                if (SumaIva == 0 || Total == 0 || Total2 == 0 ||
                SumMat == 0 || SumMat1 == 0 || SumMat2 == 1 ||
                SumKilo == 0 || SumKilo1 == 1 || SumKilo2 == 1 ||
                SumKilo3 == 0 || Total == 0)
                {

                    if (dgv_Venta.Rows[filaval].Cells[5].Value == null)
                    {
                        MessageBox.Show("El campo Total de Metros del material esta vacio en la fila " + filaval + 1 + ".", "Error", MessageBoxButtons.OK);
                    }
                    else if (dgv_Venta.Rows[filaval].Cells[6].Value == null)
                    {
                        MessageBox.Show("El campo Total de Viajes del material esta vacio en la fila " + filaval + 1 + ".", "Error", MessageBoxButtons.OK);
                    }
                    else if (dgv_Venta.Rows[filaval].Cells[7].Value == null)
                    {
                        MessageBox.Show("El campo Total de Kilometros recorridos del material esta vacio en la fila " + filaval + 1 + ".", "Error", MessageBoxButtons.OK);
                    }
                    else
                    {
                        if (contsel != 1)
                        {
                            MessageBox.Show("Hay valores vacios.", "Error", MessageBoxButtons.OK);
                        }
                    }
                    btn_Aceptar.Visible = false;
                }
                else
                {
                    for (int Fila = 0; Fila < Int32.Parse(dgv_Venta.Rows.Count.ToString()) - 1; Fila++)
                    {
                        float metros_Material = float.Parse(dgv_Venta.Rows[Fila].Cells[5].Value.ToString());
                        float metros_Auto = float.Parse(dgv_Venta.Rows[Fila].Cells[10].Value.ToString());
                        for (int Columna = 0; Columna < Int32.Parse(dgv_Venta.Columns.Count.ToString()); Columna++)
                        {
                            if (metros_Material > metros_Auto)
                            {
                                MessageBox.Show("La cantidad de metros cubicos del material en la fila " + (Fila + 1) + " sobrepasa la capacidad del auto seleccionado.", "Error", MessageBoxButtons.OK);
                                controlcapacidad = 1;
                                Columna = Int32.Parse(dgv_Venta.Columns.Count.ToString());
                                btn_Aceptar.Visible = false;
                            }
                        }
                    }
                    if (controlcapacidad != 1)
                    {
                        if (lbl_SetChofer.Text.ToString() != "------")
                        {
                            btn_Aceptar.Visible = true;
                        }
                        btn_Aceptar.Visible = true;
                    }

                }
            }

        }

        private void dgv_Venta_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int FilaIndice = Int32.Parse(dgv_Venta.CurrentRow.Index.ToString());
            int ColumnaIndice = Int32.Parse(dgv_Venta.CurrentCell.ColumnIndex.ToString());
            if (dgv_Venta.Rows[FilaIndice].Cells[ColumnaIndice].Selected == true)
            {
                if (ColumnaIndice == 5 || ColumnaIndice == 6 || ColumnaIndice == 7)
                {
                    dgv_Venta.Rows[FilaIndice].Cells[ColumnaIndice].ReadOnly = false;
                }
                else
                {
                    dgv_Venta.Rows[FilaIndice].Cells[ColumnaIndice].ReadOnly = true;
                }
            }
        }
    }
}

