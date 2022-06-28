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
    public partial class Set1Act1 : Form
    {
        Random random = new Random();

        List<Actividad> activiades = new List<Actividad>();
        public Actividad actSeleccionada;

        public Set1Act1()
        {
            InitializeComponent();

            lblCantCorr.Text = "0";
            cantErrores.Text = "0";

            Actividad actividad1 = new Actividad("¿Con qué compuestos se forma el Ácido Fulmínico?", "N1H1C1O1");
            Actividad actividad2 = new Actividad("¿Con qué compuestos se forma el Cloruro de Sodio?", "Na1Cl1");
            Actividad actividad3 = new Actividad("¿Con qué compuestos se forma el Ácido Perclórico?", "Cl1H1O4");
            Actividad actividad4 = new Actividad("¿Con qué compuestos se forma el compuesto desconocido?", "");

            activiades.Add(actividad1);
            activiades.Add(actividad2);
            activiades.Add(actividad3);
            activiades.Add(actividad4);

            nuevaPregunta(activiades);
        }

        private void nuevaPregunta(List<Actividad> activiades)
        {
            if (activiades.Count != 0)
            {
                int numAct = random.Next(0, activiades.Count);

                actSeleccionada = activiades[numAct];
                activiades.RemoveAt(numAct);

                lblPregunta.Text = actSeleccionada.enunciado;
            }
            else
            {
                MessageBox.Show("Todas las actividades completadas, es hora de avanzar!");
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string sodio = "";
            string cloro = "";
            string nitrogeno = "";
            string hidrogeno = "";
            string carbono = "";
            string oxigeno = "";


            if (nUDNa.Value != 0)
            {
                sodio = "Na" + nUDNa.Value;
            }
            if (nUDCl.Value != 0)
            {
                cloro = "Cl" + nUDCl.Value;
            }
            if (nUDN.Value != 0)
            {
                nitrogeno = "N" + nUDN.Value;
            }
            if (nUDH.Value != 0)
            {
                hidrogeno = "H" + nUDH.Value;
            }
            if (nUDC.Value != 0)
            {
                carbono = "C" + nUDC.Value;
            }
            if (nUDO.Value != 0)
            {
                oxigeno = "O" + nUDO.Value;
            }

            txtCompuesto.Text = sodio + cloro + nitrogeno + hidrogeno + carbono + oxigeno;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            if (txtCompuesto.Text == "(Compuesto)")
            {
                MessageBox.Show("Dele a actualizar para que se cargue su compuesto", "Atención", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnActualizar.Focus();
            }
            else if (txtCompuesto.Text == actSeleccionada.respuesta)
            {
                MessageBox.Show("Respuesta correcta!", "Muy bien", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblCantCorr.Text = (int.Parse(lblCantCorr.Text)+1).ToString();
                nuevaPregunta(activiades);
                reiniciar();

                if (lblCantCorr.Text == "2")
                {
                    MessageBox.Show("Ya puede avanzar a la siguiente actividad!", "Tarea completada",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnSiguiente.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Respuesta incorrecta...", "Oh on", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                cantErrores.Text = (int.Parse(cantErrores.Text) + 1).ToString();
                if (cantErrores.Text == "2")
                {
                    btnAyuda.Enabled = true;
                }
            }
        }

        private void reiniciar()
        {
            txtCompuesto.Text = "(Compuesto)";
            cantErrores.Text = "0";
            btnAyuda.Enabled = false;
            nUDNa.Value = 0;
            nUDCl.Value = 0;
            nUDN.Value = 0;
            nUDH.Value = 0;
            nUDC.Value = 0;
            nUDO.Value = 0;
            nUDNa.Focus();
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Work in progress...");
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Work in progress...");
        }
    }
}
