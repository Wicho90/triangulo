
namespace Triangulo
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxTipo = new System.Windows.Forms.ComboBox();
            this.cbxColor = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxTalla = new System.Windows.Forms.ComboBox();
            this.btnDibujar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbxTipo);
            this.groupBox1.Controls.Add(this.cbxColor);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbxTalla);
            this.groupBox1.Controls.Add(this.btnDibujar);
            this.groupBox1.Location = new System.Drawing.Point(9, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(271, 613);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(38, 287);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 19);
            this.button2.TabIndex = 28;
            this.button2.Text = "Area";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(37, 255);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 27);
            this.button1.TabIndex = 27;
            this.button1.Text = "Perimetro";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 141);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Tipo";
            // 
            // cbxTipo
            // 
            this.cbxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipo.FormattingEnabled = true;
            this.cbxTipo.Location = new System.Drawing.Point(15, 160);
            this.cbxTipo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxTipo.Name = "cbxTipo";
            this.cbxTipo.Size = new System.Drawing.Size(92, 21);
            this.cbxTipo.TabIndex = 19;
            this.cbxTipo.TabStop = false;
            this.cbxTipo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cbxColor
            // 
            this.cbxColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxColor.FormattingEnabled = true;
            this.cbxColor.Location = new System.Drawing.Point(15, 112);
            this.cbxColor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxColor.Name = "cbxColor";
            this.cbxColor.Size = new System.Drawing.Size(92, 21);
            this.cbxColor.TabIndex = 18;
            this.cbxColor.TabStop = false;
            this.cbxColor.SelectedIndexChanged += new System.EventHandler(this.cbxColor_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Color";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Tamaños";
            // 
            // cbxTalla
            // 
            this.cbxTalla.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTalla.FormattingEnabled = true;
            this.cbxTalla.Location = new System.Drawing.Point(15, 64);
            this.cbxTalla.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxTalla.Name = "cbxTalla";
            this.cbxTalla.Size = new System.Drawing.Size(92, 21);
            this.cbxTalla.TabIndex = 15;
            this.cbxTalla.TabStop = false;
            this.cbxTalla.SelectedIndexChanged += new System.EventHandler(this.cbxTalla_SelectedIndexChanged);
            // 
            // btnDibujar
            // 
            this.btnDibujar.Location = new System.Drawing.Point(38, 209);
            this.btnDibujar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDibujar.Name = "btnDibujar";
            this.btnDibujar.Size = new System.Drawing.Size(124, 19);
            this.btnDibujar.TabIndex = 12;
            this.btnDibujar.TabStop = false;
            this.btnDibujar.Text = "Dibujar";
            this.btnDibujar.UseVisualStyleBackColor = true;
            this.btnDibujar.Click += new System.EventHandler(this.dibujar_Click);
            this.btnDibujar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnDibujar_KeyDown);
          
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.Location = new System.Drawing.Point(291, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(600, 613);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
          
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 632);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
           
           
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbxTalla;
        private System.Windows.Forms.ComboBox cbxColor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxTipo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDibujar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

