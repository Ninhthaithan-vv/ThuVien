namespace QLTVWF.DataBase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MuonTra")]
    public partial class MuonTra
    {
        [Key]
        public int MaMuonTra { get; set; }

        [Required]
        [StringLength(10)]
        public string MaSach { get; set; }

        [Required]
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

        public virtual CuonSach CuonSach { get; set; }

        public virtual DocGia DocGia { get; set; }

        public virtual NhanVien NhanVien { get; set; }

        public virtual NhanVien NhanVien1 { get; set; }
    }
}
