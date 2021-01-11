using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaFletesAcarreoB.Modelo;
using System.Windows.Forms;

namespace SistemaFletesAcarreoB.Controlador
{
    public class ControladorKilometro
    {
        public static void CrearKilometro(KILOMETRO nuevoKilometro)
        {
            try
            {
                if (nuevoKilometro.Id_Kilometro<0 ||
                    nuevoKilometro.Precio<0)
                {
                    throw new Exception("Algo está vació, favor de llenar todos los campos");
                }
                ModeloKilometro.crearKilometro(nuevoKilometro);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Revisa los datos introducidos", "Error", MessageBoxButtons.OK);
            }
        }

        public static void EliminarKilometro(int idKilometro)
        {
            try
            {
                if (idKilometro<0)
                {
                    throw new Exception("Codigo no puede ser menor a 0.");
                }
                else
                {
                    ModeloKilometro.eliminarKilometo(idKilometro);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al eliminar. ", "Error", MessageBoxButtons.OK);
            }
        }
        public static void ModificarKilometro(KILOMETRO KilometroModificar)
        {
            try
            {
                if (KilometroModificar.Id_Kilometro < 0)
                {
                    throw new Exception("Valor de Codigo nulo");
                }
                ModeloKilometro.modificarKilometro(KilometroModificar);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Revisa los datos introducidos", "Error", MessageBoxButtons.OK);
            }
        }
        public static KILOMETRO BuscarKilometroporId(int idKilometro)
        {
            try
            {
                if (idKilometro < 0)
                {
                    throw new Exception("No existe codigo menor que 0.");
                }
                else
                {
                    var resultado = ModeloKilometro.buscarKilometroPorId(idKilometro);
                    return resultado;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Revisa los datos introducidos", "Error", MessageBoxButtons.OK);
                return null;
            }
        }
    }
}
