//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace La_Buena_Farmacia
{
    using System;
    using System.Collections.Generic;
    
    public partial class TarjetaCredito
    {
        public int idTarjeta { get; set; }
        public int idCliente { get; set; }
        public string numeroTarjeta { get; set; }
        public string nombrePropietario { get; set; }
    
        public virtual Cliente Cliente { get; set; }
    }
}