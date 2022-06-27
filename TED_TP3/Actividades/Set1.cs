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
            Set1Act1 ventana = new Set1Act1();
            ventana.ShowDialog();
        }
    }
}
