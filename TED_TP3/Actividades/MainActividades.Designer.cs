namespace TED_TP3.Actividades
{
    partial class MainActividades
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
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblIngresado = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSet1 = new System.Windows.Forms.Button();
            this.btnSet2 = new System.Windows.Forms.Button();
            this.btnSet3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.AutoSize = true;
            this.lblBienvenida.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblBienvenida.Location = new System.Drawing.Point(387, 87);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(254, 39);
            this.lblBienvenida.TabIndex = 4;
            this.lblBienvenida.Text = "Comenzemos...";
            this.lblBienvenida.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.lblTitulo.Location = new System.Drawing.Point(17, 18);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(533, 69);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "A TODO QUÍMICA";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIngresado
            // 
            this.lblIngresado.AutoSize = true;
            this.lblIngresado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblIngresado.Location = new System.Drawing.Point(12, 370);
            this.lblIngresado.Name = "lblIngresado";
            this.lblIngresado.Size = new System.Drawing.Size(234, 25);
            this.lblIngresado.TabIndex = 5;
            this.lblIngresado.Text = "(datos usuario ingresado)";
            this.lblIngresado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnVolver
            // 
            this.btnVolver.AutoSize = true;
            this.btnVolver.ForeColor = System.Drawing.Color.Black;
            this.btnVolver.Image = global::TED_TP3.Properties.Resources.casaNegra;
            this.btnVolver.Location = new System.Drawing.Point(672, 348);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(116, 44);
            this.btnVolver.TabIndex = 6;
            this.btnVolver.Text = "Volver";
            this.btnVolver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TED_TP3.Properties.Resources.JugarBlancoGrande;
            this.pictureBox1.Location = new System.Drawing.Point(656, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // btnSet1
            // 
            this.btnSet1.AutoSize = true;
            this.btnSet1.ForeColor = System.Drawing.Color.Black;
            this.btnSet1.Location = new System.Drawing.Point(101, 255);
            this.btnSet1.Name = "btnSet1";
            this.btnSet1.Size = new System.Drawing.Size(162, 44);
            this.btnSet1.TabIndex = 13;
            this.btnSet1.Text = "Set de actividades 1";
            this.btnSet1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSet1.UseVisualStyleBackColor = true;
            this.btnSet1.Click += new System.EventHandler(this.btnSet1_Click);
            // 
            // btnSet2
            // 
            this.btnSet2.AutoSize = true;
            this.btnSet2.ForeColor = System.Drawing.Color.Black;
            this.btnSet2.Location = new System.Drawing.Point(314, 255);
            this.btnSet2.Name = "btnSet2";
            this.btnSet2.Size = new System.Drawing.Size(162, 44);
            this.btnSet2.TabIndex = 14;
            this.btnSet2.Text = "Set de actividades 2";
            this.btnSet2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSet2.UseVisualStyleBackColor = true;
            // 
            // btnSet3
            // 
            this.btnSet3.AutoSize = true;
            this.btnSet3.ForeColor = System.Drawing.Color.Black;
            this.btnSet3.Location = new System.Drawing.Point(528, 255);
            this.btnSet3.Name = "btnSet3";
            this.btnSet3.Size = new System.Drawing.Size(162, 44);
            this.btnSet3.TabIndex = 15;
            this.btnSet3.Text = "Set de actividades 3";
            this.btnSet3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSet3.UseVisualStyleBackColor = true;
            // 
            // MainActividades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(800, 415);
            this.Controls.Add(this.btnSet3);
            this.Controls.Add(this.btnSet2);
            this.Controls.Add(this.btnSet1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lblIngresado);
            this.Controls.Add(this.lblBienvenida);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(219)))), ((int)(((byte)(213)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainActividades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainActividades";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBienvenida;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblIngresado;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSet1;
        private System.Windows.Forms.Button btnSet2;
        private System.Windows.Forms.Button btnSet3;
    }
}