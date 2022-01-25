using QL_HocSinh_EF01.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_HocSinh_EF01.Entities
{
    class HocSinh
    {
        public int HocSinhID { get; set; }
        [Required]
        public int LopID { get; set; }
        [Required]
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string QueQuan { get; set; }
        public Lop Lop { get; set; }
        public HocSinh() { }
        public HocSinh(InputType it)
        {
            switch (it)
            {
                case InputType.ThemHocSinh:
                    {
                        LopID = InputHelper.InputInt(res.InpLopID, res.ErrLopID);
                        HoTen = InputHelper.NhapTen(res.InpHoTen, res.ErrHoTen);
                        NgaySinh = InputHelper.InputDT(res.InpNgaySinh, res.ErrNgaySinh, new DateTime(2001, 1, 1), new DateTime(2013, 12, 31));
                        QueQuan = InputHelper.InputString(res.InpQueQuan, res.ErrQueQuan);
                    }
                    break;
                case InputType.SuaHocSinh:
                    {
                        HocSinhID = InputHelper.InputInt(res.InpHocSinhID, res.ErrHocSinhID);
                        HoTen = InputHelper.NhapTen(res.InpHoTen, res.ErrHoTen);
                        NgaySinh = InputHelper.InputDT(res.InpNgaySinh, res.ErrNgaySinh, new DateTime(2001, 1, 1), new DateTime(2013, 12, 31));
                        QueQuan = InputHelper.InputString(res.InpQueQuan, res.ErrQueQuan);
                    }
                    break;
                case InputType.XoaHocSinh:
                    {
                        HocSinhID = InputHelper.InputInt(res.InpHocSinhID, res.ErrHocSinhID);
                    }
                    break;
                case InputType.ChuyenLop:
                    {
                        HocSinhID = InputHelper.InputInt(res.InpHocSinhID, res.ErrHocSinhID);
                        LopID = InputHelper.InputInt(res.InpLopID, res.ErrLopID);
                    }
                    break;
                default:
                    break;
            }
        }

    }
}
