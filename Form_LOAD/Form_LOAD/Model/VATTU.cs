namespace Form_LOAD.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VATTU")]
    public partial class VATTU
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VATTU()
        {
            CTHDs = new HashSet<CTHD>();
        }

        [Key]
        [StringLength(5)]
        public string MAVT { get; set; }

        [Required]
        [StringLength(100)]
        public string TENVT { get; set; }

        [StringLength(100)]
        public string DVT { get; set; }

        public int? GIAMUA { get; set; }

        public int? SLTON { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTHD> CTHDs { get; set; }
    }
}
