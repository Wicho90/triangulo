using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Triangulo.comun;

namespace Triangulo.Class
{
    class TrianguloFactory
    {
        public static ITriangulo GetTriangulo(Tamaños Tamaño, KnownColor Color, Angulos Angulo, Tipos tipo, PictureBox pictureBox)
        {
            ITriangulo Triangulo = null;

            if (tipo == Tipos.EQUILATERO)
            {
                Triangulo = new Equilatero(Tamaño, Color, Angulo, pictureBox);
            }
            else if (tipo == Tipos.ESCALENO)
            {
                Triangulo = new Escaleno(Tamaño, Color, Angulo, pictureBox);
            }
            else if (tipo == Tipos.ISOCELES)
            {
                Triangulo = new Isosceles(Tamaño, Color, Angulo, pictureBox);
            }
            else
            {
                Triangulo = new Equilatero(Tamaño, Color, Angulo, pictureBox);
            }

            return Triangulo;

        }
    }
}
