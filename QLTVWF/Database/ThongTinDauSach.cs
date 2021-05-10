namespace QLTVWF.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ThongTinDauSach")]
    public partial class ThongTinDauSach
    {
        [Key]
        [StringLength(10)]
        public string MaDauSach { get; set; }

        [StringLength(50)]
        public string TenDauSach { get; set; }

        [StringLength(50)]
        public string TenNXB { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NamXuatBan { get; set; }

        public int? SoTrang { get; set; }

        public decimal? GiaTien { get; set; }

        public int? SoLuong { get; set; }
    }
}
