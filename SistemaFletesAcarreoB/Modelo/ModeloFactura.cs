using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFletesAcarreoB.Modelo
{
    public class ModeloFactura
    {
        static public void crearFactura(FACTURA objFactura)
        {
            try
            {
                using (var contextoFactura = new SISTEMAFLETESACARREOSEntities())
                {
                    contextoFactura.FACTURA.Add(objFactura);
                    contextoFactura.SaveChanges();
                }
            }
            catch (Exception ex)
            {

                throw new Exception("Error inesperado " + ex.Message);
            }
        }
        static public FACTURA buscarFacturaPorId(int idFactura)
        {
            try
            {
                using (var contextoFactura = new SISTEMAFLETESACARREOSEntities())
                {
                    var resultado = (from c in contextoFactura.FACTURA
                                     where c.Boleta_no == idFactura
                                     select c).FirstOrDefault();
                    return resultado;
                }
            }
            catch (Exception ex)
            {

                throw new Exception("Error " + ex.Message);
            }
        }

        public static List<FACTURA> buscarFacturaPorCriterio(String criterio)
        {
            try
            {
                using (var contextoFactura = new SISTEMAFLETESACARREOSEntities())
                {
                    var resultado = (from c in contextoFactura.FACTURA
                                     where c.Fecha.Contains(criterio)
                                     select c).ToList();
                    return resultado;
                }
            }
            catch (Exception ex)
            {

                throw new Exception ("Error " + ex.Message);
            }
        }
    }
}
