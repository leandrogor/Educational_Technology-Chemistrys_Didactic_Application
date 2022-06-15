using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TED_TP3.Login;

namespace TED_TP3.Varios
{
    public partial class CrearSolicitudEjercicio : Form
    {
        public CrearSolicitudEjercicio(Docente doc)
        {
            InitializeComponent();
            lblIngresado.Text = "Docente: " + doc.usuario + ".";
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
