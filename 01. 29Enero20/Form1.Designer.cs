namespace _29Enero20
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
            this.OK = new System.Windows.Forms.Button();
            this.Text2 = new System.Windows.Forms.Label();
            this.Text3 = new System.Windows.Forms.Label();
            this.Text4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Text1
            // 
            this.Text1.AutoSize = true;
            this.Text1.Location = new System.Drawing.Point(97, 21);
            this.Text1.Name = "Text1";
            this.Text1.Size = new System.Drawing.Size(159, 13);
            this.Text1.TabIndex = 0;
            this.Text1.Text = "Ingrese su edad a continuación:";
            this.Text1.Click += new System.EventHandler(this.Text1_Click);
            // 
            // Box1
            // 
            this.Box1.Location = new System.Drawing.Point(286, 18);
            this.Box1.Name = "Box1";
            this.Box1.Size = new System.Drawing.Size(100, 20);
            this.Box1.TabIndex = 1;
            this.Box1.TextChanged += new System.EventHandler(this.Box1_TextChanged);
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(286, 188);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 2;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.button1_Click);
            // 
            // Text2
            // 
            this.Text2.AutoSize = true;
            this.Text2.Location = new System.Drawing.Point(97, 56);
            this.Text2.Name = "Text2";
            this.Text2.Size = new System.Drawing.Size(110, 13);
            this.Text2.TabIndex = 3;
            this.Text2.Text = "Precio del boleto: $80";
            this.Text2.Click += new System.EventHandler(this.Text2_Click);
            // 
            // Text3
            // 
            this.Text3.AutoSize = true;
            this.Text3.Location = new System.Drawing.Point(97, 90);
            this.Text3.Name = "Text3";
            this.Text3.Size = new System.Drawing.Size(0, 13);
            this.Text3.TabIndex = 4;
            // 
            // Text4
            // 
            this.Text4.AutoSize = true;
            this.Text4.Location = new System.Drawing.Point(97, 130);
            this.Text4.Name = "Text4";
            this.Text4.Size = new System.Drawing.Size(98, 13);
            this.Text4.TabIndex = 5;
            this.Text4.Text = "Disfrute la función!!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 345);
            this.Controls.Add(this.Text4);
            this.Controls.Add(this.Text3);
            this.Controls.Add(this.Text2);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.Box1);
            this.Controls.Add(this.Text1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Text1;
        private System.Windows.Forms.TextBox Box1;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Label Text2;
        private System.Windows.Forms.Label Text3;
        private System.Windows.Forms.Label Text4;
    }
}

