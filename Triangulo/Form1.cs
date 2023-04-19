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

            Triangulo = TrianguloFactory.GetTriangulo(Tamaño, Tipo, pbxTriangulo, cbxColor);

            Triangulo.Dibujar();
            btnDibujar.KeyDown += Triangulo.KeyDownOn;
            cbxColor.SelectedIndexChanged += Triangulo.OnChangeColor;
        }
        
        private void cbxTalla_SelectedIndexChanged(object sender, EventArgs e)
        {
            Enum.TryParse<Tamaños>(cbxTalla.SelectedValue.ToString(), out Tamaño);
       
        }

        private void cbxColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }
        private void dibujar_Click(object sender, EventArgs e)
        {
           
           
            
            
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Enum.TryParse<Tipos>(cbxTipo.SelectedValue.ToString(), out Tipo);
        }


        //private void btnDibujar_KeyDown(object sender, KeyEventArgs e)
       // {
         //   Triangulo.KeyPress(sender, e);
        //}


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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }
    }
}
