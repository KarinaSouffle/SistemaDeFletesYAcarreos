using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFletesAcarreoB.Modelo
{
    public class ModeloKilometro
    {
        public static void crearKilometro(KILOMETRO objKilometro)
        {
            try
            {
                using (var contextoKilometro = new SISTEMAFLETESACARREOSEntities())
                {
                    contextoKilometro.KILOMETRO.Add(objKilometro);
                    contextoKilometro.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error inesperado" + ex.Message);
            }
        }

        public static KILOMETRO buscarKilometroPorId(int idKilometro)
        {
            try
            {
                using (var contextoKilometro = new SISTEMAFLETESACARREOSEntities())
                {
                    var resultado = (from c in contextoKilometro.KILOMETRO
                                     where c.Id_Kilometro == idKilometro
                                     select c).FirstOrDefault();
                    return resultado;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error " + ex.Message);
            }
        }

        //static public List<KILOMETRO> UltimoRegistro(int idkm)
        //{
        //    try
        //    {
        //        using (var contextoKilometro = new SISTEMAFLETESACARREOSEntities())
        //        {
        //            var resultado = (from c in contextoKilometro.KILOMETRO
        //                             where c.Id_Kilometro == sis
        //                             select c).ToList();
        //            return resultado;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception("Error " + ex.Message);
        //    }
        //}

        public static void eliminarKilometo(int idKilometro)
        {
            try
            {
                using (var contextoKilometro = new SISTEMAFLETESACARREOSEntities())
                {
                    var kilometro = buscarKilometroPorId(idKilometro);
                    contextoKilometro.KILOMETRO.Attach(kilometro);

                    contextoKilometro.KILOMETRO.Remove(kilometro);
                    contextoKilometro.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error inesperado " + ex.Message);
            }
        }

        public static void modificarKilometro (KILOMETRO kilometroModificar)
        {
            try
            {
                using (var contextoKilometro = new SISTEMAFLETESACARREOSEntities())
                {
                    var kilometro = buscarKilometroPorId(kilometroModificar.Id_Kilometro);
                    contextoKilometro.KILOMETRO.Attach(kilometro);
                    kilometro = kilometroModificar;
                    contextoKilometro.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error inesperado " + ex.Message);
            }
        }
    }
}
