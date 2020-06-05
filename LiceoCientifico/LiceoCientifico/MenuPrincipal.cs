using LiceoCientifico.Data;
using LiceoCientifico.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiceoCientifico.Pantallas; 

namespace LiceoCientifico
{
    public partial class MenuPrincipal : Form
    {
        Usuario auxUsuario; 
        public MenuPrincipal(Usuario usuario)
        {
            InitializeComponent();
            auxUsuario = usuario;
            this.Text = "MENU PRINCIPAL - " + auxUsuario.Nombres + " " + auxUsuario.Apellidos;
            ValidarPermisos(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void ValidarPermisos()
        {
            clsPermisos pr = new clsPermisos();
            List<PermisosxUsuario> Permisos =  pr.PermisosxIdUsuario(auxUsuario.IdUsuario); 
            if(Permisos == null || Permisos.Count() == 0 )
            {
                MessageBox.Show("Usuario sin permisos asignados.");
            }
            foreach (PermisosxUsuario item in Permisos)
            {
                switch (item.IdPermiso)
                {
                    // Crear Usuario
                    case 1:mUsuarios.Visible = true; break;
                    //Crear Alumno
                    case 2:mAlumnos.Visible = true; break;
                    //Creacion de Maestros
                    case 3:mMaestros.Visible = true; break;
                    //Creacion de Materias
                    case 4:mMaterias.Visible = true; break;
                    //Creacion de Secciones
                    case 5:mSecciones.Visible = true; break;
                    //Registro de pagos
                    case 6:mPagos.Visible = true; break;
                    //Creacion de Grados
                    case 7:mGrados.Visible = true; break;
                    //Asignacion de Alumnos
                    case 8:mAsignaciones.Visible=true;mAsignacionAlumnosS.Visible = true;  break;
                    //Asignacion de alumnos a una materia
                    case 9:mAsignaciones.Visible = true; mAsignacionAlumnosM.Visible = true;  break;
                }
            }
        }

        private void crearUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(!pnlPrincipal.Controls.Contains(ucAgregarUsuario.agregarUsuario))
            {
                pnlPrincipal.Controls.Add(ucAgregarUsuario.agregarUsuario);
                ucAgregarUsuario.agregarUsuario.Dock = DockStyle.Fill;
                ucAgregarUsuario.agregarUsuario.BringToFront(); 
            }
            else ucAgregarUsuario.agregarUsuario.BringToFront();

        }

        private void buscarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!pnlPrincipal.Controls.Contains(BuscarUsuario.buscarUsuario))
            {
                pnlPrincipal.Controls.Add(BuscarUsuario.buscarUsuario);
                BuscarUsuario.buscarUsuario.Dock = DockStyle.Fill;
                BuscarUsuario.buscarUsuario.BringToFront();
            }
            else BuscarUsuario.buscarUsuario.BringToFront();
        }

        private void crearAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!pnlPrincipal.Controls.Contains(AgregarAlumno.AgregarAlumnos))
            {
                pnlPrincipal.Controls.Add(AgregarAlumno.AgregarAlumnos);
                AgregarAlumno.AgregarAlumnos.Dock = DockStyle.Fill;
                AgregarAlumno.AgregarAlumnos.BringToFront();
            }
            else AgregarAlumno.AgregarAlumnos.BringToFront();
        }

        private void buscarAlumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!pnlPrincipal.Controls.Contains(BuscarAlumno.BuscarAlumnos))
            {
                pnlPrincipal.Controls.Add(BuscarAlumno.BuscarAlumnos);
                BuscarAlumno.BuscarAlumnos.Dock = DockStyle.Fill;
                BuscarAlumno.BuscarAlumnos.BringToFront();
            }
            else BuscarAlumno.BuscarAlumnos.BringToFront();
        }

        private void crearMaestrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!pnlPrincipal.Controls.Contains(AgregarMaestro.AgregarMaestros))
            {
                pnlPrincipal.Controls.Add(AgregarMaestro.AgregarMaestros);
                AgregarMaestro.AgregarMaestros.Dock = DockStyle.Fill;
                AgregarMaestro.AgregarMaestros.BringToFront();
            }
            else AgregarMaestro.AgregarMaestros.BringToFront();
        }

        private void buscarMaestrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!pnlPrincipal.Controls.Contains(BuscarMaestro.buscarMaestro))
            {
                pnlPrincipal.Controls.Add(BuscarMaestro.buscarMaestro);
                BuscarMaestro.buscarMaestro.Dock = DockStyle.Fill;
                BuscarMaestro.buscarMaestro.BringToFront();
            }
            else BuscarMaestro.buscarMaestro.BringToFront();
        }

        private void crearMateriasToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (!pnlPrincipal.Controls.Contains(AgregarMateria.AgregarMaterias))
            {
                pnlPrincipal.Controls.Add(AgregarMateria.AgregarMaterias);
                AgregarMateria.AgregarMaterias.Dock = DockStyle.Fill;
                AgregarMateria.AgregarMaterias.BringToFront();
            }
            else AgregarMateria.AgregarMaterias.BringToFront();
        }

        private void buscarMateriasToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (!pnlPrincipal.Controls.Contains(BuscarMateria.BucarMateria))
            {
                pnlPrincipal.Controls.Add(BuscarMateria.BucarMateria);
                BuscarMateria.BucarMateria.Dock = DockStyle.Fill;
                BuscarMateria.BucarMateria.BringToFront();
            }
            else BuscarMateria.BucarMateria.BringToFront();
        }
    }
}
