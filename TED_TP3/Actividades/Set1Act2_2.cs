using System;
using System.Drawing;
using System.Windows.Forms;

namespace Prueba2
{
    public partial class Set1Act2_2 : Form
    {
        public Set1Act2_2()
        {
            InitializeComponent();
            cmb1.Focus();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            int correctas = 0;
            if ((cmb1.Text != ""))
            {
                if (cmb1.Text == "Dicloruro de hierro")
                {
                    correctas = correctas + 1;
                    cmb1.BackColor = Color.Green;
                }
                else
                {
                    cmb1.BackColor = Color.Red;
                }
            }
            if ((cmb2.Text != ""))
            {
                if (cmb2.Text == "Tricloruro de hierro")
                {
                    correctas = correctas + 1;
                    cmb2.BackColor = Color.Green;
                }
                else
                {
                    cmb2.BackColor = Color.Red;
                }
            }
            if ((cmb3.Text != ""))
            {
                if (cmb3.Text == "Sulfuro de dioro")
                {
                    correctas = correctas + 1;
                    cmb3.BackColor = Color.Green;
                }
                else
                {
                    cmb3.BackColor = Color.Red;
                }
            }
            if ((cmb4.Text != ""))
            {
                if (cmb4.Text == "Sulfuro de oro")
                {
                    correctas = correctas + 1;
                    cmb4.BackColor = Color.Green;
                }
                else
                {
                    cmb4.BackColor = Color.Red;
                }
            }
            if ((cmb5.Text != ""))
            {
                if (cmb5.Text == "Bisfosfato de trihierro")
                {
                    correctas = correctas + 1;
                    cmb5.BackColor = Color.Green;
                }
                else
                {
                    cmb5.BackColor = Color.Red;
                }
            }
            if ((cmb6.Text != ""))
            {
                if (cmb6.Text == "Cloruro ferroso")
                {
                    correctas = correctas + 1;
                    cmb6.BackColor = Color.Green;
                }
                else
                {
                    cmb6.BackColor = Color.Red;
                }
            }
            if ((cmb7.Text != ""))
            {
                if (cmb7.Text == "Cloruro ferrico")
                {
                    correctas = correctas + 1;
                    cmb7.BackColor = Color.Green;
                }
                else
                {
                    cmb7.BackColor = Color.Red;
                }
            }
            if ((cmb8.Text != ""))
            {
                if (cmb8.Text == "Sulfuro auroso")
                {
                    correctas = correctas + 1;
                    cmb8.BackColor = Color.Green;

                }
                else
                {
                    cmb8.BackColor = Color.Red;
                }
            }
            if ((cmb9.Text != ""))
            {
                if (cmb9.Text == "Sulfuro aurico")
                {
                    correctas = correctas + 1;
                    cmb9.BackColor = Color.Green;
                }
                else
                {
                    cmb9.BackColor = Color.Red;
                }
            }
            if ((cmb10.Text != ""))
            {
                if (cmb10.Text == "Fosfato de hierro")
                {
                    correctas = correctas + 1;
                    cmb10.BackColor = Color.Green;
                }
                else
                {
                    cmb10.BackColor = Color.Red;
                }
            }
            if ((cmb11.Text != ""))
            {
                if (cmb11.Text == "Cloruro de hierro 2")
                {
                    correctas = correctas + 1;
                    cmb11.BackColor = Color.Green;
                }
                else
                {
                    cmb11.BackColor = Color.Red;
                }
            }
            if ((cmb12.Text != ""))
            {
                if (cmb12.Text == "Cloruro de hierro 3")
                {
                    correctas = correctas + 1;
                    cmb12.BackColor = Color.Green;
                }
                else
                {
                    cmb12.BackColor = Color.Red;
                }
            }
            if ((cmb13.Text != ""))
            {
                if (cmb13.Text == "Sulfuro de oro 1")
                {
                    correctas = correctas + 1;
                    cmb13.BackColor = Color.Green;
                }
                else
                {
                    cmb13.BackColor = Color.Red;
                }
            }
            if ((cmb14.Text != ""))
            {
                if (cmb14.Text == "Sulfuro de oro 2")
                {
                    correctas = correctas + 1;
                    cmb14.BackColor = Color.Green;
                }
                else
                {
                    cmb14.BackColor = Color.Red;
                }
            }
            if ((cmb15.Text != ""))
            {
                if (cmb15.Text == "Fosfato de hierro 3")
                {
                    correctas = correctas + 1;
                    cmb15.BackColor = Color.Green;
                }
                else
                {
                    cmb15.BackColor = Color.Red;
                }
            }

            MessageBox.Show("Su resultado es: " + correctas, "Resultado final", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lblResCor.Visible = true;
            lblCantCorr.Text = correctas.ToString();
            lblCantCorr.Visible = true;

            if (correctas > 5)
            {
                MessageBox.Show("Ya puede avanzar a la siguiente actividad!", "Tarea completada!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnSiguiente.Enabled = true;
                btnSiguiente.Focus();
            }
            else
            {
                MessageBox.Show("Sigue intentando!", "Resultado insuficiente",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmb11.Focus();
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            btnImagen.Visible = true;
            panelAyuda.Visible = true;
            btnOcultarAyuda.Visible = true;
            btnAyuda.Visible = false;
        }

        private void btnOcultarAyuda_Click(object sender, EventArgs e)
        {
            btnImagen.Visible = false;
            panelAyuda.Visible = false;
            btnOcultarAyuda.Visible = false;
            btnAyuda.Visible = true;
        }
    }
}
