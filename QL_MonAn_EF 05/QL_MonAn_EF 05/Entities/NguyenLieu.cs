using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace QL_MonAn_EF_05.Entities
{
    class NguyenLieu
    {
        public int NguyenLieuID { get; set; }
        [Required]
        public string TenNguyenLieu { get; set; }
        public string GhiChu { get; set; }
    }
}
