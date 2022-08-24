namespace TiendaVirtual
{
    partial class CancelarPedidos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CancelarPedidos));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.bttnBorrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bttnExit = new System.Windows.Forms.Button();
            this.bttnHome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 24);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(435, 300);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(576, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 62);
            this.button1.TabIndex = 1;
            this.button1.Text = "Mostrar Carrito";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(629, 138);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "OK";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(554, 140);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(42, 21);
            this.textBox2.TabIndex = 3;
            // 
            // bttnBorrar
            // 
            this.bttnBorrar.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnBorrar.Location = new System.Drawing.Point(576, 176);
            this.bttnBorrar.Name = "bttnBorrar";
            this.bttnBorrar.Size = new System.Drawing.Size(90, 65);
            this.bttnBorrar.TabIndex = 4;
            this.bttnBorrar.Text = "Borrar Elemento";
            this.bttnBorrar.UseVisualStyleBackColor = true;
            this.bttnBorrar.Click += new System.EventHandler(this.bttnBorrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(475, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 14);
            this.label1.TabIndex = 5;
            this.label1.Text = "Escriba el índice del pedido a cancelar";
            // 
            // bttnExit
            // 
            this.bttnExit.BackColor = System.Drawing.Color.Transparent;
            this.bttnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttnExit.BackgroundImage")));
            this.bttnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttnExit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bttnExit.Location = new System.Drawing.Point(698, 277);
            this.bttnExit.Name = "bttnExit";
            this.bttnExit.Size = new System.Drawing.Size(75, 66);
            this.bttnExit.TabIndex = 6;
            this.bttnExit.UseVisualStyleBackColor = false;
            this.bttnExit.Click += new System.EventHandler(this.bttnExit_Click);
            // 
            // bttnHome
            // 
            this.bttnHome.BackColor = System.Drawing.Color.Transparent;
            this.bttnHome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttnHome.BackgroundImage")));
            this.bttnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttnHome.Location = new System.Drawing.Point(576, 273);
            this.bttnHome.Name = "bttnHome";
            this.bttnHome.Size = new System.Drawing.Size(75, 75);
            this.bttnHome.TabIndex = 7;
            this.bttnHome.UseVisualStyleBackColor = false;
            this.bttnHome.Click += new System.EventHandler(this.bttnHome_Click);
            // 
            // CancelarPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(785, 355);
            this.Controls.Add(this.bttnHome);
            this.Controls.Add(this.bttnExit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bttnBorrar);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CancelarPedidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CancelarPedidos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button bttnBorrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bttnExit;
        private System.Windows.Forms.Button bttnHome;
    }
}