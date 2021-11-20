using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace NETCOREMANGUONMO.Models
{
    [Table("People")]
    public class People
    {
        [Key]
        public int PeopleID { get; set; }
        public string PeopleCode { get; set; }
        public string FullName { get; set; }
    }
}