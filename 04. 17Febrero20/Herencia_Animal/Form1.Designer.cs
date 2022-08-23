namespace Herencia_Animal
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
            this.NombreBox = new System.Windows.Forms.TextBox();
            this.TipoBox = new System.Windows.Forms.TextBox();
            this.PesoBox = new System.Windows.Forms.TextBox();
            this.TallaBox = new System.Windows.Forms.TextBox();
            this.Nombre = new System.Windows.Forms.Label();
            this.Tipo = new System.Windows.Forms.Label();
            this.Peso = new System.Windows.Forms.Label();
            this.Talla = new System.Windows.Forms.Label();
            this.Perro1Box = new System.Windows.Forms.TextBox();
            this.OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NombreBox
            // 
            this.NombreBox.Location = new System.Drawing.Point(167, 73);
            this.NombreBox.Name = "NombreBox";
            this.NombreBox.Size = new System.Drawing.Size(100, 20);
            this.NombreBox.TabIndex = 0;
            // 
            // TipoBox
            // 
            this.TipoBox.Location = new System.Drawing.Point(167, 99);
            this.TipoBox.Name = "TipoBox";
            this.TipoBox.Size = new System.Drawing.Size(100, 20);
            this.TipoBox.TabIndex = 1;
            // 
            // PesoBox
            // 
            this.PesoBox.Location = new System.Drawing.Point(167, 125);
            this.PesoBox.Name = "PesoBox";
            this.PesoBox.Size = new System.Drawing.Size(100, 20);
            this.PesoBox.TabIndex = 2;
            // 
            // TallaBox
            // 
            this.TallaBox.Location = new System.Drawing.Point(167, 151);
            this.TallaBox.Name = "TallaBox";
            this.TallaBox.Size = new System.Drawing.Size(100, 20);
            this.TallaBox.TabIndex = 3;
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(117, 76);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(44, 13);
            this.Nombre.TabIndex = 4;
            this.Nombre.Text = "Nombre";
            // 
            // Tipo
            // 
            this.Tipo.AutoSize = true;
            this.Tipo.Location = new System.Drawing.Point(117, 102);
            this.Tipo.Name = "Tipo";
            this.Tipo.Size = new System.Drawing.Size(28, 13);
            this.Tipo.TabIndex = 5;
            this.Tipo.Text = "Tipo";
            // 
            // Peso
            // 
            this.Peso.AutoSize = true;
            this.Peso.Location = new System.Drawing.Point(117, 128);
            this.Peso.Name = "Peso";
            this.Peso.Size = new System.Drawing.Size(31, 13);
            this.Peso.TabIndex = 6;
            this.Peso.Text = "Peso";
            // 
            // Talla
            // 
            this.Talla.AutoSize = true;
            this.Talla.Location = new System.Drawing.Point(117, 154);
            this.Talla.Name = "Talla";
            this.Talla.Size = new System.Drawing.Size(30, 13);
            this.Talla.TabIndex = 7;
            this.Talla.Text = "Talla";
            // 
            // Perro1Box
            // 
            this.Perro1Box.Location = new System.Drawing.Point(273, 50);
            this.Perro1Box.Multiline = true;
            this.Perro1Box.Name = "Perro1Box";
            this.Perro1Box.Size = new System.Drawing.Size(227, 145);
            this.Perro1Box.TabIndex = 8;
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(180, 177);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 9;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 321);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.Perro1Box);
            this.Controls.Add(this.Talla);
            this.Controls.Add(this.Peso);
            this.Controls.Add(this.Tipo);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.TallaBox);
            this.Controls.Add(this.PesoBox);
            this.Controls.Add(this.TipoBox);
            this.Controls.Add(this.NombreBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NombreBox;
        private System.Windows.Forms.TextBox TipoBox;
        private System.Windows.Forms.TextBox PesoBox;
        private System.Windows.Forms.TextBox TallaBox;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Label Tipo;
        private System.Windows.Forms.Label Peso;
        private System.Windows.Forms.Label Talla;
        private System.Windows.Forms.TextBox Perro1Box;
        private System.Windows.Forms.Button OK;
    }
}

