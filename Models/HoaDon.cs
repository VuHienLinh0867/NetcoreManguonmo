using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NETCOREMANGUONMO.Models
{
    [Table("HoaDons")]
    public class HoaDon
    {
        [Key]
        [Required (ErrorMessage = "HoaDonID is require")]
        public string HoaDonID { get; set; }
        public string KhachHangID { get; set; }
        [DataType(DataType.Date)]
        public DateTime NgayTao { get; set; }
        public KhachHang KhachHang { get; set; }
    }
}
