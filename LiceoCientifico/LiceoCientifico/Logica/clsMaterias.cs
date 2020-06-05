using LiceoCientifico.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiceoCientifico.Logica
{
    class clsMaterias
    {
        public string Mensaje;
        // Constructor
        /// <summary>
        /// Metodo para  agregar Alumnos nuevos al sistema. 
        /// </summary>
        /// <param name="nuevoUsuario"></param>
        /// <returns></returns>
        public bool AgregarMateria(Materia NuevaMateria)
        {
            bool Resultado = false;

            using (BDLiceoCientificoEntities con = new BDLiceoCientificoEntities())
            {
                try
                {
                    con.Materia.Add(NuevaMateria);
                    con.SaveChanges();
                    Resultado = true;
                }
                catch (Exception ex)
                {
                    Mensaje = "Error al agregar Materia, Error: " + ex.Message;
                }

            }
            return Resultado;
        }
        /// <summary>
        /// Metodo de busqueda para Alunnos. 
        /// </summary>
        /// <param name="Nombre"></param>
        /// <returns></returns>
        public List<Materia> BuscarMateria(string Nombre)
        {
            List<Materia> lstAlumnos = null;

            try
            {
                using (BDLiceoCientificoEntities con = new BDLiceoCientificoEntities())
                {
                    if(Nombre.Equals(string.Empty))
                    {
                        lstAlumnos = con.Materia.ToList(); 
                    }
                    else 
                    lstAlumnos = con.Materia.Where(x => x.NombreMateria.Contains(Nombre)).ToList();
                }

            }
            catch (Exception ex)
            {

                Mensaje = "Error al buscar Materias Error: " + ex.Message;
            }
            return lstAlumnos;
        }

    }
}
