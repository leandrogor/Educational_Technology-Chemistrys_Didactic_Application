using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TED_TP3.Login
{
    public class Docente
    {
        public string usuario { get; set; }
        public string contra { get; set; }

        public Docente(string uss, string pass)
        {
            usuario = uss;
            contra = pass;
        }
    }
}
