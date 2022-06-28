using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TED_TP3.Actividades
{
    public class Actividad
    {
        public string titulo {get; set; }
        public string enunciado {get; set; }
        public string respuesta {get; set; }
        public string ayuda {get; set; }

        public Actividad(string enunciado, string respuesta)
        {
            this.enunciado = enunciado;
            this.respuesta = respuesta;
        }

        public Actividad(string titulo, string enunciado, string respuesta, string ayuda)
        {
            this.titulo = titulo;
            this.enunciado = enunciado;
            this.respuesta = respuesta;
            this.ayuda = ayuda;
        }
    }
}
