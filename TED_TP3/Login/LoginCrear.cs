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
using TED_TP3.Varios;

namespace TED_TP3
{
    public partial class LoginCrear : Form
    {
        private Main main;
        public LoginCrear(Main main)
        {
            InitializeComponent();
            this.main = main;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Equals("") || txtContra.Text.Equals(""))
            {
                MessageBox.Show("Debe cargar usuario y contraseñia.", "Atención",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsuario.Focus();
            }
            else
            {
                try
                {
                    Docente doc = new Docente(txtUsuario.Text.Trim(), txtContra.Text.Trim());

                    StreamReader leer;
                    leer = File.OpenText("datosDocentes.txt");
                    string cadena;
                    string[] arreglo = new string[2];
                    char[] separador = { '-' };
                    bool existente = false;
                    cadena = leer.ReadLine();
                    while (cadena != null && existente == false)
                    {
                        arreglo = cadena.Split(separador);
                        if (arreglo[0].Trim().Equals(doc.usuario))
                        {
                            if (arreglo[1].Trim().Equals(doc.contra))
                            {
                                MessageBox.Show("Bienvenido de vuelta " + doc.usuario + "!",
                                    "Login Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                existente = true;
                                leer.Close();
                                
                                CrearSolicitudEjercicio ventana = new CrearSolicitudEjercicio(doc, main, this);
                                ventana.Show();
                                ventana.FormClosed += LogOut;
                                Hide();
                            }
                            else
                            {
                                MessageBox.Show("Contraseña incorrecta",
                                     "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                existente = true;
                                txtUsuario.Focus();
                            }
                        }
                        else
                        {
                            cadena = leer.ReadLine();
                        }
                    }
                    leer.Close();

                    if (existente == false)
                    {
                        MessageBox.Show("Usuario inexistente",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtUsuario.Focus();
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show("Error: " + error);
                }
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Equals("") || txtContra.Text.Equals(""))
            {
                MessageBox.Show("Debe cargar usuario y contraseñia.", "Atención",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsuario.Focus();
            }
            else
            {
                try
                {
                    Docente doc = new Docente(txtUsuario.Text.Trim(), txtContra.Text.Trim());

                    StreamReader leer;
                    leer = File.OpenText("datosDocentes.txt");
                    string cadena;
                    string[] arreglo = new string[2];
                    char[] separador = { '-' };
                    bool existente = false;
                    cadena = leer.ReadLine();
                    while (cadena != null && existente == false)
                    {
                        arreglo = cadena.Split(separador);
                        if (arreglo[0].Trim().Equals(doc.usuario))
                        {
                            MessageBox.Show("Ya existe un usuario con ese nombre.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtUsuario.Focus();
                            existente = true;
                        }
                        else
                        {
                            cadena = leer.ReadLine();
                        }
                    }
                    leer.Close();

                    if (existente == false)
                    {
                        StreamWriter registrar = new StreamWriter("datosDocentes.txt", true);
                        registrar.WriteLine("\n" + doc.usuario + "-" + doc.contra);
                        registrar.Close();

                        MessageBox.Show("Docente creado con éxito.",
                            "Usuario nuevo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        btnIngresar.Focus();
                    }
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
