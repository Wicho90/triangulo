using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Triangulo.Class.Sizes;
using Triangulo.comun;

namespace Triangulo.Class
{
    class Triangulo : Figura
    {



        public Triangulo(Tamaños item, PictureBox pictureBox, ComboBox cbxColor, ComboBox cbxTalla, Label lblArea, Label lblPerimetro):
            base(item, pictureBox, cbxColor, cbxTalla, lblArea, lblPerimetro)
        {

        }


        protected override void MoverDerecha()
        {
            if (Punto2.X <= LimiteP)
            {
                Punto1.X += Convert.ToInt32(Movimiento.DESPLAZAR);
                Punto2.X += Convert.ToInt32(Movimiento.DESPLAZAR);
                Punto3.X += Convert.ToInt32(Movimiento.DESPLAZAR);
            }

        }

        protected override void MoverIzquierda()
        {
            if (Punto3.X >= LimiteN)
            {
                Punto1.X -= Convert.ToInt32(Movimiento.DESPLAZAR);
                Punto2.X -= Convert.ToInt32(Movimiento.DESPLAZAR);
                Punto3.X -= Convert.ToInt32(Movimiento.DESPLAZAR);
            }

        }
        protected override void MoverArriba()
        {
            if (Punto1.Y >= LimiteN)
            {
                Punto1.Y -= Convert.ToInt32(Movimiento.DESPLAZAR);
                Punto2.Y -= Convert.ToInt32(Movimiento.DESPLAZAR);
                Punto3.Y -= Convert.ToInt32(Movimiento.DESPLAZAR);
            }

        }

        protected override void MoverAbajo()
        {
            if (Punto3.Y <= LimiteP)
            {
                Punto1.Y += Convert.ToInt32(Movimiento.DESPLAZAR);
                Punto2.Y += Convert.ToInt32(Movimiento.DESPLAZAR);
                Punto3.Y += Convert.ToInt32(Movimiento.DESPLAZAR);
            }

        }


        protected override void SetTamaño(Tamaños item)
        {
            throw new NotImplementedException();
        }
        
        protected override List<int> Lados() => new List<int>()
        {
            (int)Math.Sqrt(Math.Pow(Punto2.X - Punto1.X, 2) + Math.Pow(Punto2.Y - Punto1.Y, 2)),
            (int)Math.Sqrt(Math.Pow(Punto3.X - Punto2.X, 2) + Math.Pow(Punto3.Y - Punto2.Y, 2)),
            (int)Math.Sqrt(Math.Pow(Punto3.X - Punto2.X, 2) + Math.Pow(Punto3.Y - Punto2.Y, 2))
        };

        protected override int Altura() => (int)Math.Sqrt(Math.Pow(Lados()[0], 2) - Math.Pow(Lados()[1] / 2, 2));

    }
}
