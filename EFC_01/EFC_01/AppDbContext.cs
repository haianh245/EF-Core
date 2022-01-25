using EFC_01.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFC_01
{
    class AppDbContext:DbContext
    {
        public DbSet<HocSinh> HocSinhs { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=HAIANH;database=EFC01;integrated security=sspi;");
        }
    }
}
