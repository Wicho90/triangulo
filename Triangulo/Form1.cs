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

            Triangulo = TrianguloFactory.GetTriangulo(Tamaños.CHICO, Tipo, pbxTriangulo, cbxColor, cbxTalla);

            Triangulo.Dibujar();
            
            this.KeyDown += Triangulo.KeyDownOn;
            cbxColor.SelectedIndexChanged += Triangulo.OnChangeColor;
            cbxTalla.SelectedIndexChanged += Triangulo.OnSizeChange;

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
