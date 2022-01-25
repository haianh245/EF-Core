using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EFC_02.Entities
{
    class MonAn
    {
        public int MonAnID { get; set; }
        [Required]
        public int LoaiMonAnID { get; set; }
        public string TenMon { get; set; }
        public string GhiChu { get; set; }
        public LoaiMonAn LoaiMonAn { get; set; }
        public List<CongThuc> CongThucs { get; set; }

    }
}
