using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                                     where c.Id_Chofer == idChofer
                                     select c).FirstOrDefault();
                    return resultado;
                }
            }
            catch (Exception ex)
            {

                throw new Exception("Error " + ex.Message);
            }
        }

        public static List<CHOFER> buscarChoferPorCriterio(String criterio)
        {
            try
            {
                using (var contextoChofer = new SISTEMAFLETESACARREOSEntities())
                {
                    var resultado = (from c in contextoChofer.CHOFER
                                     where c.lICENCIA_C.Contains(criterio) 
                                     select c).ToList();
                    return resultado;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error " + ex.Message);
            }
        }
        public static List<CHOFER> buscarChoferPorDisponibilidad(String criterio)
        {
            try
            {
                using (var contextoChofer = new SISTEMAFLETESACARREOSEntities())
                {
                    var resultado = (from c in contextoChofer.CHOFER
                                     where c.Disponible.Contains(criterio)
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

                MessageBox.Show("Error al eliminar", "Error", MessageBoxButtons.OK);
            }
        }

        public static void modificarChofer (CHOFER choferModificar)
        {
            try
            {
                using (var contextoChofer = new SISTEMAFLETESACARREOSEntities())
                {
                    var choferes = buscarChoferPorId(choferModificar.Id_Chofer);
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
