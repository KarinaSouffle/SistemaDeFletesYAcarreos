using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaFletesAcarreoB.Modelo;
using System.Windows.Forms;

namespace SistemaFletesAcarreoB.Controlador
{
    public class ControladorUsuario
    {
        public static void crearUsuario(USUARIOS nuevoUsuario)
        {
            try
            {
                if (nuevoUsuario.Nombre == string.Empty ||
                    nuevoUsuario.Contra == string.Empty ||
                    nuevoUsuario.Nivel == string.Empty ||
                    nuevoUsuario.EnUso == string.Empty) 
                {
                    MessageBox.Show("Hay campos vacios.", "Error", MessageBoxButtons.OK);
                }
                else
                {
                    ModeloUsuario.crearUsuario(nuevoUsuario);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un error al almacenar los datos", "Error", MessageBoxButtons.OK);
            }
        }
        public static USUARIOS BuscarUsuariosPorId(int idUsuarios)
        {
            try
            {
                if (idUsuarios < 0)
                {
                    throw new Exception("No existe codigo menor que 0.");
                }
                else
                {
                    var resultado = ModeloUsuario.buscarUsuariosPorId(idUsuarios);
                    return resultado;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Revisa los datos introducidos", "Error", MessageBoxButtons.OK);
                return null;
            }
        }
        public static void EliminarUsuario(int idUsuario)
        {
            try
            {
                if (idUsuario < 0)
                {
                    throw new Exception("Codigo no puede ser menor que 0. ");
                }
                else
                {
                    ModeloUsuario.eliminarUsuario(idUsuario);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al eliminar", "Error", MessageBoxButtons.OK);
            }
        }
        public static List<USUARIOS> BuscarUsuariosPorCriterios(String criterios)
        {
            try
            {
                var resultado = ModeloUsuario.buscarUsuariosPorCriterios(criterios);
                return resultado;
            }
            catch (Exception ex)
            {
                throw new Exception("Error" + ex.Message);
            }
        }
    }
}
