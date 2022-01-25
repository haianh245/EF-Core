using QL_KhoaHoc_EF03.Helper;
using System;
using System.Collections.Generic;
using System.Text;

namespace QL_KhoaHoc_EF03.Entities
{
    class NgayHoc
    {
        public int NgayHocID { get; set; }
        public int KhoaHocID { get; set; }
        public string NoiDung { get; set; }
        public string GhiChu { get; set; }
        public virtual KhoaHoc KhoaHoc { get; set; }
        public NgayHoc() { }
        public NgayHoc(InputType inputType)
        {
            switch (inputType)
            {
                case InputType.ThemNgayHocVaoKhoaHoc:
                    {
                        KhoaHocID = InputHelper.InputInt(res.InpKhoaHocID, res.ErrKHoaHocID);
                        NoiDung = InputHelper.InputString(res.InpNoiDung, res.ErrorNoiDung);
                        GhiChu = InputHelper.InputString(res.InpGhiChu, res.ErrGhiChu);
                    }
                    break;
            }
        }
    }
}
