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
        //Command Es utilizado en esta situacion con la estructura del modelo la cual gestiona la informacion de las requests.
        public static void CrearAuto(AUTOS nuevoAuto)
        {
            try
            {
                int control = 0;
                string placas = nuevoAuto.Num_Placas.ToString();
                if (nuevoAuto.Num_Placas == string.Empty ||
                   nuevoAuto.Kilometraje == string.Empty ||
                   nuevoAuto.Cap_A == string.Empty ||
                   nuevoAuto.Marca == string.Empty ||
                   nuevoAuto.Disponible == string.Empty)
                {
                    MessageBox.Show("Hay campos vacios.", "Error", MessageBoxButtons.OK);
                }
                else
                {
                    try
                    {
                        float kilometraje = float.Parse(nuevoAuto.Kilometraje.ToString());
                        float capacidad = float.Parse(nuevoAuto.Cap_A.ToString());
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Hay datos con el formato incorrecto.", "Error", MessageBoxButtons.OK);
                        control = 1;
                    }
                    if (control != 1)
                    {
                        nuevoAuto.Kilometraje = (Math.Round(float.Parse(nuevoAuto.Kilometraje), 2)).ToString(); ;
                        nuevoAuto.Cap_A = (float.Parse(nuevoAuto.Cap_A)).ToString();
                        ModeloAuto.crearAuto(nuevoAuto);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Hubo un error al almacenar los datos", "Error", MessageBoxButtons.OK);
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
