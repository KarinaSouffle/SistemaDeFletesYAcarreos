using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFletesAcarreoB.GOF
{
    class MainApp

    {
        /// <summary>

        /// Entry point into console application.

        /// </summary
    }

    /// <summary>

    /// The 'State' abstract class

    /// </summary>

    abstract class State

    {
        public abstract void Handle(Context context);
    }

    /// <summary>

    /// A 'ConcreteState' class

    /// </summary>

    class Disponible: State

    {
        public override void Handle(Context context)
        {
            context.State = new No_Disponible();
        }
    }

    /// <summary>

    /// A 'ConcreteState' class

    /// </summary>

    class No_Disponible : State

    {
        public override void Handle(Context context)
        {
            context.State = new Disponible();
        }
    }

    /// <summary>

    /// The 'Context' class

    /// </summary>

    class Context

    {
        private State _state;

        // Constructor

        public Context(State state)
        {
            this.State = state;
        }

        // Gets or sets the state

        public State State
        {
            get { return _state; }
            set

            {
                _state = value;
                Console.WriteLine("Estado: " +
                  _state.GetType().Name);
            }
        }

        public void Request()
        {
            _state.Handle(this);
        }
    }
}
