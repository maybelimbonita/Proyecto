//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LiceoCientifico.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Seccion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Seccion()
        {
            this.AlumnoXSeccion = new HashSet<AlumnoXSeccion>();
        }
    
        public int IdSeccion { get; set; }
        public string Nombreseccion { get; set; }
        public int IdGrado { get; set; }
        public int MaestroEncargado { get; set; }
        public bool Estado { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AlumnoXSeccion> AlumnoXSeccion { get; set; }
        public virtual Grado Grado { get; set; }
        public virtual Maestro Maestro { get; set; }
    }
}
