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
            LoginCrear ventana = new LoginCrear(this);
            ventana.Show();
            ventana.FormClosed += LogOut;
            Hide();
        }

        private void LogOut(object sender, FormClosedEventArgs e)
        {
            Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Prueba ventana = new Prueba();
            ventana.ShowDialog();
        }

        private void btnCreditos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este programa fue desarrollado por alumnos de la Univerdidad Tecnológica Nacional\n" +
                "Facultad Regional Córdoba. \n\n* CONTACTO:\n" +
                "Andrada Cabo, Juan Ignacio - juanandrada_07_@hotmail.com\n" +
                "Gor, Leandro Gabriel - leandrogabrielgor@gmail.com\n" +
                "Haliska, Martina - martihaliska@gmail.com\n\n" +
                "Tecnología Educativa - 2022", "Créditos", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnComoUsar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Para acceder a este programa usted tiene que acceder con su nombre.\n" +
                "Si ya accedió alguna vez, carga su progreso.\n" +
                "Si es su primera vez se crea automáticamente una cuenta para que empiece a guardar su progreso.\n\n" +
                "Si usted es docente tendrá la posibilidad de enviar un correo electrónico solicitando una actividad.\n\n" +
                "Una vez dentro del sistema (Como alumno), podrá ir realizando las actividades.\n" +
                "Necesitará conexión a internet para acceder a enlaces de noticias o videos de la web.\n" +
                "Como podrá ver no todas las actividades están desbloqueadas.\n" +
                "Usted necesitará de ir completando niveles para desbloquear los siguientes niveles.\n\n" +
                "Esperamos que lo disfrute, buena suerte!!!", "Cómo usar", 
                MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
    }
}
