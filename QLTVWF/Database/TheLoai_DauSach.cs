namespace QLTVWF.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TheLoai_DauSach
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string MaDauSach { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string MaTheLoai { get; set; }

        [StringLength(20)]
        public string TenTheLoai { get; set; }

        public int? ViTriVaiTro { get; set; }
    }
}
