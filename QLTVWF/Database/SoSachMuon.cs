namespace QLTVWF.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SoSachMuon")]
    public partial class SoSachMuon
    {
        [Key]
        [StringLength(10)]
        public string MaDocGia { get; set; }

        public int? Muon { get; set; }
    }
}
