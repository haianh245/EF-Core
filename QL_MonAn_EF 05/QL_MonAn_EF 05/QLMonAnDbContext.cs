using Microsoft.EntityFrameworkCore;
using QL_MonAn_EF_05.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace QL_MonAn_EF_05
{
    class QLMonAnDbContext:DbContext
    {
        public DbSet<CongThuc> congThucs { get; set; }
        public DbSet<LoaiMonAn> loaiMonAns { get; set; }
        public DbSet<MonAn> monAns { get; set; }
        public DbSet<NguyenLieu> nguyenLieus { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=HAIANH;database=EF_QLMonAnDb;integrated security=sspi;");
        }
    }
}
