﻿using System;
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
        }

        private void btnVideo_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.youtube.com/watch?v=qwxptJvloio&t=161s");
        }

        private void btnNoticia_Click(object sender, EventArgs e)
        {
            Process.Start("https://750.am/2021/01/14/el-cosito-del-clima-como-funciona-el-souvenir-preferido-de-las-personas-que-visitan-la-costa/");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int result = 0;
            if ((comboBox1.Text != ""))
            {
                if (comboBox1.Text == "vidrio")
                {

                    result = result + 1;
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

                    result = result + 1;
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

                    result = result + 1;
                    comboBox3.BackColor = Color.Green;

                }
                else
                {
                    comboBox3.BackColor = Color.Red;
                }
            }
            if ((comboBox4.Text != ""))
            {
                if (comboBox4.Text == "azul")
                {

                    result = result + 1;
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

                    result = result + 1;
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

                    result = result + 1;
                    comboBox6.BackColor = Color.Green;

                }
                else
                {
                    comboBox6.BackColor = Color.Red;
                }
            }
            MessageBox.Show("Su resultado es: " + result, "Resultado final", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lblResCor.Visible = true;
            lblCantCorr.Text = result.ToString();
            lblCantCorr.Visible = true;

            if (result > 5)
            {
                MessageBox.Show("Ya puede avanzar a la siguiente actividad!", "Tarea completada!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Sigue intentando!", "Resultado insuficiente",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboBox1.Focus();
            }
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            var point = new Point();
            point.X = Location.X;
            point.Y = Location.Y - 100;
            Location = point;

            Size = new Size(Size.Width, 730);
            btnSiguiente.Visible = false;
            btnVolver.Visible = false;
            btnAyuda.Visible = false;

            btnImagen.Visible = true;
            panelAyuda.Visible = true;
            btnOcultarAyuda.Visible = true;
        }

        private void btnOcultarAyuda_Click(object sender, EventArgs e)
        {
            var point = new Point();
            point.X = Location.X;
            point.Y = Location.Y + 100;
            Location = point;
            Size = new Size(Size.Width, 487);
            btnSiguiente.Visible = true;
            btnVolver.Visible = true;
            btnAyuda.Visible = true;

            btnImagen.Visible = false;
            panelAyuda.Visible = false;
            btnOcultarAyuda.Visible = false;
        }
    }
}
