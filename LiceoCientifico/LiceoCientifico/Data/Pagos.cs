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
    
    public partial class Pagos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Pagos()
        {
            this.DetallePago = new HashSet<DetallePago>();
        }
    
        public int IdPago { get; set; }
        public int IdAlumno { get; set; }
        public int IdUsuario { get; set; }
        public string Detalle { get; set; }
        public System.DateTime FechaPago { get; set; }
    
        public virtual Alumno Alumno { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetallePago> DetallePago { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}