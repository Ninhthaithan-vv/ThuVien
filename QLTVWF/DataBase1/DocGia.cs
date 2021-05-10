namespace QLTVWF.DataBase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DocGia")]
    public partial class DocGia
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DocGia()
        {
            MuonTras = new HashSet<MuonTra>();
            XuLyViPhams = new HashSet<XuLyViPham>();
        }

        [Key]
        [StringLength(10)]
        public string MaDocGia { get; set; }

        [StringLength(50)]
        public string TenDocGia { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgaySinh { get; set; }

        [StringLength(20)]
        public string DonVi { get; set; }

        [StringLength(10)]
        public string SDT { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayDK { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayHetHanDK { get; set; }

        [StringLength(20)]
        public string LoaiDocGia { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MuonTra> MuonTras { get; set; }

        public virtual TaiKhoanDG TaiKhoanDG { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<XuLyViPham> XuLyViPhams { get; set; }
    }
}
