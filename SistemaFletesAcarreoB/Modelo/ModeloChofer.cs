using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFletesAcarreoB.Modelo
{
    public class ModeloChofer
    {
        static public void crearChofer(CHOFER objChofer)
        {
            try
            {
                using (var contextoChofer = new SISTEMAFLETESACARREOSEntities())
                {
                    contextoChofer.CHOFER.Add(objChofer);
                    contextoChofer.SaveChanges();
                }
            }
            catch (Exception ex)
            {

                throw new Exception("Error inesperado " + ex.Message);
            }
        }

        static public CHOFER buscarChoferPorId(int idChofer)
        {
            try
            {
                using (var contextoChofer = new SISTEMAFLETESACARREOSEntities())
                {
                    var resultado = (from c in contextoChofer.CHOFER
                                     where c.lICENCIA_C == idChofer
                                     select c).FirstOrDefault();
                    return resultado;
                }
            }
            catch (Exception ex)
            {

                throw new Exception("Error " + ex.Message);
            }
        }

        static public List<CHOFER> buscarChoferPorCriterio(String criterio)
        {
            try
            {
                using (var contextoChofer = new SISTEMAFLETESACARREOSEntities())
                {
                    var resultado = (from c in contextoChofer.CHOFER
                                     where c.N_Chofer.Contains(criterio) ||
                                     c.ApellidoP_C.Contains(criterio) ||
                                     c.ApellidoM_C.Contains(criterio) ||
                                     c.Correo.Contains(criterio) ||
                                     c.Chofer_Direccion.Contains(criterio)
                                     select c).ToList();
                    return resultado;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error " + ex.Message);
            }
        }

        static public void eliminarChofer(int idChofer)
        {
            try
            {
                using (var contextoChofer = new SISTEMAFLETESACARREOSEntities())
                {
                    var chofer = buscarChoferPorId(idChofer);
                    contextoChofer.CHOFER.Attach(chofer);

                    contextoChofer.CHOFER.Remove(chofer);
                    contextoChofer.SaveChanges();
                }
            }
            catch (Exception ex)
            {

                throw new Exception("Error inesperado " + ex.Message);
            }
        }

        public static void modificarChofer (CHOFER choferModificar)
        {
            try
            {
                using (var contextoChofer = new SISTEMAFLETESACARREOSEntities())
                {
                    var choferes = buscarChoferPorId(choferModificar.lICENCIA_C);
                    contextoChofer.CHOFER.Attach(choferes);
                    choferes = choferModificar;
                    contextoChofer.SaveChanges();
                }
            }
            catch (Exception ex)
            {

                throw new Exception("Error inesperado " + ex.Message);
            }
        }
    }
}
