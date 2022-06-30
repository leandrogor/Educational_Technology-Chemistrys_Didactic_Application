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
    }
}
