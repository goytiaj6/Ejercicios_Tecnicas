namespace _24Febrero20
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bttnTamaño = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.bttnDato = new System.Windows.Forms.Button();
            this.bttnSuma = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese el tamaño del arreglo:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(200, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // bttnTamaño
            // 
            this.bttnTamaño.Location = new System.Drawing.Point(132, 56);
            this.bttnTamaño.Name = "bttnTamaño";
            this.bttnTamaño.Size = new System.Drawing.Size(75, 23);
            this.bttnTamaño.TabIndex = 2;
            this.bttnTamaño.Text = "OK";
            this.bttnTamaño.UseVisualStyleBackColor = true;
            this.bttnTamaño.Click += new System.EventHandler(this.bttnTamaño_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ingrese un dato:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(200, 92);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            // 
            // bttnDato
            // 
            this.bttnDato.Location = new System.Drawing.Point(132, 118);
            this.bttnDato.Name = "bttnDato";
            this.bttnDato.Size = new System.Drawing.Size(75, 23);
            this.bttnDato.TabIndex = 5;
            this.bttnDato.Text = "OK";
            this.bttnDato.UseVisualStyleBackColor = true;
            this.bttnDato.Click += new System.EventHandler(this.bttnDato_Click);
            // 
            // bttnSuma
            // 
            this.bttnSuma.Location = new System.Drawing.Point(354, 65);
            this.bttnSuma.Name = "bttnSuma";
            this.bttnSuma.Size = new System.Drawing.Size(77, 43);
            this.bttnSuma.TabIndex = 6;
            this.bttnSuma.Text = "Calcular suma";
            this.bttnSuma.UseVisualStyleBackColor = true;
            this.bttnSuma.Click += new System.EventHandler(this.bttnSuma_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 175);
            this.Controls.Add(this.bttnSuma);
            this.Controls.Add(this.bttnDato);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bttnTamaño);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button bttnTamaño;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button bttnDato;
        private System.Windows.Forms.Button bttnSuma;
    }
}

