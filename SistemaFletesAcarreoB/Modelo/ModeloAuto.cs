using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFletesAcarreoB.Modelo
{
    public class ModeloAuto
    {
        public static void crearAuto(AUTOS objAutos)
        {
            try
            {
                using (var contextoAutos = new SISTEMAFLETESACARREOSEntities())
                {
                    contextoAutos.AUTOS.Add(objAutos);
                    contextoAutos.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error inesperado" + ex.Message);
            }
        }

        public static AUTOS buscarAutosPorId(int idAutos)
        {
            try
            {
                using (var contextoAuto = new SISTEMAFLETESACARREOSEntities())
                {
                    var resultado = (from c in contextoAuto.AUTOS
                                     where c.Id_Autos == idAutos
                                     select c).FirstOrDefault();
                    return resultado;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error " + ex.Message);
            }
        }
        static public List<AUTOS> buscarAutosPorCriterio(String criterio)
        {
            try
            {
                using (var contextoAuto = new SISTEMAFLETESACARREOSEntities())
                {
                    var resultado = (from c in contextoAuto.AUTOS
                                     where c.Marca.Contains(criterio)
                                     select c).ToList();
                    return resultado;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error " + ex.Message);
            }
        }
        public static void eliminarAutos(int idAuto)
        {
            try
            {
                using (var contextoAuto = new SISTEMAFLETESACARREOSEntities())
                {
                    var auto = buscarAutosPorId(idAuto);
                    contextoAuto.AUTOS.Attach(auto);

                    contextoAuto.AUTOS.Remove(auto);
                    contextoAuto.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error " + ex.Message);
            }
        }
        public static void modificarAuto(AUTOS autoModificar)
        {
            try
            {
                using (var contextoAuto = new SISTEMAFLETESACARREOSEntities())
                {
                    var auto = buscarAutosPorId(autoModificar.Id_Autos);
                    contextoAuto.AUTOS.Attach(auto);
                    auto = autoModificar;
                    contextoAuto.SaveChanges();
                }
            }
            catch (Exception ex)
            {

                throw new Exception("Error inesperado " + ex.Message);
            }
        }

    }
}
