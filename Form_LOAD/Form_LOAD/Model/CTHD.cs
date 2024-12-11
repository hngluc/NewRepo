namespace Form_LOAD.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CTHD")]
    public partial class CTHD
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(5)]
        public string MAHD { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(5)]
        public string MAVT { get; set; }

        public int? SL { get; set; }

        public double? KHUYENMAI { get; set; }

        public double? GIABAN { get; set; }

        public virtual HOADON HOADON { get; set; }

        public virtual VATTU VATTU { get; set; }
    }
}
