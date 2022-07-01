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

        private void button7_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            otroNivel.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.youtube.com/watch?v=qwxptJvloio&t=161s");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int result = 0;
            if ((comboBox1.Text != ""))
            {
                if (comboBox1.Text == "temperatura")
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
                if (comboBox2.Text == "sin impurezas")
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
                if (comboBox3.Text == "lluvias")
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
                if (comboBox4.Text == "puntitos")
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
                if (comboBox5.Text == "plumas")
                {

                    result = result + 1;
                    comboBox5.BackColor = Color.Green;

                }
                else
                {
                    comboBox5.BackColor = Color.Red;
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
                otroNivel.Enabled = true;
                otroNivel.Focus();
            }
            else
            {
                MessageBox.Show("Sigue intentando!", "Resultado insuficiente",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboBox1.Focus();
            }
        }

       
    }
}
