namespace _19Febrero20
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
            this.Limpieza = new System.Windows.Forms.Button();
            this.Jefe = new System.Windows.Forms.Button();
            this.Laboratorio = new System.Windows.Forms.Button();
            this.Asignatura = new System.Windows.Forms.Button();
            this.DatosEmpleado = new System.Windows.Forms.TextBox();
            this.Nomina = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Limpieza
            // 
            this.Limpieza.Location = new System.Drawing.Point(18, 2);
            this.Limpieza.Name = "Limpieza";
            this.Limpieza.Size = new System.Drawing.Size(83, 52);
            this.Limpieza.TabIndex = 0;
            this.Limpieza.Text = "Limpieza";
            this.Limpieza.UseVisualStyleBackColor = true;
            this.Limpieza.Click += new System.EventHandler(this.Limpieza_Click);
            // 
            // Jefe
            // 
            this.Jefe.Location = new System.Drawing.Point(107, 2);
            this.Jefe.Name = "Jefe";
            this.Jefe.Size = new System.Drawing.Size(83, 52);
            this.Jefe.TabIndex = 1;
            this.Jefe.Text = "Jefe Departamento";
            this.Jefe.UseVisualStyleBackColor = true;
            this.Jefe.Click += new System.EventHandler(this.Jefe_Click);
            // 
            // Laboratorio
            // 
            this.Laboratorio.Location = new System.Drawing.Point(196, 2);
            this.Laboratorio.Name = "Laboratorio";
            this.Laboratorio.Size = new System.Drawing.Size(83, 52);
            this.Laboratorio.TabIndex = 2;
            this.Laboratorio.Text = "Responsable de laboratorio";
            this.Laboratorio.UseVisualStyleBackColor = true;
            this.Laboratorio.Click += new System.EventHandler(this.Laboratorio_Click);
            // 
            // Asignatura
            // 
            this.Asignatura.Location = new System.Drawing.Point(285, 2);
            this.Asignatura.Name = "Asignatura";
            this.Asignatura.Size = new System.Drawing.Size(83, 52);
            this.Asignatura.TabIndex = 3;
            this.Asignatura.Text = "Profesor Asignatura";
            this.Asignatura.UseVisualStyleBackColor = true;
            this.Asignatura.Click += new System.EventHandler(this.Asignatura_Click);
            // 
            // DatosEmpleado
            // 
            this.DatosEmpleado.Location = new System.Drawing.Point(61, 60);
            this.DatosEmpleado.Multiline = true;
            this.DatosEmpleado.Name = "DatosEmpleado";
            this.DatosEmpleado.Size = new System.Drawing.Size(260, 240);
            this.DatosEmpleado.TabIndex = 4;
            // 
            // Nomina
            // 
            this.Nomina.Location = new System.Drawing.Point(402, 131);
            this.Nomina.Name = "Nomina";
            this.Nomina.Size = new System.Drawing.Size(98, 53);
            this.Nomina.TabIndex = 5;
            this.Nomina.Text = "Pago de la nómina";
            this.Nomina.UseVisualStyleBackColor = true;
            this.Nomina.Click += new System.EventHandler(this.Nomina_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 312);
            this.Controls.Add(this.Nomina);
            this.Controls.Add(this.DatosEmpleado);
            this.Controls.Add(this.Asignatura);
            this.Controls.Add(this.Laboratorio);
            this.Controls.Add(this.Jefe);
            this.Controls.Add(this.Limpieza);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Limpieza;
        private System.Windows.Forms.Button Jefe;
        private System.Windows.Forms.Button Laboratorio;
        private System.Windows.Forms.Button Asignatura;
        private System.Windows.Forms.TextBox DatosEmpleado;
        private System.Windows.Forms.Button Nomina;
    }
}

