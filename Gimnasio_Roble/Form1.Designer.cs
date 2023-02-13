namespace Gimnasio_Roble
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        // My values
        Dictionary<string, int> sueldo = new Dictionary<string, int>
            {
                {"De $ 1000000 a $ 1999999",40000 },
                {"De $ 2000000 a $ 5000000",60000 },
                {"Mas de $ 5000000",80000 }
            };

        Dictionary<string, double> estrato_fun = new Dictionary<string, double>
            {
                {"1",0.2 },
                {"2",0.2 },
                {"3",0.15 },
                {"4",0.15 },
                {"5",0.1 },
                {"6",0.1 }
            };

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Sueldo_text = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.genero = new System.Windows.Forms.ComboBox();
            this.estrato = new System.Windows.Forms.ComboBox();
            this.cedula = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(240, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre y apellidos";
            // 
            // Nombre
            // 
            this.Nombre.Location = new System.Drawing.Point(168, 252);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(313, 31);
            this.Nombre.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(286, 326);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sueldo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Cyan;
            this.label3.Location = new System.Drawing.Point(152, 415);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "estrato";
            // 
            // Sueldo_text
            // 
            this.Sueldo_text.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Sueldo_text.FormattingEnabled = true;
            this.Sueldo_text.Location = new System.Drawing.Point(122, 368);
            this.Sueldo_text.Name = "Sueldo_text";
            this.Sueldo_text.Size = new System.Drawing.Size(411, 33);
            this.Sueldo_text.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label4.Location = new System.Drawing.Point(423, 412);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Genero";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(206, 522);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(246, 43);
            this.button1.TabIndex = 9;
            this.button1.Text = "iniciar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // genero
            // 
            this.genero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genero.Items.AddRange(new object[] {
            "Masculino",
            "Femenino",
            "Otros"});
            this.genero.Location = new System.Drawing.Point(386, 451);
            this.genero.Name = "genero";
            this.genero.Size = new System.Drawing.Size(140, 33);
            this.genero.TabIndex = 10;
            this.genero.TabStop = false;
            // 
            // estrato
            // 
            this.estrato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.estrato.FormattingEnabled = true;
            this.estrato.Location = new System.Drawing.Point(110, 449);
            this.estrato.Name = "estrato";
            this.estrato.Size = new System.Drawing.Size(140, 33);
            this.estrato.TabIndex = 11;
            // 
            // cedula
            // 
            this.cedula.Location = new System.Drawing.Point(187, 148);
            this.cedula.Name = "cedula";
            this.cedula.Size = new System.Drawing.Size(267, 31);
            this.cedula.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(238, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Cedula Ciudadania";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Gimnasio_Roble.Properties.Resources.asset_generation_b6ffaaaf_f501_48d1_b468_5597820c1ae6_3_watermarked;
            this.pictureBox1.Location = new System.Drawing.Point(-219, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1052, 662);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(252, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "Gimnasio Robles";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(-1, 590);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(354, 25);
            this.label7.TabIndex = 16;
            this.label7.Text = "Creado por: Carlos Arturo Corredor MUñoz";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 624);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cedula);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.estrato);
            this.Controls.Add(this.genero);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Sueldo_text);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Gimnasio Robles";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        public TextBox Nombre;
        private Label label2;
        private Label label3;
        public ComboBox Sueldo_text;
        private Label label4;
        private Button button1;
        public ComboBox estrato;
        public ComboBox genero;
        public TextBox cedula;
        private Label label5;
        private PictureBox pictureBox1;
        private Label label6;
        private Label label7;
    }
}