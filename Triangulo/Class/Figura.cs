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
        public Point Punto1 { get; set; } = new Point(300, 50);
        public Point Punto2 { get; set; } = new Point(350, 100);
        public Point Punto3 { get; set; } = new Point(250, 100);

        public Color Color { get; set; }

        public int Angulo { get; set; }
        public Figura()
        {
        }

        public Figura(Tamaños item) => SetDatos(item);
        public Figura(Tamaños item, Colores item2): this(item) => SetColor(item2);
        public Figura(Tamaños item, Colores item2, Angulos item3): this(item, item2) => SetAngulo(item3);
        
  

        protected virtual void SetDatos(Tamaños item)
        {
            if (item.Equals(Tamaños.CHICO))
            {
                Punto1 = new Point(300, 50);
                Punto2 = new Point(350, 100);
                Punto3 = new Point(250, 100);
            }
            else if (item.Equals(Tamaños.MEDIANO))
            {
                Punto1 = new Point(300, 50);
                Punto2 = new Point(400, 150);
                Punto3 = new Point(200, 150);
            }
            else if (item.Equals(Tamaños.GRANDE))
            {
                Punto1 = new Point(300, 50);
                Punto2 = new Point(450, 200);
                Punto3 = new Point(150, 200);
            }
            else if (item.Equals(Tamaños.ENORME))
            {
                Punto1 = new Point(300, 50);
                Punto2 = new Point(500, 250);
                Punto3 = new Point(100, 250);
            }

        }

        void SetColor(Colores item)
        {
            if (item.Equals(Colores.RED))
            {
                Color = Color.Red;
            }
            else if (item.Equals(Colores.AZUL))
            {
                Color = Color.Blue;
            }
            else if (item.Equals(Colores.VERDE))
            {
                Color = Color.Green;
            }
        }

        void SetAngulo(Angulos item)
        {

            if (item.Equals(Angulos.CERO))
            {
                Angulo = 0;
            }
            else if (item.Equals(Angulos.CUARENTA_Y_CINCO))
            {
                Angulo = -45;
            }
            else if (item.Equals(Angulos.NOVENTA))
            {
                Angulo = -90;
            }
            else if (item.Equals(Angulos.CIENTO_TREINTA_Y_CINCO))
            {
                Angulo = -135;
            }
            else if (item.Equals(Angulos.CIENTO_OCHENTA))
            {
                Angulo = -180;
            }
            else if (item.Equals(Angulos.DOSCIENTOS_VEINTICINCO))
            {
                Angulo = -225;
            }
            else if (item.Equals(Angulos.DOSCIENTOS_SETENTA))
            {
                Angulo = -270;
            }
            else if (item.Equals(Angulos.TRESCIENTOS_QUINCE))
            {
                Angulo = -315;
            }
            else if (item.Equals(Angulos.TRESCIENTOS_SESENTA))
            {
                Angulo = -360;
            }

        }

        public List<Point> Points()
        {
            return new List<Point>() { Punto1, Punto2, Punto3 };
        }

        public void MoverDerecha()
        {
            Punto1 = new Point(Punto1.X + 20, Punto1.Y);
            Punto2 = new Point(Punto2.X + 20, Punto2.Y);
            Punto3 = new Point(Punto3.X + 20, Punto3.Y);
        }
        
        public void MoverIzquierda()
        {
            Punto1 = new Point(Punto1.X - 20, Punto1.Y);
            Punto2 = new Point(Punto2.X - 20, Punto2.Y);
            Punto3 = new Point(Punto3.X - 20, Punto3.Y);
        }
        public void MoverArriba()
        {
            Punto1 = new Point(Punto1.X, Punto1.Y - 20);
            Punto2 = new Point(Punto2.X, Punto2.Y - 20);
            Punto3 = new Point(Punto3.X, Punto3.Y - 20);
        }
        
        public void MoverAbajo()
        {
            Punto1 = new Point(Punto1.X, Punto1.Y + 20);
            Punto2 = new Point(Punto2.X, Punto2.Y + 20);
            Punto3 = new Point(Punto3.X, Punto3.Y + 20);
        }

    }
}
