using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Triangulo.Class;
using Triangulo.Class.Sizes;
using Triangulo.comun;

namespace Triangulo
{
    public partial class Form1 : Form
    {
        ITriangulo Triangulo { get; set; }

        Tamaños Tamaño;
        Colores Color;
        Tipos Tipo;

        public Form1()
        {
            InitializeComponent();
            cbxTalla.DataSource = Enum.GetValues(typeof(Tamaños));
            cbxColor.DataSource = Enum.GetValues(typeof(Colores));
            cbxTipo.DataSource = Enum.GetValues(typeof(Tipos));

        }

        private void cbxTalla_SelectedIndexChanged(object sender, EventArgs e)
        {
            Enum.TryParse<Tamaños>(cbxTalla.SelectedValue.ToString(), out Tamaño);
        }

        private void cbxColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            Enum.TryParse<Colores>(cbxColor.SelectedValue.ToString(), out Color);
        }
        private void dibujar_Click(object sender, EventArgs e)
        {
            if (Tipo == Tipos.EQUILATERO)
            {
                Triangulo = new Equilatero(Tamaño, Color);
            }
            else if (Tipo == Tipos.ESCALENO)
            {
                Triangulo = new Escaleno(Tamaño, Color);
            }
            else if (Tipo == Tipos.ISOCELES)
            {
                Triangulo = new Isosceles(Tamaño, Color);
            }

            Triangulo.Dibujar(pictureBox1);
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            Enum.TryParse<Tipos>(cbxTipo.SelectedValue.ToString(), out Tipo);

           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Triangulo.MoverDerecha();
            Triangulo.Dibujar(pictureBox1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Triangulo.MoverArriba();
            Triangulo.Dibujar(pictureBox1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Triangulo.MoverIzquierda();
            Triangulo.Dibujar(pictureBox1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Triangulo.MoverAbajo();
            Triangulo.Dibujar(pictureBox1);
        }
    }
}
