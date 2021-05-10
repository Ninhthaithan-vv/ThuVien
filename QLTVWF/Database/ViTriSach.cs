namespace QLTVWF.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ViTriSach")]
    public partial class ViTriSach
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ViTriSach()
        {
            CuonSaches = new HashSet<CuonSach>();
        }

        [Key]
        [StringLength(10)]
        public string MaViTri { get; set; }

        [StringLength(50)]
        public string TenGiaSach { get; set; }

        [StringLength(15)]
        public string Tang { get; set; }

        [StringLength(15)]
        public string Ngan { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CuonSach> CuonSaches { get; set; }
    }
}
