using HVIT_EF_QLNhanVien.Helper;
using QLNhanVienEF.Helper;
using System;
using System.Collections.Generic;
using System.Text;

namespace QLNhanVienEF.Entitis
{
    class DuAn
    {
        public int DuAnId { get; set; }
        public string TenDuAn { get; set; }
        public string MoTa { get; set; }
        public string GhiChu { get; set; }
        public virtual IEnumerable<PhanCong> PhanCongs { get; set; }
        public DuAn() { }
        public DuAn(inputType inputType)
        {
            switch (inputType)
            {
                case inputType.ThemNhanVienVaoDuAn:
                    {
                        DuAnId = inputHelper.InputInt(res.inputDuAnId, res.errorDuAnId);
                    }
                    break;
                case inputType.SuaThongTinDuAn:
                    {
                        DuAnId = inputHelper.InputInt(res.inputDuAnId, res.errorDuAnId);
                        TenDuAn = inputHelper.NhapTenDuAn(res.inputTenDuAn, res.errorTenDuAn);
                        MoTa = inputHelper.InputString(res.inputMoTa, res.errorMota);
                        GhiChu = inputHelper.InputString(res.inputGhiChu, res.errorGhiChu);
                    }
                    break;
            }
        }
    }
}
