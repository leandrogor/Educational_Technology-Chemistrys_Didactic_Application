using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TED_TP3.Varios
{
    public partial class Prueba : Form
    {
        public Prueba()
        {
            InitializeComponent();
            string html = "<html><head> <meta content='IE=Edge' http-equiv='X-UA-Compatible'/>";
            html += "<iframe src='https://www.youtube.com/embed/4uDf1GfqLXk' width='700' height='400' frameborder='0' allowfullscreen> </iframe>";
            html += "</body></html>";
            this.webBrowser1.DocumentText = html;
        }
    }
}
 