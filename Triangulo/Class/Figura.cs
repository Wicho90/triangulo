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
        public Point Punto1 { get; set; } = new Point(300, 50);
        public Point Punto2 { get; set; } = new Point(330, 100);
        public Point Punto3 { get; set; } = new Point(270, 100);


        public Keys KeyUp { get; set; } = Keys.W;
        public Keys KeyDown { get; set; } = Keys.S;
        public Keys KeyRight { get; set; } = Keys.D;
        public Keys KeyLeft { get; set; } = Keys.A;
        public Keys KeyRotateRight { get; set; } = Keys.E;
        public Keys KeyRotateLeft { get; set; } = Keys.Q;
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
        public Figura(Tamaños item, Colores item2, PictureBox pictureBox) : this(item, pictureBox) => SetColor(item2);
        public Figura(Tamaños item, Colores item2, Angulos item3, PictureBox pictureBox) : this(item, item2, pictureBox) => SetAngulo(item3);
        
  
        public void KeyPress(object sender, KeyEventArgs e)
        {
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

        void SetColor(Colores item)
        {
            if (item.Equals(Colores.RED))
                Color = Color.Red;
            else if (item.Equals(Colores.AZUL))
                Color = Color.Blue;
            else if (item.Equals(Colores.VERDE))
                Color = Color.Green;


        }

        void SetAngulo(Angulos item)
        {

            if (item.Equals(Angulos.CERO))
                Angulo = 0;
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

            
            Brush = new SolidBrush(Color);


        }

        public void Dibujar()
        {
            Bitmap = new Bitmap(PictureBox.Width, PictureBox.Height);
            Graphics = Graphics.FromImage(Bitmap);
            PictureBox.Image = (Image)Bitmap;

            Matrix myMatrix = new Matrix();
            myMatrix.RotateAt(Angulo, Punto3, MatrixOrder.Append);
            Graphics.Transform = myMatrix;

            Graphics.FillPolygon(Brush, Points().ToArray());
            Graphics.DrawPolygon(Pens.Black, Points().ToArray());
        }

        public List<Point> Points()
        {
            return new List<Point>() { Punto1, Punto2, Punto3 };
        }

        void MoverDerecha()
        {

            Punto1 = new Point(Punto1.X + 20, Punto1.Y);
            Punto2 = new Point(Punto2.X + 20, Punto2.Y);
            Punto3 = new Point(Punto3.X + 20, Punto3.Y);
        }
        
        void MoverIzquierda()
        {
            Punto1 = new Point(Punto1.X - 20, Punto1.Y);
            Punto2 = new Point(Punto2.X - 20, Punto2.Y);
            Punto3 = new Point(Punto3.X - 20, Punto3.Y);
        }
        void MoverArriba()
        {
            Console.WriteLine("Moviendo arriba");
            Punto1 = new Point(Punto1.X, Punto1.Y - 20);
            Punto2 = new Point(Punto2.X, Punto2.Y - 20);
            Punto3 = new Point(Punto3.X, Punto3.Y - 20);
        }
        
        void MoverAbajo()
        {
            Punto1 = new Point(Punto1.X, Punto1.Y + 20);
            Punto2 = new Point(Punto2.X, Punto2.Y + 20);
            Punto3 = new Point(Punto3.X, Punto3.Y + 20);
        }

        void RotarDerecha()
        {
            Angulo += 45;
        }

        void RotarIzquierda()
        {
            Angulo -= 45;
        }


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
