namespace TiendaVirtual
{
    partial class Alambricos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Alambricos));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bttnComprar = new System.Windows.Forms.Button();
            this.bttnVolver = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.bttnNo = new System.Windows.Forms.Button();
            this.bttnSí = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(260, 253);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(292, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(401, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Diadema Headset Recon 70x Turtle Beach";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(292, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Precio: $1,980 MXN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(292, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "*IVA Incluido";
            // 
            // bttnComprar
            // 
            this.bttnComprar.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnComprar.Location = new System.Drawing.Point(295, 117);
            this.bttnComprar.Name = "bttnComprar";
            this.bttnComprar.Size = new System.Drawing.Size(75, 23);
            this.bttnComprar.TabIndex = 4;
            this.bttnComprar.Text = "Comprar";
            this.bttnComprar.UseVisualStyleBackColor = true;
            this.bttnComprar.Click += new System.EventHandler(this.bttnComprar_Click);
            // 
            // bttnVolver
            // 
            this.bttnVolver.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnVolver.Location = new System.Drawing.Point(441, 117);
            this.bttnVolver.Name = "bttnVolver";
            this.bttnVolver.Size = new System.Drawing.Size(75, 23);
            this.bttnVolver.TabIndex = 5;
            this.bttnVolver.Text = "Volver";
            this.bttnVolver.UseVisualStyleBackColor = true;
            this.bttnVolver.Click += new System.EventHandler(this.bttnVolver_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(292, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(272, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "¿Deseas comprar algo más?";
            this.label4.Visible = false;
            // 
            // bttnNo
            // 
            this.bttnNo.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnNo.Location = new System.Drawing.Point(441, 211);
            this.bttnNo.Name = "bttnNo";
            this.bttnNo.Size = new System.Drawing.Size(75, 23);
            this.bttnNo.TabIndex = 8;
            this.bttnNo.Text = "No";
            this.bttnNo.UseVisualStyleBackColor = true;
            this.bttnNo.Visible = false;
            this.bttnNo.Click += new System.EventHandler(this.bttnNo_Click);
            // 
            // bttnSí
            // 
            this.bttnSí.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnSí.Location = new System.Drawing.Point(295, 211);
            this.bttnSí.Name = "bttnSí";
            this.bttnSí.Size = new System.Drawing.Size(75, 23);
            this.bttnSí.TabIndex = 9;
            this.bttnSí.Text = "Sí";
            this.bttnSí.UseVisualStyleBackColor = true;
            this.bttnSí.Visible = false;
            this.bttnSí.Click += new System.EventHandler(this.bttnSí_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(185, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "Geek-ID S.A. de C.V.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 326);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(318, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Todos los derechos reservados";
            // 
            // Alambricos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(743, 355);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bttnSí);
            this.Controls.Add(this.bttnNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bttnVolver);
            this.Controls.Add(this.bttnComprar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "Alambricos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alambricos";
            this.Load += new System.EventHandler(this.Alambricos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bttnComprar;
        private System.Windows.Forms.Button bttnVolver;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bttnNo;
        private System.Windows.Forms.Button bttnSí;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}