//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Infraestructure.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    [MetadataType(typeof(RUBRO_COBROMetadata))]

    public partial class RUBRO_COBRO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RUBRO_COBRO()
        {
            this.GESTION_PLANES_COBRO = new HashSet<GESTION_PLANES_COBRO>();
        }
    
        public int ID_RUBRO_COBRO { get; set; }
        public string NOMBRE_RUBRO { get; set; }
        public Nullable<decimal> MONTO { get; set; }
        public byte[] IMAGEN { get; set; }
        public string DESCRIPCION { get; set; }
        public Nullable<int> BORRADO { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GESTION_PLANES_COBRO> GESTION_PLANES_COBRO { get; set; }
    }
}
