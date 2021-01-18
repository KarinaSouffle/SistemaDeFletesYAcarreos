using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SistemaFletesAcarreoB.Modelo;
using System.Threading.Tasks;
using SistemaFletesAcarreoB.Modelo;

namespace SistemaFletesAcarreoB.GOF
{
    abstract class UsuarioPrototype

    {
        public abstract UsuarioPrototype Clone();
    }


    class Usuario : UsuarioPrototype

    {
        private string _Usuario;


        public Usuario(string usuario)
        {
            this._Usuario = usuario;
        }

        public override UsuarioPrototype Clone()
        {
            _Usuario = "Admi";
            return this.MemberwiseClone() as UsuarioPrototype;
        }
    }


    class UsuarioManager

    {
        private Dictionary<string, UsuarioPrototype> _usuarios =
          new Dictionary<string, UsuarioPrototype>();


        public UsuarioPrototype this[string key]
        {
            get { return _usuarios[key]; }
            set { _usuarios.Add(key, value); }
        }
    }
}
