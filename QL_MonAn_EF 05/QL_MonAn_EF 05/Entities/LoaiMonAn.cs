using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace QL_MonAn_EF_05.Entities
{
    class LoaiMonAn
    {
        public int LoaiMonAnID { get; set; }
        [Required]
        public string TenLoai { get; set; }
        public string MoTa { get; set; }
        public List<MonAn> MonAns { get; set; }
    }
}
