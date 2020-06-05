using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiceoCientifico.Logica
{
    class Utilidades
    {

        public static void  limpiarControles(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }
            }
        }
    }
}
