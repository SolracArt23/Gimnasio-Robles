namespace Gimnasio_Roble
{
    partial class Respuesta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cedula = new System.Windows.Forms.TextBox();
            this.nombre_r = new System.Windows.Forms.TextBox();
            this.sueldo = new System.Windows.Forms.TextBox();
            this.estrato = new System.Windows.Forms.TextBox();
            this.genero = new System.Windows.Forms.TextBox();
            this.Resultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 25);
            this.label5.TabIndex = 17;
            this.label5.Text = "Cedula Ciudadania";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 25);
            this.label4.TabIndex = 16;
            this.label4.Text = "Genero";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "estrato";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Sueldo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nombre y apellidos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(111, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 25);
            this.label6.TabIndex = 18;
            this.label6.Text = "toal a pagar";
            // 
            // cedula
            // 
            this.cedula.Location = new System.Drawing.Point(202, 27);
            this.cedula.Name = "cedula";
            this.cedula.ReadOnly = true;
            this.cedula.Size = new System.Drawing.Size(267, 31);
            this.cedula.TabIndex = 19;
            // 
            // nombre_r
            // 
            this.nombre_r.Location = new System.Drawing.Point(202, 78);
            this.nombre_r.Name = "nombre_r";
            this.nombre_r.ReadOnly = true;
            this.nombre_r.Size = new System.Drawing.Size(267, 31);
            this.nombre_r.TabIndex = 20;
            // 
            // sueldo
            // 
            this.sueldo.Location = new System.Drawing.Point(111, 125);
            this.sueldo.Name = "sueldo";
            this.sueldo.ReadOnly = true;
            this.sueldo.Size = new System.Drawing.Size(267, 31);
            this.sueldo.TabIndex = 21;
            // 
            // estrato
            // 
            this.estrato.Location = new System.Drawing.Point(111, 162);
            this.estrato.Name = "estrato";
            this.estrato.ReadOnly = true;
            this.estrato.Size = new System.Drawing.Size(39, 31);
            this.estrato.TabIndex = 22;
            // 
            // genero
            // 
            this.genero.Location = new System.Drawing.Point(111, 199);
            this.genero.Name = "genero";
            this.genero.ReadOnly = true;
            this.genero.Size = new System.Drawing.Size(127, 31);
            this.genero.TabIndex = 23;
            // 
            // Resultado
            // 
            this.Resultado.AutoSize = true;
            this.Resultado.Location = new System.Drawing.Point(302, 301);
            this.Resultado.Name = "Resultado";
            this.Resultado.Size = new System.Drawing.Size(0, 25);
            this.Resultado.TabIndex = 24;
            // 
            // Respuesta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 362);
            this.Controls.Add(this.Resultado);
            this.Controls.Add(this.genero);
            this.Controls.Add(this.estrato);
            this.Controls.Add(this.sueldo);
            this.Controls.Add(this.nombre_r);
            this.Controls.Add(this.cedula);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Respuesta";
            this.Text = "Respuesta";
            this.Load += new System.EventHandler(this.Respuesta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label6;
        public TextBox cedula;
        public TextBox nombre_r;
        public TextBox sueldo;
        public TextBox estrato;
        public TextBox genero;
        public Label Resultado;
    }
}