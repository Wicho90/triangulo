using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
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
        
        public Triangulo(): base(Tamaños.CHICO, new PictureBox())
        {

        }
        public Triangulo(Tamaños item, PictureBox pictureBox) : base(item, pictureBox)
        {

        }

        public Triangulo(Tamaños item, KnownColor item2, PictureBox pictureBox) : base(item, item2, pictureBox)
        {

        }

        public Triangulo(Tamaños item, KnownColor item2, Angulos item3, PictureBox pictureBox) : base(item, item2, item3, pictureBox)
        {

        }


        

        


    }
}
