namespace ApiContabilidad.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Detalle_Venta
    {
        [Key]
        public int id_detalle_venta { get; set; }

        public int? id_producto { get; set; }

        public int? id_venta { get; set; }

        public float? precio_unitario { get; set; }

        public int? cantidad { get; set; }

        public float? monto { get; set; }
    }
}
