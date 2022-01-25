using Microsoft.EntityFrameworkCore;
using QL_KhoaHoc_EF03.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace QL_KhoaHoc_EF03
{
    class QLKhoaHocDbContext:DbContext
    {
        public DbSet<HocVien> hocViens { get; set; }
        public DbSet<KhoaHoc> khoaHocs { get; set; }
        public DbSet<NgayHoc> ngayHocs { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = HAIANH; initial catalog = EF_QLKhoaHocDb; integrated security = SSPI;");
        }
    }
}
