namespace QLTVWF.DataBase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TaiLieuMuonTra")]
    public partial class TaiLieuMuonTra
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaMuonTra { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string MaDocGia { get; set; }

        [StringLength(50)]
        public string TenDocGia { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(10)]
        public string MaDauSach { get; set; }

        [StringLength(50)]
        public string TenDauSach { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(10)]
        public string MaSach { get; set; }

        public bool? DaTra { get; set; }
    }
}
