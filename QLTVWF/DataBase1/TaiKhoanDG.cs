namespace QLTVWF.DataBase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TaiKhoanDG")]
    public partial class TaiKhoanDG
    {
        [Key]
        [StringLength(10)]
        public string MaDocGia { get; set; }

        [Required]
        [StringLength(50)]
        public string TenDangNhap { get; set; }

        [Required]
        [StringLength(50)]
        public string MatKhau { get; set; }

        public virtual DocGia DocGia { get; set; }
    }
}
