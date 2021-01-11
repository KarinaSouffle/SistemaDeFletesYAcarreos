using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace SistemaFletesAcarreoB.Modelo
{
    public class ModeloUsuario
    {
        static public void crearUsuario(USUARIOS objUsuario)
        {
            try
            {
                using (var contextoUsuario = new SISTEMAFLETESACARREOSEntities())
                {
                    contextoUsuario.USUARIOS.Add(objUsuario);
                    contextoUsuario.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Revisa los datos introducidos", "Error", MessageBoxButtons.OK);
            }
        }

        public static USUARIOS buscarUsuariosPorId(int idUsuario)
        {
            try
            {
                using (var contextoUsuario = new SISTEMAFLETESACARREOSEntities())
                {
                    var resultado = (from c in contextoUsuario.USUARIOS
                                     where c.Id == idUsuario
                                     select c).FirstOrDefault();
                    return resultado;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Revisa los datos introducidos", "Error", MessageBoxButtons.OK);
                return null;
            }
        }

        public static void eliminarUsuario(int idUsuario)
        {
            try
            {
                using(var contextoUsuario = new SISTEMAFLETESACARREOSEntities())
                {
                    var usuario = buscarUsuariosPorId(idUsuario);
                    contextoUsuario.USUARIOS.Attach(usuario);

                    contextoUsuario.USUARIOS.Remove(usuario);
                    contextoUsuario.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar. ", "Error", MessageBoxButtons.OK);
            }
        }

    }
}
