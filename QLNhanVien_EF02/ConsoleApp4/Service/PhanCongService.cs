using System;
using QLNhanVienEF.IServices;
using System.Collections.Generic;
using System.Text;
using HVIT_EF_QLNhanVien.Helper;
using QLNhanVienEF.Entitis;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace QLNhanVienEF.Service
{
    class PhanCongService : IPhanCongService
    {
        private QLNhanVienDbContext dbContext { get; }
        public PhanCongService()
        {
            dbContext = new QLNhanVienDbContext();
        }
      
    }
}
