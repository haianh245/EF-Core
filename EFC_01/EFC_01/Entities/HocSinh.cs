﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFC_01.Entities
{
    public class HocSinh
    {
        public int HocSinhID { get; set; }
        [Required]
        [MinLength(6)]
        [MaxLength(50)]
        public string HoTen { get; set; }
        [Required]
        public DateTime NgaySinh { get; set; }
        [Required]
        public bool GioiTinh { get; set; }
        [Required]
        [MinLength(10)]
        [MaxLength(100)]
        public string Email { get; set; }
        [Required]
        [MinLength(10)]
        [MaxLength(15)]
        public string SDT { get; set; }
        public string DiaChi { get; set; }
        public string TrinhDoHienTai { get; set; }
        public string Lop { get; set; }
        public DateTime NgayDangKy { get; set; }

    }
}
