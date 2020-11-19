namespace Api.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Venta")]
    public partial class Venta
    {
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        //public Venta()
        //{
        //    Detalle_Venta = new HashSet<Detalle_Venta>();
        //}

        [Key]
        public int id_venta { get; set; }

        [StringLength(10)]
        public string num_factura { get; set; }

        public DateTime? fecha { get; set; }

        public float? subtotal { get; set; }

        public float? iva { get; set; }

        public float? total { get; set; }

        public int? id_cliente { get; set; }

        public int? id_empleado { get; set; }

        public virtual Cliente Cliente { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<Detalle_Venta> Detalle_Venta { get; set; }

        public virtual Empleado Empleado { get; set; }
    }
}
