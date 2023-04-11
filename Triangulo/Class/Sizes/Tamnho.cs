using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangulo.Class.Sizes
{
    
    public class Tamnho
    {
        public Point Punto1 { get; set; }
        public Point Punto2 { get; set; }
        public Point Punto3 { get; set; }


        public Tamnho(Point punto1, Point punto2, Point punto3)
        {
            Punto1 = punto1;
            Punto2 = punto2;
            Punto3 = punto3;
        }

        public Point[] Points()
        {
            return new Point[3] { Punto1, Punto2, Punto3 };
        }

        public void MakeSmall()
        {
            Punto1 = new Point(Punto1.X * 3, Punto1.Y * 3);
            Punto2 = new Point(Punto2.X * 3, Punto2.Y * 3);
            Punto3 = new Point(Punto3.X * 3, Punto3.Y * 3);
        }


        public void MakeMedium()
        {
            Punto1 = new Point(Punto1.X * 3, Punto1.Y * 3);
            Punto2 = new Point(Punto2.X * 3, Punto2.Y * 3);
            Punto3 = new Point(Punto3.X * 3, Punto3.Y * 3);
        }

        public void MakeLarge()
        {
            Punto1 = new Point(Punto1.X * 3, Punto1.Y * 3);
            Punto2 = new Point(Punto2.X * 3, Punto2.Y * 3);
            Punto3 = new Point(Punto3.X * 3, Punto3.Y * 3);
        }

        public void MakeExtraLarge()
        {
            Punto1 = new Point(Punto1.X * 3, Punto1.Y * 3);
            Punto2 = new Point(Punto2.X * 3, Punto2.Y * 3);
            Punto3 = new Point(Punto3.X * 3, Punto3.Y * 3);
        }


    }
}
