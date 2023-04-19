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

        
        Tipos Tipo;


        public Form1()
        {
            InitializeComponent();
            cbxTalla.DataSource = Enum.GetValues(typeof(Tamaños));

            cbxColor.DataSource = Enum.GetValues(typeof(KnownColor));

            cbxTipo.DataSource = Enum.GetValues(typeof(Tipos));

            Triangulo = TrianguloFactory.GetTriangulo(Tamaños.ENORME, Tipo, pbxTriangulo, cbxColor);

            Triangulo.Dibujar();
            cbxColor.SelectedIndexChanged += Triangulo.OnChangeColor;
            this.KeyPreview = true;

            this.KeyDown += Triangulo.KeyDownOn;

        }
        
        private void cbxTalla_SelectedIndexChanged(object sender, EventArgs e)
        {
            Enum.TryParse<Tamaños>(cbxTalla.SelectedValue.ToString(), out Tamaño);
       
        }

       


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Enum.TryParse<Tipos>(cbxTipo.SelectedValue.ToString(), out Tipo);
        }


        


        private void button1_Click_1(object sender, EventArgs e)
        {
            if (Triangulo != null)//exepcion para que el programa no se detenga
                MessageBox.Show(Triangulo.GetPerimetro().ToString() + "cm");
            else
                MessageBox.Show("Porfavor dibuja el triangulo antes");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (Triangulo != null) //exepcion para que el programa no se detenga
                MessageBox.Show(Triangulo.GetArea().ToString() + "cm2");
            else
                MessageBox.Show("Porfavor dibuja el triangulo antes");
        }

       

       
    }
}
