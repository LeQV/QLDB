namespace AppQLDB.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LienLac")]
    public partial class LienLac
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdLienLac { get; set; }

        [StringLength(50)]
        public string TenGoi { get; set; }

        [StringLength(50)]
        public string DiaChi { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(10)]
        public string SDT { get; set; }

        public int? IdNhom { get; set; }

        public virtual Nhom Nhom { get; set; }
    }
}
