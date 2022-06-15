using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TED_TP3.Varios;

namespace TED_TP3
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        bool idiomaEsp = true;
        bool sonOn = true;
        bool musOn = false;

        private void btnAjustes_Click(object sender, EventArgs e)
        {
            Ajustes ventana = new Ajustes(idiomaEsp, sonOn, musOn, this);
            ventana.ShowDialog();
        }

        public void guardarAjustes(bool idiomaEspNuevo, bool sonOnNuevo, bool munOnNuevo)
        {
            idiomaEsp = idiomaEspNuevo;
            sonOn = sonOnNuevo;
            musOn = munOnNuevo;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("¿Está seguro que desea salir?", "Salir",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Close();                
            }           
        }

        private void btnJugar_Click(object sender, EventArgs e)
        {
            LoginJugar ventana = new LoginJugar();
            ventana.Show();
            ventana.FormClosed += LogOut;
            Hide();
        }


        private void btnCrear_Click(object sender, EventArgs e)
        {
            LoginCrear ventana = new LoginCrear();
            ventana.Show();
            ventana.FormClosed += LogOut;
            Hide();
        }

        private void LogOut(object sender, FormClosedEventArgs e)
        {
            Show();
        }
    }
}
