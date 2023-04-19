using System.Drawing;
using System.Windows.Forms;
using Triangulo.comun;

namespace Triangulo.Class
{
    class Isosceles : Triangulo, ITriangulo
    {

        public Isosceles(Tamaños item, PictureBox pictureBox, ComboBox cbxColor) : base(item, pictureBox, cbxColor)
        {

        }


        protected override void SetDatos(Tamaños item, PictureBox pictureBox, ComboBox cbxColor)
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

            
            PictureBox = pictureBox;
            CbxColor = cbxColor;
            Color = Color.Black;
        }
    }
}
