using NUnit.Framework;
using SistemaFletesAcarreoB;
using SistemaFletesAcarreoB.Controlador;
using SistemaFletesAcarreoB.Modelo;
using SistemaFletesAcarreoB.Vista;
using System;

namespace TestProject3
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            string criterio = "";
            bool mock = Validar.FormatoPlaca(criterio);
            Assert.IsTrue(mock);
        }

        [Test]
        public void TestValidatPassword()
        {
            string criterio = "Password1!";
            bool mock = Validar.ValidatePassword(criterio);
            Assert.True(mock);
        }

        [Test]
        public void TestValidarNum()
        {
            string criterio = "0123456789";
            bool mock = Validar.ValidarNum("52", criterio);
            Assert.IsTrue(mock);
        }

        [Test]
        public void TestValidarCorreo()
        {
            string criterio = "hectorprueba@gmail.net";
            bool mock = Validar.ValidarCorreo(criterio);
            Assert.True(mock);
        }

        [Test]
        public void TestValidarVacio()
        {
            string criterio = "";
            bool mock = Validar.ValidarVacio(criterio);
            Assert.IsFalse(mock);
        }

        [Test]
        public void TestValidarNombre()
        {
            string criterio = "";
            string criterio2 = "";
            bool mock = Validar.ValidarNombre(criterio, criterio2);
            Assert.False(mock);
        }

        [Test]
        public void TestValidarNumeroTel()
        {
            string criterio = "0123456789";
            bool mock = Validar.ValidarNumeroTel(criterio);
            Assert.True(mock);
        }

        [Test]
        /*public void TestEdad()
        {
            var fecha = new DateTime(1999, 08, 04);

            int edad = 
        }*/


    }
}