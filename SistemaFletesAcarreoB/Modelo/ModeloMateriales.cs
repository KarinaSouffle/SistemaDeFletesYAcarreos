using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFletesAcarreoB.Modelo
{
    public class ModeloMateriales
    {

        static public void crearMaterial(MATERIALES objMateriales)
        {
            try
            {
                using (var contextoMaterial = new SISTEMAFLETESACARREOSEntities())
                {
                    contextoMaterial.MATERIALES.Add(objMateriales);
                    contextoMaterial.SaveChanges();
                }
            }
            catch (Exception ex)
            {

                throw new Exception("Error inesperado " + ex.Message);
            }
        }

        static public MATERIALES buscarMaterialPorId(int idMaterial)
        {
            try
            {
                using (var contextoMaterial = new SISTEMAFLETESACARREOSEntities())
                {
                    var resultado = (from c in contextoMaterial.MATERIALES
                                     where c.Codigo == idMaterial
                                     select c).FirstOrDefault();
                    return resultado;
                }
            }
            catch (Exception ex)
            {

                throw new Exception("Error " + ex.Message);
            }
        }

        static public List<MATERIALES> buscarMaterialesPoCriterios(String criterios)
        {
            try
            {
                using (var contextoMateriales = new SISTEMAFLETESACARREOSEntities())
                {
                    var resultado = (from c in contextoMateriales.MATERIALES
                                     where c.Nombre_M.Contains(criterios)
                                     select c).ToList();
                    return resultado;
                }
            }
            catch (Exception ex)
            {

                throw new Exception("Error " + ex.Message);
            }
        }

        static public void eliminarMaterial(int idMaterial)
        {
            try
            {
                using (var contextoMaterial = new SISTEMAFLETESACARREOSEntities())
                {
                    var material = buscarMaterialPorId(idMaterial);
                    contextoMaterial.MATERIALES.Attach(material);

                    contextoMaterial.MATERIALES.Remove(material);
                    contextoMaterial.SaveChanges();
                }
            }
            catch (Exception ex)
            {

                throw new Exception("Error inesperado " + ex.Message);
            }
        }

        static public void modificarMaterial(MATERIALES materialModificar)
        {
            try
            {
                using (var contextoMaterial = new SISTEMAFLETESACARREOSEntities())
                {
                    var Materiales = buscarMaterialPorId(materialModificar.Codigo);
                    contextoMaterial.MATERIALES.Attach(Materiales);
                    Materiales = materialModificar;
                    contextoMaterial.SaveChanges();
                }
            }
            catch (Exception ex)
            {

                throw new Exception("Error inesperado "+ ex.Message);
            }
        }
    }
}
