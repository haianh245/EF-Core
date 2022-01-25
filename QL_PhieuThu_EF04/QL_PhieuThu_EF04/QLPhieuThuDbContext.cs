using Microsoft.EntityFrameworkCore;
using QL_PhieuThu_EF04.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace QL_PhieuThu_EF04
{
    class QLPhieuThuDbContext:DbContext
    {
        public DbSet<ChiTietPhieuThu> chiTietPhieuThus { get; set; }
        public DbSet<LoaiNguyenLieu> loaiNguyenLieus { get; set; }
        public DbSet<NguyenLieu> nguyenLieus { get; set; }
        public DbSet<PhieuThu> phieuThus { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=HAIANH;database=EF_QLPhieuThuDb;integrated security=sspi;");
        }
    }
}
