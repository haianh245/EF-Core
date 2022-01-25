using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EFC_02.Entities
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
