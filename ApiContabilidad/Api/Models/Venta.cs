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
        [Key]
        public int id_venta { get; set; }

        [StringLength(10)]
        public string num_factura { get; set; }

        public DateTime? fecha { get; set; }

        public float? subtotal { get; set; }

        public float? iva { get; set; }

        public float? total { get; set; }

        public int? id_cliente { get; set; }

        public int? id_vendedor { get; set; }
    }
}
