//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Proyecto_RadixWeb.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class contratos
    {
        public int Con_Id { get; set; }
        public int Sub_Id { get; set; }
        public Nullable<int> PC_Id { get; set; }
        public int TCon_Id { get; set; }
        public string Per_Rut { get; set; }
    
        public virtual planillascontratos planillascontratos { get; set; }
        public virtual subempresas subempresas { get; set; }
        public virtual tiposcontratos tiposcontratos { get; set; }
    }
}
