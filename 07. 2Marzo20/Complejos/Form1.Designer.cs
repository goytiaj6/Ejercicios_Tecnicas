﻿namespace Complejos
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
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bttnProduto = new System.Windows.Forms.Button();
            this.bttnDivision = new System.Windows.Forms.Button();
            this.bttnResta = new System.Windows.Forms.Button();
            this.bttnSuma = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(250, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Ingresa los complejos mediante el uso de una coma";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(86, 106);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(110, 20);
            this.textBox2.TabIndex = 25;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(86, 56);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(110, 20);
            this.textBox1.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Complejo 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Complejo 1";
            // 
            // bttnProduto
            // 
            this.bttnProduto.Location = new System.Drawing.Point(283, 121);
            this.bttnProduto.Name = "bttnProduto";
            this.bttnProduto.Size = new System.Drawing.Size(91, 28);
            this.bttnProduto.TabIndex = 21;
            this.bttnProduto.Text = "Producto";
            this.bttnProduto.UseVisualStyleBackColor = true;
            this.bttnProduto.Click += new System.EventHandler(this.bttnProduto_Click);
            // 
            // bttnDivision
            // 
            this.bttnDivision.Location = new System.Drawing.Point(283, 86);
            this.bttnDivision.Name = "bttnDivision";
            this.bttnDivision.Size = new System.Drawing.Size(91, 29);
            this.bttnDivision.TabIndex = 20;
            this.bttnDivision.Text = "División";
            this.bttnDivision.UseVisualStyleBackColor = true;
            this.bttnDivision.Click += new System.EventHandler(this.bttnDivision_Click);
            // 
            // bttnResta
            // 
            this.bttnResta.Location = new System.Drawing.Point(283, 51);
            this.bttnResta.Name = "bttnResta";
            this.bttnResta.Size = new System.Drawing.Size(91, 29);
            this.bttnResta.TabIndex = 19;
            this.bttnResta.Text = "Resta";
            this.bttnResta.UseVisualStyleBackColor = true;
            this.bttnResta.Click += new System.EventHandler(this.bttnResta_Click);
            // 
            // bttnSuma
            // 
            this.bttnSuma.Location = new System.Drawing.Point(283, 17);
            this.bttnSuma.Name = "bttnSuma";
            this.bttnSuma.Size = new System.Drawing.Size(91, 28);
            this.bttnSuma.TabIndex = 18;
            this.bttnSuma.Text = "Suma";
            this.bttnSuma.UseVisualStyleBackColor = true;
            this.bttnSuma.Click += new System.EventHandler(this.bttnSuma_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(101, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Real,Imaginario";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 159);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bttnProduto);
            this.Controls.Add(this.bttnDivision);
            this.Controls.Add(this.bttnResta);
            this.Controls.Add(this.bttnSuma);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bttnProduto;
        private System.Windows.Forms.Button bttnDivision;
        private System.Windows.Forms.Button bttnResta;
        private System.Windows.Forms.Button bttnSuma;
        private System.Windows.Forms.Label label4;
    }
}

