namespace QLTVWF.DataBase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TanXuatMuon")]
    public partial class TanXuatMuon
    {
        [Key]
        [StringLength(10)]
        public string MaSach { get; set; }

        public int? SoLanDuocMuon { get; set; }
    }
}
