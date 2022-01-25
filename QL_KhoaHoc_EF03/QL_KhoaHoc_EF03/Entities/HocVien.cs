using QL_KhoaHoc_EF03.Helper;
using System;
using System.Collections.Generic;
using System.Text;

namespace QL_KhoaHoc_EF03.Entities
{
    class HocVien
    {
        public int HocVienID { get; set; }
        public int KhoaHocID { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string QueQuan { get; set; }
        public string DiaChi { get; set; }
        public string SoDienThoai { get; set; }
        public virtual KhoaHoc KhoaHoc { get; set; }
        public HocVien() { }
        public HocVien(InputType inputType) 
        {
            switch (inputType)
            {
                case InputType.SuaThongTinHocVien:
                    {
                        HocVienID = InputHelper.InputInt(res.InpHocVienID, res.ErrHocVienID);
                        HoTen = InputHelper.NhapTen(res.InpHoTen, res.ErrHoTen);
                        NgaySinh = InputHelper.InputDT(res.InpNgaySinh, res.ErrNgaySinh,new DateTime(2002,1,1),new DateTime(2013,12,12));
                        QueQuan = InputHelper.InputString(res.InpQueQuan, res.ErrQueQuan);
                        DiaChi = InputHelper.InputString(res.InpDiaChi, res.ErrDiaChi);
                        SoDienThoai = InputHelper.InputString(res.InpSdt, res.ErrSdt);
                    }
                    break;
            }
        }
    }
}
