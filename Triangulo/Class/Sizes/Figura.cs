using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Triangulo.comun;

namespace Triangulo.Class.Sizes
{

    abstract class Figura
    {
        public Point Punto1 { get; set; } = new Point(50,50);
        public Point Punto2 { get; set; } = new Point(100, 100);
        public Point Punto3 { get; set; } = new Point(0, 100);

        public Figura()
        {

        }

        public Figura(Tamaños item) => SetDatos(item);
        

        void SetDatos(Tamaños item)
        {
            if (item.Equals(Tamaños.CHICO))
            {
                Punto1 = new Point(50, 50);
                Punto2 = new Point(100, 100);
                Punto3 = new Point(0, 100);
            }
            else if (item.Equals(Tamaños.MEDIANO))
            {
                Punto1 = new Point(100, 100);
                Punto2 = new Point(200, 200);
                Punto3 = new Point(0, 200);
            }

        }

        public List<Point> Points()
        {
            return new List<Point>() { Punto1, Punto2, Punto3 };
        }



    }
}
