using LiceoCientifico.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiceoCientifico.Logica
{
    class clsAlumno
    {
        public string Mensaje;
        // Constructor
        /// <summary>
        /// Metodo para  agregar Alumnos nuevos al sistema. 
        /// </summary>
        /// <param name="nuevoUsuario"></param>
        /// <returns></returns>
        public bool AgregarAlumno(Alumno NuevoAlumno)
        {
            bool Resultado = false;

            using (BDLiceoCientificoEntities con = new BDLiceoCientificoEntities())
            {
                try
                {
                    con.Alumno.Add(NuevoAlumno);
                    con.SaveChanges();
                    Resultado = true;
                }
                catch (Exception ex)
                {
                    Mensaje = "Error al agregar Alumno, Error: " + ex.Message;
                }

            }
            return Resultado;
        }
        /// <summary>
        /// Metodo de busqueda para Alunnos. 
        /// </summary>
        /// <param name="Nombre"></param>
        /// <returns></returns>
        public List<Alumno> BuscarAlumnos(string Nombre)
        {
            List<Alumno> lstAlumnos = null;

            try
            {
                using (BDLiceoCientificoEntities con = new BDLiceoCientificoEntities())
                {
                    if(Nombre.Equals(string.Empty))
                    {
                        lstAlumnos = con.Alumno.ToList(); 
                    }
                    else 
                    lstAlumnos = con.Alumno.Where(x => x.Nombres.Contains(Nombre)).ToList();
                }

            }
            catch (Exception ex)
            {

                Mensaje = "Error al buscar Alumnos Error: " + ex.Message;
            }
            return lstAlumnos;
        }

    }
}
