using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PicrossSolver
{
    class Cell
    {
        public enum State { Filled, Empty, Unknown}

        private State p_currentState = State.Empty;

        public State state { get { return p_currentState; } set { p_currentState = value; } }

        public Cell(State s)
        {
            p_currentState = s;
        }
    }
}
