using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EFC_02.Entities
{
    class LoaiMonAn
    {
        public int LoaiMonAnID { get; set; }
        [Required]
        public string TenLoai { get; set; }
    }
}
