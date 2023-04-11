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

        public Form1()
        {
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

            Escaleno escaleno = new Escaleno();
            Tamnho size = new Tamnho(new Point(50, 50), new Point(100, 100), new Point(0, 100));
            escaleno.Sizes = size;

            escaleno.Sizes.MakeMedium();


            // Dibujamos el triángulo
            e.Graphics.DrawPolygon(Pens.Black, escaleno.Sizes.Points());

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
