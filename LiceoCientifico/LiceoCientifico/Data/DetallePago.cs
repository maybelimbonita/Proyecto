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
    
    public partial class DetallePago
    {
        public int IdDetallePago { get; set; }
        public int IdPago { get; set; }
        public int TipoPago { get; set; }
        public decimal Monto { get; set; }
        public string Descripcion { get; set; }
    
        public virtual Pagos Pagos { get; set; }
        public virtual TipoPago TipoPago1 { get; set; }
    }
}
