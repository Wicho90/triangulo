using System.Windows.Forms;
using Triangulo.comun;

namespace Triangulo.Class
{
    class TrianguloFactory
    {

        public static ITriangulo GetTriangulo(Tamaños Tamaño, Tipos tipo, PictureBox pictureBox, ComboBox cbxColor, ComboBox cbxTalla, Label lblArea, Label lblPerimetro)
        {
            ITriangulo Triangulo = null;

            if (tipo == Tipos.EQUILATERO)
            {
                Triangulo = new Equilatero(Tamaño, pictureBox, cbxColor, cbxTalla, lblArea, lblPerimetro);
            }
            else if (tipo == Tipos.ESCALENO)
            {
                Triangulo = new Escaleno(Tamaño, pictureBox, cbxColor, cbxTalla, lblArea, lblPerimetro);
            }
            else if (tipo == Tipos.ISOCELES)
            {
                Triangulo = new Isosceles(Tamaño, pictureBox, cbxColor, cbxTalla, lblArea, lblPerimetro);
            }
            else
            {
                Triangulo = new Equilatero(Tamaño, pictureBox, cbxColor, cbxTalla, lblArea, lblPerimetro);
            }


            return Triangulo;

        }
    }
}
