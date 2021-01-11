using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SistemaFletesAcarreoB.Modelo;
using System.Threading.Tasks;

namespace SistemaFletesAcarreoB.GOF
{ 
    /// <summary>

    /// The 'Prototype' abstract class

    /// </summary>

    abstract class UsuarioPrototype

    {
        public abstract UsuarioPrototype Clone();
    }

    /// <summary>
    /// The 'ConcretePrototype' class
    /// </summary>

    class Usuario : UsuarioPrototype

    {
        private string _Usuario;

        // Constructor

        public Usuario(string usuario)
        {
            this._Usuario = usuario;
        }




        // Create a shallow copy

        public override UsuarioPrototype Clone()
        {
            _Usuario = "Admi";
            return this.MemberwiseClone() as UsuarioPrototype;
        }
    }

    /// <summary>

    /// Prototype manager

    /// </summary>

    class UsuarioManager

    {
        private Dictionary<string, UsuarioPrototype> _usuarios =
          new Dictionary<string, UsuarioPrototype>();

        // Indexer

        public UsuarioPrototype this[string key]
        {
            get { return _usuarios[key]; }
            set { _usuarios.Add(key, value); }
        }
    }
}
