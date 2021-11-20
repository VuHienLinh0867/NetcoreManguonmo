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
    }

}
