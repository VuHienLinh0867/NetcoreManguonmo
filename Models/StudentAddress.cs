using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace NETCOREMANGUONMO.Models
{
    public class StudentAddress
    {
        public List<Student> Student { get; set; }
        public SelectList Address { get; set; }
        public string AddressStudent { get; set; }
        public string SearchString { get; set; }
    }
}