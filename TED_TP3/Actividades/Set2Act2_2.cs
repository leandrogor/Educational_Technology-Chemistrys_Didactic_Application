using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Prueba2
{
    public partial class Set2Act2_2 : Form
    {
        public Set2Act2_2()
        {
            InitializeComponent();
        }

        private void btnVideo_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.youtube.com/watch?v=qwxptJvloio&t=161s");
            comboBox1.Enabled = true;
            comboBox2.Enabled = true;
            comboBox3.Enabled = true;
            comboBox4.Enabled = true;
            comboBox5.Enabled = true;
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            btnAyuda.Visible = false;
            btnImagen.Visible = true;
            panelAyuda.Visible = true;
            btnOcultarAyuda.Visible = true;
        }

        private void btnOcultarAyuda_Click(object sender, EventArgs e)
        {
            btnAyuda.Visible = true;
            btnImagen.Visible = false;
            panelAyuda.Visible = false;
            btnOcultarAyuda.Visible = false;
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            int resultado = 0;
            if ((comboBox1.Text != ""))
            {
                if (comboBox1.Text == "temperatura")
                {
                    resultado = resultado + 1;
                    comboBox1.BackColor = Color.Green;
                }
                else
                {
                    comboBox1.BackColor = Color.Red;
                }
            }
            if ((comboBox2.Text != ""))
            {
                if (comboBox2.Text == "sin impurezas")
                {
                    resultado = resultado + 1;
                    comboBox2.BackColor = Color.Green;
                }
                else
                {
                    comboBox2.BackColor = Color.Red;
                }
            }
            if ((comboBox3.Text != ""))
            {
                if (comboBox3.Text == "lluvias")
                {
                    resultado = resultado + 1;
                    comboBox3.BackColor = Color.Green;
                }
                else
                {
                    comboBox3.BackColor = Color.Red;
                }
            }
            if ((comboBox4.Text != ""))
            {
                if (comboBox4.Text == "puntitos")
                {
                    resultado = resultado + 1;
                    comboBox4.BackColor = Color.Green;
                }
                else
                {
                    comboBox4.BackColor = Color.Red;
                }
            }
            if ((comboBox5.Text != ""))
            {
                if (comboBox5.Text == "plumas")
                {
                    resultado = resultado + 1;
                    comboBox5.BackColor = Color.Green;
                }
                else
                {
                    comboBox5.BackColor = Color.Red;
                }
            }
            MessageBox.Show("Su resultado es: " + resultado, "Resultado final", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lblResCor.Visible = true;
            lblCantCorr.Text = resultado.ToString();
            lblCantCorr.Visible = true;

            if (resultado >= 4)
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
                comboBox1.Focus();
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Volviendo a set de actividades 2...");
            Close();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
