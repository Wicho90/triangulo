using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;
using Triangulo.comun;

namespace Triangulo.Class.Sizes
{

    abstract class Figura : Mover
    {


        public Point Punto1 = new Point(300, 50);
        public Point Punto2 = new Point(330, 100);
        public Point Punto3 = new Point(270, 100);

        public PictureBox PictureBox { get; set; }
        public ComboBox CbxColor { get; set; }
        public ComboBox CbxTalla { get; set; }

        public Label LblArea { get; set; }
        public Label LblPerimetro { get; set; }


        Bitmap Bitmap { get; set; }
        Graphics Graphics { get; set; }
        Brush Brush { get; set; }


        public Color Color { get; set; }

        //limite del picture box
        protected int LimiteP = 570;
        protected int LimiteN = 25;
        public int Angulo { get; set; } = 0;
        public Figura()
        {
        }

        public Figura(Tamaños item, PictureBox pictureBox, ComboBox cbxColor, ComboBox cbxTalla, Label lblArea, Label lblPerimetro) =>
            SetDatos(item, pictureBox, cbxColor, cbxTalla, lblArea, lblPerimetro);


        public new void KeyDownOn(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(KeyRotateRight))
                RotarDerecha();
            else if (e.KeyCode.Equals(KeyRotateLeft))
                RotarIzquierda();
            else
                base.KeyDownOn(sender, e);

            Dibujar();
        }

        public void OnChangeColor(object sender, EventArgs e)
        {
            KnownColor selectedColor;
            Enum.TryParse<KnownColor>(CbxColor.SelectedValue.ToString(), out selectedColor);
            Color = Color.FromKnownColor(selectedColor);
            Dibujar();
        }

        public void OnSizeChange(object sender, EventArgs e)
        {
            Tamaños tamaño;
            Enum.TryParse<Tamaños>(CbxTalla.SelectedValue.ToString(), out tamaño);

            SetTamaño(tamaño);
            SetLabels();

            Dibujar();
        }

        protected abstract void SetTamaño(Tamaños item);

        protected void SetLabels()
        {
            LblArea.Text = $"Area: {GetArea()}";
            LblPerimetro.Text = $"Perimetro: {GetPerimetro()}";
        }

        protected virtual void SetDatos(Tamaños item, PictureBox pictureBox, ComboBox cbxColor, ComboBox cbxTalla, Label lblArea, Label lblPerimetro)
        {

            SetTamaño(item);
            PictureBox = pictureBox;
            CbxColor = cbxColor;
            CbxTalla = cbxTalla;
            LblArea = lblArea;
            LblPerimetro = lblPerimetro;
            Color = Color.Black;
            SetLabels();

        }




        public void Dibujar()
        {
            Bitmap = new Bitmap(PictureBox.Width, PictureBox.Height);
            Graphics = Graphics.FromImage(Bitmap);
            PictureBox.Image = (Image)Bitmap;

            Matrix myMatrix = new Matrix();
            myMatrix.RotateAt(Angulo, Punto1, MatrixOrder.Append);
            Graphics.Transform = myMatrix;
            Brush = new SolidBrush(Color);
            Graphics.FillPolygon(Brush, Points().ToArray());
            Graphics.DrawPolygon(Pens.Black, Points().ToArray());
        }

        public List<Point> Points() => new List<Point>() { Punto1, Punto2, Punto3 };



        //Rotacion del Triangulo
        void RotarDerecha() => Angulo += Convert.ToInt32(Movimiento.ROTAR);
        void RotarIzquierda() => Angulo -= Convert.ToInt32(Movimiento.ROTAR);


        protected abstract List<int> Lados();

        protected abstract int Altura();

        int GetPerimetro() => Lados().Sum();


        protected int GetArea()
        {
            int altura = Altura();

            return (Lados()[1] * altura) / 2;
        }




        
    }
}
