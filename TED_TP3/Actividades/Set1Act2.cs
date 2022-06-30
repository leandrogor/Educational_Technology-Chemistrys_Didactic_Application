using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TED_TP3.Actividades
{
    public partial class Set1Act2 : Form
    {
        private Set1 set1;
        public Set1Act2(Set1 set1)
        {
            InitializeComponent();
            this.set1 = set1;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Volviendo a set de actividades 1...");
            set1.habilitarAct3();
            Close();
        }

        private void btnVideo_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.youtube.com/watch?v=MeJg036Awjg");
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

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            int correctas = 0;
            if ((Respuesta1.Text != ""))
            {
                if (Respuesta1.Text.Trim() == "hidróxido")
                {
                    correctas = correctas + 1;
                    Respuesta1.BackColor = Color.Green;
                }
                else
                {
                    Respuesta1.BackColor = Color.Red;
                }
            }
            if ((Respuesta2.Text != ""))
            {
                if (Respuesta2.Text.Trim() == "ácido")
                {
                    correctas = correctas + 1;
                    Respuesta2.BackColor = Color.Green;
                }
                else
                {
                    Respuesta2.BackColor = Color.Red;
                }
            }
            if ((Respuesta3.Text != ""))
            {
                if (Respuesta3.Text.Trim() == "sales binarias")
                {
                    correctas = correctas + 1;
                    Respuesta3.BackColor = Color.Green;
                }
                else
                {
                    Respuesta3.BackColor = Color.Red;
                }
            }
            if ((Respuesta4.Text != ""))
            {
                if (Respuesta4.Text.Trim() == "oxisales")
                {
                    correctas = correctas + 1;
                    Respuesta4.BackColor = Color.Green;
                }
                else
                {
                    Respuesta4.BackColor = Color.Red;
                }
            }
            if ((Respuesta5.Text != ""))
            {
                if (Respuesta5.Text.Trim() == "metal")
                {
                    correctas = correctas + 1;
                    Respuesta5.BackColor = Color.Green;
                }
                else
                {
                    Respuesta5.BackColor = Color.Red;
                }
            }
            if ((Respuesta6.Text != ""))
            {
                if (Respuesta6.Text.Trim() == "no metal")
                {
                    correctas = correctas + 1;
                    Respuesta6.BackColor = Color.Green;
                }
                else
                {
                    Respuesta6.BackColor = Color.Red;
                }
            }
            if ((Respuesta7.Text != ""))
            {
                if (Respuesta7.Text.Trim() == "metalico")
                {
                    correctas = correctas + 1;
                    Respuesta7.BackColor = Color.Green;
                }
                else
                {
                    Respuesta7.BackColor = Color.Red;
                }
            }
            if ((Respuesta8.Text != ""))
            {
                if (Respuesta8.Text.Trim() == "no metalico")
                {
                    correctas = correctas + 1;
                    Respuesta8.BackColor = Color.Green;
                }
                else
                {
                    Respuesta8.BackColor = Color.Red;
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
                Respuesta1.Focus();
            }
        }
    }
}
