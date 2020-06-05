using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiceoCientifico.Logica;
using LiceoCientifico.Data;

namespace LiceoCientifico.Pantallas
{
    public partial class BuscarMaestro : UserControl
    {
        private static BuscarMaestro _buscarMaestro;
        public static BuscarMaestro buscarMaestro
        {
            get
            {
                if (_buscarMaestro == null)
                    _buscarMaestro = new BuscarMaestro();
                return _buscarMaestro;
            }
        }
        public BuscarMaestro()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            clsMaestro maestro = new clsMaestro();
            List<Maestro> Maestros = null;
            Maestros = maestro.BuscarMaestros(txtNombre.Text);
            if (Maestros.Count() > 0)
            {
                dgBusquedaMaestro.DataSource = Maestros;
            }
        }
    }
}
