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
    public partial class BuscarAlumno : UserControl
    {
        private static BuscarAlumno _buscarAlumno;
        public static BuscarAlumno BuscarAlumnos
        {
            get
            {
                if (_buscarAlumno == null)
                    _buscarAlumno = new BuscarAlumno();
                return _buscarAlumno;
            }
        }
        public BuscarAlumno()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            clsAlumno alumno = new clsAlumno();
            List<Alumno> alumnos = null;
            alumnos = alumno.BuscarAlumnos(txtNombre.Text);
            if (alumnos.Count() > 0)
            {
                dgBusquedaAlumno.DataSource = alumnos;
            }
        }
    }
}
