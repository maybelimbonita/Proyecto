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
    public partial class AgregarMateria : UserControl
    {
        private static AgregarMateria _agregarMateria;
        public static AgregarMateria AgregarMaterias
        {
            get
            {
                if (_agregarMateria == null)
                    _agregarMateria = new AgregarMateria();
                return _agregarMateria;
            }
        }
        public AgregarMateria()
        {
            InitializeComponent();
            CargarCombos(); 
        }

        private void CargarCombos()
        {
            List<Maestro> lstMaestros;
            clsMaestro maestro = new clsMaestro();
            lstMaestros = maestro.BuscarMaestros("");
            cmbMaestros.DataSource = lstMaestros; 
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Materia nuevamateria = new Materia()
            {
                NombreMateria = txtNombre.Text,
                MaestroDeMateria = (int)cmbMaestros.SelectedValue,
                Estado = cmbEstado.SelectedItem.Equals("Activo")
            };
            clsMaterias materia = new clsMaterias();
            if (materia.AgregarMateria(nuevamateria))
            {
                MessageBox.Show("Materia Creada exitosamente");
                Utilidades.limpiarControles(this);
            }
            else
            {
                MessageBox.Show(materia.Mensaje);
            }
        }
    }
}
