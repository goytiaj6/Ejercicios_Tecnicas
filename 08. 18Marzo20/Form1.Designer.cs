namespace _18Marzo20
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
            this.CheckEmpleado = new System.Windows.Forms.CheckBox();
            this.CheckFactura = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BttnPagar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CheckEmpleado
            // 
            this.CheckEmpleado.AutoSize = true;
            this.CheckEmpleado.Location = new System.Drawing.Point(87, 61);
            this.CheckEmpleado.Name = "CheckEmpleado";
            this.CheckEmpleado.Size = new System.Drawing.Size(82, 17);
            this.CheckEmpleado.TabIndex = 0;
            this.CheckEmpleado.Text = "A empleado";
            this.CheckEmpleado.UseVisualStyleBackColor = true;
            this.CheckEmpleado.CheckedChanged += new System.EventHandler(this.CheckEmpleado_CheckedChanged);
            // 
            // CheckFactura
            // 
            this.CheckFactura.AutoSize = true;
            this.CheckFactura.Location = new System.Drawing.Point(187, 61);
            this.CheckFactura.Name = "CheckFactura";
            this.CheckFactura.Size = new System.Drawing.Size(82, 17);
            this.CheckFactura.TabIndex = 1;
            this.CheckFactura.Text = "Una factura";
            this.CheckFactura.UseVisualStyleBackColor = true;
            this.CheckFactura.CheckedChanged += new System.EventHandler(this.CheckFactura_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(128, 108);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(128, 134);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(128, 160);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Seleccione que desea pagar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(234, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Apellido / Descripción";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(234, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Número SS / Cantidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nombre / Número de pieza";
            // 
            // BttnPagar
            // 
            this.BttnPagar.Location = new System.Drawing.Point(141, 186);
            this.BttnPagar.Name = "BttnPagar";
            this.BttnPagar.Size = new System.Drawing.Size(75, 23);
            this.BttnPagar.TabIndex = 10;
            this.BttnPagar.Text = "Pagar";
            this.BttnPagar.UseVisualStyleBackColor = true;
            this.BttnPagar.Click += new System.EventHandler(this.BttnPagar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 249);
            this.Controls.Add(this.BttnPagar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.CheckFactura);
            this.Controls.Add(this.CheckEmpleado);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox CheckEmpleado;
        private System.Windows.Forms.CheckBox CheckFactura;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BttnPagar;
    }
}

