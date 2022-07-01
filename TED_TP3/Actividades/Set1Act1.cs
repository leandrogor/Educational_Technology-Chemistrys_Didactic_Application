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
        private Set1 set1;
        
        Random random = new Random();

        List<Actividad> activiades = new List<Actividad>();
        public Actividad actSeleccionada;

        public Set1Act1(Set1 set1)
        {
            InitializeComponent();
            this.set1 = set1;

            lblCantCorr.Text = "0";
            cantErrores.Text = "0";

            Actividad actividad1 = new Actividad("Act1", "¿Cómo podemos formar Cloruro de sodio?", "Na1Cl1", "Más conocida como sal de mesa, está compuesto por dos elementos.");
            Actividad actividad2 = new Actividad("Act2", "¿Cómo podemos formar Nitrato de potasio?", "K1N1O3", "Además del potasio, contiene nitrógeno y oxígeno.");
            Actividad actividad3 = new Actividad("Act3", "¿Cómo podemos formar Bisulfato de sodio?", "Na1H1S1O4", "Es la sal de sodio del anión bisulfato.");
            Actividad actividad4 = new Actividad("Act4", "¿Cómo podemos formar Bicarbonato de sodio?", "Na1H1C1O3", "Es un antiácido usado para aliviar la pirosis.");
            Actividad actividad5 = new Actividad("Act5", "¿Cómo podemos formar Nitrato básico de cobre (II)?", "Cu1N2O6", "Además de cobre, contiene nitrógeno y oxígeno.");

            activiades.Add(actividad1);
            activiades.Add(actividad2);
            activiades.Add(actividad3);
            activiades.Add(actividad4);
            activiades.Add(actividad5);

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
            string cobre = "";
            string potasio = "";
            string nitrogeno = "";
            string hidrogeno = "";
            string azufre = "";
            string carbono = "";
            string oxigeno = "";


            if (Na.Value != 0)
            {
                sodio = "Na" + Na.Value;
            }
            if (Cl.Value != 0)
            {
                cloro = "Cl" + Cl.Value;
            }
            if (Cu.Value != 0)
            {
                cobre = "Cu" + Cu.Value;
            }
            if (K.Value != 0)
            {
                potasio = "K" + K.Value;
            }
            if (N.Value != 0)
            {
                nitrogeno = "N" + N.Value;
            }
            if (H.Value != 0)
            {
                hidrogeno = "H" + H.Value;
            }
            if (S.Value != 0)
            {
                azufre = "S" + H.Value;
            }
            if (C.Value != 0)
            {
                carbono = "C" + C.Value;
            }
            if (O.Value != 0)
            {
                oxigeno = "O" + O.Value;
            }

            txtCompuesto.Text = sodio + cloro + cobre + potasio + nitrogeno + hidrogeno + azufre + carbono + oxigeno;
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
                    btnSiguiente.Focus();
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
            Na.Value = 0;
            Cl.Value = 0;
            Cu.Value = 0;
            K.Value = 0;
            N.Value = 0;
            H.Value = 0;
            S.Value = 0;
            C.Value = 0;
            O.Value = 0;
            Na.Focus();
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show(actSeleccionada.ayuda, "Ayuda", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Volviendo a set de actividades 1...");
            set1.habilitarAct2();
            Close();
        }
    }
}
