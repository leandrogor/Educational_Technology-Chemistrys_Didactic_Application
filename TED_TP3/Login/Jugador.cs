using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TED_TP3.Login
{
    public class Jugador
    {
        public string nombre { get; set; }
        public int nivelAlcanzado { get; set; }

        public Jugador(string nom, int nivel)
        {
            nombre = nom;
            nivelAlcanzado = nivel;
        }
    }
}
