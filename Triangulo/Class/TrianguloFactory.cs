using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Triangulo.comun;

namespace Triangulo.Class
{
    class TrianguloFactory
    {
        public static ITriangulo GetTriangulo(Tamaños Tamaño, Colores Color, Angulos Angulo, Tipos tipo)
        {
            ITriangulo Triangulo = null;

            if (tipo == Tipos.EQUILATERO)
            {
                Triangulo = new Equilatero(Tamaño, Color, Angulo);
            }
            else if (tipo == Tipos.ESCALENO)
            {
                Triangulo = new Escaleno(Tamaño, Color, Angulo);
            }
            else if (tipo == Tipos.ISOCELES)
            {
                Triangulo = new Isosceles(Tamaño, Color, Angulo);
            }
            else
            {
                Triangulo = new Equilatero(Tamaño, Color, Angulo);
            }

            return Triangulo;

        }
    }
}
