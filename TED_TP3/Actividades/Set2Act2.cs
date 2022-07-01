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
using TED_TP3.Actividades;

namespace Prueba2
{
    public partial class Set2Act2 : Form
    {
        private Set2 set2;
        public Set2Act2(Set2 set2)
        {
            InitializeComponent();
            this.set2 = set2;
            comboBox1.Sorted = true;
            comboBox2.Sorted = true;
            comboBox3.Sorted = true;
            comboBox4.Sorted = true;
            comboBox5.Sorted = true;
            comboBox6.Sorted = true;
        }

        private void Set2Act2_Load(object sender, EventArgs e)
        {
            var point = new Point();
            point.X = Location.X;
            point.Y = Location.Y - 100;
            Location = point;
        }

        private void btnVideo_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.youtube.com/watch?v=qwxptJvloio&t=161s");
        }

        private void btnNoticia_Click(object sender, EventArgs e)
        {
            Process.Start("https://750.am/2021/01/14/el-cosito-del-clima-como-funciona-el-souvenir-preferido-de-las-personas-que-visitan-la-costa/");
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            Size = new Size(Size.Width, Size.Height + 200);
            btnAyuda.Visible = false;

            btnImagen.Visible = true;
            panelAyuda.Visible = true;
            btnOcultarAyuda.Visible = true;
        }

        private void btnOcultarAyuda_Click(object sender, EventArgs e)
        {
            Size = new Size(Size.Width, Size.Height - 200);
            btnAyuda.Visible = true;

            btnImagen.Visible = false;
            panelAyuda.Visible = false;
            btnOcultarAyuda.Visible = false;
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            int correctas = 0;
            if ((comboBox1.Text != ""))
            {
                if (comboBox1.Text == "vidrio")
                {
                    correctas = correctas + 1;
                    comboBox1.BackColor = Color.Green;
                }
                else
                {
                    comboBox1.BackColor = Color.Red;
                }
            }
            if ((comboBox2.Text != ""))
            {
                if (comboBox2.Text == "nitrato de potasio")
                {
                    correctas = correctas + 1;
                    comboBox2.BackColor = Color.Green;
                }
                else
                {
                    comboBox2.BackColor = Color.Red;
                }
            }
            if ((comboBox3.Text != ""))
            {
                if (comboBox3.Text == "cloruro de amonio")
                {
                    correctas = correctas + 1;
                    comboBox3.BackColor = Color.Green;
                }
                else
                {
                    comboBox3.BackColor = Color.Red;
                }
            }
            lblResCor1.Visible = true;
            lblCantCorr1.Text = correctas.ToString();
            lblCantCorr1.Visible = true;

            comboBox4.Focus();
            validarSiPuedeAvanzar(lblCantCorr1.Text, lblCantCorr2.Text);
        }

        private void btnVerificar2_Click(object sender, EventArgs e)
        {
            int correctas = 0;
            if ((comboBox4.Text != ""))
            {
                if (comboBox4.Text == "azul")
                {
                    correctas = correctas + 1;
                    comboBox4.BackColor = Color.Green;
                }
                else
                {
                    comboBox4.BackColor = Color.Red;
                }
            }
            if ((comboBox5.Text != ""))
            {
                if (comboBox5.Text == "violeta")
                {
                    correctas = correctas + 1;
                    comboBox5.BackColor = Color.Green;
                }
                else
                {
                    comboBox5.BackColor = Color.Red;
                }
            }
            if ((comboBox6.Text != ""))
            {
                if (comboBox6.Text == "rosado")
                {
                    correctas = correctas + 1;
                    comboBox6.BackColor = Color.Green;
                }
                else
                {
                    comboBox6.BackColor = Color.Red;
                }
            }
            lblResCor2.Visible = true;
            lblCantCorr2.Text = correctas.ToString();
            lblCantCorr2.Visible = true;

            comboBox1.Focus();
            validarSiPuedeAvanzar(lblCantCorr1.Text, lblCantCorr2.Text);
        }

        private void validarSiPuedeAvanzar(string cant1, string cant2)
        {
            if (!btnSiguiente.Enabled)
            {
                if (int.Parse(cant1) + int.Parse(cant2) >= 4)
                {
                    MessageBox.Show("Ya puede avanzar a la siguiente actividad!", "Tarea completada!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnSiguiente.Enabled = true;
                    set2.habilitarAct3();
                    btnSiguiente.Focus();
                }
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Work in progress...");
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
