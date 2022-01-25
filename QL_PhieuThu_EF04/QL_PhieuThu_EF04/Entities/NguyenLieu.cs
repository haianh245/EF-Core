using QL_PhieuThu_EF04.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace QL_PhieuThu_EF04.Entities
{
    class NguyenLieu
    {
        public int NguyenlieuID { get; set; }
        [Required]
        public int LoainguyenlieuID { get; set; }
        public string Tennguyenlieu { get; set; }
        public long Giaban { get; set; }
        public string Donvitinh { get; set; }
        public int Soluongkho { get; set; }
        public List<ChiTietPhieuThu> ChiTietPhieuThus { get; set; }
        public LoaiNguyenLieu LoaiNguyenLieu { get; set; }
        public NguyenLieu() { }
        public NguyenLieu(InputType it)
        {
            switch (it)
            {
                case InputType.ThemNguyenLieu:
                    {
                        LoainguyenlieuID = InputHelper.InputInt(res.InpLoaiNguyenLieuID, res.ErrLoaiNguyenLieuID);
                        Tennguyenlieu = InputHelper.NhapTen(res.InpTenNguyenLieu, res.ErrTenNguyenLieu);
                        Giaban = InputHelper.InputInt(res.InpGiaBan, res.ErrGiaBan);
                        Donvitinh = InputHelper.InputString(res.InpDonViTinh, res.ErrDonViTinh,0,10);
                        Soluongkho = InputHelper.InputInt(res.InpSoLuongKho, res.ErrSoLuongKho);
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
