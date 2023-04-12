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

namespace Triangulo
{
    public partial class Form1 : Form
    {
        PictureBox PictureBox;
        ITriangulo Triangulo { get; set; }
        public Form1()
        {
            Bitmap b = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            InitializeComponent();

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxX1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {

            Triangulo = new Escaleno(comun.Tamaños.CHICO);


            // Dibujamos el triángulo
            e.Graphics.DrawPolygon(Pens.Black, Triangulo.Points().ToArray());

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Click(object sender, EventArgs e)
        {

        }

        private void dibujar_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
    }
}
