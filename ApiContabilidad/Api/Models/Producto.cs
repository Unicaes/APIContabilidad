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
        [Key]
        public int id_producto { get; set; }

        [StringLength(100)]
        public string nombre { get; set; }

        public int? id_proveedor { get; set; }
    }
}
