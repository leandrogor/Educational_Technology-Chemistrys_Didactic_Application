using Prueba2;
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
    public partial class Set2 : Form
    {
        private MainActividades mainActividades;
        public Set2(MainActividades mainActividades)
        {
            InitializeComponent();
            this.mainActividades = mainActividades;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAct1_Click(object sender, EventArgs e)
        {
            Set2Act1 ventana = new Set2Act1(this);
            ventana.ShowDialog();
        }

        public void habilitarAct2()
        {
            btnAct2.Enabled = true;
        }

        private void btnAct2_Click(object sender, EventArgs e)
        {
            Set2Act2 ventana = new Set2Act2(this);
            ventana.Show();
            ventana.FormClosed += LogOut;
            mainActividades.Hide();
            Hide();
        }

        private void LogOut(object sender, FormClosedEventArgs e)
        {
            mainActividades.Show();
            Show();
        }

        public void habilitarAct3()
        {
            btnAct3.Enabled = true;
        }

        private void btnAct3_Click(object sender, EventArgs e)
        {
            Set2Act3 ventana = new Set2Act3(this);
            ventana.ShowDialog();
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
