using System.Windows.Forms;
using Triangulo.comun;

namespace Triangulo.Class
{
    class TrianguloFactory
    {
        public static ITriangulo GetTriangulo(Tamaños Tamaño, Colores Color, Tipos tipo, PictureBox pictureBox)
        {
            ITriangulo Triangulo = null;

            if (tipo == Tipos.EQUILATERO)
            {
                Triangulo = new Equilatero(Tamaño, Color, pictureBox);
            }
            else if (tipo == Tipos.ESCALENO)
            {
                Triangulo = new Escaleno(Tamaño, Color, pictureBox);
            }
            else if (tipo == Tipos.ISOCELES)
            {
                Triangulo = new Isosceles(Tamaño, Color, pictureBox);
            }
            else
            {
                Triangulo = new Equilatero(Tamaño, Color, pictureBox);
            }

            return Triangulo;

        }
    }
}
