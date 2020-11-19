namespace Api.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Compra")]
    public partial class Compra
    {
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        //public Compra()
        //{
        //    Detalle_Compra = new HashSet<Detalle_Compra>();
        //}

        [Key]
        public int id_compra { get; set; }

        [StringLength(10)]
        public string num_factura { get; set; }

        public DateTime? fecha { get; set; }

        public float? subtotal { get; set; }

        public float? iva { get; set; }

        public float? total { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<Detalle_Compra> Detalle_Compra { get; set; }
    }
}
