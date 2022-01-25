using EFC_02.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFC_02
{
    class AppDbContext:DbContext
    {
        public DbSet<CongThuc> congThucs { get; set; }
        public DbSet<LoaiMonAn> loaiMonAns { get; set; }
        public DbSet<MonAn> monAns { get; set; }
        public DbSet<NguyenLieu> nguyenLieus { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=HAIANH;database=EFC02;integrated security=sspi;");
        }
    }
}
