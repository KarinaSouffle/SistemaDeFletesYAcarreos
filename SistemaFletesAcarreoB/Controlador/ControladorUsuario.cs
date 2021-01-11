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
                if (String.IsNullOrEmpty(nuevoUsuario.Nombre) ||
                    String.IsNullOrEmpty(nuevoUsuario.Contra) ||
                    string.IsNullOrEmpty(nuevoUsuario.Nivel)) 
                {
                    throw new Exception("Existe parametro vacio");
                }
                ModeloUsuario.crearUsuario(nuevoUsuario);
            }
            catch (Exception)
            {
                MessageBox.Show("Revisa los datos introducidos", "Error", MessageBoxButtons.OK);
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
    }
}
