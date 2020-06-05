using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiceoCientifico.Data; 

namespace LiceoCientifico.Logica
{
    /// <summary>
    /// Clase logica para manejar eventos e Usuario. 
    /// </summary>
    class clsMaestro
    {
        private int IdUsuario;
        public string Mensaje;
        public Usuario usuarioPrincipal; 
     
        /// <summary>
        /// Metodo para  agregar Maestros nuevos al sistema. 
        /// </summary>
        /// <param name="NuevoMaestro"></param>
        /// <returns></returns>
        public bool AgregarMaestro(Maestro nuevomaestro)
        {
            bool Resultado = false;

            using (BDLiceoCientificoEntities con = new BDLiceoCientificoEntities())
            {
                try
                {
                    con.Maestro.Add(nuevomaestro);
                    con.SaveChanges();
                    Resultado = true; 
                }
                catch (Exception ex)
                {
                    Mensaje = "Error al agregar Maestro, Error: " + ex.Message; 
                }
               
            }
                return Resultado; 
        }
        /// <summary>
        /// Metodo de busqueda para Maestros. 
        /// </summary>
        /// <param name="Nombre"></param>
        /// <returns></returns>
        public List<Maestro> BuscarMaestros(string Nombre)
        {
            List<Maestro> lstMaestros=null;

            try
            {
                using (BDLiceoCientificoEntities con = new BDLiceoCientificoEntities())
                {
                    if (Nombre.Equals(string.Empty))
                    {
                        lstMaestros = con.Maestro.ToList();
                    }
                    else
                        lstMaestros = con.Maestro.Where(x => x.Nombres.Contains(Nombre)).ToList(); 
                }

            }
            catch (Exception ex)
            {

                Mensaje = "Error al buscar Maestros Error: "+ex.Message; 
            }
            return lstMaestros; 
        }


    }
}
