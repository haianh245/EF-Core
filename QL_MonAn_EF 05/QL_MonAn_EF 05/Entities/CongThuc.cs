using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace QL_MonAn_EF_05.Entities
{
    class CongThuc
    {
        public int CongThucID { get; set; }
        public int NguyenLieuID { get; set; }
        [Required]
        public int MonAnID { get; set; }
        public int SoLuong { get; set; }
        [Required]
        public string DonViTinh { get; set; }
        public MonAn MonAn { get; set; }
        public NguyenLieu NguyenLieu { get; set; }
    }
}
