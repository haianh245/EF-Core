using QL_PhieuThu_EF04.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace QL_PhieuThu_EF04.Entities
{
    class ChiTietPhieuThu
    {
        public int ChitietphieuthuID { get; set; }
        public int NguyenlieuID { get; set; }
        [Required]
        public int PhieuthuID { get; set; }
        public int Soluongban { get; set; }
        public NguyenLieu NguyenLieu { get; set; }
        public PhieuThu PhieuThu { get; set; }
        public ChiTietPhieuThu() { }
        public ChiTietPhieuThu(InputType it)
        {
            switch (it)
            {
                default:
                    break;
            }
        }
    }
}
