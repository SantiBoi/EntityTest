//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClassLibrary1
{
    using System;
    using System.Collections.Generic;
    
    public partial class FacturasDetalle
    {
        public int id_detalle_factura { get; set; }
        public Nullable<int> id_factura { get; set; }
        public Nullable<int> numero_orden { get; set; }
        public Nullable<int> id_producto { get; set; }
        public Nullable<int> id_proyecto { get; set; }
        public Nullable<int> id_ciclo_prueba { get; set; }
        public Nullable<decimal> precio { get; set; }
        public Nullable<bool> borrado { get; set; }
    
        public virtual CiclosPrueba CiclosPrueba { get; set; }
        public virtual Factura Factura { get; set; }
        public virtual Producto Producto { get; set; }
        public virtual Proyecto Proyecto { get; set; }
    }
}
