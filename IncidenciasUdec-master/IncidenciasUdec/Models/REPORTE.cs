//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IncidenciasUdec.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class REPORTE
    {
        public int ID { get; set; }
        public string NOMBRE { get; set; }
        public Nullable<int> ID_UBICACION { get; set; }
        public Nullable<int> ID_TIPO_DAÑO { get; set; }
        public string DESCRIPCION { get; set; }
        public Nullable<int> ID_CLASIFICACION { get; set; }
        public Nullable<int> ID_ESTADO { get; set; }
        public string IMAGEN { get; set; }
        public Nullable<int> ID_USUARIO { get; set; }
    
        public virtual CLASIFICACION CLASIFICACION { get; set; }
        public virtual ESTADO ESTADO { get; set; }
        public virtual TIPO_DAÑO TIPO_DAÑO { get; set; }
        public virtual UBICACION UBICACION { get; set; }
        public virtual USUARIO USUARIO { get; set; }
    }
}
