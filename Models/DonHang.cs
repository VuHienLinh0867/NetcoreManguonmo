using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NETCOREMANGUONMO.Models
{
    [Table("DonHangs")]
    public class DonHang
    {
        [Key]
        public int DonHangID { get; set; }
        public int NhanVienID { get; set; }
        public DateTime NgayTao { get; set; }
        public NhanVien NhanVien { get; set; }
    }
}
