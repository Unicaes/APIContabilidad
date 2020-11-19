namespace Api.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Inventario")]
    public partial class Inventario
    {
        [Key]
        public int id_inventario { get; set; }

        public int? id_producto { get; set; }

        [StringLength(50)]
        public string lote { get; set; }

        public DateTime? fecha_entrada { get; set; }

        public int? cantidad { get; set; }

        public float? costo { get; set; }

        public float? precio { get; set; }

        public int? id_detalle_compra { get; set; }
    }
}
