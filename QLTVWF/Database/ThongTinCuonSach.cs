namespace QLTVWF.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ThongTinCuonSach")]
    public partial class ThongTinCuonSach
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string MaSach { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string MaDauSach { get; set; }

        [StringLength(50)]
        public string TenDauSach { get; set; }

        public bool? TinhTrang { get; set; }

        [StringLength(50)]
        public string TenGiaSach { get; set; }

        [StringLength(15)]
        public string Tang { get; set; }

        [StringLength(15)]
        public string Ngan { get; set; }
    }
}
