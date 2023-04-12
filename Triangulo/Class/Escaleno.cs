using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Triangulo.comun;

namespace Triangulo.Class
{
    class Escaleno: Triangulo, ITriangulo
    {
        public Escaleno(): base()
        {

        }

        public Escaleno(Tamaños item): base(item)
        {

        }
    }
}
