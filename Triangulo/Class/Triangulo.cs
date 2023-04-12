using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Triangulo.Class.Sizes;
using Triangulo.comun;

namespace Triangulo.Class
{
    class Triangulo: Figura
    {

        public Triangulo(): base(Tamaños.CHICO)
        {

        }
        public Triangulo(Tamaños item): base(item)
        {

        }

    }
}
