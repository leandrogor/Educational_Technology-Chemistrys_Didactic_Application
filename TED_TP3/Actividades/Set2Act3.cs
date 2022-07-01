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
            html += "<iframe src='https://www.youtube.com/embed/cQQLyN8EtE4' width='420' height='250' frameborder='0' allowfullscreen> </iframe>";
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
            MessageBox.Show("Desea verificar sus respuestas antes de ver las soluciones?", "Atención",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
        }
    }
}
