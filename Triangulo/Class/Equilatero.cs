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
    class Equilatero : Triangulo, ITriangulo
    {
        public Equilatero(): base()
        {

        }

        public Equilatero(Tamaños item): base(item)
        {

        }

        public Equilatero(Tamaños item, Colores item2) : base(item, item2)
        {

        }
        
        public Equilatero(Tamaños item, Colores item2, Angulos item3) : base(item, item2, item3)
        {

        }

       
    }
}
