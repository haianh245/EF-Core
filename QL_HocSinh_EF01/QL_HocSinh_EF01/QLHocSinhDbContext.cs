using Microsoft.EntityFrameworkCore;
using QL_HocSinh_EF01.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_HocSinh_EF01
{
    class QLHocSinhDbContext:DbContext
    {
        public DbSet<HocSinh> hocSinhs { get; set; }
        public DbSet<Lop> lops { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=HAIANH;database=EF_QLHocSinhDb;integrated security=sspi;");
        }
    }
}
