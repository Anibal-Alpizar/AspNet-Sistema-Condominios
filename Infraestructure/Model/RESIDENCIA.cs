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
    
    public partial class RESIDENCIA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RESIDENCIA()
        {
            this.GESTION_DEUDA = new HashSet<GESTION_DEUDA>();
        }
    
        public int ID_RESIDENCIA { get; set; }
        public int ID_ESTADO_RESIDENCIA { get; set; }
        public int NUMERO_RESIDENCIA { get; set; }
        public int CANTIDAD_PERSONAS { get; set; }
        public int ANIO_INICIO { get; set; }
        public int CANTIDAD_CARROS { get; set; }
        public Nullable<int> ID_USUARIO { get; set; }
    
        public virtual ESTADO_RESIDENCIA ESTADO_RESIDENCIA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GESTION_DEUDA> GESTION_DEUDA { get; set; }
        public virtual USUARIO USUARIO { get; set; }
    }
}
