using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TED_TP3.Actividades
{
    public partial class Set2Act3 : Form
    {
        private Set2 set2;
        public Set2Act3(Set2 set2)
        {
            InitializeComponent();
            this.set2 = set2;
            string html = "<html><head> <meta content='IE=Edge' http-equiv='X-UA-Compatible'/>";
            html += "<iframe src='https://www.youtube.com/embed/M7lc1UVf-VE' width='420' height='250' frameborder='0' allowfullscreen> </iframe>";
            html += "</body></html>";
            this.webBrowser1.DocumentText = html;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Volviendo a set de actividades 2...");
            set2.habilitarAct4();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Desea verificar sus respuestas antes de ver las soluciones?", "Atención",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                int correctas = 0;
                int incorrectas = 0;

                if (p1.Checked)
                {
                    correctas += 1;
                }
                else
                {
                    incorrectas += 1;
                }

                if (p2.Checked == false)
                {
                    correctas += 1;
                }
                else
                {
                    incorrectas += 1;
                }

                if (p3.Checked)
                {
                    correctas += 1;
                }
                else
                {
                    incorrectas += 1;
                }

                if (p4.Checked)
                {
                    correctas += 1;
                }
                else
                {
                    incorrectas += 1;
                }

                if (p5.Checked == false)
                {
                    correctas += 1;
                }
                else
                {
                    incorrectas += 1;
                }

                if (p6.Checked == false)
                {
                    correctas += 1;
                }
                else
                {
                    incorrectas += 1;
                }

                lblCantCorr.Text = correctas.ToString();
                lblCantErrores.Text = incorrectas.ToString();

                lblCantCorr.Visible = true;
                lblCantErrores.Visible = true;
                lblCor.Visible = true;
                lblNoCor.Visible = true;
            }
            else if (result == DialogResult.No)
            {
                if (p1.Checked)
                {
                    p1.ForeColor = Color.Green;
                }
                else
                {
                    p1.ForeColor = Color.Red;
                }

                if (p2.Checked == false)
                {
                    p2.ForeColor = Color.Green;
                }
                else
                {
                    p2.ForeColor = Color.Red;
                }

                if (p3.Checked)
                {
                    p3.ForeColor = Color.Green;
                }
                else
                {
                    p3.ForeColor = Color.Red;
                }

                if (p4.Checked)
                {
                    p4.ForeColor = Color.Green;
                }
                else
                {
                    p4.ForeColor = Color.Red;
                }

                if (p5.Checked == false)
                {
                    p5.ForeColor = Color.Green;
                }
                else
                {
                    p5.ForeColor = Color.Red;
                }

                if (p6.Checked == false)
                {
                    p6.ForeColor = Color.Green;
                }
                else
                {
                    p6.ForeColor = Color.Red;
                }

                r1.ForeColor = Color.Green;
                r2.ForeColor = Color.Red;
                r3.ForeColor = Color.Green;
                r4.ForeColor = Color.Green;
                r5.ForeColor = Color.Red;
                r6.ForeColor = Color.Red;

                r1.Visible = true;
                r2.Visible = true;
                r3.Visible = true;
                r4.Visible = true;
                r5.Visible = true;
                r6.Visible = true;
            }
        }

        private void btnHabilitarPanel_Click(object sender, EventArgs e)
        {
            btnHabilitarPanel.Visible = false;
            panel1.Visible = true;
            r1.Focus();
        }
    }
}
