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
        public Set1Act1()
        {
            InitializeComponent();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string hidrogeno = "";
            if (nUDH.Value != 0)
            {
                hidrogeno = "H" + nUDH.Value;
            }

            btnCompuesto.Text = hidrogeno;
        }
    }
}
