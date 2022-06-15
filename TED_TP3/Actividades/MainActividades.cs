﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TED_TP3.Login;

namespace TED_TP3.Actividades
{
    public partial class MainActividades : Form
    {
        public MainActividades(Jugador jug)
        {
            InitializeComponent();
            lblIngresado.Text = "Usuario: " + jug.nombre + ". Puntaje alcanzado: " + jug.nivelAlcanzado + "."; 
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
