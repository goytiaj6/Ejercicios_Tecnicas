namespace TiendaVirtual
{
    partial class Audífonos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Audífonos));
            this.bttnHome = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bttnAudífonos = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bttnHome
            // 
            this.bttnHome.BackColor = System.Drawing.Color.Transparent;
            this.bttnHome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttnHome.BackgroundImage")));
            this.bttnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttnHome.Location = new System.Drawing.Point(656, 12);
            this.bttnHome.Name = "bttnHome";
            this.bttnHome.Size = new System.Drawing.Size(75, 75);
            this.bttnHome.TabIndex = 0;
            this.bttnHome.UseVisualStyleBackColor = false;
            this.bttnHome.Click += new System.EventHandler(this.bttnHome_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(99, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(226, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Audífonos alámbricos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(387, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Audífonos inalámbricos";
            // 
            // bttnAudífonos
            // 
            this.bttnAudífonos.BackColor = System.Drawing.Color.Transparent;
            this.bttnAudífonos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttnAudífonos.BackgroundImage")));
            this.bttnAudífonos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bttnAudífonos.Location = new System.Drawing.Point(85, 94);
            this.bttnAudífonos.Name = "bttnAudífonos";
            this.bttnAudífonos.Size = new System.Drawing.Size(250, 143);
            this.bttnAudífonos.TabIndex = 10;
            this.bttnAudífonos.UseVisualStyleBackColor = false;
            this.bttnAudífonos.Click += new System.EventHandler(this.bttnAudífonos_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(382, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 143);
            this.button1.TabIndex = 11;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // Audífonos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(743, 355);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bttnAudífonos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bttnHome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Audífonos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Audífonos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttnHome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bttnAudífonos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}