namespace QLTVWF.DataBase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SangTac")]
    public partial class SangTac
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string MaDauSach { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string MaTacGia { get; set; }

        public int? ViTriVaiTro { get; set; }

        public virtual DauSach DauSach { get; set; }

        public virtual TacGia TacGia { get; set; }
    }
}
