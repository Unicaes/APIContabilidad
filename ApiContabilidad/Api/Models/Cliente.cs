namespace Api.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Cliente")]
    public partial class Cliente
    {
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        //public Cliente()
        //{
        //    Venta = new HashSet<Venta>();
        //}

        [Key]
        public int id_cliente { get; set; }

        [StringLength(150)]
        public string nombre { get; set; }

        [StringLength(150)]
        public string apellido { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<Venta> Venta { get; set; }
    }
}
