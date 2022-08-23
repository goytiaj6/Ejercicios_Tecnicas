namespace Listas1._2
{
    partial class Form12
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.bttnAgregar = new System.Windows.Forms.Button();
            this.bttnBorrar = new System.Windows.Forms.Button();
            this.bttnVaciar = new System.Windows.Forms.Button();
            this.bttnModificar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Compras = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bttnOK = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(29, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(133, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(220, 93);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(38, 20);
            this.textBox2.TabIndex = 1;
            // 
            // bttnAgregar
            // 
            this.bttnAgregar.Location = new System.Drawing.Point(191, 18);
            this.bttnAgregar.Name = "bttnAgregar";
            this.bttnAgregar.Size = new System.Drawing.Size(92, 54);
            this.bttnAgregar.TabIndex = 4;
            this.bttnAgregar.Text = "Agregar elemento a la lista";
            this.bttnAgregar.UseVisualStyleBackColor = true;
            this.bttnAgregar.Click += new System.EventHandler(this.bttnAgregar_Click);
            // 
            // bttnBorrar
            // 
            this.bttnBorrar.Location = new System.Drawing.Point(35, 131);
            this.bttnBorrar.Name = "bttnBorrar";
            this.bttnBorrar.Size = new System.Drawing.Size(75, 35);
            this.bttnBorrar.TabIndex = 5;
            this.bttnBorrar.Text = "Borrar elemento";
            this.bttnBorrar.UseVisualStyleBackColor = true;
            this.bttnBorrar.Click += new System.EventHandler(this.bttnBorrar_Click);
            // 
            // bttnVaciar
            // 
            this.bttnVaciar.Location = new System.Drawing.Point(119, 131);
            this.bttnVaciar.Name = "bttnVaciar";
            this.bttnVaciar.Size = new System.Drawing.Size(75, 35);
            this.bttnVaciar.TabIndex = 6;
            this.bttnVaciar.Text = "Vaciar lista";
            this.bttnVaciar.UseVisualStyleBackColor = true;
            this.bttnVaciar.Click += new System.EventHandler(this.bttnVaciar_Click);
            // 
            // bttnModificar
            // 
            this.bttnModificar.Location = new System.Drawing.Point(200, 131);
            this.bttnModificar.Name = "bttnModificar";
            this.bttnModificar.Size = new System.Drawing.Size(75, 35);
            this.bttnModificar.TabIndex = 7;
            this.bttnModificar.Text = "Modificar lista";
            this.bttnModificar.UseVisualStyleBackColor = true;
            this.bttnModificar.Click += new System.EventHandler(this.bttnModificar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Usted a seleccionado el elemento:";
            // 
            // Compras
            // 
            this.Compras.FormattingEnabled = true;
            this.Compras.Location = new System.Drawing.Point(302, 16);
            this.Compras.Name = "Compras";
            this.Compras.Size = new System.Drawing.Size(120, 277);
            this.Compras.TabIndex = 9;
            this.Compras.SelectedIndexChanged += new System.EventHandler(this.Compras_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Seleccione elemento y escriba otro";
            this.label2.Visible = false;
            // 
            // bttnOK
            // 
            this.bttnOK.Location = new System.Drawing.Point(119, 241);
            this.bttnOK.Name = "bttnOK";
            this.bttnOK.Size = new System.Drawing.Size(75, 23);
            this.bttnOK.TabIndex = 11;
            this.bttnOK.Text = "OK";
            this.bttnOK.UseVisualStyleBackColor = true;
            this.bttnOK.Visible = false;
            this.bttnOK.Click += new System.EventHandler(this.bttnOK_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(89, 215);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(133, 20);
            this.textBox3.TabIndex = 12;
            this.textBox3.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(229, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "NOTA: Antes de borrar, seleccione el elemento";
            // 
            // Form12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 314);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.bttnOK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Compras);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bttnModificar);
            this.Controls.Add(this.bttnVaciar);
            this.Controls.Add(this.bttnBorrar);
            this.Controls.Add(this.bttnAgregar);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form12";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form12_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button bttnAgregar;
        private System.Windows.Forms.Button bttnBorrar;
        private System.Windows.Forms.Button bttnVaciar;
        private System.Windows.Forms.Button bttnModificar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox Compras;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bttnOK;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
    }
}

