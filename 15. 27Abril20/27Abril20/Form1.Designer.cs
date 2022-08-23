namespace _27Abril20
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
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.InsertarInicio = new System.Windows.Forms.Button();
            this.InsertarFinal = new System.Windows.Forms.Button();
            this.EliminarInicio = new System.Windows.Forms.Button();
            this.EliminarFinal = new System.Windows.Forms.Button();
            this.InsertarPila = new System.Windows.Forms.Button();
            this.EliminarPila = new System.Windows.Forms.Button();
            this.ImprimirPila = new System.Windows.Forms.Button();
            this.InsertarCola = new System.Windows.Forms.Button();
            this.EliminarCola = new System.Windows.Forms.Button();
            this.ImprimirCola = new System.Windows.Forms.Button();
            this.ImprimirLista = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(379, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pila";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Dato:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(295, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Dato:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(562, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Dato:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(87, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(122, 20);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(334, 45);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(123, 20);
            this.textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(601, 45);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(119, 20);
            this.textBox3.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(642, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Cola";
            // 
            // InsertarInicio
            // 
            this.InsertarInicio.Location = new System.Drawing.Point(99, 91);
            this.InsertarInicio.Name = "InsertarInicio";
            this.InsertarInicio.Size = new System.Drawing.Size(93, 23);
            this.InsertarInicio.TabIndex = 11;
            this.InsertarInicio.Text = "Insertar Inicio";
            this.InsertarInicio.UseVisualStyleBackColor = true;
            this.InsertarInicio.Click += new System.EventHandler(this.InsertarInicio_Click);
            // 
            // InsertarFinal
            // 
            this.InsertarFinal.Location = new System.Drawing.Point(99, 120);
            this.InsertarFinal.Name = "InsertarFinal";
            this.InsertarFinal.Size = new System.Drawing.Size(93, 23);
            this.InsertarFinal.TabIndex = 12;
            this.InsertarFinal.Text = "Insertar Final";
            this.InsertarFinal.UseVisualStyleBackColor = true;
            this.InsertarFinal.Click += new System.EventHandler(this.InsertarFinal_Click);
            // 
            // EliminarInicio
            // 
            this.EliminarInicio.Location = new System.Drawing.Point(99, 169);
            this.EliminarInicio.Name = "EliminarInicio";
            this.EliminarInicio.Size = new System.Drawing.Size(93, 23);
            this.EliminarInicio.TabIndex = 13;
            this.EliminarInicio.Text = "Eliminar Inicio";
            this.EliminarInicio.UseVisualStyleBackColor = true;
            this.EliminarInicio.Click += new System.EventHandler(this.EliminarInicio_Click);
            // 
            // EliminarFinal
            // 
            this.EliminarFinal.Location = new System.Drawing.Point(99, 198);
            this.EliminarFinal.Name = "EliminarFinal";
            this.EliminarFinal.Size = new System.Drawing.Size(93, 23);
            this.EliminarFinal.TabIndex = 14;
            this.EliminarFinal.Text = "Eliminar Final";
            this.EliminarFinal.UseVisualStyleBackColor = true;
            this.EliminarFinal.Click += new System.EventHandler(this.EliminarFinal_Click);
            // 
            // InsertarPila
            // 
            this.InsertarPila.Location = new System.Drawing.Point(359, 106);
            this.InsertarPila.Name = "InsertarPila";
            this.InsertarPila.Size = new System.Drawing.Size(75, 23);
            this.InsertarPila.TabIndex = 16;
            this.InsertarPila.Text = "Insertar";
            this.InsertarPila.UseVisualStyleBackColor = true;
            this.InsertarPila.Click += new System.EventHandler(this.InsertarPila_Click);
            // 
            // EliminarPila
            // 
            this.EliminarPila.Location = new System.Drawing.Point(359, 182);
            this.EliminarPila.Name = "EliminarPila";
            this.EliminarPila.Size = new System.Drawing.Size(75, 23);
            this.EliminarPila.TabIndex = 17;
            this.EliminarPila.Text = "Eliminar";
            this.EliminarPila.UseVisualStyleBackColor = true;
            this.EliminarPila.Click += new System.EventHandler(this.EliminarPila_Click);
            // 
            // ImprimirPila
            // 
            this.ImprimirPila.Location = new System.Drawing.Point(359, 265);
            this.ImprimirPila.Name = "ImprimirPila";
            this.ImprimirPila.Size = new System.Drawing.Size(75, 23);
            this.ImprimirPila.TabIndex = 18;
            this.ImprimirPila.Text = "Imprimir Pila";
            this.ImprimirPila.UseVisualStyleBackColor = true;
            this.ImprimirPila.Click += new System.EventHandler(this.ImprimirPila_Click);
            // 
            // InsertarCola
            // 
            this.InsertarCola.Location = new System.Drawing.Point(626, 106);
            this.InsertarCola.Name = "InsertarCola";
            this.InsertarCola.Size = new System.Drawing.Size(75, 23);
            this.InsertarCola.TabIndex = 19;
            this.InsertarCola.Text = "Insertar";
            this.InsertarCola.UseVisualStyleBackColor = true;
            this.InsertarCola.Click += new System.EventHandler(this.InsertarCola_Click);
            // 
            // EliminarCola
            // 
            this.EliminarCola.Location = new System.Drawing.Point(626, 182);
            this.EliminarCola.Name = "EliminarCola";
            this.EliminarCola.Size = new System.Drawing.Size(75, 23);
            this.EliminarCola.TabIndex = 20;
            this.EliminarCola.Text = "Eliminar";
            this.EliminarCola.UseVisualStyleBackColor = true;
            this.EliminarCola.Click += new System.EventHandler(this.EliminarCola_Click);
            // 
            // ImprimirCola
            // 
            this.ImprimirCola.Location = new System.Drawing.Point(626, 265);
            this.ImprimirCola.Name = "ImprimirCola";
            this.ImprimirCola.Size = new System.Drawing.Size(75, 23);
            this.ImprimirCola.TabIndex = 21;
            this.ImprimirCola.Text = "Imprimir Cola";
            this.ImprimirCola.UseVisualStyleBackColor = true;
            this.ImprimirCola.Click += new System.EventHandler(this.ImprimirCola_Click);
            // 
            // ImprimirLista
            // 
            this.ImprimirLista.Location = new System.Drawing.Point(108, 265);
            this.ImprimirLista.Name = "ImprimirLista";
            this.ImprimirLista.Size = new System.Drawing.Size(75, 23);
            this.ImprimirLista.TabIndex = 22;
            this.ImprimirLista.Text = "Imprimir Lista";
            this.ImprimirLista.UseVisualStyleBackColor = true;
            this.ImprimirLista.Click += new System.EventHandler(this.ImprimirLista_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 334);
            this.Controls.Add(this.ImprimirLista);
            this.Controls.Add(this.ImprimirCola);
            this.Controls.Add(this.EliminarCola);
            this.Controls.Add(this.InsertarCola);
            this.Controls.Add(this.ImprimirPila);
            this.Controls.Add(this.EliminarPila);
            this.Controls.Add(this.InsertarPila);
            this.Controls.Add(this.EliminarFinal);
            this.Controls.Add(this.EliminarInicio);
            this.Controls.Add(this.InsertarFinal);
            this.Controls.Add(this.InsertarInicio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button InsertarInicio;
        private System.Windows.Forms.Button InsertarFinal;
        private System.Windows.Forms.Button EliminarInicio;
        private System.Windows.Forms.Button EliminarFinal;
        private System.Windows.Forms.Button InsertarPila;
        private System.Windows.Forms.Button EliminarPila;
        private System.Windows.Forms.Button ImprimirPila;
        private System.Windows.Forms.Button InsertarCola;
        private System.Windows.Forms.Button EliminarCola;
        private System.Windows.Forms.Button ImprimirCola;
        private System.Windows.Forms.Button ImprimirLista;
    }
}

