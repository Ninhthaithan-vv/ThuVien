namespace QLTVWF.DataBase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TacGia")]
    public partial class TacGia
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TacGia()
        {
            SangTacs = new HashSet<SangTac>();
        }

        [Key]
        [StringLength(10)]
        public string MaTacGia { get; set; }

        [StringLength(20)]
        public string TenTacGia { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgaySinh { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SangTac> SangTacs { get; set; }
    }
}
