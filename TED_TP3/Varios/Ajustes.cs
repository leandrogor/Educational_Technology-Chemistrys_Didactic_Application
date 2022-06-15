using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TED_TP3.Varios
{
    public partial class Ajustes : Form
    {
        Main FrmMain = new Main();
        public Ajustes(bool idiomaEsp, bool sonOn, bool musOn, Main main)
        {
            InitializeComponent();
            rbIdiomaEsp.Checked = idiomaEsp;
            rbIdiomaIng.Checked = !idiomaEsp;
            rbSonOn.Checked = sonOn;
            rbSonOff.Checked = !sonOn;
            rbMusOn.Checked = musOn;
            rbMusOff.Checked = !musOn;
            FrmMain = main;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool idiomaEsp = rbIdiomaEsp.Checked;
            bool sonOn = rbSonOn.Checked;
            bool musOn = rbMusOn.Checked;
            FrmMain.guardarAjustes(idiomaEsp, sonOn, musOn);
            Close();
        }
    }
}
