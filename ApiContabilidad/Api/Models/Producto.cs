namespace Api.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Producto")]
    public partial class Producto
    {
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        //public Producto()
        //{
        //    Detalle_Compra = new HashSet<Detalle_Compra>();
        //    Detalle_Venta = new HashSet<Detalle_Venta>();
        //    Inventario = new HashSet<Inventario>();
        //}

        [Key]
        public int id_producto { get; set; }

        [StringLength(100)]
        public string nombre { get; set; }

        public int? id_proveedor { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<Detalle_Compra> Detalle_Compra { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<Detalle_Venta> Detalle_Venta { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<Inventario> Inventario { get; set; }

        public virtual Proveedor Proveedor { get; set; }
    }
}
