using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TED_TP3.Login;

namespace TED_TP3
{
    public partial class LoginJugar : Form
    {
        public LoginJugar()
        {
            InitializeComponent();
        }

        private void btnJugar_Click(object sender, EventArgs e)
        {
            try
            {
                Jugador jug = new Jugador();

                jug.nombre = txtNombre.Text; 

                StreamWriter leer;
                //StreamReader leer;

                leer = File.CreateText("datosJugadores.txt");
                //leer = File.OpenText("datosJugadores.txt");
                string cadena;
                string[] arreglo = new string[2];
                //char[] separador = { '-' };
                //bool autorizado = false;
                //cadena = leer.ReadLine();
                //while (cadena != null && autorizado == false)
                //{
                //    arreglo = cadena.Split(separador);
                //    if (arreglo[0].Trim().Equals(user_verificar) && arreglo[1].Trim().Equals(contra_verificar))
                //    {
                //        MessageBox.Show("Usuario y contraseñas correctos", "Login Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //        MenuPr();
                //        autorizado = true;
                //    }
                //    else
                //    {
                //        cadena = leer.ReadLine();
                //    }
                //}
                //if (autorizado == false)
                //{
                //    MessageBox.Show("Usuario y/o contraseña incorrectos", "Login Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
            }
            catch (Exception error)
            {
                MessageBox.Show("Error: " + error);
            }
        }
    }
}
