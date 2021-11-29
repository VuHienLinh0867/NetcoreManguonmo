using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace NETCOREMANGUONMO.Models
{
    [Table("Student")]
    public class Student
    {
        [Key]
        [StringLength(15, MinimumLength = 5)]
        [Required]
        [Display(Name = "Mã sinh viên" )]
        public string StudentID { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [Required]
        [StringLength(30)]
        [Display(Name = "Họ tên")]
        public string StudentName { get; set; }

        [Required]
        [StringLength(60)]
        [Display(Name = "Địa chỉ" )]
        public string Address { get; set; }

        [Required]
        [RegularExpression(@"^[0-9]*$")]
        [StringLength(10)]
        [Display(Name = "Số điện thoại")]
        public string PhoneNumber { get; set; }
    }
}