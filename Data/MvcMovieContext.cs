using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NETCOREMANGUONMO.Models;

namespace NETCOREMANGUONMO.Data
{
        public class MvcMovieContext : DbContext
    {
        public MvcMovieContext (DbContextOptions<MvcMovieContext> options)
            : base(options)
        {
        }

        public DbSet<NETCOREMANGUONMO.Models.Movie> Movie { get; set; }
        public DbSet<People> People { get; set; }
        public DbSet<NETCOREMANGUONMO.Models.Person> Person { get; set; }
        public DbSet<NETCOREMANGUONMO.Models.Student> Student { get; set; }
        public DbSet<NETCOREMANGUONMO.Models.Employee> Employee { get; set; }
        public DbSet<NETCOREMANGUONMO.Models.Product> Product { get; set; }
        public DbSet<NETCOREMANGUONMO.Models.KhachHang> KhachHang { get; set; }
        public DbSet<NETCOREMANGUONMO.Models.HoaDon> HoaDon { get; set; }
        public DbSet<NETCOREMANGUONMO.Models.SinhVien> SinhVien { get; set; }
        public DbSet<NETCOREMANGUONMO.Models.NhanVien> NhanVien { get; set; }
        public DbSet<NETCOREMANGUONMO.Models.DonHang> DonHang { get; set; }
    }

}
