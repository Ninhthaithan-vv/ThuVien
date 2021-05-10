namespace QLTVWF.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ViPham")]
    public partial class ViPham
    {
        [Key]
        [StringLength(10)]
        public string MaDocGia { get; set; }

        [Column("ViPham")]
        public int? ViPham1 { get; set; }
    }
}
