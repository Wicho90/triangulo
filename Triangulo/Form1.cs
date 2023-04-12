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
        Angulos Angulo;

        public Form1()
        {
            InitializeComponent();
            cbxTalla.DataSource = Enum.GetValues(typeof(Tamaños));
            cbxColor.DataSource = Enum.GetValues(typeof(Colores));
            cbxTipo.DataSource = Enum.GetValues(typeof(Tipos));
            cbxAngulo.DataSource = Enum.GetValues(typeof(Angulos));

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

            Triangulo = TrianguloFactory.GetTriangulo(Tamaño, Color, Angulo, Tipo);
            Triangulo.Dibujar(pictureBox1);
        }

       

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Enum.TryParse<Tipos>(cbxTipo.SelectedValue.ToString(), out Tipo);
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Enum.TryParse<Angulos>(cbxAngulo.SelectedValue.ToString(), out Angulo);
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

        private void btnDibujar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                Triangulo.MoverArriba();
            }

            if (e.KeyCode == Keys.S)
            {
                Triangulo.MoverAbajo();
            }

            if (e.KeyCode == Keys.D)
            {
                Triangulo.MoverDerecha();

            }

            if (e.KeyCode == Keys.A)
            {
                Triangulo.MoverIzquierda();
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

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
          

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void button5_KeyDown(object sender, KeyEventArgs e)
        {

            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnDibujar_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //Hola 
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
