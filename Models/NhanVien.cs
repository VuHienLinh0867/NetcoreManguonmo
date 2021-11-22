using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NETCOREMANGUONMO.Models
{
    [Table("NhanViens")]
    public class NhanVien : People
    {
        [Key]
        public int NhanVienID { get; set; }
        public string TenNhanVien { get; set; }
        public ICollection<DonHang> DonHangs { get; set; }
    }
}
