using HVIT_EF_QLNhanVien.Helper;
using QLNhanVienEF.Entitis;
using System;
using System.Collections.Generic;
using System.Text;

namespace QLNhanVienEF.IServices
{
    interface INhanVienService
    {
        public errType ThemNhanVien(NhanVien nv);
        public IEnumerable<NhanVien> HienThiDSNhanVien(string keyword = null);
        public errType ThemNhanVienVaoDuAn(DuAn da, NhanVien nv, PhanCong pc);
        public errType XoaNhanVien(NhanVien nv);
        public errType TinhLuongChoNhanVien(NhanVien nv);
    }
}
