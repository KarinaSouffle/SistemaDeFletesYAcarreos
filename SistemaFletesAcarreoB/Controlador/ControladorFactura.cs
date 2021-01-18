using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaFletesAcarreoB.Modelo;
using System.Windows.Forms;
using System.Globalization;

namespace SistemaFletesAcarreoB.Controlador
{
    public class ControladorFactura
    {
        public static void CrearFactura(FACTURA nuevaFactura)
        {
            string numfac = nuevaFactura.Num_Factura.ToString();
            string subtotal = nuevaFactura.Subtotal.ToString();
            string iva = nuevaFactura.IVA.ToString();
            string total = nuevaFactura.Total.ToString();
            string facmaterial = nuevaFactura.Fact_material.ToString();
            string totalviajes = nuevaFactura.Total_viajes.ToString();
            string totalkilo = nuevaFactura.Total_Kilometros.ToString();
            try
            {
                int control = 0;
                if (numfac == string.Empty ||
                    nuevaFactura.Fecha == string.Empty ||
                    nuevaFactura.Hora == string.Empty ||
                    nuevaFactura.Materiales == string.Empty ||
                    nuevaFactura.Total_metros == string.Empty ||
                    totalviajes == string.Empty ||
                    totalkilo == string.Empty ||
                    subtotal == string.Empty ||
                    iva == string.Empty ||
                    total == string.Empty ||
                    facmaterial == string.Empty ||
                    nuevaFactura.Fact_licencia == string.Empty ||
                    nuevaFactura.Fact_placas == string.Empty ||
                    nuevaFactura.Fact_Kilometro == string.Empty)
                {
                    MessageBox.Show("Hay campos vacios.", "Error", MessageBoxButtons.OK);
                }
                else
                {
                    try
                    {
                        float.Parse((nuevaFactura.Total_metros.ToString()), CultureInfo.InvariantCulture.NumberFormat);
                        float.Parse((nuevaFactura.Total_viajes.ToString()), CultureInfo.InvariantCulture.NumberFormat);
                        float.Parse((nuevaFactura.Total_Kilometros.ToString()), CultureInfo.InvariantCulture.NumberFormat);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Hay datos con el formato incorrecto.", "Error", MessageBoxButtons.OK);
                        control = 1;
                    }
                    if (control != 1)
                    {
                        ModeloFactura.crearFactura(nuevaFactura);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error al almacenar los datos", "Error", MessageBoxButtons.OK);
            }
        }
        public static List<FACTURA> BuscarFacturaPorCriterio(String criterio)
        {
            try
            {
                var resultado = ModeloFactura.buscarFacturaPorCriterio(criterio);
                return resultado;
            }
            catch (Exception ex)
            {

                throw new Exception("Controlador: Error inesperado " + ex.Message);
            }
        }
    }
}
