
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
            this.cbxTalla = new System.Windows.Forms.ComboBox();
            this.btnMediano = new System.Windows.Forms.Button();
            this.btnCh = new System.Windows.Forms.Button();
            this.dibujar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxColor = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.cbxColor);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbxTalla);
            this.groupBox1.Controls.Add(this.btnMediano);
            this.groupBox1.Controls.Add(this.btnCh);
            this.groupBox1.Controls.Add(this.dibujar);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(361, 754);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // cbxTalla
            // 
            this.cbxTalla.FormattingEnabled = true;
            this.cbxTalla.Location = new System.Drawing.Point(20, 79);
            this.cbxTalla.Name = "cbxTalla";
            this.cbxTalla.Size = new System.Drawing.Size(121, 24);
            this.cbxTalla.TabIndex = 15;
            this.cbxTalla.SelectedIndexChanged += new System.EventHandler(this.cbxTalla_SelectedIndexChanged);
            // 
            // btnMediano
            // 
            this.btnMediano.Location = new System.Drawing.Point(101, 199);
            this.btnMediano.Name = "btnMediano";
            this.btnMediano.Size = new System.Drawing.Size(75, 23);
            this.btnMediano.TabIndex = 14;
            this.btnMediano.Text = "M";
            this.btnMediano.UseVisualStyleBackColor = true;
            this.btnMediano.Click += new System.EventHandler(this.btnMediano_Click);
            // 
            // btnCh
            // 
            this.btnCh.Location = new System.Drawing.Point(20, 199);
            this.btnCh.Name = "btnCh";
            this.btnCh.Size = new System.Drawing.Size(75, 23);
            this.btnCh.TabIndex = 13;
            this.btnCh.Text = "CH";
            this.btnCh.UseVisualStyleBackColor = true;
            this.btnCh.Click += new System.EventHandler(this.button1_Click);
            // 
            // dibujar
            // 
            this.dibujar.Location = new System.Drawing.Point(66, 309);
            this.dibujar.Name = "dibujar";
            this.dibujar.Size = new System.Drawing.Size(165, 23);
            this.dibujar.TabIndex = 12;
            this.dibujar.Text = "Dibujar";
            this.dibujar.UseVisualStyleBackColor = true;
            this.dibujar.Click += new System.EventHandler(this.dibujar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.Location = new System.Drawing.Point(388, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(744, 754);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Tamaños";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Color";
            // 
            // cbxColor
            // 
            this.cbxColor.FormattingEnabled = true;
            this.cbxColor.Location = new System.Drawing.Point(20, 138);
            this.cbxColor.Name = "cbxColor";
            this.cbxColor.Size = new System.Drawing.Size(121, 24);
            this.cbxColor.TabIndex = 18;
            this.cbxColor.SelectedIndexChanged += new System.EventHandler(this.cbxColor_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1339, 778);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Click += new System.EventHandler(this.Form1_Click);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button dibujar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnMediano;
        private System.Windows.Forms.Button btnCh;
        private System.Windows.Forms.ComboBox cbxTalla;
        private System.Windows.Forms.ComboBox cbxColor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

