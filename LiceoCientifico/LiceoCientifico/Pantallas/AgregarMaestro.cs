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
    public partial class AgregarMaestro : UserControl
    {
        private static AgregarMaestro _agregarMaestro;
        public static AgregarMaestro AgregarMaestros
        {
            get
            {
                if (_agregarMaestro == null)
                    _agregarMaestro = new AgregarMaestro();
                return _agregarMaestro;
            }
        }
        public AgregarMaestro()
        {
            InitializeComponent();
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            if (txtNombres.Text.Equals(string.Empty) || txtApellidos.Text.Equals(string.Empty) || txtNivelAcademico.Text.Equals(string.Empty)
             || txtEspecializacion.Text.Equals(string.Empty)  || cmbEstado.SelectedItem.ToString().Equals(string.Empty))
            {
                MessageBox.Show("Hay campos  obligatorios vacios.");
            }
            else
            {
                Maestro nuevoAlumno = new Maestro()
                {
                    Nombres = txtNombres.Text,
                    Apellidos = txtApellidos.Text,
                    Especializacion = txtEspecializacion.Text,
                    NivelAcademico = txtNivelAcademico.Text,
                     estado = cmbEstado.SelectedItem.ToString().Equals("Activo") ? true : false,
                };

                clsMaestro maestro = new clsMaestro();
                if (maestro.AgregarMaestro(nuevoAlumno))
                {
                    MessageBox.Show("Maestro Creado exitosamente");
                    Utilidades.limpiarControles(this);
                }
                else
                {
                    MessageBox.Show(maestro.Mensaje);
                }

            }
        }
    }
}
