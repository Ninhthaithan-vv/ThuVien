namespace QLTVWF.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ThongTinDocGia")]
    public partial class ThongTinDocGia
    {
        [Key]
        [StringLength(10)]
        public string MaDocGia { get; set; }

        [StringLength(50)]
        public string TenDocGia { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgaySinh { get; set; }

        [StringLength(20)]
        public string DonVi { get; set; }

        [StringLength(10)]
        public string SDT { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayDK { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayHetHanDK { get; set; }

        [StringLength(20)]
        public string LoaiDocGia { get; set; }
    }
}
