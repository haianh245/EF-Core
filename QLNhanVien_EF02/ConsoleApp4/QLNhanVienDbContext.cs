using QLNhanVienEF.Entitis;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace QLNhanVienEF
{
    class QLNhanVienDbContext:DbContext
    {
        public DbSet<NhanVien> nhanViens { get; set; }
        public DbSet<PhanCong> phanCongs { get; set; }
        public DbSet<DuAn> duAns { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = DESKTOP-BL4JSQM\\HAIANH; initial catalog = EF_QLNhanVienDb; integrated security = SSPI;");
        }
    }
}
