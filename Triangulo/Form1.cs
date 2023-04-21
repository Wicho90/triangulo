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



        Tipos Tipo;


        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;

            cbxTalla.DataSource = Enum.GetValues(typeof(Tamaños));

            cbxColor.DataSource = Enum.GetValues(typeof(KnownColor));

            cbxTipo.DataSource = Enum.GetValues(typeof(Tipos));

            Triangulo = TrianguloFactory.GetTriangulo(Tamaños.CHICO, Tipo, pbxTriangulo, cbxColor, cbxTalla, lblArea, lblPerimetro);


            this.KeyDown += Triangulo.KeyDownOn;
            cbxColor.SelectedIndexChanged += Triangulo.OnChangeColor;
            cbxTalla.SelectedIndexChanged += Triangulo.OnSizeChange;

            Triangulo.Dibujar();


        }





        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Enum.TryParse<Tipos>(cbxTipo.SelectedValue.ToString(), out Tipo);
        }



        private void button1_Click_1(object sender, EventArgs e)
        {
           
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lblArea_Click(object sender, EventArgs e)
        {

        }

        private void pbxTriangulo_Click(object sender, EventArgs e)
        {

        }
    }
}
