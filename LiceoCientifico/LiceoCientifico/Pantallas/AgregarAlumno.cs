using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiceoCientifico.Data;
using LiceoCientifico.Logica;

namespace LiceoCientifico.Pantallas
{
    public partial class AgregarAlumno : UserControl
    {
        private static AgregarAlumno _agregarAlumno;
        public static AgregarAlumno AgregarAlumnos
        {
            get
            {
                if (_agregarAlumno == null)
                    _agregarAlumno = new AgregarAlumno();
                return _agregarAlumno;
            }
        }
        public AgregarAlumno()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNombres.Text.Equals(string.Empty) || txtApellidos.Text.Equals(string.Empty) || txtCUI.Text.Equals(string.Empty)
              || txtEncargado.Text.Equals(string.Empty) || txtTelefonoEncargado.Text.Equals(string.Empty) || cmbEstado.SelectedItem.ToString().Equals(string.Empty))
            {
                MessageBox.Show("Hay campos  obligatorios vacios.");
            }
            else
            {
                Alumno nuevoAlumno = new Alumno()
                {
                    Nombres = txtNombres.Text,
                    Apellidos = txtApellidos.Text,
                    CUI = txtCUI.Text,
                    NombreEncargado = txtEncargado.Text,
                    TelefonoEncargado = long.Parse(txtTelefonoEncargado.Text),
                    Estado = cmbEstado.SelectedItem.ToString().Equals("Activo") ? true : false,
                    FechaNacimiento = dtNacimiento.Value
                };

                clsAlumno alumno = new clsAlumno();
                if (alumno.AgregarAlumno(nuevoAlumno))
                {
                    MessageBox.Show("Alumno Creado exitosamente");
                    Utilidades.limpiarControles(this);
                }
                else
                {
                    MessageBox.Show(alumno.Mensaje);
                }

            }
        }
    }
}
