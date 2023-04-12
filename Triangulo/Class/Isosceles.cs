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
    class Isosceles : Triangulo, ITriangulo
    {
        public Isosceles(): base()
        {

        }

        public Isosceles(Tamaños item): base(item)
        {

        }

        public Isosceles(Tamaños item, Colores item2) : base(item, item2)
        {

        }

        protected override void SetDatos(Tamaños item)
        {
            if (item.Equals(Tamaños.CHICO))
            {
                Punto2 = new Point(320, 100);
                Punto3 = new Point(280, 100);
            }
            else if (item.Equals(Tamaños.MEDIANO))
            {
                Punto2 = new Point(340, 150);
                Punto3 = new Point(260, 150);
            }
            else if (item.Equals(Tamaños.GRANDE))
            {
                Punto2 = new Point(360, 200);
                Punto3 = new Point(240, 200);
            }
            else if (item.Equals(Tamaños.ENORME))
            {
                Punto2 = new Point(380, 250);
                Punto3 = new Point(220, 250);
            }
        }
    }
}
