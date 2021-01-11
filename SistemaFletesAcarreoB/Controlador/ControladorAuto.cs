using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaFletesAcarreoB.Modelo;
using System.Windows.Forms;

namespace SistemaFletesAcarreoB.Controlador
{
    public class ControladorAuto
    {
        public static void CrearAuto(AUTOS nuevoAuto)
        {
            try
            {
                if (String.IsNullOrEmpty(nuevoAuto.Num_Placas) ||
                   nuevoAuto.Kilometraje < 0 ||
                   nuevoAuto.Cap_A < 0 ||
                   String.IsNullOrEmpty(nuevoAuto.Marca))
                {
                    MessageBox.Show("Revisa los datos introducidos", "Error", MessageBoxButtons.OK);
                }
                ModeloAuto.crearAuto(nuevoAuto);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Revisa los datos introducidos", "Error", MessageBoxButtons.OK);
            }
        }
        public static List<AUTOS> BuscarAutosPorCriterio(String criterio)
        {
            try
            {
                var resultado = ModeloAuto.buscarAutosPorCriterio(criterio);
                return resultado;
            }
            catch (Exception ex)
            {
                throw new Exception("Error" + ex.Message);
            }
        }
        public static void EliminarAutos(int idAuto)
        {
            try
            {
                if (idAuto < 0)
                {
                    throw new Exception("Codigo no puede ser menor 0");
                }
                else
                {
                    ModeloAuto.eliminarAutos(idAuto);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error" + ex.Message);
            }
        }
        public static void ModificarAuto(AUTOS AutosModificar)
        {
            try
            {
                if (Convert.ToInt32(AutosModificar.Id_Autos) < 0)
                {
                    throw new Exception("Se esperaba un numero mayo a 0");
                }
                ModeloAuto.modificarAuto(AutosModificar);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Revisa los datos introducidos", "Error", MessageBoxButtons.OK);
            }
        }
        public static AUTOS BuscarAutoPorId(int idAutos)
        {
            try
            {
                if (idAutos < 0)
                {
                    throw new Exception("No existe autos menos que 0.");
                }
                else
                {
                    var resultado = ModeloAuto.buscarAutosPorId(idAutos);
                    return resultado;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error" + ex.Message);
            }
        }
    }
}
