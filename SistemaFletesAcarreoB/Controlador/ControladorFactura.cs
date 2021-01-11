using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaFletesAcarreoB.Modelo;

namespace SistemaFletesAcarreoB.Controlador
{
    public class ControladorFactura
    {
        public static void CrearFactura(FACTURA nuevaFactura)
        {
            try
            {
                if (nuevaFactura.Boleta_no < 0 ||
                    nuevaFactura.Maquina < 0 ||
                    String.IsNullOrEmpty(nuevaFactura.Fecha)||
                    String.IsNullOrEmpty(nuevaFactura.Hora) ||
                    string.IsNullOrEmpty(nuevaFactura.Materiales) ||
                    nuevaFactura.Total_metros < 0 ||
                    nuevaFactura.Total_viajes < 0 ||
                    nuevaFactura.Subtotal < 0 ||
                    nuevaFactura.IVA < 0 ||
                    nuevaFactura.Total < 0 ||
                    nuevaFactura.Fact_material < 0 ||
                    nuevaFactura.Fact_licencia < 0 ||
                    nuevaFactura.Fact_placas < 0 ||
                    nuevaFactura.Fact_Kilometro < 0 )

                {
                    throw new Exception("Algo está vacio, favor de llenar todos los campos");
                }
                ModeloFactura.crearFactura(nuevaFactura);
            }
            catch (Exception ex)
            {

                throw new Exception("Controlador: Error inesperado " + ex.Message);
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
