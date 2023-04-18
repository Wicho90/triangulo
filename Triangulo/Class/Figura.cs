using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Triangulo.comun;

namespace Triangulo.Class.Sizes
{

    abstract class Figura
    {
        public event EventHandler Up;

        public Keys KeyUp { get; set; } = Keys.W;
        public Keys KeyDown { get; set; } = Keys.S;
        public Keys KeyRight { get; set; } = Keys.D;
        public Keys KeyLeft { get; set; } = Keys.A;
        public Keys KeyRotateRight { get; set; } = Keys.E;
        public Keys KeyRotateLeft { get; set; } = Keys.Q;

        public Point Punto1 = new Point(300, 50);
        public Point Punto2 = new Point(330, 100);
        public Point Punto3 = new Point(270, 100);

        public PictureBox PictureBox { get; set; }
        Bitmap Bitmap { get; set; }
        Graphics Graphics { get; set; }
        Brush Brush { get; set; }

        protected int LadoA = 100;
        protected int LadoB = 100;
        protected int LadoC = 100;
        public Color Color { get; set; }

        public int Angulo { get; set; } = 0;
        public Figura()
        {
        }

        public Figura(Tamaños item, PictureBox pictureBox) => SetDatos(item, pictureBox);
        public Figura(Tamaños item, KnownColor item2, PictureBox pictureBox) : this(item, pictureBox) => SetColor(item2);






        public void KeyDownOn(object sender, KeyEventArgs e)
        {
            //eventos para la rotacion y desplazamiento 

            if (e.KeyCode.Equals(KeyUp))
                MoverArriba();
            else if (e.KeyCode.Equals(KeyDown))
                MoverAbajo();
            else if (e.KeyCode.Equals(KeyRight))
                MoverDerecha();
            else if (e.KeyCode.Equals(KeyLeft))
                MoverIzquierda();
            else if (e.KeyCode.Equals(KeyRotateRight))
                RotarDerecha();
            else if (e.KeyCode.Equals(KeyRotateLeft))
                RotarIzquierda();

            Dibujar();
        }
        protected virtual void SetDatos(Tamaños item, PictureBox pictureBox)
        {
            Punto1 = new Point(300, 50);

            if (item.Equals(Tamaños.CHICO))
            {
                Punto2 = new Point(330, 102);
                Punto3 = new Point(270, 102);
            }
            else if (item.Equals(Tamaños.MEDIANO))
            {
                Punto2 = new Point(348, 134);
                Punto3 = new Point(252, 134);
            }
            else if (item.Equals(Tamaños.GRANDE))
            {
                Punto2 = new Point(366, 165);
                Punto3 = new Point(234, 165);
            }
            else if (item.Equals(Tamaños.ENORME))
            {
                Punto2 = new Point(384, 196);
                Punto3 = new Point(216, 196);
            }

            PictureBox = pictureBox;

        }

        void SetColor(KnownColor item)
        {
            Color = Color.FromKnownColor(item);
        }



        public void Dibujar()
        {
            Bitmap = new Bitmap(PictureBox.Width, PictureBox.Height);
            Graphics = Graphics.FromImage(Bitmap);
            PictureBox.Image = (Image)Bitmap;

            Matrix myMatrix = new Matrix();
            myMatrix.RotateAt(Angulo, Punto3, MatrixOrder.Append);
            Graphics.Transform = myMatrix;
            Brush = new SolidBrush(Color);
            Graphics.FillPolygon(Brush, Points().ToArray());
            Graphics.DrawPolygon(Pens.Black, Points().ToArray());
        }

        public List<Point> Points()
        {
            return new List<Point>() { Punto1, Punto2, Punto3 };
        }

        void MoverDerecha()
        {
            Punto1.X += Convert.ToInt32(Movimiento.DESPLAZAR);
            Punto2.X += Convert.ToInt32(Movimiento.DESPLAZAR);
            Punto3.X += Convert.ToInt32(Movimiento.DESPLAZAR);
        }

        void MoverIzquierda()
        {
            Punto1.X -= Convert.ToInt32(Movimiento.DESPLAZAR);
            Punto2.X -= Convert.ToInt32(Movimiento.DESPLAZAR);
            Punto3.X -= Convert.ToInt32(Movimiento.DESPLAZAR);
        }
        void MoverArriba()
        {
            Punto1.Y -= Convert.ToInt32(Movimiento.DESPLAZAR);
            Punto2.Y -= Convert.ToInt32(Movimiento.DESPLAZAR);
            Punto3.Y -= Convert.ToInt32(Movimiento.DESPLAZAR);
        }

        void MoverAbajo()
        {
            Punto1.Y += Convert.ToInt32(Movimiento.DESPLAZAR);
            Punto2.Y += Convert.ToInt32(Movimiento.DESPLAZAR);
            Punto3.Y += Convert.ToInt32(Movimiento.DESPLAZAR);
        }
        //Rotacion del Triangulo
        void RotarDerecha() => Angulo += Convert.ToInt32(Movimiento.ROTAR);




        void RotarIzquierda() => Angulo -= Convert.ToInt32(Movimiento.ROTAR);





        public int GetPerimetro()
        {

            SetLados();
            return LadoA + LadoB + LadoC;

        }
        
        public int GetArea()
        {
            SetLados();
            int altura = GetAltura();

            return (LadoB * altura) / 2;
        }



        int GetAltura()
        {
            return (int)Math.Sqrt(Math.Pow(LadoA, 2) - Math.Pow(LadoB / 2, 2));
        }

        void SetLados()
        {
            LadoA = (int)Math.Sqrt(Math.Pow(Punto2.X - Punto1.X, 2) + Math.Pow(Punto2.Y - Punto1.Y, 2));
            LadoB = (int)Math.Sqrt(Math.Pow(Punto3.X - Punto2.X, 2) + Math.Pow(Punto3.Y - Punto2.Y, 2));
            LadoC = (int)Math.Sqrt(Math.Pow(Punto1.X - Punto3.X, 2) + Math.Pow(Punto1.Y - Punto3.Y, 2));
        }
    }
}
