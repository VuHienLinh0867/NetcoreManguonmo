using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NETCOREMANGUONMO.Models
{
    [Table("KhachHangs")]
    public class KhachHang
    {
        [Key]
        [Required (ErrorMessage = "KhachHangID is require")]
        public string KhachHangID { get; set; }
        public string TenKhachHang { get; set; }
        public ICollection<HoaDon> HoaDons { get; set; }
    }
}