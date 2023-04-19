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


        public Equilatero(Tamaños item, PictureBox pictureBox, ComboBox cbxColor, ComboBox cbxTalla) : base(item, pictureBox, cbxColor, cbxTalla)
        {

        }
       
    }
}
