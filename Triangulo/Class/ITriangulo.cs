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
        void Dibujar();
     
        int GetPerimetro();

        int GetArea();

        event EventHandler Up;
        void KeyDownOn(object sender, KeyEventArgs e);
        void OnChangeColor(object sender, EventArgs e);

        void OnSizeChange(object sender, EventArgs e);

    }
}
