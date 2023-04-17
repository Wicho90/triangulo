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
    class Equilatero : Triangulo, ITriangulo
    {
        public Equilatero(): base()
        {

        }

        public Equilatero(Tamaños item, PictureBox pictureBox) : base(item, pictureBox)
        {

        }

        public Equilatero(Tamaños item, Colores item2, PictureBox pictureBox) : base(item, item2, pictureBox)
        {

        }
        
      

       
    }
}
