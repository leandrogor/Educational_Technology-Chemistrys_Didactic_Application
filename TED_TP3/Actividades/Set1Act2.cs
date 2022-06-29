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
    }
}
