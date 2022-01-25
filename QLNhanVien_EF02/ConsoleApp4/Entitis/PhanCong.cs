using HVIT_EF_QLNhanVien.Helper;
using QLNhanVienEF.Helper;
using System;
using System.Collections.Generic;
using System.Text;

namespace QLNhanVienEF.Entitis
{
    class PhanCong
    {
        public int PhanCongId { get; set; }
        public int NhanVienId { get; set; }
        public int DuAnId { get; set; }
        public int SoGioLam { get; set; }
        public virtual NhanVien NhanVien { get; set; }
        public virtual DuAn DuAn { get; set; }
        public PhanCong() { }
        public PhanCong(inputType inputType)
        {
            switch (inputType)
            {
                case inputType.ThemNhanVienVaoDuAn:
                    {
                        SoGioLam = inputHelper.InputInt(res.inputSoGioLam, res.errorSoGioLam);
                    }
                    break;
            }
        }

    }
}
