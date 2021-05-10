namespace QLTVWF.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ThongTinMuonTra")]
    public partial class ThongTinMuonTra
    {
        [Key]
        [Column(Order = 0)]
        public int MaMuonTra { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string MaSach { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(10)]
        public string MaDocGia { get; set; }

        [StringLength(10)]
        public string MaNVmuon { get; set; }

        [StringLength(10)]
        public string MaNVtra { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayMuon { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayHanTra { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayTra { get; set; }

        public bool? DaTra { get; set; }
    }
}
