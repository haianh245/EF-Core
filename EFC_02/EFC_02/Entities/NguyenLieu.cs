using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EFC_02.Entities
{
    class NguyenLieu
    {
        public int NguyenLieuID { get; set; }
        [Required]
        public string TenNguyenLieu { get; set; }
        public virtual IEnumerable<CongThuc> CongThucs { get; set; }
    }
}
