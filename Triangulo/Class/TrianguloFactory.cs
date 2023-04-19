using System.Windows.Forms;
using Triangulo.comun;

namespace Triangulo.Class
{
    class TrianguloFactory
    {

        public static ITriangulo GetTriangulo(Tamaños Tamaño, Tipos tipo, PictureBox pictureBox, ComboBox cbxColor, ComboBox cbxTalla)
        {
            ITriangulo Triangulo = null;

            if (tipo == Tipos.EQUILATERO)
            {
                Triangulo = new Equilatero(Tamaño, pictureBox, cbxColor, cbxTalla);
            }
            else if (tipo == Tipos.ESCALENO)
            {
                Triangulo = new Escaleno(Tamaño, pictureBox, cbxColor, cbxTalla);
            }
            else if (tipo == Tipos.ISOCELES)
            {
                Triangulo = new Isosceles(Tamaño, pictureBox, cbxColor, cbxTalla);
            }
            else
            {
                Triangulo = new Equilatero(Tamaño, pictureBox, cbxColor, cbxTalla);
            }

            return Triangulo;

        }
    }
}
