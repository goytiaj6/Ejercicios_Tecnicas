namespace _5Febrero20
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
            this.Text1 = new System.Windows.Forms.Label();
            this.Box1 = new System.Windows.Forms.TextBox();
            this.btSuma = new System.Windows.Forms.Button();
            this.btFibonacci = new System.Windows.Forms.Button();
            this.btSerie = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Text1
            // 
            this.Text1.AutoSize = true;
            this.Text1.Location = new System.Drawing.Point(223, 42);
            this.Text1.Name = "Text1";
            this.Text1.Size = new System.Drawing.Size(354, 13);
            this.Text1.TabIndex = 1;
            this.Text1.Text = "Ingrese el límite de números enteros para la suma y términos de Fibonacci";
            // 
            // Box1
            // 
            this.Box1.Location = new System.Drawing.Point(350, 78);
            this.Box1.Name = "Box1";
            this.Box1.Size = new System.Drawing.Size(106, 20);
            this.Box1.TabIndex = 2;
            this.Box1.TextChanged += new System.EventHandler(this.Box1_TextChanged);
            // 
            // btSuma
            // 
            this.btSuma.Location = new System.Drawing.Point(366, 128);
            this.btSuma.Name = "btSuma";
            this.btSuma.Size = new System.Drawing.Size(75, 23);
            this.btSuma.TabIndex = 3;
            this.btSuma.Text = "Suma";
            this.btSuma.UseVisualStyleBackColor = true;
            this.btSuma.Click += new System.EventHandler(this.BtSuma_Click);
            // 
            // btFibonacci
            // 
            this.btFibonacci.Location = new System.Drawing.Point(366, 173);
            this.btFibonacci.Name = "btFibonacci";
            this.btFibonacci.Size = new System.Drawing.Size(75, 23);
            this.btFibonacci.TabIndex = 4;
            this.btFibonacci.Text = "Fibonacci";
            this.btFibonacci.UseVisualStyleBackColor = true;
            this.btFibonacci.Click += new System.EventHandler(this.BtFibonacci_Click);
            // 
            // btSerie
            // 
            this.btSerie.Location = new System.Drawing.Point(366, 216);
            this.btSerie.Name = "btSerie";
            this.btSerie.Size = new System.Drawing.Size(75, 23);
            this.btSerie.TabIndex = 5;
            this.btSerie.Text = "Serie";
            this.btSerie.UseVisualStyleBackColor = true;
            this.btSerie.Click += new System.EventHandler(this.BtSerie_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btSerie);
            this.Controls.Add(this.btFibonacci);
            this.Controls.Add(this.btSuma);
            this.Controls.Add(this.Box1);
            this.Controls.Add(this.Text1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Text1;
        private System.Windows.Forms.TextBox Box1;
        private System.Windows.Forms.Button btSuma;
        private System.Windows.Forms.Button btFibonacci;
        private System.Windows.Forms.Button btSerie;
    }
}

