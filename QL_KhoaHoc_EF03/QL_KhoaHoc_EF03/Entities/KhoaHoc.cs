using QL_KhoaHoc_EF03.Helper;
using System;
using System.Collections.Generic;
using System.Text;

namespace QL_KhoaHoc_EF03.Entities
{
    class KhoaHoc
    {
        public int KhoaHocID { get; set; }
        public string TenKhoaHoc { get; set; }
        public string MoTa { get; set; }
        public int HocPhi { get; set; }
        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }
        public virtual IEnumerable<HocVien> HocViens { get; set; }
        public virtual IEnumerable<NgayHoc> NgayHocs { get; set; }
        public KhoaHoc() { }
        public KhoaHoc(InputType inputType)
        {
            switch (inputType)
            {
                case InputType.XoaKhoaHoc:
                    {
                        KhoaHocID = InputHelper.InputInt(res.InpKhoaHocID, res.ErrKHoaHocID);
                    }
                    break;
            }
        }

    }
}
