using HVIT_EF_QLNhanVien.Helper;
using QLNhanVienEF.Helper;
using System;
using System.Collections.Generic;
using System.Text;

namespace QLNhanVienEF.Entitis
{
    class NhanVien
    {
        public int NhanVienId { get; set; }
        public string HoTen { get; set; }
        public int Sdt { get; set; }
        public string DiaChi { get; set; }
        public string Email { get; set; }
        public int HeSoLuong { get; set; }
        public virtual IEnumerable<PhanCong> PhanCongs { get; set; }
        public NhanVien() { }
        public NhanVien(inputType inputType)
        {
            switch (inputType)
            {
                case inputType.ThemNhanVien:
                    {
                        HoTen = inputHelper.NhapTen(res.inputHoTen,res.errorHoten);
                        Sdt = inputHelper.InputInt(res.inputSdt, res.errorSdt);
                        DiaChi = inputHelper.InputString(res.inputDiaChi, res.errorDiaChi);
                        Email = inputHelper.InputString(res.inputEmail, res.errorEmail);
                        HeSoLuong = inputHelper.InputInt(res.inputHeSoLuong, res.errorHeSoLuong);
                    }
                    break;
                case inputType.XoaNhanVien:
                    {
                        NhanVienId = inputHelper.InputInt(res.inputNhanVienId, res.errorNhanVienId);
                    }
                    break;
                case inputType.ThemNhanVienVaoDuAn:
                    {
                        NhanVienId = inputHelper.InputInt(res.inputNhanVienId, res.errorNhanVienId);
                    }
                    break;
                case inputType.TinhLuongChoNhanVien:
                    {
                        NhanVienId = inputHelper.InputInt(res.inputNhanVienId, res.errorNhanVienId);
                    }
                    break;
            }
        }
    }
}
