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
    
    public partial class RESERVA_AREA_COMUN
    {
        public int ID_RESERVA_AREA_COMUN { get; set; }
        public int ID_USUARIO { get; set; }
        public int ID_AREA_COMUN { get; set; }
        public System.DateTime FECHA_RESERVA { get; set; }
        public System.DateTime HORA_INICIO { get; set; }
        public System.DateTime HORA_FIN { get; set; }
        public int ID_ESTADO_RESERVACION { get; set; }
        public string COMENTARIOS { get; set; }
        public System.DateTime FECHA_CREACION { get; set; }
        public System.DateTime FECHA_ACTUALIZACION { get; set; }
        public int CREADO_POR { get; set; }
        public int ACTUALIZADO_POR { get; set; }
    
        public virtual AREA_COMUN AREA_COMUN { get; set; }
        public virtual ESTADO_RESERVACION ESTADO_RESERVACION { get; set; }
        public virtual USUARIO USUARIO { get; set; }
    }
}
