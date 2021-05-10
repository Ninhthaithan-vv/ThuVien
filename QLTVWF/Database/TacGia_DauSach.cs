namespace QLTVWF.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TacGia_DauSach
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string MaDauSach { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string MaTacGia { get; set; }

        [StringLength(20)]
        public string TenTacGia { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgaySinh { get; set; }

        public int? ViTriVaiTro { get; set; }
    }
}
