namespace TED_TP3.Actividades
{
    partial class Set1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Set1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.btnAct1 = new System.Windows.Forms.Button();
            this.btnAct2 = new System.Windows.Forms.Button();
            this.btnAct3 = new System.Windows.Forms.Button();
            this.btnAct4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TED_TP3.Properties.Resources.JugarBlancoGrande;
            this.pictureBox1.Location = new System.Drawing.Point(640, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.lblTitulo.Location = new System.Drawing.Point(1, 19);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(533, 69);
            this.lblTitulo.TabIndex = 13;
            this.lblTitulo.Text = "A TODO QUÍMICA";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnVolver
            // 
            this.btnVolver.AutoSize = true;
            this.btnVolver.ForeColor = System.Drawing.Color.Black;
            this.btnVolver.Image = global::TED_TP3.Properties.Resources.casaNegra;
            this.btnVolver.Location = new System.Drawing.Point(656, 347);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(116, 44);
            this.btnVolver.TabIndex = 16;
            this.btnVolver.Text = "Volver";
            this.btnVolver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.AutoSize = true;
            this.lblBienvenida.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblBienvenida.Location = new System.Drawing.Point(371, 88);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(254, 39);
            this.lblBienvenida.TabIndex = 14;
            this.lblBienvenida.Text = "Comenzemos...";
            this.lblBienvenida.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAct1
            // 
            this.btnAct1.AutoSize = true;
            this.btnAct1.ForeColor = System.Drawing.Color.Black;
            this.btnAct1.Location = new System.Drawing.Point(78, 180);
            this.btnAct1.Name = "btnAct1";
            this.btnAct1.Size = new System.Drawing.Size(116, 44);
            this.btnAct1.TabIndex = 17;
            this.btnAct1.Text = "Actividad 1";
            this.btnAct1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAct1.UseVisualStyleBackColor = true;
            this.btnAct1.Click += new System.EventHandler(this.btnAct1_Click);
            // 
            // btnAct2
            // 
            this.btnAct2.AutoSize = true;
            this.btnAct2.Enabled = false;
            this.btnAct2.ForeColor = System.Drawing.Color.Black;
            this.btnAct2.Location = new System.Drawing.Point(254, 180);
            this.btnAct2.Name = "btnAct2";
            this.btnAct2.Size = new System.Drawing.Size(116, 44);
            this.btnAct2.TabIndex = 18;
            this.btnAct2.Text = "Actividad 2";
            this.btnAct2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAct2.UseVisualStyleBackColor = true;
            this.btnAct2.Click += new System.EventHandler(this.btnAct2_Click);
            // 
            // btnAct3
            // 
            this.btnAct3.AutoSize = true;
            this.btnAct3.Enabled = false;
            this.btnAct3.ForeColor = System.Drawing.Color.Black;
            this.btnAct3.Location = new System.Drawing.Point(78, 276);
            this.btnAct3.Name = "btnAct3";
            this.btnAct3.Size = new System.Drawing.Size(116, 44);
            this.btnAct3.TabIndex = 19;
            this.btnAct3.Text = "Actividad 3";
            this.btnAct3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAct3.UseVisualStyleBackColor = true;
            this.btnAct3.Click += new System.EventHandler(this.btnAct3_Click);
            // 
            // btnAct4
            // 
            this.btnAct4.AutoSize = true;
            this.btnAct4.Enabled = false;
            this.btnAct4.ForeColor = System.Drawing.Color.Black;
            this.btnAct4.Location = new System.Drawing.Point(254, 276);
            this.btnAct4.Name = "btnAct4";
            this.btnAct4.Size = new System.Drawing.Size(116, 44);
            this.btnAct4.TabIndex = 20;
            this.btnAct4.Text = "Actividad 4";
            this.btnAct4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAct4.UseVisualStyleBackColor = true;
            this.btnAct4.Click += new System.EventHandler(this.btnAct4_Click);
            // 
            // Set1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(782, 403);
            this.Controls.Add(this.btnAct4);
            this.Controls.Add(this.btnAct3);
            this.Controls.Add(this.btnAct2);
            this.Controls.Add(this.btnAct1);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblBienvenida);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(219)))), ((int)(((byte)(213)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Set1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Set1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblBienvenida;
        private System.Windows.Forms.Button btnAct1;
        private System.Windows.Forms.Button btnAct2;
        private System.Windows.Forms.Button btnAct3;
        private System.Windows.Forms.Button btnAct4;
    }
}