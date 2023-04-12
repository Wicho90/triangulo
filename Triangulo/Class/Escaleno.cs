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

        public Escaleno(Tamaños item, Colores item2) : base(item, item2)
        {

        }

        public Escaleno(Tamaños item, Colores item2, Angulos item3) : base(item, item2, item3)
        {

        }

        protected override void SetDatos(Tamaños item)
        {
            if (item.Equals(Tamaños.CHICO))
            {
                Punto2 = new Point(360, 100);
                Punto3 = new Point(320, 100);
            }
            else if (item.Equals(Tamaños.MEDIANO))
            {
                Punto2 = new Point(410, 150);
                Punto3 = new Point(320, 150);
            }
            else if (item.Equals(Tamaños.GRANDE))
            {
                Punto2 = new Point(460, 200);
                Punto3 = new Point(320, 200);
            }
            else if (item.Equals(Tamaños.ENORME))
            {
                Punto2 = new Point(510, 250);
                Punto3 = new Point(320, 250);
            }
        }
    }
}
