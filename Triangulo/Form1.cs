using System;
using System.Drawing;
using System.Windows.Forms;
using Triangulo.Class;
using Triangulo.comun;

namespace Triangulo
{
    public partial class Form1 : Form
    {
        ITriangulo Triangulo { get; set; }

        Tamaños Tamaño;

        KnownColor Color;
        Tipos Tipo;


        public Form1()
        {
            InitializeComponent();
            cbxTalla.DataSource = Enum.GetValues(typeof(Tamaños));

            cbxColor.DataSource = Enum.GetValues(typeof(KnownColor));

            cbxTipo.DataSource = Enum.GetValues(typeof(Tipos));
        }
        
        private void cbxTalla_SelectedIndexChanged(object sender, EventArgs e)
        {
            Enum.TryParse<Tamaños>(cbxTalla.SelectedValue.ToString(), out Tamaño);
        }

        private void cbxColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            Enum.TryParse<KnownColor>(cbxColor.SelectedValue.ToString(), out Color);
        }
        private void dibujar_Click(object sender, EventArgs e)
        {

            Triangulo = TrianguloFactory.GetTriangulo(Tamaño, Color, Tipo, pictureBox1);
            Triangulo.Dibujar();
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Enum.TryParse<Tipos>(cbxTipo.SelectedValue.ToString(), out Tipo);
        }


        private void btnDibujar_KeyDown(object sender, KeyEventArgs e)
        {
            Triangulo.KeyPress(sender, e);
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            if (Triangulo != null)
                MessageBox.Show(Triangulo.GetPerimetro().ToString() + "cm");
            else
                MessageBox.Show("Porfavor dibuja el triangulo antes");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (Triangulo != null)
                MessageBox.Show(Triangulo.GetArea().ToString() + "cm2");
            else
                MessageBox.Show("Porfavor dibuja el triangulo antes");
        }


    }
}
