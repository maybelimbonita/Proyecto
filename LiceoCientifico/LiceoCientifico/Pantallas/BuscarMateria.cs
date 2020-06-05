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
    public partial class BuscarMateria : UserControl
    {
        private static BuscarMateria _BuscarMateria;
        public static BuscarMateria BucarMateria
        {
            get
            {
                if (_BuscarMateria == null)
                    _BuscarMateria = new BuscarMateria();
                return _BuscarMateria;
            }
        }
        public BuscarMateria()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            clsMaterias materia = new clsMaterias();
            List<Materia> Materias = null;
            Materias = materia.BuscarMateria(txtNombre.Text);
            if (Materias.Count() > 0)
            {
                dgBusquedaMaestro.DataSource = Materias;
            }
        }
    }
}
