using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Triangulo.Class.Sizes;
using Triangulo.comun;

namespace Triangulo.Class
{
    class Triangulo: Figura
    {

        public Triangulo(): base(Tamaños.CHICO)
        {

        }
        public Triangulo(Tamaños item): base(item)
        {

        }

        public Triangulo(Tamaños item, Colores item2): base(item, item2)
        {

        }

        

        public void Dibujar(PictureBox pictureBox1)
        {
            Bitmap b = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics g = Graphics.FromImage(b);
            pictureBox1.Image = (Image)b;
            Brush brush = new SolidBrush(Color);

            g.FillPolygon(brush, Points().ToArray());
            g.DrawPolygon(Pens.Black, Points().ToArray());
        }

    }
}
