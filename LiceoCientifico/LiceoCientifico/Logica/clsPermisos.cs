using LiceoCientifico.Data;
using System.Collections.Generic;
using System.Linq;

namespace LiceoCientifico.Logica
{
    /// <summary>
    /// Clase para validacion de permisos  de usuario  en comportamiento de pantalla. 
    /// </summary>
    class clsPermisos
    {

        public List<PermisosxUsuario> PermisosxIdUsuario(int IdUsuario)
        {
            List<PermisosxUsuario> lstPermisos = null;
            using (BDLiceoCientificoEntities con = new BDLiceoCientificoEntities())
            {
                lstPermisos = con.PermisosxUsuario.Where(x=>x.IdUsuario==IdUsuario).ToList();

            }
            return lstPermisos;

        }

    }
}

