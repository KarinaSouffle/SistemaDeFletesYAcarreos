﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaFletesAcarreoB
{
    class Validar
    {
        public Boolean ValidatePassword(string password)
        {
            var input = password;

            if (string.IsNullOrWhiteSpace(input))
            {
                MessageBox.Show("Contraseña no puede estar vacia");
            }

            var tieneNumero = new Regex(@"[0-9]+");
            var tieneMayus = new Regex(@"[A-Z]+");
            var tieneMinMaxChar = new Regex(@".{8,15}");
            var tieneMinus = new Regex(@"[a-z]+");
            var tieneSimbolos = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");

            if (!tieneMinus.IsMatch(input))
            {
                MessageBox.Show("La contraseña debe contener por lo menos una letra minuscula");
                return false;
            }
            else if (!tieneMayus.IsMatch(input))
            {
                MessageBox.Show("La contraseña debe contener por lo menos una letra mayuscula");
                return false;
            }
            else if (!tieneMinMaxChar.IsMatch(input))
            {
                MessageBox.Show("La contraseña debe contener 12 characteres totales");
                return false;
            }
            else if (!tieneNumero.IsMatch(input))
            {
                MessageBox.Show("La contraseña debe contener por lo menos un número");
                return false;
            }

            else if (!tieneSimbolos.IsMatch(input))
            {
                MessageBox.Show("La contraseña debe contener por lo menos un character especial (ejemplo: !, @, #)");
                return false;
            }
            else
            {
                return true;
            }
        }
        public Boolean ValidarNum(string pri)
        {
            var input = pri;
            var ValorVal = new Regex(@"^[0-9]+(\.[0-9]+)?$");
            if (string.IsNullOrWhiteSpace(input))
            {
                MessageBox.Show("Favor de llenar el campo " + pri);
                return false;
            }
            else if (!ValorVal.IsMatch(input))
            {
                MessageBox.Show("Favor de introducir solo numeros positivos.");
                return false;
            }
            else
            {
                return true;
            }

        }

        public Boolean ValidarCorreo(string correo)
        {
            String expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(correo, expresion))
            {
                if (Regex.Replace(correo, expresion, String.Empty).Length == 0)
                {

                    return true;
                }
                else
                {
                    MessageBox.Show("Ingresar un correo");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Ingresar un correo");
                return false;
            }
        }

        public Boolean ValidarVacio(string caso)
        {
            if (string.IsNullOrWhiteSpace(caso))
            {
                MessageBox.Show("El campo " + caso + "no puede quedar vacio, favor de intentar de nuevo.");
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean ValidarLicencia(string licencia)
        {
            var Uinput = licencia;
            if (string.IsNullOrWhiteSpace(Uinput))
            {
                MessageBox.Show("El campo de licencia se encuentra vacio, favor de intentar de nuevo.");
            }
            var tieneNumero = new Regex(@"[A-Z]+([0-9]+[A-Z])+");
            //Numero maximo de numeros para licencia 11
            if (!tieneNumero.IsMatch(Uinput))
            {
                MessageBox.Show("El formato de licencia debera ser A111111111111, favor de intentar de nuevo.");
                return false;
            }
            else
            {
                return true;
            }
        }

        public Boolean ValidarNombre(string caso)
        {
            var Uinput = caso;
            if (string.IsNullOrWhiteSpace(Uinput))
            {
                MessageBox.Show("El campo de " + caso + " no puede quedar vacio, favor de intentar de nuevo.");
            }
            var formatoNombre = new Regex(@"[A-Z][a-z]");
            //El Nombre tiene que comenzar con una Mayuscula.
            if (!formatoNombre.IsMatch(Uinput))
            {
                MessageBox.Show("El nombre introducido debe de iniciar con mayusucula, favor de intentar de nuevo.");
                return false;
            }
            else
            {
                return true;
            }
        }

        public Boolean ValidarNumeroTel(string telefono)
        {
            var Uinput = telefono;
            if (string.IsNullOrWhiteSpace(Uinput))
            {
                MessageBox.Show("El campo Telefono se encuentra vacio, favor de intentar de nuevo.");
            }
            var tieneNumero = new Regex(@"[0-9]+");
            var tieneMinChar = new Regex(@".{10}");
            //Numero maximo de numeros para licencia 11
            if (!tieneNumero.IsMatch(Uinput))
            {
                MessageBox.Show("Formato incorrecto, favor de incluir solo numeros.");
                return false;
            }
            else if (!tieneMinChar.IsMatch(Uinput))
            {
                MessageBox.Show("El numero telefonico debera incluir minimo 10 digitos.");
                return false;
            }
            else
            {
                return true;
            }
        }

        public Boolean FormatoPlaca(string Matricula)
        {
            var Uinput = Matricula;
            if (string.IsNullOrWhiteSpace(Uinput))
            {
                MessageBox.Show("El campo Numero de placa no puede quedar vacio, favor de introducir un dato.");
            }
            var formatoNombre = new Regex(@"[A-Z]{2}-[0-9]{3}");

            if (!formatoNombre.IsMatch(Uinput))
            {
                MessageBox.Show("El formato introducido para la matricula es incorrecto (LL-NNN), favor de intentar de nuevo.");
                return false;
            }
            else
            {
                return true;
            }
        }
    }


}