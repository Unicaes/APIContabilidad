namespace Api.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Empleado")]
    public partial class Empleado
    {
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        //public Empleado()
        //{
        //    Venta = new HashSet<Venta>();
        //}

        [Key]
        public int id_empleado { get; set; }

        [StringLength(150)]
        public string nombre { get; set; }

        [StringLength(150)]
        public string apellido { get; set; }

        [StringLength(15)]
        public string telefono { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<Venta> Venta { get; set; }
    }
}
