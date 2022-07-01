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
    public partial class Set1 : Form
    {
        public Set1()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAct1_Click(object sender, EventArgs e)
        {
            Set1Act1 ventana = new Set1Act1(this);
            ventana.ShowDialog();
        }

        public void habilitarAct2()
        {
            btnAct2.Enabled = true;
        }

        private void btnAct2_Click(object sender, EventArgs e)
        {
            Set1Act2 ventana = new Set1Act2(this);
            ventana.ShowDialog();
        }

        public void habilitarAct3()
        {
            btnAct3.Enabled = true;
        }

        private void btnAct3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Desarrollo de actividad 3...");
            habilitarAct4();
            btnAct4.Focus();
            //Set1Act3 ventana = new Set1Act3(this);
            //ventana.ShowDialog();
        }

        public void habilitarAct4()
        {
            btnAct4.Enabled = true;
        }

        private void btnAct4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Work in progress...");
        }
    }
}
