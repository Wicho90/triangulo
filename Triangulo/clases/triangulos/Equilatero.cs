
using System.Windows.Forms;
using Triangulo.comun;

namespace Triangulo.Class
{
    class Equilatero : Triangulo, ITriangulo
    {


        public Equilatero(Tamaños item, PictureBox pictureBox, ComboBox cbxColor, ComboBox cbxTalla, Label lblArea, Label lblPerimetro) :
            base(item, pictureBox, cbxColor, cbxTalla, lblArea, lblPerimetro)
        {

        }

        protected override void SetTamaño(Tamaños item)
        {
            if (item.Equals(Tamaños.CHICO))
            {
                Punto2.X = Punto1.X + 30;
                Punto2.Y = Punto1.Y + 52;

                Punto3.X = Punto1.X - 30;
                Punto3.Y = Punto1.Y + 52;

            }
            else if (item.Equals(Tamaños.MEDIANO))
            {
                Punto2.X = Punto1.X + 48;
                Punto2.Y = Punto1.Y + 84;

                Punto3.X = Punto1.X - 48;
                Punto3.Y = Punto1.Y + 84;
            }
            else if (item.Equals(Tamaños.GRANDE))
            {
                Punto2.X = Punto1.X + 66;
                Punto2.Y = Punto1.Y + 115;

                Punto3.X = Punto1.X - 66;
                Punto3.Y = Punto1.Y + 115;
            }
            else if (item.Equals(Tamaños.ENORME))
            {
                Punto2.X = Punto1.X + 84;
                Punto2.Y = Punto1.Y + 146;

                Punto3.X = Punto1.X - 84;
                Punto3.Y = Punto1.Y + 146;
            }
        }
    }
}
