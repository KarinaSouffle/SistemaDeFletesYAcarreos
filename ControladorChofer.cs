using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using SistemaFletesAcarreoB.Controlador;
using SistemaFletesAcarreoB.Modelo;
using System.Windows.Forms;

namespace SistemaFletesAcarreoB.Controlador
{
    public class ControladorChofer
    {
        public static void CrearChofer(CHOFER nuevoChofer)
        {
            try
            {
                if (nuevoChofer.lICENCIA_C<0 ||
                    String.IsNullOrEmpty(nuevoChofer.N_Chofer) ||
                    String.IsNullOrEmpty(nuevoChofer.ApellidoP_C) ||
                    String.IsNullOrEmpty(nuevoChofer.ApellidoM_C) ||
                    String.IsNullOrEmpty(nuevoChofer.Sexo) ||
                    nuevoChofer.Edad<0 ||
                    String.IsNullOrEmpty(nuevoChofer.Telefono) ||
                    String.IsNullOrEmpty(nuevoChofer.Correo) ||
                    nuevoChofer.F_Nac == DateTime.MinValue ||
                    String.IsNullOrEmpty(nuevoChofer.Direccion))
                {
                    throw new Exception("Algo está vació, favor de llenar todos los campos");
                }
                ModeloChofer.crearChofer(nuevoChofer);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Revisa los datos introducidos", "Error", MessageBoxButtons.OK);
            }
        }
        //Singleton.
        public sealed class Singleton
        {
            Singleton()
            {
                CHOFER nuevoChofer;
            }
            private static readonly object padlock = new object();
            private static Singleton nuevoChofer = null;
            public static Singleton proove
            {
                get
                {
                    lock (padlock)
                    {
                        if (nuevoChofer == null)
                        {
                            nuevoChofer = new Singleton();
                        }
                        return nuevoChofer;
                    }
                }
            }
        }
        public static List<CHOFER> BuscarChoferesPorCriterio(String criterio)
        {
            try
            {
                var resultado = ModeloChofer.buscarChoferPorCriterio(criterio);
                return resultado;
            }
            catch (Exception ex)
            {

                throw new Exception("Error " + ex.Message);
            }
        }

        public static void EliminarChofer(int idChofer)
        {
            try
            {
                if (idChofer < 0)
                {
                    throw new Exception("Codigo no puede ser menor 0.");
                }
                else
                {
                    ModeloChofer.eliminarChofer(idChofer);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error " + ex.Message);
            }
        }

        public static void ModificarChofer(CHOFER ChoferModificar)
        {
            try
            {
                if (ChoferModificar.Id_Chofer < 0)
                {
                    throw new Exception("Valor de Codigo nulo");
                }
                ModeloChofer.modificarChofer(ChoferModificar);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Revisa los datos introducidos", "Error", MessageBoxButtons.OK);
            }
        }

        public static CHOFER BuscarChoferPorId(int idChofer)
        {
            try
            {
                if (idChofer < 0)
                {
                    throw new Exception("No existe Codigo menor que 0.");
                }
                else
                {
                    var resultado = ModeloChofer.buscarChoferPorId(idChofer);
                    return resultado;
                }
            }
            catch (Exception ex)
            {

                throw new Exception("Error " + ex.Message);
            }
        }
    }
}
