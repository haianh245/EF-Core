using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace QL_PhieuThu_EF04.Entities
{
    class LoaiNguyenLieu
    {
        public int LoainguyenlieuID { get; set; }
        [Required]
        public string Tenloai { get; set; }
        public string Mota { get; set; }
        public  List<NguyenLieu> NguyenLieus { get; set; }

    }
}
