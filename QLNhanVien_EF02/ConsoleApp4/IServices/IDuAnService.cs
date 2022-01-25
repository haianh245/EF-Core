using HVIT_EF_QLNhanVien.Helper;
using QLNhanVienEF.Entitis;
using System;
using System.Collections.Generic;
using System.Text;

namespace QLNhanVienEF.IServices
{
    interface IDuAnService
    {
        public IEnumerable<DuAn> HienThiDSDuAn(string keyword = null);
        public errType SuaThongTinDuAn(DuAn da);
    }
}
