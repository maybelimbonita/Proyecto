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
    class clsUsuario
    {
        private int IdUsuario;
        public string Mensaje;
        public Usuario usuarioPrincipal; 
        // Constructor
        public  clsUsuario(int IdUsuario)
        {
            this.IdUsuario = IdUsuario;
            Mensaje = ""; 
        }

        public clsUsuario()
        {
        }

        /// <summary>
        /// Metodo para inicio de sesion
        /// </summary>
        /// <param name="Usuario"></param>
        /// <param name="Contaseña"></param>
        /// <returns></returns>
        public bool InicioDeSesion(string Usuario, string Contaseña)
        {
            bool Resp = false ; 
            try
            {
                using (BDLiceoCientificoEntities con = new BDLiceoCientificoEntities())
                {
                    if (con.Usuario.Where(x => x.Usuario1 == Usuario && x.Contraseña == Contaseña).Count() > 0)
                    {
                        usuarioPrincipal = con.Usuario.FirstOrDefault(x => x.Usuario1 == Usuario && x.Contraseña == Contaseña);
                        Resp = true;
                    }
                }
                       
            }
            catch (Exception ex)
            {

                Mensaje = "Error al inciar sesion Error: " + ex.Message; 
            }
            return Resp; 
            
        }

        /// <summary>
        /// Metodo para  agregar usuarios nuevos al sistema. 
        /// </summary>
        /// <param name="nuevoUsuario"></param>
        /// <returns></returns>
        public bool AgregarUsuario(Usuario nuevoUsuario)
        {
            bool Resultado = false;

            using (BDLiceoCientificoEntities con = new BDLiceoCientificoEntities())
            {
                try
                {
                    con.Usuario.Add(nuevoUsuario);
                    con.SaveChanges();
                    Resultado = true; 
                }
                catch (Exception ex)
                {
                    Mensaje = "Error al agregar usuario, Error: " + ex.Message; 
                }
               
            }
                return Resultado; 
        }
        /// <summary>
        /// Metodo de busqueda para usuarios. 
        /// </summary>
        /// <param name="Nombre"></param>
        /// <returns></returns>
        public List<Usuario> BuscarUsuarios(string Nombre)
        {
            List<Usuario> lstusuarios=null;

            try
            {
                using (BDLiceoCientificoEntities con = new BDLiceoCientificoEntities())
                {
                    if (Nombre.Equals(string.Empty))
                    {
                        lstusuarios = con.Usuario.ToList();
                    }
                    else
                        lstusuarios = con.Usuario.Where(x => x.Nombres.Contains(Nombre)).ToList(); 
                }

            }
            catch (Exception ex)
            {

                Mensaje = "Error al buscar usuarios Error: "+ex.Message; 
            }
            return lstusuarios; 
        }


    }
}
