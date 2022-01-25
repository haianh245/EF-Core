using QL_PhieuThu_EF04.Helper;
using System;
using System.Collections.Generic;
using System.Text;

namespace QL_PhieuThu_EF04.Entities
{
    class PhieuThu
    {
        public int PhieuthuID { get; set; }
        public DateTime Ngaylap { get; set; }
        public string Nhanvienlap { get; set; }
        public string Ghichu { get; set; }
        public long Thanhtien { get; set; }
        public List<ChiTietPhieuThu> ChiTietPhieuThus { get; set; }
        public PhieuThu() { }
        public PhieuThu(InputType it)
        {
            switch (it)
            {
                case InputType.ThemDSChiTietPhieuThu:
                    {
                        PhieuthuID = InputHelper.InputInt(res.InpPhieuThuID, res.ErrPhieuThuID);
                        ChiTietPhieuThus = InputHelper.NhapDSCTPhieuThu(res.InpChiTietPhieuThu);
                    }
                    break;
                case InputType.ThemPhieuThu:
                    {
                        Ngaylap = InputHelper.InputDT(res.InpNgayLap, res.ErrNgayLap,new DateTime(2000-1-1),DateTime.Now);
                        Nhanvienlap = InputHelper.InputString(res.InpTenNhanVienLapPhieu, res.ErrTenNhanVienLapPhieu, 1, 20);
                        Ghichu = InputHelper.InputString(res.InpGhiChu, res.ErrGhiChu);
                        ChiTietPhieuThus = InputHelper.NhapDSCTPhieuThu(res.InpChiTietPhieuThu);
                    }
                    break;
                case InputType.XoaPhieuThu:
                    {
                        PhieuthuID = InputHelper.InputInt(res.InpPhieuThuID, res.ErrPhieuThuID);
                    }
                    break;
                case InputType.LayThongTinPhieuThuTheoTG:
                    break;
                default:
                    break;
            }
        }
    } 
}
