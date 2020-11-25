using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using SistemaFletesAcarreoB.Controlador;
using SistemaFletesAcarreoB.Modelo;

namespace SistemaFletesAcarreoB.Controlador
{
    public class ControladorMateriales
    {

        public static void CrearMaterial(MATERIALES nuevoMaterial)
        {
            try
            {
                if (nuevoMaterial.Codigo<0 || 
                    String.IsNullOrEmpty(nuevoMaterial.Nombre_M) ||
                    nuevoMaterial.Precio<0)
                {
                    throw new Exception("Existe parametro vacio");
                }
                ModeloMateriales.crearMaterial(nuevoMaterial);
            }
            catch (Exception ex)
            {

                throw new Exception("Controlador: Error inesperado " + ex.Message);
            }
        }

        public static List<MATERIALES> BuscarMaterialesPorCriterios(String criterios)
        {
            try
            {
                var resultado = ModeloMateriales.buscarMaterialesPoCriterios(criterios);
                return resultado;
            }
            catch (Exception ex)
            {

                throw new Exception("Controlador: Error inesperado "+ ex.Message);
            }
        }

        public static void EliminarMaterial(int idMaterial)
        {
            try
            {
                if (idMaterial<0)
                {
                    throw new Exception("Codigo no puede ser menor que 0.");
                }
                else
                {
                    ModeloMateriales.eliminarMaterial(idMaterial);
                }
            }
            catch (Exception ex)
            {

                throw new Exception("Controlador: Error inesperado " + ex.Message);
            }
        }

        public static void ModificarMaterial(MATERIALES MaterialesModificar)
        {
            try
            {
                if (MaterialesModificar.Codigo<0)
                {
                    throw new Exception("Valo de Codigo nulo");
                }
                ModeloMateriales.modificarMaterial(MaterialesModificar);
            }
            catch (Exception ex)
            {

                throw new Exception("Controlador: Error inesperado " + ex.Message);
            }
        }

        public static MATERIALES BuscaMaterialPorId(int idMateriales)
        {
            try
            {
                if (idMateriales < 0)
                {
                    throw new Exception("No existe Codigo menos que 0.");
                }
                else
                {
                    var resultado = ModeloMateriales.buscarMaterialPorId(idMateriales);
                    return resultado;
                }
            }
            catch (Exception ex)
            {

                throw new Exception("Controlador: Error inesperado " + ex.Message);
            }
        }
    }
}
