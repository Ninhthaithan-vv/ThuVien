namespace QLTVWF.DataBase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DauSach")]
    public partial class DauSach
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DauSach()
        {
            CuonSaches = new HashSet<CuonSach>();
            SangTacs = new HashSet<SangTac>();
            TheLoaiDauSaches = new HashSet<TheLoaiDauSach>();
        }

        [Key]
        [StringLength(10)]
        public string MaDauSach { get; set; }

        [StringLength(50)]
        public string TenDauSach { get; set; }

        [StringLength(50)]
        public string TenNXB { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NamXuatBan { get; set; }

        public int? SoTrang { get; set; }

        public decimal? GiaTien { get; set; }

        [Column(TypeName = "image")]
        public byte[] HinhAnh { get; set; }

        public int? SoLuong { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CuonSach> CuonSaches { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SangTac> SangTacs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TheLoaiDauSach> TheLoaiDauSaches { get; set; }
    }
}
