namespace Arboles
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
            this.bttnInsertar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rdbttnInorden = new System.Windows.Forms.RadioButton();
            this.rdbttnPreorden = new System.Windows.Forms.RadioButton();
            this.rdbttnPostorden = new System.Windows.Forms.RadioButton();
            this.bttnRecorrer = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese un dato:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(102, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // bttnInsertar
            // 
            this.bttnInsertar.Location = new System.Drawing.Point(208, 29);
            this.bttnInsertar.Name = "bttnInsertar";
            this.bttnInsertar.Size = new System.Drawing.Size(75, 23);
            this.bttnInsertar.TabIndex = 2;
            this.bttnInsertar.Text = "Insertar";
            this.bttnInsertar.UseVisualStyleBackColor = true;
            this.bttnInsertar.Click += new System.EventHandler(this.bttnInsertar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Los datos insertados son:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(145, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 4;
            // 
            // rdbttnInorden
            // 
            this.rdbttnInorden.AutoSize = true;
            this.rdbttnInorden.Location = new System.Drawing.Point(15, 115);
            this.rdbttnInorden.Name = "rdbttnInorden";
            this.rdbttnInorden.Size = new System.Drawing.Size(61, 17);
            this.rdbttnInorden.TabIndex = 5;
            this.rdbttnInorden.TabStop = true;
            this.rdbttnInorden.Text = "Inorden";
            this.rdbttnInorden.UseVisualStyleBackColor = true;
            // 
            // rdbttnPreorden
            // 
            this.rdbttnPreorden.AutoSize = true;
            this.rdbttnPreorden.Location = new System.Drawing.Point(15, 138);
            this.rdbttnPreorden.Name = "rdbttnPreorden";
            this.rdbttnPreorden.Size = new System.Drawing.Size(68, 17);
            this.rdbttnPreorden.TabIndex = 6;
            this.rdbttnPreorden.TabStop = true;
            this.rdbttnPreorden.Text = "Preorden";
            this.rdbttnPreorden.UseVisualStyleBackColor = true;
            // 
            // rdbttnPostorden
            // 
            this.rdbttnPostorden.AutoSize = true;
            this.rdbttnPostorden.Location = new System.Drawing.Point(15, 161);
            this.rdbttnPostorden.Name = "rdbttnPostorden";
            this.rdbttnPostorden.Size = new System.Drawing.Size(73, 17);
            this.rdbttnPostorden.TabIndex = 7;
            this.rdbttnPostorden.TabStop = true;
            this.rdbttnPostorden.Text = "Postorden";
            this.rdbttnPostorden.UseVisualStyleBackColor = true;
            // 
            // bttnRecorrer
            // 
            this.bttnRecorrer.Location = new System.Drawing.Point(15, 184);
            this.bttnRecorrer.Name = "bttnRecorrer";
            this.bttnRecorrer.Size = new System.Drawing.Size(75, 23);
            this.bttnRecorrer.TabIndex = 8;
            this.bttnRecorrer.Text = "Recorrer";
            this.bttnRecorrer.UseVisualStyleBackColor = true;
            this.bttnRecorrer.Click += new System.EventHandler(this.bttnRecorrer_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Los datos son:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(146, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 10;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 277);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bttnRecorrer);
            this.Controls.Add(this.rdbttnPostorden);
            this.Controls.Add(this.rdbttnPreorden);
            this.Controls.Add(this.rdbttnInorden);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bttnInsertar);
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
        private System.Windows.Forms.Button bttnInsertar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdbttnInorden;
        private System.Windows.Forms.RadioButton rdbttnPreorden;
        private System.Windows.Forms.RadioButton rdbttnPostorden;
        private System.Windows.Forms.Button bttnRecorrer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

