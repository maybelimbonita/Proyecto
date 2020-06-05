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
    public partial class BuscarUsuario : UserControl
    {
        private static BuscarUsuario _buscarUsuario;
        public static BuscarUsuario buscarUsuario
        {
            get
            {
                if (_buscarUsuario == null)
                    _buscarUsuario = new BuscarUsuario();
                return _buscarUsuario;
            }
        }

        public BuscarUsuario()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            clsUsuario usuario = new clsUsuario();
            List<Usuario> Usuarios = null;
            Usuarios = usuario.BuscarUsuarios(txtNombre.Text); 
            if(Usuarios.Count() >0 )
            {
                dgBusquedaUsuario.DataSource = Usuarios; 
            }
        }
    }
}
