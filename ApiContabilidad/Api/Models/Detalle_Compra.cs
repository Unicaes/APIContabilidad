namespace Api.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Detalle_Compra
    {
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        //public Detalle_Compra()
        //{
        //    Inventario = new HashSet<Inventario>();
        //}

        [Key]
        public int id_detalle_compra { get; set; }

        public int? id_producto { get; set; }

        public int? id_compra { get; set; }

        public int? cantidad { get; set; }

        public float? precio_unitario { get; set; }

        public float? monto { get; set; }

        public virtual Compra Compra { get; set; }

        public virtual Producto Producto { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<Inventario> Inventario { get; set; }
    }
}
