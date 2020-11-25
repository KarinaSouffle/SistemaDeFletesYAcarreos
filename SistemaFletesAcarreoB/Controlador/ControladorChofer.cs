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
                    nuevoChofer.Telefono<0 ||
                    String.IsNullOrEmpty(nuevoChofer.Correo) ||
                    nuevoChofer.F_Nac == DateTime.MinValue)
                {
                    throw new Exception("Existe parametro vacio");
                }
                ModeloChofer.crearChofer(nuevoChofer);
            }
            catch (Exception ex)
            {

                throw new Exception("Controlador: Error inesperado " + ex.Message);
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

                throw new Exception("Controlador: Error inesperado " + ex.Message);
            }
        }

        public static void EliminarChofer(int idChofer)
        {
            try
            {
                if (idChofer<0)
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

                throw new Exception("Controlador: Error inesperado " + ex.Message);
            }
        }

        public static void ModificarChofer(CHOFER ChoferModificar)
        {
            try
            {
                if (ChoferModificar.lICENCIA_C < 0)
                {
                    throw new Exception("Valo de Codigo nulo");
                }
                ModeloChofer.modificarChofer(ChoferModificar);
            }
            catch (Exception ex)
            {

                throw new Exception("Controlador: Error inesperado " + ex.Message);
            }
        }

        public static CHOFER BuscarChoferPorId(int idChofer)
        {
            try
            {
                if (idChofer < 0)
                {
                    throw new Exception("No existe Codigo menos que 0.");
                }
                else
                {
                    var resultado = ModeloChofer.buscarChoferPorId(idChofer);
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
