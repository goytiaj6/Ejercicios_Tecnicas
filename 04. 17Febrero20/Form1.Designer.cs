namespace _17Febrero20
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Cocinar = new System.Windows.Forms.Button();
            this.Ingrediente = new System.Windows.Forms.Button();
            this.Sal = new System.Windows.Forms.Button();
            this.Cambios = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(145, 47);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(227, 193);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Cocinar
            // 
            this.Cocinar.Location = new System.Drawing.Point(12, 79);
            this.Cocinar.Name = "Cocinar";
            this.Cocinar.Size = new System.Drawing.Size(127, 23);
            this.Cocinar.TabIndex = 1;
            this.Cocinar.Text = "Cocinar";
            this.Cocinar.UseVisualStyleBackColor = true;
            this.Cocinar.Click += new System.EventHandler(this.Cocinar_Click);
            // 
            // Ingrediente
            // 
            this.Ingrediente.Location = new System.Drawing.Point(12, 108);
            this.Ingrediente.Name = "Ingrediente";
            this.Ingrediente.Size = new System.Drawing.Size(127, 23);
            this.Ingrediente.TabIndex = 2;
            this.Ingrediente.Text = "Agregarle el toque";
            this.Ingrediente.UseVisualStyleBackColor = true;
            this.Ingrediente.Click += new System.EventHandler(this.Ingrediente_Click);
            // 
            // Sal
            // 
            this.Sal.Location = new System.Drawing.Point(12, 137);
            this.Sal.Name = "Sal";
            this.Sal.Size = new System.Drawing.Size(127, 23);
            this.Sal.TabIndex = 3;
            this.Sal.Text = "Le falta sal";
            this.Sal.UseVisualStyleBackColor = true;
            this.Sal.Click += new System.EventHandler(this.Sal_Click);
            // 
            // Cambios
            // 
            this.Cambios.Location = new System.Drawing.Point(12, 166);
            this.Cambios.Name = "Cambios";
            this.Cambios.Size = new System.Drawing.Size(127, 23);
            this.Cambios.TabIndex = 4;
            this.Cambios.Text = "Checa el pastel";
            this.Cambios.UseVisualStyleBackColor = true;
            this.Cambios.Click += new System.EventHandler(this.Cambios_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 280);
            this.Controls.Add(this.Cambios);
            this.Controls.Add(this.Sal);
            this.Controls.Add(this.Ingrediente);
            this.Controls.Add(this.Cocinar);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Cocinar;
        private System.Windows.Forms.Button Ingrediente;
        private System.Windows.Forms.Button Sal;
        private System.Windows.Forms.Button Cambios;
    }
}

