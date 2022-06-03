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

        private void btnAjustes_Click(object sender, EventArgs e)
        {
            //messagebox.show("( work in progress )", " -> ventana de ajutes",
            //    messageboxbuttons.ok,messageboxicon.information);
            Ajustes ventana = new Ajustes();
            ventana.ShowDialog();
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
    }
}
