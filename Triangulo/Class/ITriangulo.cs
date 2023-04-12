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
    public interface ITriangulo
    {
        List<Point> Points();
        void Dibujar(PictureBox pictureBox);
        void MoverDerecha();
        void MoverIzquierda();
        void MoverArriba();
        void MoverAbajo();
    }
}
