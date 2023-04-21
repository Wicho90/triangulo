using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triangulo.Class
{
    abstract class Mover
    {

        public event EventHandler Up;
        public Keys KeyUp { get; set; } = Keys.W;
        public Keys KeyDown { get; set; } = Keys.S;
        public Keys KeyRight { get; set; } = Keys.D;
        public Keys KeyLeft { get; set; } = Keys.A;
        public Keys KeyRotateRight { get; set; } = Keys.E;
        public Keys KeyRotateLeft { get; set; } = Keys.Q;

        public void KeyDownOn(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(KeyUp))
                MoverArriba();
            else if (e.KeyCode.Equals(KeyDown))
                MoverAbajo();
            else if (e.KeyCode.Equals(KeyRight))
                MoverDerecha();
            else if (e.KeyCode.Equals(KeyLeft))
                MoverIzquierda();
        }

        protected abstract void MoverDerecha();


        protected abstract void MoverIzquierda();
        protected abstract void MoverArriba();

        protected abstract void MoverAbajo();
    }
}
