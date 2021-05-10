namespace QLTVWF.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CuonSach")]
    public partial class CuonSach
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CuonSach()
        {
            MuonTras = new HashSet<MuonTra>();
        }

        [Key]
        [StringLength(10)]
        public string MaSach { get; set; }

        [StringLength(10)]
        public string MaDauSach { get; set; }

        [StringLength(10)]
        public string MaViTri { get; set; }

        public bool? TinhTrang { get; set; }

        public virtual DauSach DauSach { get; set; }

        public virtual ViTriSach ViTriSach { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MuonTra> MuonTras { get; set; }
    }
}
