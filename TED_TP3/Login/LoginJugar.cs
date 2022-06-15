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
using TED_TP3.Actividades;
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
            if (txtNombre.Text.Equals(""))
            {
                MessageBox.Show("Debe cargar nombre.", "Atención",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
            }
            else
            {
                try
                {
                    Jugador jug = new Jugador(txtNombre.Text.Trim(), 0);

                    StreamReader leer;
                    leer = File.OpenText("datosJugadores.txt");
                    string cadena;
                    string[] arreglo = new string[2];
                    char[] separador = { '-' };
                    bool existente = false;
                    cadena = leer.ReadLine();
                    while (cadena != null && existente == false)
                    {
                        arreglo = cadena.Split(separador);
                        if (arreglo[0].Trim().Equals(jug.nombre))
                        {
                            jug.nivelAlcanzado = int.Parse(arreglo[1]);

                            MessageBox.Show("Bienvenido de vuelta " + jug.nombre + "! \nNivel guardado: " + 
                                jug.nivelAlcanzado, "Login Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            existente = true;
                            leer.Close();
                        }
                        else
                        {
                            cadena = leer.ReadLine();
                        }
                    }
                    if (existente == false)
                    {
                        leer.Close();
                        StreamWriter registrar = new StreamWriter("datosJugadores.txt", true);
                        registrar.WriteLine("\n" + jug.nombre + "-" + "0");
                        registrar.Close();

                        MessageBox.Show("¡Bienvenido a nuestro sistema " + jug.nombre + "!", 
                            "Usuario nuevo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    MainActividades ventana = new MainActividades(jug);
                    ventana.Show();
                    ventana.FormClosed += LogOut;
                    Hide();

                }
                catch (Exception error)
                {
                    MessageBox.Show("Error: " + error);
                }
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LogOut(object sender, FormClosedEventArgs e)
        {
            Show();
        }
    }
}
