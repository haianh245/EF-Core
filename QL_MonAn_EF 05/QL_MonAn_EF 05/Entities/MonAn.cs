using QL_MonAn_EF_05.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace QL_MonAn_EF_05.Entities
{
    class MonAn
    {
        public int MonAnID { get; set; }
        [Required]
        public int LoaiMonAnID { get; set; }
        public string TenMon { get; set; }
        public int GiaBan { get; set; }
        public string GioiThieu { get; set; }
        public string CachLam { get; set; }
        public LoaiMonAn LoaiMonAn { get; set; }
        public List<CongThuc> CongThucs { get; set; }

        public MonAn() { }
        public MonAn(InputType it)
        {
            switch(it)
            {
                case InputType.ThemMonAn:
                    {
                        LoaiMonAnID = InputHelper.InputInt(res.inpLoaiMonAnID, res.errLoaiMonAnID);
                        TenMon = InputHelper.NhapTen(res.inpTenMon, res.errTenMon);
                        GiaBan = InputHelper.InputInt(res.inpGiaBan, res.errGiaBan);
                        GioiThieu = InputHelper.InputString(res.inpGioiThieu, res.errGioiThieu);
                        CachLam = "";
                    }
                    break;
                case InputType.ThemCongThucChoMonAn:
                    {
                        MonAnID = InputHelper.InputInt(res.inpMonAnID, res.errMonAnID);
                        CongThucs = InputHelper.NhapCongThuc(res.inpCongThuc, res.errCongThuc);
                    }
                    break;
                case InputType.XoaMonAn:
                    {
                        MonAnID = InputHelper.InputInt(res.inpMonAnID, res.errMonAnID);
                    }
                    break;
            }
        }
    }
}
