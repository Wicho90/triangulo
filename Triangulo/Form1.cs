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
        public Form1()
        {
            InitializeComponent();
            cbxTalla.DataSource = Enum.GetValues(typeof(Tamaños));
            cbxColor.DataSource = Enum.GetValues(typeof(Colores));

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
            Triangulo = new Escaleno(comun.Tamaños.CHICO);
            Triangulo.Dibujar(pictureBox1);

        }

        private void btnMediano_Click(object sender, EventArgs e)
        {
          


            Triangulo = new Escaleno(comun.Tamaños.MEDIANO);
            Triangulo.Dibujar(pictureBox1);

        }

        private void cbxTalla_SelectedIndexChanged(object sender, EventArgs e)
        {
            Enum.TryParse<Tamaños>(cbxTalla.SelectedValue.ToString(), out Tamaño);
            Triangulo = new Escaleno(Tamaño, Color);
            Triangulo.Dibujar(pictureBox1);
        }

        private void cbxColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            Enum.TryParse<Colores>(cbxColor.SelectedValue.ToString(), out Color);
            Triangulo = new Escaleno(Tamaño, Color);
            Triangulo.Dibujar(pictureBox1);
        }
    }
}
