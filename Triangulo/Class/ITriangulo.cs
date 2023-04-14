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
        Keys KeyUp { get; set; }
        Keys KeyDown { get; set; }
        List<Point> Points();
        void Dibujar();
     
        int GetPerimetro();

        int GetArea();

        event EventHandler Up;
        void KeyPress(object sender, KeyEventArgs e);
    }
}
